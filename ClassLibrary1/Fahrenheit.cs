using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadesDeTemperatura
{
    public class Fahrenheit
    {
        public double Temperatura { get; }

        public Fahrenheit(double temperatura)
        {
            Temperatura = temperatura;
        }


        internal double FahrenheitACelsius()
        {
            return (Temperatura - 32) * 5.0 / 9.0;
        }

        internal double FahrenheitAKelvin()
        {
            return (Temperatura + 459.67) * 5.0 / 9.0;
        }


        // Conversores explicitos 
        public static explicit operator Celsius(Fahrenheit f)
        {
            return new Celsius(f.FahrenheitACelsius());
        }

        public static explicit operator Kelvin(Fahrenheit f)
        {
            return new Kelvin(f.FahrenheitAKelvin());
        }


        // Sobrecarga de operadores == y != entre Fahrenheit y Celsius
        public static bool operator ==(Fahrenheit f, Celsius c)
        {
            return f.Temperatura == ((Fahrenheit)c).Temperatura;
        }
        public static bool operator !=(Fahrenheit f, Celsius c)
        {
            return !(f == c);
        }


        // Sobrecarga de operadores == y != entre Fahrenheit y Kelvin
        public static bool operator ==(Fahrenheit f, Kelvin k)
        {
            return f.Temperatura == ((Fahrenheit)k).Temperatura;
        }
        public static bool operator !=(Fahrenheit f, Kelvin k)
        {
            return !(f == k);
        }


        // Sobrecarga de operador + y -
        public static double operator +(Fahrenheit f, Celsius c)
        {
            return f.Temperatura + ((Fahrenheit)c).Temperatura;
        }
        public static double operator -(Fahrenheit f, Celsius c)
        {
            return f.Temperatura - ((Fahrenheit)c).Temperatura;
        }

        public static double operator +(Fahrenheit f, Kelvin k)
        {
            return f.Temperatura + ((Fahrenheit)k).Temperatura;
        }
        public static double operator -(Fahrenheit f, Kelvin k)
        {
            return f.Temperatura - ((Fahrenheit)k).Temperatura;
        }

        //public override string ToString()
        //{
        //    return Temperatura.ToString("F2");
        //}
    }
}
