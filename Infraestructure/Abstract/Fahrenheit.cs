using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Abstract
{
    public class Fahrenheit : TemperatureAbstract
    {
        public override double CalculateTemperature(double temperature, int i)
        {
            double temp = 0;
            if (i == 1)
            {
                return temp = ((temperature - 32) * (0.556));
            }
            else if (i == 2)
            {
                return temp = (((temperature - 32) * (0.556)) + 273.15);
            }
            return temp;
        }
    }
}
