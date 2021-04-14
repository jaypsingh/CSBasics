/*
 * This short method demonstrates how we can read data from console.
 * This file demonstrates the below concept:
 * - reading data from console.
 */
using System;
using System.Collections.Generic;

namespace CSBasic
{
    /// <summary>
    /// This is a ReadFromConsole class used for the demo.
    /// This is xml style documention and a good practice to use.
    /// </summary>
    class ReadFromConsole
    {

        public void ReadStringFromConsole()
        {
            string input = "";
            var readString = new List<string>() { };
            while (input != "q")
            {
                Console.WriteLine("Enter some string that you would like or enter 'q' to quit");
                // this is how we read data from console.
                input = Console.ReadLine();
                readString.Add(input);
            }

            Console.WriteLine("Reading back the items that were entered by you");
            foreach(var item in readString)
            {
                Console.WriteLine($"read {item}");
            }
        }
    }
}
