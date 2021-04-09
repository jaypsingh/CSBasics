/*
* This files demos the below concept:
* - foreach loop
* 
* This is also explaine with other loops in FlowAndLoop.cs file. 
* Please do refer to that as well.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    class ForEach
    {
        public void ForEachDemo()
        {
            double sum = 0;
            var numbers = new[] { 1.1, 2.2, 3.3 };
            foreach (double number in numbers)
            {
                sum += number;
            }
            System.Console.WriteLine($"Sum of items : {sum}");

        }
    }
}
