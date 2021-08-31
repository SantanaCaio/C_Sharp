using System;

namespace _3__Projeto_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o valor que deseja saber a tabuada");
            int numero = int.Parse(Console.ReadLine());

            for (var i = 0; i < 11; i++)
            {
                Console.WriteLine(numero + " X " + i + " = " + numero * i);

            }
        }
    }
}
