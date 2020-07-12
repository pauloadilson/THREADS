// <copyright file="ListaEncadeadaTest.cs">Copyright ©  2020</copyright>
using System;
using ListEncadeada;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ListEncadeada.Tests
{
    /// <summary>Essa classe contém testes de unidade com parâmetros para ListaEncadeada</summary>
    [PexClass(typeof(ListaEncadeada))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class ListaEncadeadaTest
    {
        /// <summary>Stub de teste para .ctor(Int32)</summary>
        [PexMethod]
        public ListaEncadeada ConstructorTest(int element)
        {
            ListaEncadeada target = new ListaEncadeada(element);
            return target;
            // TODO: adicionar declarações para método ListaEncadeadaTest.ConstructorTest(Int32)
        }
    }
}
