using System;

namespace _6_Projeto_C_
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

            if (idade <= 18)
            {
                Console.WriteLine(" Vai dormir ! ");
            }
            else
            {
                // Console.WriteLine("Liberado");
                Console.WriteLine("O Cliente possui ingresso?");
                string resposta = Console.ReadLine();

                if (resposta == "Sim")
                {
                    Console.WriteLine("Liberar Acesso!");
                }else
                {
                    Console.WriteLine("Encaminhar para a bilheteria ");
                }
            }


        }
    }
}
