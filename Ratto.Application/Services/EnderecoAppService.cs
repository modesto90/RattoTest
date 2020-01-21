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
    public class EnderecoAppService : IEnderecoAppService
    {
        private readonly IEnderecoService _enderecoService;
        private readonly IRepositoryEndereco _enderecoRepository;
        public EnderecoAppService(IEnderecoService enderecoService, IRepositoryEndereco enderecoRepository)
        {
            _enderecoService = enderecoService;
            _enderecoRepository = enderecoRepository;

        }

        public RetornoPadraoDTO ExcluirEndereco(int id)
        {
            try
            {
                _enderecoService.ExcluirEndereco(id);
                return new RetornoPadraoDTO("Endereco excluído com sucesso", ErrorStatusEnum.Sucesso);

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
        public RetornoPadraoDTO AdicionarEndereco(EnderecoDTO request)
        {
            try
            {
                Endereco end = _enderecoService.AdicionarEndereco(request.Logradouro, request.Bairro, request.Cidade, request.Estado);
                return new RetornoPadraoDTO("Endereço adicionado com sucesso", ErrorStatusEnum.Sucesso, end.ConverterEntidadeEmDto());
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

        public RetornoPadraoDTO AtualizarEndereco(EnderecoDTO request)
        {
            try
            {
                Endereco end = _enderecoService.AtualizarEndereco(request.Id,
                    request.Logradouro,
                    request.Bairro, 
                    request.Cidade, 
                    request.Estado);

                return new RetornoPadraoDTO("Endereço atualizado com sucesso", ErrorStatusEnum.Sucesso, end.ConverterEntidadeEmDto());
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
                List<EnderecoDTO> end = _enderecoRepository.GetAll().ConverterEntidadesEmDtos().ToList();

                return new RetornoPadraoDTO("Endereço atualizado com sucesso", ErrorStatusEnum.Sucesso, end);
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

        public RetornoPadraoDTO Obter(int Id)
        {
            try
            {
                EnderecoDTO end = _enderecoService.Obter(Id).ConverterEntidadeEmDto();

                return new RetornoPadraoDTO("Endereço obtido com sucesso", ErrorStatusEnum.Sucesso, end);
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
