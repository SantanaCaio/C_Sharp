using System;

namespace _23___Projetos_C_
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Insira 10 valores ");

      double[] numeros = new double[10];
      int contador = 0;
      double maiorNumero = -999999999, menorNumero = 999999999;

      foreach (var item in numeros)
      {
        Console.Write($"Insira o primeiro valor: ");
        numeros[contador] = int.Parse(Console.ReadLine());

        if (numeros[contador] > maiorNumero)
        {
          maiorNumero = numeros[contador];
        }
        if (numeros[contador] < menorNumero)
        {
          menorNumero = numeros[contador];
        }
        contador++;
      }
      Console.WriteLine($"O menor valor inserido é: {menorNumero} \n O Maior valor inserido é: {maiorNumero}");

    }
  }
}