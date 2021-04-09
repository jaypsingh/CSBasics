/* This files demos the below concept:
* - Declaring Arrays
* - Adding item to arrays
* - getting the item count from Arrays
* 
* Here only few of the Array mmethods are shown but you can play around with that since intelisence will give all the details.
* To use any of tha static method of Array class use Array. and intelisense will poulate all the static methods.
* And to use any of the instance methods use ArrayInstanceVariable., here ArrayInstanceVariable is tha array variable you define.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    /// <summary>
    /// This is a Array class used for the demo.
    /// This is xml style documention and a good practice to use.
    /// </summary>
    public class ArrayDemo
    {
        public ArrayDemo()
        {
            // this is an array declaration in constructor.
            // Notice the two diffrent ways how the aray is declared/
            dNumbers = new double[3];
            iNumbers = new[] {1,2,3};
        }
        // Array declaration if you want to declare an array and define it in the constructor
        double[] dNumbers;
        int[] iNumbers;

        public double SumDoubleArray()
        {
            // This is how you should declare an array inside methods. 
            // Also see the demonstration how it is declared in the constructor
            // if you want to declare the array contents while declaring
            var doubleNumbers = new[] { 1.1, 2.2, 3.3 };

            // if you just want to declare the array and add elements latter see method ArrayDoubleArray().            

            // Accessing array elements            
            double DoubleNumberSum = doubleNumbers[0] + doubleNumbers[1] + doubleNumbers[2];
            System.Console.WriteLine($"Sum of numbers : {DoubleNumberSum}");

            // Array have a length property that gives the count of item in array
            var arrayLength = doubleNumbers.Length;
            System.Console.WriteLine($"Double Array Length is : {arrayLength}");

            return DoubleNumberSum;
        }

        public int SumIntArray()
        {
            // This is how you should declare an array inside methods. 
            // Also see the demonstration how it is declared in the constructor
            // if you just want to declare the array and add elements latter this is what you shoul do.
            var intNumbers = new int[3];

            // adding items to array
            for (int i = 0; i < 3; i++)
            {
                intNumbers[i] = i;
            }

            // if you want to declare the array contents while declaring see method ArrayDoubleArray().            
            
            // Accessing array elements           
            int intNumberSum = intNumbers[0] + intNumbers[1] + intNumbers[2];
            System.Console.WriteLine($"Sum of numbers : {intNumberSum}");

            // Array have a length property that gives the count of item in array
            var arrayLength = intNumbers.Length;
            System.Console.WriteLine($"Int Array Length is : {arrayLength}");

            return intNumberSum;
        }

        // this method demonstrates how you can get index of a particular item in an Array.
        public int GetItemIndex(string item)
        {
            var fruits = new string[] {"apple", "orange", "banana" };
            // Array here is a class derived form Systems (Systems.Array)
            var index = Array.IndexOf(fruits, item);
            Console.WriteLine($"index of {item} is {index}");
            return index;
        }

        // this method demonstrates how you can get count of elements in an Array.
        public int GetItemCount()
        {
            var fruits = new string[] { "apple", "orange", "banana" };           
            var itemCount = fruits.Length;
            Console.WriteLine($"length of fruits array is {itemCount}");
            return itemCount;
        }

        // this method demonstrates how you can set value of an item at a particular index.
        public string[] SetArrayValue(int index, string value)
        {
            var fruits = new string[] { "apple", "orange", "banana" };           
            Console.WriteLine($"initial array is: {fruits[0]},{fruits[1]},{fruits[2]} ");
            fruits.SetValue(value, index);
            Console.WriteLine($"final array is: {fruits[0]},{fruits[1]},{fruits[2]} ");
            return fruits;
        }
    }
}
