/*
 * This file demos how we can create generic method that cam accept variable of any data type.
 * Follow through the comments and you will see what all is required to have a generic method.
 * NOTE that using 'T' is a common practice to represent generic parameters.
 * You can also use other name like 'TMessage', 'TValue' etc to be more descriptive, especially when there are more than 1 generic parameter.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    class TMethod
    {
        // See how the retrun type is set as T
        // Also notice how the Method name is followe by <T> to indicate that this is a generic method.
        // The datatype of the argument is also set as T.
        public T ExampleOne<T>(T VarOne)
        {
            Console.WriteLine($"Adding to data base: {VarOne}");
            return VarOne;
        }

        // This method demonstrates how more than one argument can also be set as generic in the method.
        public int ExampleTwo<TVarOne, TVarTwo>(TVarOne VarOne, TVarTwo VarTwo)
        {
            Console.WriteLine($"Adding to data base: {VarOne}, {VarTwo}");
            return 0;
        }
    }
}
