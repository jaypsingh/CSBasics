/*
 * This files demos the below concept:
 * - string interpolation
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    /// <summary>
    /// This is a StringInterpolation class used for the demo.
    /// This is xml style documention and a good practice to use.
    /// </summary>
    public class StringInterpolation
    {
        public string SayHello(string name)
        {
            // String interpolation is done by $
            System.Console.WriteLine($"Hello {name} !!");
            return ($"Hello {name} !!"); ;
        }
    }
}
