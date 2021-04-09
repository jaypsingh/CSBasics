using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    class FlowAndLoops
    {
        public FlowAndLoops()
        {
            numbers = new List<double> { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6 };
        }

        public double ForEachDemo()
        {
            var max = Double.MinValue;
            foreach(var number in numbers)
            {
                max = Math.Max(max, number);
            }
            return max;
        }

        public void IfDemo(int checkNumber)
        {
            var maxValue = ForEachDemo();

            if (maxValue > checkNumber)
            {
                System.Console.WriteLine($"{maxValue} is greater than {checkNumber}");
            }
        }

        private List<Double> numbers;
    }
}
