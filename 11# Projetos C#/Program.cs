using System;

namespace _11__Projetos_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, contador = 0;
            Console.Write("Insira o numero que deseja saber a tabuada do 0 ao 100 => ");
            n = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine($"{contador} X {n} = {contador * n}" );
                
                contador++;
            } while (contador < 101);

        }
    }
}
