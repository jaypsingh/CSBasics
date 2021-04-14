/*
 * This file demonstrates the concept of 
 * - method overloading 
*/

namespace CSBasic
{
    /// <summary>
    /// This is a OverLoading class used for the demo.
    /// This is xml style documention and a good practice to use.
    /// </summary>
    class OverLoading
    {
        // This method FindSum() accepts integers
        public void FindSum(int number1, int number2)
        {
            var sum = number1 + number2;
            System.Console.WriteLine($"Int Addition result is {sum}");
        }


        // This method FindSum() is overloaded and accepts double
        public void FindSum(double number1, double number2)
        {
            var sum = number1 + number2;
            System.Console.WriteLine($"Double Addition result is {sum}");
        }

        // This method FindSum() is overloaded and accepts string
        public void FindSum(string str1, string str2)
        {
            var sum = str1 + str2;
            System.Console.WriteLine($"String Addition result is {sum}");
        }

        // Please note that the overloaded method also can have arguments in diffrent order
        // The return type of the overloaded methods doesn't count.
    }
}
