using System;

namespace _9__Projetos_C_
{
    class Program
    {
        static void Main(string[] args)
        {


                Console.WriteLine("usuario invalido");
                string usuario = Console.ReadLine();

            while (usuario != "dev")
            {
                Console.WriteLine("usuario invalido");
                Console.WriteLine("tente novamente");
                usuario = Console.ReadLine(); 
            }
            string senha = "";
            string conta = "";

            int contador =0;
            do
            {
                if (contador <3 )
                {
                    Console.WriteLine("digite sua senha");
                    senha = Console.ReadLine();
                    contador = contador + 1;
                    
                }else
                {
                    Console.WriteLine("Conta bloqueada");
                    conta = "bloquada";
                    break;
                    
                }
            } while (senha != "dev@132");

            if (conta == "bloqueada")
            {
                Console.WriteLine("Entre em contato com o seu gerente");
            }else
            {
                Console.WriteLine("Aqui esta o acesso de sua conta");
                
            }


        }
    }
}

