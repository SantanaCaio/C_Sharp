using System;

namespace _15___Projetos_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            string[] nomes = new string[3];
            string[] sobreNomes = new string[3];
            string[] senha = new string[3];
            
            do
            {
                int contador = 0;
                Console.WriteLine("Selecionar uma opção");
                Console.WriteLine("1 - Cadastro de usuario com Do While");
                Console.WriteLine("2 - cadastro de usuario com For");
                Console.WriteLine("3 - Listar usuario com While");
                Console.WriteLine("4 - Listar usuario com FOR");
                Console.WriteLine("0 - Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1: //Cadastro de usuario com Do While
                        do
                        {
                            Console.Write($"Digite o nome do usuario: ");
                            nomes[contador] = Console.ReadLine();
                            contador++;
                        } while (contador < 3);

                        break;
                    case 2: //cadastro de usuario com For
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine($"nome: {nomes[i]}{sobreNomes[i]}{senha[i]}");
                        }
                        break;
                    case 3: //Listar usuario com While
                        int contadorLista = 0;
                        while (contadorLista < 3)
                        {
                            Console.WriteLine($"{nomes[contadorLista]}");
                            contadorLista++;
                        }
                        break;
                    case 4: //Listar usuario com FOR
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine($"Digite o sobrenome: ");
                            sobreNomes[i] = Console.ReadLine();
                            Console.WriteLine($"Digite a senha: ");
                            senha[i] = Console.ReadLine();
                        }

                        break;
                    case 0: // Sair
                        break;
                    default:

                        break;
                }
            } while (opcao != 0);

        }
    }
}
