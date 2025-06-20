// See https://aka.ms/new-console-template for more information
using System;
using EspacioCalculadora;

class Program
{
    static void Main()
    {
        Calculadora calc = new Calculadora();
        string opcion;

        do
        {
            Console.WriteLine($"\nResultado actual: {calc.Resultado}");
            Console.WriteLine("Opciones: sumar, restar, multiplicar, dividir, limpiar, salir");
            Console.Write("Ingrese una operacion: ");
            opcion = Console.ReadLine()?.ToLower();

            if (opcion == "salir") break;

            if (opcion == "limpiar")
            {
                calc.Limpiar();
                continue;
            }

            Console.Write("Ingrese un numero: ");
            if (!double.TryParse(Console.ReadLine(), out double numero))
            {
                Console.WriteLine("Numero invalido.");
                continue;
            }

            switch (opcion)
            {
                case "sumar":
                    calc.Sumar(numero);
                    break;
                case "restar":
                    calc.Restar(numero);
                    break;
                case "multiplicar":
                    calc.Multiplicar(numero);
                    break;
                case "dividir":
                    calc.Dividir(numero);
                    break;
                default:
                    Console.WriteLine("Operacion no valida.");
                    break;
            }
        } while (true);

        Console.WriteLine($"Resultado final: {calc.Resultado}");
        Console.WriteLine("Programa finalizado.");
    }
}

