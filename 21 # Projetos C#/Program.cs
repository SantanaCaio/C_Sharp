using System;

namespace _21___Projetos_C_
{
  class Program
  {
    static void Main(string[] args)
    {
      double litros;
      string combustivel;
      do
      {
        Console.WriteLine("\nBem vindo ao Posto Code Caio \n\n Qual combustivel gostaria de abastecer? \n\n pressione:  [A] para álcool \n pressione:  [G] para gasolina");
        combustivel = Console.ReadLine();
        Console.WriteLine($"\n\n Quantos litros gostaria de abastecer?");
        litros = double.Parse(Console.ReadLine());

      } while (ValidaOpção(combustivel, litros));

      bool ValidaOpção(string opcao, double litros)
      {
        if (opcao == "g" || opcao == "G" && (litros / 1) == litros)
        {
          DescontoGasolina(litros);
          Console.WriteLine($"Gasolina escolhida");

          return false;
        }
        else if (opcao == "A" || opcao == "a" && (litros / 1) == litros)
        {
          DescontoAlcool(litros);
          Console.WriteLine($"alcool escolhido");
          return false;
        }
        else
        {
          Console.WriteLine($"Opção invalida, Tente novamente");
          return true;
        }
      }


      void DescontoGasolina(double litros)
      {
        double valorDoLitro = 5.30;
        double descontoPorLitro;
        double valorDeDesconto = 0;
        if (litros > 0 && litros <= 20)
        {
          descontoPorLitro = 4;

          valorDeDesconto = ((descontoPorLitro * valorDoLitro) * 100);
          Console.WriteLine($"Desconto Aplicado com sucesso \n\n Litros abastecidos : {litros} litros");
          Console.WriteLine($"Valor do litro: {valorDoLitro} ");
          Console.WriteLine($"Valor total: {litros * valorDoLitro}");
          Console.WriteLine($"-----------------------------------");
          Console.WriteLine($"Desconto por litro: {valorDeDesconto}");
          Console.WriteLine($"Valor a Pagar: {(valorDeDesconto * litros) - (valorDoLitro * litros)}");
          Console.WriteLine($"");
        }
        else if (litros > 20)
        {
          descontoPorLitro = 6;

          valorDeDesconto = ((descontoPorLitro * valorDoLitro) * 100);
          Console.WriteLine($"Desconto Aplicado com sucesso \n\n Litros abastecidos : {litros} litros");
          Console.WriteLine($"Valor do litro: {valorDoLitro} ");
          Console.WriteLine($"Valor total: {litros * valorDoLitro}");
          Console.WriteLine($"-----------------------------------");
          Console.WriteLine($"Desconto por litro: {valorDeDesconto}");
          Console.WriteLine($"Valor a Pagar: {(valorDeDesconto * litros) - (valorDoLitro * litros)}");
          Console.WriteLine($"");
        }
      }
      void DescontoAlcool(double litros)
      {
        double valorDoLitro = 4.90;
        double descontoPorLitro;
        double valorDeDesconto;
        if (litros > 0 && litros <= 20)
        {
          descontoPorLitro = 3;

          valorDeDesconto = ((descontoPorLitro * valorDoLitro) * 100);
          Console.WriteLine($"Desconto Aplicado com sucesso \n\n Litros abastecidos : {litros} litros");
          Console.WriteLine($"Valor do litro: {valorDoLitro} ");
          Console.WriteLine($"Valor total: {litros * valorDoLitro}");
          Console.WriteLine($"-----------------------------------");
          Console.WriteLine($"Desconto por litro: {valorDeDesconto}");
          Console.WriteLine($"Valor a Pagar: {(valorDeDesconto * litros) - (valorDoLitro * litros)}");
          Console.WriteLine($"");
        }
        else if (litros > 20)
        {
          descontoPorLitro = 5;

          valorDeDesconto = ((descontoPorLitro * valorDoLitro) * 100);
          Console.WriteLine($"Desconto Aplicado com sucesso \n\n Litros abastecidos : {litros} litros");
          Console.WriteLine($"Valor do litro: {valorDoLitro} ");
          Console.WriteLine($"Valor total: {litros * valorDoLitro}");
          Console.WriteLine($"-----------------------------------");
          Console.WriteLine($"Desconto por litro: {valorDeDesconto}");
          Console.WriteLine($"Valor a Pagar: {(valorDeDesconto * litros) - (valorDoLitro * litros)}");
          Console.WriteLine($"");
        }
      }
    }//fim da main
  }
}

