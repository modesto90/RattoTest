using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ratto.Domain.Entities;
using System;

namespace Tests
{
    [TestClass]
    public class ClienteTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Idade não informada")]
        [DataRow("")]
        public void DadoQueNaoInformoUmaIdadeLancaException(string idade)
        {
            Cliente c = new Cliente();
            c.setIdade(idade);
        }


        [TestMethod]
        [DataRow("29")]
        public void DadoQueInformoIdadeNaoLancaException(string idade)
        {
            try
            {
                Cliente c = new Cliente();
                c.setIdade(idade);
                Assert.IsTrue(true);

            }
            catch (ArgumentException)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Nome não informado")]
        [DataRow("")]
        public void DadoQueNaoInformoNomeLancaException(string nome)
        {
            Cliente c = new Cliente();
            c.setNome(nome);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Nome excedeu 30 caracteres")]
        [DataRow("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
            "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
            "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
            "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa")]
        public void DadoQueNomePossuiMaisDe30CaracteresLancaException(string nome)
        {
            Cliente c = new Cliente();
            c.setNome(nome);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Cpf obrigatório")]
        [DataRow("")]
        public void DadoQueNaoInformoUmCpfLancaException(string cpf)
        {
            Cliente c = new Cliente();
            c.setCpf(cpf);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Cpf não é válido")]
        [DataRow("948765874")]
        public void DadoQueInformoUmCpfInvalidoLancaException(string cpf)
        {
            Cliente c = new Cliente();
            c.setCpf(cpf);
        }

        [TestMethod]
        [DataRow("12889544761")]
        public void DadoQueInformoUmCpfValido(string cpf)
        {
            try
            {
                Cliente c = new Cliente();
                c.setCpf(cpf);
                Assert.IsTrue(true);

            }
            catch (ArgumentException)
            {
                Assert.Fail();
            }


        }
    }
}
