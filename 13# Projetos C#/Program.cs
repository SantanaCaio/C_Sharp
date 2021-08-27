using System;

namespace _13__Projetos_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, sexo, contador = 0, sexoMasculino = 0, sexoFeminino = 0, somaIdadeMasculina = 0, somaIdadeFeminina = 0, abaixoDoPeso = 0, pesoNormal = 0, sobrePeso = 0;
            double peso = 0, altura = 0;

            Console.Write($"Quantas pessoas deseja cadastrar ? => ");
                int pessoas = int.Parse(Console.ReadLine());

            do
            {
                // COLETA DE DADOS
                Console.WriteLine($"insira a idade da {contador + 1}ª pessoa");
                idade = int.Parse(Console.ReadLine());

                Console.WriteLine($"insira o peso da {contador + 1}ª pessoa");
                peso = double.Parse(Console.ReadLine());

                Console.WriteLine($"insira a altura da {contador + 1}ª pessoa");
                altura = double.Parse(Console.ReadLine());

                Console.WriteLine($"insira a sexo da {contador + 1}ª pessoa, \n DIGITE ' 1 ' para MASCULINO \n DIGITE ' 2 ' para FEMININO ");
                sexo = int.Parse(Console.ReadLine());

                //Divisão de sexo
                if (sexo == 1)
                {
                    sexoMasculino++; //somar a quantidade de homens 
                    somaIdadeMasculina += idade; // idade + idade que ja tinha 
                }
                else if (sexo == 2)
                {
                    sexoFeminino++; //somar a quantidade de mulheres
                    somaIdadeFeminina += idade; // idade + idade que ja tinha 
                }

                //IMC
                double imc = peso/(altura*altura);

                if (imc <= 18.5)
                {
                    abaixoDoPeso++;
                }
                else if (imc < 24.9)
                {
                    pesoNormal++;
                }
                else
                {
                    sobrePeso++;
                }



                contador++;
            } while (contador < pessoas); //FINAL DO WHILE

            //mostra a quantidade de pessoas por sexo
            Console.WriteLine( $"\nTemos {sexoMasculino} homens");
            Console.WriteLine($"Temos {sexoFeminino} mulheres");

            //mostra a media de idade por sexo
            if ((sexoMasculino) != 0)
            {
                Console.WriteLine($"\nA media de idade de homens é de {somaIdadeMasculina / sexoMasculino} anos");
            }
            if (sexoFeminino != 0)
            {
                Console.WriteLine($"\nA media de idade de mulheres é de {somaIdadeFeminina / sexoFeminino} anos");
            }

            //mostra a quantidade de pessoas acima do peso
            Console.WriteLine($"\nTemos {abaixoDoPeso}, pessoas abaixo do peso");
            Console.WriteLine($"Temos {pesoNormal}, pessoas com peso normal");
            Console.WriteLine($"Temos {sobrePeso}, pessoas com sobre peso");
        }
    }
}