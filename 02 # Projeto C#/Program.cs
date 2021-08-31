using System;

namespace _2__Projeto_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Soma de dois númetros inteiros");

            Console.WriteLine("insira o primeiro numero");
            int numeroUm = int.Parse(Console.ReadLine());

            Console.WriteLine("insira o primeiro numero");
            int numeroDois = int.Parse(Console.ReadLine());

            int soma = numeroDois + numeroUm;

            Console.WriteLine("A soma dos dois valores é " + soma);


        }
    }
}
