/* 
* This files demos the below concept:
*  - Constructore
*  - Parameterized constructor
*  - "this" keyword
*/

using System;
using System.Collections.Generic;

namespace CSBasic
{
    public class Constructor
    {
        // This is the variable declaration for the class
        public List<Double> number;
        private string name;

        public Constructor(string name)
        {   
            // this is the defination for the declared variable. 
            // Now when ever this class will be instantiated it will have this as part of its instance.
            number = new List<double>() { 1.1, 1.2};

            // this is an example of parameterzed constructore.
            // Notice how the variable name and argument name is same
            // and to resolve the name conflict we are using this keyword
            this.name = name;
        }

        public void AddNumberToList(double newNumber)
        {
            System.Console.WriteLine($"Length of the list is:: {number.Count}");
            number.Add(newNumber);
        }

        public string GetBookName()
        {
            System.Console.WriteLine($"Name of the book is:: {name}");
            return name;
        }

    }
}
