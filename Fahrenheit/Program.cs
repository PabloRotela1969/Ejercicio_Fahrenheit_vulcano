using System;
using Biblioteca;

namespace EscalasDeTemperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creo objeto Fahrenheit con 10 grados");
            Fahrenheit f = new Fahrenheit(10);
            Console.WriteLine("Paso 10F a Celsius");
            Celsius c = (Celsius)f;// explícita
            Console.WriteLine($"Y el resultado es {c.Temperatura}C°");
            Console.WriteLine($"Ahora paso los {f.Temperatura} grados Fahrenheit a Kelvin");
            Kelvin k = (Kelvin)f;// explícita
            Console.WriteLine($"Y el resultado es {k.Temperatura} Kelvin");
            Console.WriteLine($"Ahora paso los {k.Temperatura} grados Kelvin a Celsius");
            c = k;// implícita
            Console.WriteLine($"Y el resultado es {c.Temperatura} C°");

        }
    }
}
