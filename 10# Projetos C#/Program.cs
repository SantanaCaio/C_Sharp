using System;

namespace _10__Projetos_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            double contador = 0, soma = 0;
            do
            {
                Console.WriteLine($"Insira o {contador+1}º numero");
                soma += double.Parse(Console.ReadLine());
                contador ++;
            } while (contador < 10);
            Console.WriteLine(soma);              
        }
    }
}
