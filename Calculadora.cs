using System;

namespace CalculadoraBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se declaran las variables para almacenar los números y la operación
            float numero1, numero2, resultado;
            char operacion;

            // Se solicita al usuario que ingrese el primer número
            Console.Write("Ingrese el primer número: ");
            numero1 = float.Parse(Console.ReadLine());

            // Se solicita al usuario que ingrese la operación (+, -, *, /)
            Console.Write("Ingrese la operación (+, -, *, /): ");
            operacion = Console.ReadLine()[0]; // Se toma solo el primer caracter

            // Se solicita al usuario que ingrese el segundo número
            Console.Write("Ingrese el segundo número: ");
            numero2 = float.Parse(Console.ReadLine());

            // Se realiza la operación correspondiente
            switch (operacion)
            {
                case '+':
                    resultado = numero1 + numero2;
                    break;
                case '-':
                    resultado = numero1 - numero2;
                    break;
                case '*':
                    resultado = numero1 * numero2;
                    break;
                case '/':
                    if (numero2 == 0)
                    {
                        Console.WriteLine("Error: No se puede dividir por cero.");
                        return; // Se termina el programa
                    }
                    else
                    {
                        resultado = numero1 / numero2;
                    }
                    break;
                default:
                    Console.WriteLine("Operación no válida.");
                    return; // Se termina el programa
            }

            // Se muestra el resultado de la operación al usuario
            Console.WriteLine("El resultado de la operación es: {0}", resultado);
        }
    }
}

