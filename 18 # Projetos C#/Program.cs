using System;

namespace _18___Projetos_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] temperaturas = new double[12];
            double temMax = -999, temMin = 999;

            for (var i = 0; i < 12; i++)
            {
                Console.WriteLine($"Coloque a temperatura média do mês {i+1}:");
                temperaturas[i] = double.Parse(Console.ReadLine());
            }

            for (var i = 0; i < 12; i++)
            {
                if (temperaturas[i] > temMax)
                {
                    temMax = temperaturas[i];
                }
                if (temperaturas[i] < temMin)
                {
                    temMin = temperaturas[i];
                }
            }

            Console.WriteLine($"A menor temperatura média do ano é {temMin}º, e a maior é {temMax}º");
            
        }
    }
}


//  Calcule e exiba a maior e a menor temperatura do ano.