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
                Console.WriteLine("Calculadora V2");
                Console.WriteLine();

                Console.WriteLine("Digite el primer número:");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite el segundo número:");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("¿Qué desea hacer?");
                Console.WriteLine("Sumar = 1 " +
                    "Restar = 2 " +
                    "Multiplicacar = 3 "  +
                    "Dividir = 4");
                string operador = Console.ReadLine();

                switch (operador)
                {
                    case "1":
                        Console.Clear();
                        res = num1 + num2;
                        Console.WriteLine($"El resultado de la suma de {num1} + {num2} = {res}");
                        desicion = false;
                        break;
                    case "2":
                        Console.Clear();
                        res = num1 - num2;
                        Console.WriteLine($"El resultado de la resta de {num1} - {num2} = {res}");
                        desicion = false;
                        break;

                    case "3":
                        Console.Clear();
                        res = num1 * num2;
                        Console.WriteLine($"El resultado de la multiplicación de {num1} x {num2} = {res}");
                        desicion = false;
                        break;

                    case "4":
                        Console.Clear();
                        res = num1 / num2;
                        Console.WriteLine($"El resultado de la divicion de {num1} entre {num2} = {res}");
                        desicion = false;
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
