using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Tests.ValueObjects
{
    [TestClass]
    public class UrlTests
    {
        private const string InvalidUrl = "asdwasdwa";
        private const string ValidUrl = "https://balta.io";
        
        [TestMethod]
        [ExpectedException(typeof(InvalidUrlException))]
        public void Dado_uma_url_invalida_deve_retornar_uma_excecao()
        {
            new Url(InvalidUrl);
        }

        [TestMethod]
        public void Nao_retorna_uma_excecao_quando_a_url_e_valida()
        {
            new Url(ValidUrl);
            Assert.IsTrue(true);
        }
    }
}