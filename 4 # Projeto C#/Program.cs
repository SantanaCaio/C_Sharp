using System;

namespace _4__Projeto_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a primeira nota ");
            double nota01 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a segunda nota ");
            double nota02 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a terceira nota ");
            double nota03 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quarta nota ");
            double nota04 = double.Parse(Console.ReadLine());

            Console.WriteLine("Sua nota final é " + ((nota01 + nota02 + nota03 + nota04)/4));

        

        }
    }
}