using Microsoft.VisualStudio.TestTools.UnitTesting;
using ListEncadeada;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListEncadeada.Tests
{
    [TestClass()]
    public class ListaEncadeadaTests
    {
        [TestMethod()]
        public void createListaEncadeadaTest()
        {
            ListaEncadeada<int> _ = ListaEncadeada<int>.createListaEncadeada(0);
            Assert.AreEqual(1, _.size());
        }

        [TestMethod()]
        public void createListaEncadeadaValueZeroTest()
        {
            ListaEncadeada<int> _ = ListaEncadeada<int>.createListaEncadeada(0);
            Assert.AreEqual(1, _.size());
            Assert.AreEqual(0, _.value());
        }

        [TestMethod()]
        public void createListaEncadeadaValueOneTest()
        {
            ListaEncadeada<int> _ = ListaEncadeada<int>.createListaEncadeada(1);
            Assert.AreEqual(1, _.size());
            Assert.AreEqual(1, _.value());
        }

        [TestMethod()]
        public void createListaEncadeadaAndAddOneElementTest()
        {
            ListaEncadeada<int> _ = ListaEncadeada<int>.createListaEncadeada(1);
            _.addElement(1);
            Assert.AreEqual(2, _.size());
        }
    }
}