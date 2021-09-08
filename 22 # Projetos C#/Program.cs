using System;

namespace _22___Projetos_C_
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine($"Qual a Descrição do produto");
      string produto = Console.ReadLine();

      Console.WriteLine($"Qual a Quantidade a ser adquitida?");
      double quantidade = double.Parse(Console.ReadLine());

      Console.WriteLine($"Qual o valor do produto");
      double valor = double.Parse(Console.ReadLine());

      double total = quantidade * valor;
      double percentual;

      Console.WriteLine($"--------------------------------");
      Console.WriteLine($"Produto cadastrado com sucesso!!");
      Console.WriteLine($"Poduto {produto}....QTD {quantidade}....R$ {total}");
      Console.WriteLine($"--------------------------------\n");

      if (quantidade <= 5)
      {
        percentual = 2 / 100.0;
      }
      else if (quantidade > 5 && quantidade <= 10)
      {
        percentual = 3 / 100.0;
      }
      else
      {
        percentual = 3 / 100.0;
      }

      Console.WriteLine($"Desconto de {percentual * 100.0}%..................R${percentual * valor}");
      Console.WriteLine($"Valor final a pagar com desconto R${valor - (percentual * valor)} \n\n\n");

    }
  }
}

// Calcular e escrever o total (total = quantidade adquirida * preço unitário) 
// desconto e o total a pagar (total a pagar = total - desconto)

// - Se quantidade <= 5 o desconto será de 2% 
// - Se quantidade > 5 e quantidade <=10 o desconto será de 3% 
// - Se quantidade > 10 o desconto será de 5%.....