using Ratto.Application.Dtos;
using Ratto.Application.DTOS;
using Ratto.Application.Enums;
using Ratto.Application.Extensions;
using Ratto.Application.Interface;
using Ratto.Domain.Entities;
using Ratto.Domain.Interfaces.Repositories;
using Ratto.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ratto.Application.Services
{
    public class ClienteAppService : IClienteAppService
    {
        private readonly IClienteService _clienteService;
        private readonly IRepositoryCliente _clienteRepository;
        public ClienteAppService(IClienteService clienteService,
            IRepositoryCliente clienteRepository)
        {
            _clienteService = clienteService;
            _clienteRepository = clienteRepository;

        }

        public RetornoPadraoDTO AtualizarCliente(ClienteDTO cliente)
        {

            try
            {
                Cliente c =  _clienteService.AtualizarCliente(cliente.Id, cliente.Nome, cliente.Cpf, cliente.Idade);
                return new RetornoPadraoDTO("Cliente atualizado com sucesso", ErrorStatusEnum.Sucesso, c);

            }
            catch (ArgumentException ex)
            {
                return new RetornoPadraoDTO(ex.Message, ErrorStatusEnum.Warning);
            }
            catch (Exception ex)
            {

                return new RetornoPadraoDTO(ex.Message, ErrorStatusEnum.Error);
            }

        }


        public RetornoPadraoDTO ExcluirCliente(int id)
        {
            try
            {
                _clienteService.ExcluirCliente(id);
                return new RetornoPadraoDTO("Cliente excluído com sucesso", ErrorStatusEnum.Sucesso);

            }
            catch (ArgumentException ex)
            {
                return new RetornoPadraoDTO(ex.Message, ErrorStatusEnum.Warning);
            }
            catch (Exception ex)
            {

                return new RetornoPadraoDTO(ex.Message, ErrorStatusEnum.Error);
            }

        }

        public RetornoPadraoDTO Obter(int id)
        {

            try
            {
                ClienteDTO c = _clienteService.Obter(id).ConverterEntidadeEmDto();
                return new RetornoPadraoDTO("Cliente obtido com sucesso", ErrorStatusEnum.Sucesso, c);

            }
            catch (ArgumentException ex)
            {
                return new RetornoPadraoDTO(ex.Message, ErrorStatusEnum.Warning);
            }
            catch (Exception ex)
            {

                return new RetornoPadraoDTO(ex.Message, ErrorStatusEnum.Error);
            }
        }

        public RetornoPadraoDTO ObterTodos()
        {
            try
            {
                List<ClienteDTO> retorno = _clienteRepository.GetAll().ConverterEntidadesEmDtos().ToList();
                return new RetornoPadraoDTO("Clientes obtidos", ErrorStatusEnum.Sucesso, retorno);

            }
            catch (ArgumentException ex)
            {
                return new RetornoPadraoDTO(ex.Message, ErrorStatusEnum.Warning);
            }
            catch (Exception ex)
            {

                return new RetornoPadraoDTO(ex.Message, ErrorStatusEnum.Error);
            }
        }

        public RetornoPadraoDTO AdicionarCliente(AdicionarClienteDTO request)
        {
            try
            {
                Cliente c = _clienteService.AdicionarCliente(request.Nome, request.Cpf, request.Idade);
                return new RetornoPadraoDTO("Cliente Adicionado com sucesso", ErrorStatusEnum.Sucesso, c);

            }
            catch (ArgumentException ex)
            {
                return new RetornoPadraoDTO(ex.Message, ErrorStatusEnum.Warning);
            }
            catch (Exception ex)
            {

                return new RetornoPadraoDTO(ex.Message, ErrorStatusEnum.Error);
            }
        }
    }
}
