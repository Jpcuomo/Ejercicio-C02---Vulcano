using UnidadesDeTemperatura;
namespace Ejercicio_A01___Fahrenheit_451
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kelvin k = new Kelvin(100);
            Celsius c = new Celsius(100);
            if (k == c)
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine(k.Temperatura);
                Console.WriteLine(((Kelvin)c).Temperatura);
                Console.WriteLine("Son distintos");
            }

            Console.WriteLine($"{k.Temperatura:N}");
            k = (Kelvin)c;
            Console.WriteLine($"{k.Temperatura:N}");
            double suma = c + k;
            Console.WriteLine($"{suma:N}");

            Celsius celsiusTemperature = new Celsius(100);
            Kelvin convertedKelvin = (Kelvin)celsiusTemperature;

            Console.WriteLine($"Celsius: {celsiusTemperature.Temperatura:N}");
            Console.WriteLine($"Kelvin: {convertedKelvin.Temperatura:N}");
            Console.WriteLine($"{celsiusTemperature + convertedKelvin:N}");

        }
    }
}
