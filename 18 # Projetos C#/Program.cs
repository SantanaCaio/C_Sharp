using System;

namespace _18___Projetos_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] temperaturas = new double[12];
            string[] meses = new string[12] {"jan", "fev", "mar", "abr", "mai", "jun", "jul", "ago", "set", "out", "nov", "dez"};
            // int[] myIntArray = new int[5] { 1, 2, 3, 4, 5 };
            double temMax = -999, temMin = 999;
            string meseMax = "", meseMin = "";

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
                    meseMax = meses[i];
                }
                if (temperaturas[i] < temMin)
                {
                    temMin = temperaturas[i];
                    meseMin = meses[i];
                }
            }

            Console.WriteLine($"A menor temperatura média do ano é {meseMin} - {temMin}º, e a maior é {meseMax} - {temMax}º");
            
        }
    }
}


//  Calcule e exiba a maior e a menor temperatura do ano.