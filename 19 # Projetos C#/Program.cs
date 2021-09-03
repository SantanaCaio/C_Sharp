using System;

namespace _19___Projetos_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[5];
            string[] origens = new string[5];
            string[] destinos = new string[5];
            string[] datas = new string[5];
            string resposta = "";
            int contador = 0;




            Console.WriteLine("digite a senha");
            string senhaDigitada = Console.ReadLine();
            bool retornoDaFuncao = validarSenha(senhaDigitada);
            while (!retornoDaFuncao)
            {
                Console.WriteLine("Senha invalida");
                Console.WriteLine($"Digite novamente a senha:");
                senhaDigitada = Console.ReadLine();
                retornoDaFuncao = validarSenha(senhaDigitada);
            }

            Console.WriteLine($"x----------------------------------x");
            Console.WriteLine($"| Bem vindo a Tsukamoto Air Lines   |");
            Console.WriteLine($"x----------------------------------x");

            Console.WriteLine($"x----------------------------------x");
            Console.WriteLine($"| Selecione uma das opções abaixo  |");
            Console.WriteLine($"x----------------------------------x");

            string opcao = "";

            do
            {
                Console.WriteLine($"x----------------------------------x");
                Console.WriteLine($"|    [1] - Cadastrar Passagens     |");
                Console.WriteLine($"|    [2] - Listar Passagens        |");
                Console.WriteLine($"|    [0] - Sair                    |");
                Console.WriteLine($"x----------------------------------x");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine($"Cadastro de passagens");

                        cadastroDePassagens();
                        break;
                    case "2":
                        Console.WriteLine($"Lista Passagens");
                        break;
                    case "0":
                        Console.WriteLine($"Obrigado por usar a Tsulamoto Air Lines");
                        Console.WriteLine($"Volte sempre");
                        break;

                    default:
                        Console.WriteLine($"Opção invalida!");
                        break;
                }


            } while (opcao != "0");

            bool validarSenha(string senha)
            {
                if (senha == "123456")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            void cadastroDePassagens()
            {
                if (contador < 5)
                {
                    do
                    {
                        Console.WriteLine($"Digite o nome do passageiro");
                        nomes[contador] = Console.ReadLine();
                        Console.WriteLine($"Digite a origem");
                        origens[contador] = Console.ReadLine();
                        Console.WriteLine($"Digite o destino");
                        destinos[contador] = Console.ReadLine();
                        Console.WriteLine($"Digite a data da viagem");
                        datas[contador] = Console.ReadLine();

                        Console.WriteLine($"Gostaria de cadastrar outra passagem?");
                        resposta = Console.ReadLine();

                        contador++;
                    } while (resposta == "sim" && contador < 5);
                }
                Console.WriteLine("Limite de passagens cadastradas");
            }
            Console.Clear();
            Console.WriteLine($"fim do programa");
        }
    }
}
