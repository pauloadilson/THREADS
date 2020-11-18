using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace THREADS
{
    class Program
    {
        static int intervalo;
        //system calls = interrupções , fork/create, close, chmod 
        static void Main(string[] args)
        {
            Console.WriteLine("Intervalo para exibição: ");
            intervalo = int.Parse(Console.ReadLine());
            Thread trab1 = CriaThread("Trabalhadora 1");
            trab1.Start();
            Thread trab2 = CriaThread("Trabalhadora 2");
            trab2.Start();
            //trab2.Priority = ThreadPriority.Highest;
            //inicio();
            Console.ReadKey();
        }
        static Thread CriaThread(string nome)
        {
            ThreadStart trabalho = new ThreadStart(inicio); //a thread começa instanciando uma chamada para inicio() 
            Thread Trabalho = new Thread(trabalho);
            Trabalho.Name = nome;
            return Trabalho;
        }
        static void inicio()
        {
            MostraNro();
            Thread estaThread = Thread.CurrentThread;
            string nome = estaThread.Name;
            Console.WriteLine("Thread Finalizada " + nome);
        }
        static void MostraNro()
        {
            Thread estaThread = Thread.CurrentThread;
            string nome = estaThread.Name;
            if (nome == null)
                nome = "Principal";
            Console.WriteLine("\nInicia Thread " + nome);
            for (int i = 1; i <= 8 * intervalo; i++)
            {
                if (i % intervalo == 0)
                {
                    Console.WriteLine("Thread = " + nome + " = contagem = " + i);
                    Console.WriteLine("");
                }
            }
            Console.WriteLine("");

        }
        /*static void MostraNroOD()
        {
            Thread estaThread = Thread.CurrentThread;
            string nome = estaThread.Name;
            if (nome == null)
                nome = "Principal";
            Console.WriteLine("\nInicia Thread " + nome);
            for (int i = 1; i <= 8 * intervalo; i++)
            {
                if (i % intervalo == 0)
                {
                    Console.WriteLine("Thread = " + nome + " = contagem = " + i);
                    Console.WriteLine("");
                }
            }
            Console.WriteLine("");

        }
        static void MostraNroOI()
        {
            Thread estaThread = Thread.CurrentThread;
            string nome = estaThread.Name;
            if (nome == null)
                nome = "Principal";
            Console.WriteLine("\nInicia Thread " + nome);
            for (int i = 1; i <= 8 * intervalo; i--)
            {
                if (i % intervalo == 0)
                {
                    Console.WriteLine("Thread = " + nome + " = contagem = " + i);
                    Console.WriteLine("");
                }
            }
            Console.WriteLine("");

        }*/

    }
}
