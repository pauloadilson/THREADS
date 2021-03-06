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
        /// <summary>Stub de teste para addElement(Int32)</summary>
        [TestMethod]
        public void addElementTest([PexAssumeUnderTest]ListaEncadeada target, int value)
        {
            target.addElement(value);
            // TODO: adicionar declarações para método ListaEncadeadaTest.addElementTest(ListaEncadeada, Int32)
        }

        /// <summary>Stub de teste para createListaEncadeada(Int32)</summary>
        [PexMethod]
        public ListaEncadeada createListaEncadeadaTest(int value)
        {
            ListaEncadeada result = ListaEncadeada.createListaEncadeada(value);
            return result;
            // TODO: adicionar declarações para método ListaEncadeadaTest.createListaEncadeadaTest(Int32)
        }

        /// <summary>Stub de teste para size()</summary>
        [PexMethod]
        public int sizeTest([PexAssumeUnderTest]ListaEncadeada target)
        {
            int result = target.size();
            return result;
            // TODO: adicionar declarações para método ListaEncadeadaTest.sizeTest(ListaEncadeada)
        }

        /// <summary>Stub de teste para value()</summary>
        [PexMethod]
        public int valueTest([PexAssumeUnderTest]ListaEncadeada target)
        {
            int result = target.value();
            return result;
            // TODO: adicionar declarações para método ListaEncadeadaTest.valueTest(ListaEncadeada)
        }
    }
}
