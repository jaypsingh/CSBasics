/* This files demos the below concept:
 - Double.MinValue 
 - Double.MaxValue
 - Math.Min
 - Math.Max
 - Static : This is just discussed and not demoed.
 Static Methods and methods that are not associated with object instance. If a method is static you cannot call it with class object. 
 Also all the members of a static methids must be static.
 for example see the main method.

 Also you can see below example
 
 Class DemoStatic
 {
    public DemoStatic()
    {
        number = new List<Double> {1.1, 1.2., 3.3, 4.4};
    }

     static public DemoStatic(double newNumber)
     {

       number.Add(newNumber); // number must be static since this is a static method
 
     }

     static private List<double> number; // note that this is static member

 }


*/

using System;
using System.Collections.Generic;

namespace CSBasic
{
    /// <summary>
    /// This is a MinMaxStatic class used for the demo.
    /// This is xml style documention and a good practice to use.
    /// </summary>
    class MinMaxStatic
    {
        public MinMaxStatic()
        {
            numbers = new List<double> { 1.1, 5.2, 0.3, 10.1, 6.8 };            
        }

        public void FindMinMax()
        {
            // Double.MinValue is an inbuild property that gives the minimum possible value for a double.
            var max = Double.MinValue;
            // Double.MaxVale is an inbuild property that gives the maximum possible value for a double.
            var min = Double.MaxValue;
            foreach(var number in numbers)
            {
                // Math.Max gets us the maximum of two nubers
                max = Math.Max(max, number);
                // Math.Min gets us the minimum of two nubers
                min = Math.Min(min, number);
            }

            System.Console.WriteLine($"Max value is:: {max}");
            System.Console.WriteLine($"Min value is:: {min}");

        }

        List<double> numbers;
    }
}
