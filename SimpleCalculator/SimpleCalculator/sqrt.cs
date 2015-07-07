using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Sqrt : IOperationWithOneArgument
    {
        public double Calculate(double argument)
        {
            return Math.Sqrt(argument);
        }
    }
}
