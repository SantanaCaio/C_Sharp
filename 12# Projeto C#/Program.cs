using System;

namespace _12__Projeto_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0, idade = 0, menorDeIdade = 0, maiorDeIdade = 0;
            do
            {
                Console.WriteLine($"insira o {contador + 1}º nome");
                string nome = Console.ReadLine();
                Console.WriteLine($"insira o sexo do {nome} \n Digite ' 1 ' para masculino \n Digite ' 2 ' para feminino  ");
                int sexo = int.Parse(Console.ReadLine());
                Console.WriteLine($"insira a idade do {nome}");
                idade = int.Parse(Console.ReadLine());

                switch (sexo)
                {
                    case 1:
                        if (idade < 18)
                        {
                            MmenorDeIdade = menorDeIdade + 1;
                        }
                        else
                        {
                            MmaiorDeIdade++;
                        }
                        break;
                        
                    case 2:
                        if (idade < 18)
                        {
                            FmenorDeIdade = menorDeIdade + 1;
                        }
                        else
                        {
                            FmaiorDeIdade++;
                        }
                        break;
                    default:
                        break;
                }






                contador++;
            } while (contador < 10);
            Console.WriteLine($"Temos {menorDeIdade}, pessoas menor de idade \n Temos {maiorDeIdade}, pessoas maior de idade");
        }
    }
}



// mostrar a quantidade de homens menor de idade e seus nomes 
// mostrar a quantidade de homens maior de idade e seus nomes 

// mostrar a quantidade de mulheres menor de idade e seus nomes 
// mostrar a quantidade de mulheres maio de idade e seus nomes 





//nome
//sexo
//idade
//quantos homens e mulheres maiores e menores de idade
