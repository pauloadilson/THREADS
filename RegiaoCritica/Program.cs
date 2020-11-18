using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RegiaoCritica
{
    class Program
    {
        static int saldo, saque, deposito;
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o saldo inicial: ");
            saldo = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor do saque: ");
            saque = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor do depósito: ");
            deposito = int.Parse(Console.ReadLine());
            Thread saqueMov = CriaThread("Saque");
            saqueMov.Start();
            Thread depositoMov = CriaThread("Depósito");
            depositoMov.Start();
            Console.ReadKey();
        }
        static Thread CriaThread(string nome)
        {
            ThreadStart transacao = new ThreadStart(Movimentar);
            Thread Transacao = new Thread(transacao);
            Transacao.Name = nome;
            return Transacao;
        }
        static void Movimentar()
        {
            Thread estaThread = Thread.CurrentThread;
            string nome = estaThread.Name;
            if (nome == "Saque")
                Saque();
            else if (nome == "Depósito")
                Deposito();

            Console.WriteLine($"Thread Finalizada = {nome}.");
        }
        static void Saque()
        {   
            int flag = saldo;
            Thread.Sleep(2000);
            saldo = flag;
            saldo -= saque;
            Console.WriteLine($"\nAtualizou saque = R$ {saldo}.");
        }
        static void Deposito()
        {
            saldo += deposito;
            Console.WriteLine($"\nAtualizou depósito = R$ {saldo}.");

        }
        // solução de condição de corrida: lock = 1
        // lock: protocolo de entrada da região crítica
        // a região crítica é trancada por um thread até a sua finalização
        // priorização pode não ser a melhor solução
        // protocolo de saída da região crítica: lock = 0
        // para que o acesso seja liberado para o outro processo ou thread 
    }
}