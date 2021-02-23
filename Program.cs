using System;

namespace Prueba_Github
{
    class Program
    {
        static void Main(string[] args)
        {
            bool desicion = true;
            double res;

            while (desicion)
            {
                Console.Clear();
                Console.WriteLine("Calculadora");
                Console.WriteLine();

                Console.WriteLine("Digite el primer número:");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite el primer número:");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("¿Qué desea hacer?");
                Console.WriteLine("Sumar = 1 " +
                    "Restar = 2");
                string operador = Console.ReadLine();

                switch (operador)
                {
                    case "1":
                        Console.Clear();
                        res = num1 + num2;
                        Console.WriteLine($"El resultado de la suma de {num1} + {num2} = {res}");
                        desicion = true;
                        break;
                    case "2":
                        Console.Clear();
                        res = num1 - num2;
                        Console.WriteLine($"El resultado de la resta de {num1} - {num2} = {res}");
                        desicion = true;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Ninguno de los valores insertados es correcto... Presione 'ENTER', para continuar.");
                        break;
                }
                Console.ReadKey();
            }

        }
    }
}
