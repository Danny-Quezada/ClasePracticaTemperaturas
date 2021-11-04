using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Abstract
{
    public class Celsius : TemperatureAbstract
    {
        public override double CalculateTemperature(double temperature, int i)
        {
            double temp = 0;
            if (i == 0)
            {
                return temp = (temperature * 1.8) + 32;
            }
            else if (i == 2)
            {
                return temp = ((temperature + 273.15));
            }
            return temp;
        }
    }
}
