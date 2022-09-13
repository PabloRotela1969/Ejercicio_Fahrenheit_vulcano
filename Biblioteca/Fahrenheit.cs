using System;

namespace Biblioteca
{
    public class Fahrenheit
    {
        private double temperatura;

        public Fahrenheit(double temperatura)
        {
            this.temperatura = temperatura;
        }

        public static explicit operator Celsius(Fahrenheit f)
        {
            double cuenta = (f.temperatura - 32) * 5 / 9;
            return new Celsius(cuenta);
        }
        public static explicit operator Kelvin(Fahrenheit f)
        {
            double cuenta = (f.temperatura + 459.67) * 5 / 9;
            return new Kelvin(cuenta);
        }

        public double Temperatura
        {
            get
            {
                return this.temperatura;
            }
        }

    }
}
