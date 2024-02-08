namespace UnidadesDeTemperatura
{
    public class Celsius
    {
        public double Temperatura { get; }

        public Celsius(double temperatura)
        {
            Temperatura = temperatura;
        }


        internal double CelsiusAFahrenheit()
        {
            return Temperatura * (9.0 / 5.0) + 32;
        }

        internal double CelsiusAKelvin()
        {
            double tempF = CelsiusAFahrenheit();
            Fahrenheit f = new Fahrenheit(tempF);
            return f.FahrenheitAKelvin();
        }


        // Conversores explicitos 
        public static explicit operator Fahrenheit(Celsius c)
        {
            return new Fahrenheit(c.CelsiusAFahrenheit());
        }

        public static explicit operator Kelvin(Celsius c)
        {
            return new Kelvin(c.CelsiusAKelvin());
        }


        // Sobrecarga de operadores == y != entre Celsius y Fahrenheit
        public static bool operator ==(Celsius c, Fahrenheit f)
        {
            return f.Temperatura == ((Celsius)c).Temperatura;
        }
        public static bool operator !=(Celsius c, Fahrenheit f)
        {
            return !(f == c);
        }


        // Sobrecarga de operadores == y != entre Celsius y Kelvin
        public static bool operator ==(Celsius c, Kelvin k)
        {
            return c.Temperatura == ((Celsius)k).Temperatura;
        }
        public static bool operator !=(Celsius c, Kelvin k)
        {
            return !(c == k);
        }


        // Sobrecarga de operador + y -
        public static double operator +(Celsius c, Fahrenheit f)
        {
            return c.Temperatura + ((Celsius)f).Temperatura;
        }
        public static double operator -(Celsius c, Fahrenheit f)
        {
            return c.Temperatura - ((Celsius)f).Temperatura;
        }

        public static double operator +(Celsius c, Kelvin k)
        {
            return c.Temperatura + ((Celsius)k).Temperatura;
        }
        public static double operator -(Celsius c, Kelvin k)
        {
            return c.Temperatura - ((Celsius)k).Temperatura;
        }
    }
}
