/*
* This files demos the below concept:
* - format specifiers
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    class FormattingSpecifier
    {
        public void FormattingSpecifierDemo()
        {
            var number = 1.0123456789;

            // print the number to only one decimal place
            System.Console.WriteLine($"The number to one decimal place is {number:N1}");

            // print the number to three decimal place
            System.Console.WriteLine($"The number to three decimal place is {number:N3}");

            // print the number to five decimal place
            System.Console.WriteLine($"The number to five decimal place is {number:N5}");


        }
    }
}
