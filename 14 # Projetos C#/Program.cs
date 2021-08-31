using System;

namespace _14__Projetos_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            string respostasP, respostasS;
            bool sexoValido = false;
            int respostaMS = 0, respostaFS = 0;
            int respostaMN = 0, respostaFN = 0;
            int cont = 0;

            do
            {
                Console.WriteLine($"Gostou do produto \n ' 1 ' SIM \n ' 2 ' NÂO");
                respostasP = Console.ReadLine();

                do
                {
                    sexoValido = false;
                    Console.WriteLine($"Qual o seu sexo \n ' 1 ' MASCULINO \n ' 2 ' FEMININO");
                    respostasS = Console.ReadLine();

                    if (respostasS == "1")// define os sexos das pessoas
                    {
                        if (respostasP == "1")//divide as respostas das pessoas
                        {
                            respostaMS++;
                        }
                        else if (respostasP == "2")
                        {
                            respostaMN++;
                        }

                    }
                    else if (respostasS == "2")
                    {
                        if (respostasP == "1")//divide as respostas das pessoas
                        {
                            respostaFS++;
                        }
                        else if (respostasP == "2")
                        {
                            respostaFN++;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Sexo invalido, digite apenas ' 1 ' ou ' 2 ' !");
                        sexoValido = true;
                    }

                } while (sexoValido);
                cont++;
            } while (cont < 10);

            Console.WriteLine($"O número de pessoas que responderam SIM foram {respostaFS + respostaMS} pessoas");
            Console.WriteLine($"O número de pessoas que responderam NÂO foram {respostaFN + respostaMN} pessoas");

            Console.WriteLine($"O número de mulheres que responderam SIM foram {respostaFS} mulheres");

            double percentual = ((respostaMS + respostaMN) * (respostaMN * 100));
            Console.WriteLine($"O número de homens que responderam NÂO entre os homens analisados foi de {percentual}%");
        }
    }
}


