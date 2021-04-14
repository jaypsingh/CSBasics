/*
 * This file demos the below concepts
 * - break
 * - continue
 * */
using System;
using System.Collections.Generic;

namespace CSBasic
{
    public class BreakContinue
    {   
        public List<string> DemoBreak()
        {
            var nameList = new List<string>() { "jay", "kairav", "bijay", "sujata", "bruce", "batman", "alferd" };
            var breakList = new List<string>();

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
                breakList.Add(item);
                Console.WriteLine($"name: {item}");                
            }
            return breakList;
        }

        public List<string> DemoContinue()
        {
            var nameList = new List<string>() { "jay", "kairav", "bijay", "sujata", "bruce", "batman", "alferd" };
            var continueList = new List<string>();

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
                continueList.Add(item);
                Console.WriteLine($"name: {item}");
            }
            return continueList;
        }

    }
}
