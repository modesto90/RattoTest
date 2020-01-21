using Ratto.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ratto.Domain.ValueObjects
{
    public class Document : ValueObject
    {
        public string Numero { get; private set; }
        public DocumentTypeEnum Tipo { get; private set; }
        public Document()
        {

        }
        public Document(string numero, DocumentTypeEnum tipo)
        {
            if (tipo == DocumentTypeEnum.CPF)
                setCpf(numero);

            Numero = numero;
            Tipo = tipo;
        }

        public void setCpf(string numero)
        {
            if (!ValidaCPF(numero))
                showError(DocumentTypeEnum.CPF);

            Numero = numero;
            Tipo = DocumentTypeEnum.CPF;

        }

        private void showError(DocumentTypeEnum type)
        {
            throw new ArgumentException(type.ToString() + " Inválido");
        }
        private bool ValidaCPF(string vrCPF)

        {

            string valor = vrCPF.Replace(".", "");

            valor = valor.Replace("-", "");



            if (valor.Length != 11)
                return false;



            bool igual = true;

            for (int i = 1; i < 11 && igual; i++)

                if (valor[i] != valor[0])

                    igual = false;



            if (igual || valor == "12345678909")
                return false;



            int[] numeros = new int[11];



            for (int i = 0; i < 11; i++)

                numeros[i] = int.Parse(

                  valor[i].ToString());



            int soma = 0;

            for (int i = 0; i < 9; i++)

                soma += (10 - i) * numeros[i];



            int resultado = soma % 11;



            if (resultado == 1 || resultado == 0)

            {

                if (numeros[9] != 0)
                    return false;

            }

            else if (numeros[9] != 11 - resultado)
                return false;



            soma = 0;

            for (int i = 0; i < 10; i++)

                soma += (11 - i) * numeros[i];



            resultado = soma % 11;



            if (resultado == 1 || resultado == 0)

            {

                if (numeros[10] != 0)
                    return false;

            }

            else

                if (numeros[10] != 11 - resultado)
                return false;



            return true;

        }

    }

}
