using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Kelvin
    {
        private double temperatura;
        public Kelvin(double temperatura)
        {
            this.temperatura = temperatura;
        }

        public static implicit operator Fahrenheit(Kelvin k)
        {
            double cuenta = k.Temperatura * (9 / 5) - 459.67;
            return new Fahrenheit(cuenta);
        }

        public static implicit operator Celsius(Kelvin k)
        {
            double cuenta = k.Temperatura - 273.15;
            return new Celsius(cuenta);
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
