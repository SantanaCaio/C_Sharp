using System;

namespace _20___Projetos_C_
{
  class Program
  {
    static void Main(string[] args)
    {
      bool repeat;
      Console.WriteLine("\n\nEste programa lê a data do usuario, e retorna se ela pode ou não votar este ano.\n\n");
      do
      {
      Console.WriteLine("Qual seu ano de nascimento?");
      if (ConsultaIdadeVoto(Console.ReadLine()))
      {
        Console.WriteLine($"Pode votar");
      }
      else
      {
        Console.WriteLine("Voto não permitido");
      }
      Console.WriteLine($"\n\nPressione qualquer tecla para nova consulta\n\n");
      Console.WriteLine($"Ou [ 0 ] - para sair");
      string entradaRepeat = Console.ReadLine();
      if (entradaRepeat != "0")
      {
          repeat = true;
      }else
      {
          repeat = false;
      }
      } while (repeat);

      bool ConsultaIdadeVoto(string anoNascimentos)
      {
        string data = string.Empty;
        data = DateTime.Now.Date.ToString("yyyy");
        int dataAtual = int.Parse(data);
        int anoDeNascimeto = int.Parse(anoNascimentos);

        if ((dataAtual - anoDeNascimeto) >= 18)
        {
          return true;
        }
        else
        {
          return false;
        }
      }

    }

  }
}
