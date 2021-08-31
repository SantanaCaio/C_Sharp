using System;

namespace _16___projetos_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            int soma = 0;

            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"Insira o {i + 1}º de 10 valores");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            for (var i = 0; i < 10; i++)
            {
                soma += numeros[i]; 
            }
                Console.WriteLine($"a soma dos valores é: {soma}");

        }
    }
}
