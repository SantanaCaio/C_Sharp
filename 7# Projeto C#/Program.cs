using System;

namespace _7__Projeto_C_
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o primeiro número");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual operação deseja fazer?");
            Console.WriteLine(" + - / * ");
            string operation = Console.ReadLine();

            Console.WriteLine("Digite o segundo número");
            double num2 = double.Parse(Console.ReadLine());

            double resultado = 0;
            bool validador = true;
            switch (operation)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                    
                case "-":
                    resultado = num1 - num2;
                    break;

                case "/":
                    resultado = num1 / num2;
                    break;

                case "*":
                    resultado = num1 * num2;
                    break;

                default:
                Console.WriteLine("Operação Invalida");
                validador = false;
                    break;
            }

            if(validador == true){
                Console.WriteLine("O resultado = "+resultado);
            }

       


        }
    }
}
