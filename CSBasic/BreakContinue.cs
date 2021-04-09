/*
 * This file demos the below concepts
 * - break
 * - continue
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    class BreakContinue
    {
        public void DemoBreakContinue()
        {
            var nameList = new List<string>() { "jay", "kairav", "bijay", "sujata", "bruce", "batman", "alferd" };

            // This loop deonstrates the use of break.
            // break breaks the execution flow and comes out
            // when a condition is met
            Console.WriteLine("Demoing Break...");
            foreach(var item in nameList)
            {
                if (item == "bruce")
                {
                    Console.WriteLine("won't print names beyound sujata...\n");
                    break;
                }
                Console.WriteLine($"name: {item}");
            }

            // This loop deonstrates the use of continue.
            // continue skips the iteration where condition is met and jumps to the next itteration.
            // when a condition is met
            Console.WriteLine("Demoing Continue...");
            foreach (var item in nameList)
            {
                if (item == "bruce")
                {
                    Console.WriteLine("will print names till alferd...\n");
                    continue;
                }
                Console.WriteLine($"name: {item}");
            }
        }

    }
}
