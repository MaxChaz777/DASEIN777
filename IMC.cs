using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se declaran las variables para almacenar el peso y la altura
            float peso, altura, imc;

            // Se solicita al usuario que ingrese su peso en kilogramos
            Console.Write("Ingrese su peso en kg: ");
            peso = float.Parse(Console.ReadLine());

            // Se solicita al usuario que ingrese su altura en metros
            Console.Write("Ingrese su altura en metros: ");
            altura = float.Parse(Console.ReadLine());

            // Se calcula el IMC utilizando la fórmula de Quetelet
            imc = peso / (altura * altura);

            // Se muestra el IMC al usuario
            Console.WriteLine("Su IMC es: {0:F2}", imc);

            // Se clasifica el IMC según la Organización Mundial de la Salud (OMS)
            if (imc < 18.5)
            {
                Console.WriteLine("Su clasificación según la OMS es: Bajo peso");
            }
            else if (imc < 25)
            {
                Console.WriteLine("Su clasificación según la OMS es: Peso normal");
            }
            else if (imc < 30)
            {
                Console.WriteLine("Su clasificación según la OMS es: Sobrepeso");
            }
            else
            {
                Console.WriteLine("Su clasificación según la OMS es: Obesidad");
            }
        }
    }
}
