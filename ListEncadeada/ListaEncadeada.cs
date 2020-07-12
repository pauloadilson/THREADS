using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace ListEncadeada
{
    public class ListaEncadeada<T>
    {
        static public ListaEncadeada<T> createListaEncadeada(T value)
        {
            ListaEncadeada<T> lista = new ListaEncadeada<T>();
            lista.element = value;
            lista.next = null;
            return lista;
        }

        public int size()
        {
            int size = 1;
            ListaEncadeada<T> lista = first;
            while( (lista = lista.next) != null)
            {
                size++;
            }
            return size;
        }

        public T value()
        {
            return this.element;
        }

        public void addElement(T value)
        {
            ListaEncadeada<T> novo = new ListaEncadeada<T>();
            novo.element = value;
            next = novo;
        }

        private ListaEncadeada()
        {
            this.first = this;
        }

        private T element;
        private ListaEncadeada<T> next;

        private readonly ListaEncadeada<T> first;
    }
}
