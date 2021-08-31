using System;

namespace _12__Projeto_C_
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] nomeA = new string[9];

      int[] idadeA = new int[9];
      int[] mmenorDeIdade = new int[9]; // mmenorDeIdade[contador][contador]
      int[] mmaiorDeIdade = new int[9]; // mmaiorDeIdade[contador][contador]
      int[] fmenorDeIdade = new int[9]; // fmenorDeIdade[contador][contador]
      int[] fmaiorDeIdade = new int[9]; // fmaiorDeIdade[contador][contador]

      int contador = 0;

      bool cont = true;
      do
      {
        Console.WriteLine($"insira o nome da {contador + 1}º pessoa");
        nomeA[contador] = Console.ReadLine();

        do
        {
          Console.WriteLine($"Qual o sexo do {nomeA[contador]} \n Digite ' 1 ' para masculino \n Digite ' 2 ' para feminino  ");
          int sexo = int.Parse(Console.ReadLine());

          cont = true;
          switch (sexo)
          {
            case 1: //MASCULINO
              if (idadeA[contador] < 18)
              {
                mmenorDeIdade[contador] = mmenorDeIdade[contador] + 1; // mostra a quantidade homens menor de idade 
              }
              else
              {
                mmaiorDeIdade[contador] = mmaiorDeIdade[contador] + 1; // mostra a quantidade homens maior de idade 
              }
              break;

            case 2: //FEMININO
              if (idadeA[contador] < 18)
              {
                fmenorDeIdade[contador] = fmenorDeIdade[contador] + 1; // mostra a quantidade mulheres menor de idade 
              }
              else
              {
                fmaiorDeIdade[contador] = fmaiorDeIdade[contador] + 1; // mostra a quantidade mulheres maior de idade 
              }
              break;

            default:
              Console.WriteLine($"Ops!! escreveu algo errado, não fique nervoso!! \n\n Digite novamente !! \n porem desta vez apenas numero 1 ou 2");
              cont = false;
              break;
          }

        } while (cont == false);

        Console.WriteLine($"insira a idade do {nomeA[contador]}");
        idadeA[contador] = int.Parse(Console.ReadLine());

        contador++;
      } while (contador < 10);

      // Console.WriteLine($"Temos {menorDeIdade}, pessoas menor de idade \n Temos {maiorDeIdade}, pessoas maior de idade");
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
