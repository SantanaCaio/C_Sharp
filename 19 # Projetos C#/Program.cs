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

            string nomePassageiro = "";
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
                Console.WriteLine($"x-------------------------------------x");
                Console.WriteLine($"|    [1] - Cadastrar Passagens        |");
                Console.WriteLine($"|    [2] - Listar Passagens           |");
                Console.WriteLine($"|    [3] - Consulta Passageiro        |");
                Console.WriteLine($"|    [0] - Sair                       |");
                Console.WriteLine($"x-------------------------------------x");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine($"Cadastro de passagens");
                        CadastroDePassagens();
                        break;
                    case "2":
                        Console.WriteLine($"Lista Passagens");
                        ListarFuncao();
                        break;
                    case "3":
                        Console.WriteLine($"Consulta passageiro");
                        Console.WriteLine($"Insira o nome do passageiro : ");
                        nomePassageiro = Console.ReadLine();
                        ConsultaPassageiro(nomePassageiro);
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

            void CadastroDePassagens()
            {
                if (contador < 2)
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
                    } while (resposta == "sim" && contador < 2);
                }
                Console.WriteLine("Limite de passagens cadastradas");
            }

            void ListarFuncao()
            {
                for (int i = 0; i < contador; i++)
                {
                    Console.WriteLine($"- - - - - {i + 1}ª passagens - - - - -");
                    Console.WriteLine($"Nome : {nomes[i]}");
                    Console.WriteLine($"Origem : {origens[i]}");
                    Console.WriteLine($"Destino : {destinos[i]}");
                    Console.WriteLine($"Data : {datas[i]}");
                }
            }

            void ConsultaPassageiro(string nome)
            {
                for (int i = 0; i < contador; i++)
                {
                    if (nome == nomes[i])
                    {
                        Console.WriteLine($"Nome : {nomes[i]}");
                        Console.WriteLine($"Origem : {origens[i]}");
                        Console.WriteLine($"Destino : {destinos[i]}");
                        Console.WriteLine($"Data : {datas[i]}");
                        break;
                    }
                    contador++;
                }

            }
            Console.Clear();
            Console.WriteLine($"fim do programa");
        }
    }
}