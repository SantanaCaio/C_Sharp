using System;

namespace _5__Projeto_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe Seu Ano de Nascimento");
            int anoDeNascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o Ano Atual");
            int anoAtual = int.Parse(Console.ReadLine()); 

            int idade = anoAtual - anoDeNascimento;
            Console.WriteLine("Sua Idade atual é igual à " + idade);

            int semanasPorIdade = idade * 52;
            Console.WriteLine("Sua idade possui " + semanasPorIdade + " semanas");


        }
    }
}
