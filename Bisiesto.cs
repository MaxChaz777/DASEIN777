using System;

namespace AnioBisiesto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se declara la variable para almacenar el año
            int año;

            // Se solicita al usuario que ingrese el año
            Console.Write("Ingrese un año: ");
            año = int.Parse(Console.ReadLine());

            // Se determina si el año es bisiesto utilizando operadores lógicos
            bool esBisiesto;
            esBisiesto = (año % 4 == 0) && (año % 100 != 0) || (año % 400 == 0);

            // Se muestra un mensaje al usuario indicando si el año es bisiesto o no
            if (esBisiesto)
            {
                Console.WriteLine("{0} es un año bisiesto.", año);
            }
            else
            {
                Console.WriteLine("{0} no es un año bisiesto.", año);
            }
        }
    }
}
