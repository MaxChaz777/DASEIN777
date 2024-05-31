using System;

namespace PromedioTresNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se declaran las variables para almacenar los números ingresados y el promedio
            float numero1, numero2, numero3, promedio;

            // Se solicita al usuario que ingrese el primer número
            Console.Write("Ingrese el primer número: ");
            numero1 = float.Parse(Console.ReadLine());

            // Se solicita al usuario que ingrese el segundo número
            Console.Write("Ingrese el segundo número: ");
            numero2 = float.Parse(Console.ReadLine());

            // Se solicita al usuario que ingrese el tercer número
            Console.Write("Ingrese el tercer número: ");
            numero3 = float.Parse(Console.ReadLine());

            // Se calcula el promedio de los tres números
            promedio = (numero1 + numero2 + numero3) / 3;

            // Se muestra el promedio al usuario
            Console.WriteLine("El promedio de los tres números es: {0}", promedio);
        }
    }
}