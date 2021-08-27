using System;

namespace _14__Projetos_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            string respostasP, respostasS;
            bool sexoValido = false;
            int respostaM = 0, respostaF = 0;
            do
            {
                Console.WriteLine($"Gostou do produto \n ' 1 ' SIM \n ' 2 ' NÂO");
                respostasP = Console.ReadLine();

                do
                {
                    sexoValido = false;
                    Console.WriteLine($"Qual o seu sexo \n ' 1 ' MASCULINO \n ' 2 ' FEMININO");
                    respostasS = Console.ReadLine();

                    if (respostasS == "1")
                    {
                        if (respostasP == ' 1 ')
                        {
                            
                        }
                        respostaM++;
                    }
                    else if (respostasS == "2")
                    {
                        respostaF++;
                    }
                    else
                    {
                        Console.WriteLine($"Sexo invalido, digite apenas ' 1 ' ou ' 2 ' !");
                        sexoValido = true;
                    }

                } while (sexoValido);







            } while (true);
        }
    }
}
// pegar o sexo e se respondeu sim ou não de 10 pessoas

// quantas pessoas responderam sim
// quantas pessoas responderam não

