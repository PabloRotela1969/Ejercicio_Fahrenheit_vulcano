using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Celsius
    {
        private double temperatura;

        public Celsius(double temperatura)
        {
            this.temperatura = temperatura;
        }

        public static implicit operator Fahrenheit(Celsius c)
        {
            double cuenta = (c.Temperatura * (9 / (double)5)) + 32;
            return new Fahrenheit(cuenta);
        }

        public static implicit operator Kelvin(Celsius c)
        {
            double cuenta = c.Temperatura + 273.15;
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
