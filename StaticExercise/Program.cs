using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(25);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(25);
            

            Console.WriteLine($"C = {celsius}, F = {fahrenheit}");
        }
    }
}
