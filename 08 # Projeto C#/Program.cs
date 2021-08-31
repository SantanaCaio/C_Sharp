using System;

namespace _8__Projeto_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            do
            {
            Console.WriteLine("Digite o numero de acordo com o seu pedido");
            Console.WriteLine(" 1 = Hamburguer");
            Console.WriteLine(" 2 = Cheese salada");
            Console.WriteLine(" 3 = Cheese burhuer");
            Console.WriteLine(" 4 = Cheese bacon");
            string pedido = Console.ReadLine();

            opcao = int.Parse(pedido);
            
                switch (pedido)
                {
                    case "1":
                        Console.WriteLine("Seu pedido foi Hamburguer");
                        break;
                    case "2":
                        Console.WriteLine("Seu pedido foi Cheese salada");
                        break;
                    case "3":
                        Console.WriteLine("Seu pedido foi Cheese burhuer");
                        break;
                    case "4":
                        Console.WriteLine("Seu pedido foi Cheese bacon");
                        break;
                    default:
                        Console.WriteLine("Opção invalida");
                        break;
                }   // fim switch

            } while (opcao < 1 || opcao > 4);

        }
    }
}
