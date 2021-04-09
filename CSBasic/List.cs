/*
 * This files demos the below concept:
 * - Declating List
 * - Adding to list
 * - getting item count from list
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    /// <summary>
    /// This is a List class used for the demo.
    /// This is xml style documention and a good practice to use.
    /// </summary>
    class List
    {
        public void ListDemo()
        {
            // make a note of this include that is needed for list => using System.Collections.Generic 
            // unlike arrays list doesn't require you to tell how many items you will need in collection
            // note that inluding the initializatoon in list is not mandatory if you want to create a empty list
            var number = new List<double>() { 1.1, 1.2, 1.3};
            number.Add(4.4);

            // List have a length property that gives the count of item in the list
            var numberCount = number.Count;
            System.Console.WriteLine($"List Length is : {numberCount}");
        }
    }
}
