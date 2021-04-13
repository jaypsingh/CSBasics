/* 
This files demos the below concept:
 - If control flow
 - For loop
 - For each loop
 - While loop
 - Do while loop
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    public class FlowAndLoop
    {
        public FlowAndLoop()
        {
            numbers = new List<double> { 1.1, 2.2, 3.3, 4.4, 5.5};
        }

        public double AddListNumbersForEach()
        {            
            double sum = 0;

            //Here is how foreach is used.
            foreach(var number in numbers)
            {
                sum = sum + number;
            }
            System.Console.WriteLine($"ForEach Loop Demo Sum of all items : {sum}");
            return sum;
        }

        public double PrintIfTrue(double compareNumber)
        {
            // This method prints the larget number if the larget number is greater than the test number
            // This also demos the use of "if" statment in C#
            var listNumberSum = AddListNumbersForEach();
            if (listNumberSum > compareNumber)
            {
                System.Console.WriteLine("If loop demo : ListNumberSum is larger");
                return listNumberSum;
            }   
            else
            {
                System.Console.WriteLine("If loop demo : compareNumber is larger");
                return compareNumber;
            }

        }

        public double AddListNumbersDoWhile()
        {
            // This method demos the use of do-while loop
            int index = 0;
            double sum = 0;
            do
            {
                sum = sum + numbers[index];
                index++;
            } while (index < numbers.Count);

            System.Console.WriteLine($"Do-While Loop Demo Sum of all items : {sum}");
            return sum;
        }

        public double AddListNumbersWhile()
        {
            // This method demos the use or while loop
            int index = numbers.Count;            
            double sum = 0;
            while(index>0)
            {
                sum = sum + numbers[index-1];
                index--;
            }

            System.Console.WriteLine($"While Loop Demo Sum of all items : {sum}");
            return sum;

        }

        public double AddListNumbersFor()
        {
            // This method demos the use or For loop
            double sum = 0;
            for(var index=0; index < numbers.Count; index++)
            {
                sum = sum + numbers[index];                
            }

            System.Console.WriteLine($"For Loop Demo Sum of all items : {sum}");
            return sum;

        }

        private List<Double> numbers;
    }
}
