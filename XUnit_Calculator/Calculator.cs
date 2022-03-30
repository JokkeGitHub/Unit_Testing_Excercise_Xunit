using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnit_Calculator
{
    public class Calculator
    {

        public double Add(double no1, double no2)
        {
            return no1 + no2;
        }

        public double Substract(double no1, double no2)
        {
            return no1 - no2;
        }

        public double Multiply(double no1, double no2)
        {
            return no1 * no2;
        }

        public double Divide(double no1, double no2)
        {
            if (no2 != 0)
            {
                return no1 / no2; 
            }
            else
            {
                // Custom business logic for divide by zero
                return 0;
            }
        }
    }
}
