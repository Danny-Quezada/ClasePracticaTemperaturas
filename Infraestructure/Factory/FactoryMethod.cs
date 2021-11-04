using Infraestructure.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Factory
{
    public class FactoryMethod
    {
        public static TemperatureAbstract CreateInstance(int i)
        {
            if (i == 0)
            {
                return new Fahrenheit();
            }
            else if (i == 1)
            {
                return new Celsius();
            }
            else if (i == 2)
            {
                return new Kelvin();
            }
            return null;
        }
    }
}
