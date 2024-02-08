using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadesDeTemperatura
{
    public class Kelvin
    {
        public double Temperatura { get; }


        public Kelvin(double temperatura)
        {
            Temperatura = temperatura;
        }


        internal double KelvinACelsius()
        {
            double tempF = KalvinAFahrenheit();
            Fahrenheit f = new Fahrenheit(tempF);
            return f.FahrenheitACelsius();
        }

        internal double KalvinAFahrenheit()
        {
            return Temperatura * 9.0 / 5.0 - 459.67;
        }


        // Conversores explicitos
        public static explicit operator Celsius(Kelvin k)
        {
            return new Celsius(k.KelvinACelsius());
        }

        public static explicit operator Fahrenheit(Kelvin k)
        {
            return new Fahrenheit(k.KalvinAFahrenheit());
        }


        // Sobrecarga de operadores == y != entre Kelvin y Celsius
        public static bool operator ==(Kelvin k, Celsius c)
        {
            return k.Temperatura == ((Kelvin)c).Temperatura;
        }
        public static bool operator !=(Kelvin k, Celsius c)
        {
            return !(k == c);
        }


        // Sobrecarga de operadores == y != entre Kelvin y Fahrenheit
        public static bool operator ==(Kelvin k, Fahrenheit f)
        {
            return k.Temperatura == ((Kelvin)f).Temperatura;
        }
        public static bool operator !=(Kelvin k, Fahrenheit f)
        {
            return !(k == f);
        }


        // Sobrecarga de operador + y -
        public static double operator +(Kelvin k, Celsius c)
        {
            return k.Temperatura + ((Kelvin)c).Temperatura;
        }
        public static double operator -(Kelvin k, Celsius c)
        {
            return k.Temperatura - ((Kelvin)c).Temperatura;
        }

        public static double operator +(Kelvin k, Fahrenheit f)
        {
            return k.Temperatura + ((Kelvin)f).Temperatura;
        }
        public static double operator -(Kelvin k, Fahrenheit f)
        {
            return k.Temperatura - ((Kelvin)f).Temperatura;
        }
    }
}
