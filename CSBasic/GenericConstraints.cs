/*
 * This file demos the generic constraints.
 * Here is a writeup on the supported constraints
 * where T : struct     <= Value Type
 * where T : class      <= Reference Type
 * where T : new()      <= Type has a parameterless constructor
 * where T : vendor()   <= Be or derive from a class (for example class Vendor)
 * where T : IVendor    <= Be or implement the IVendor interface * 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    class GenericConstraints
    {
        public int GenericConstraintStruct<T>(T VarOne) where T : struct
        {
            Console.WriteLine($"Demo GenericConstraintStruct: {VarOne}");
            return 0;
        }

        public int GenericConstraintClass<T>(T VarOne) where T : class
        {
            Console.WriteLine($"Demo GenericConstraintClass: {VarOne}");
            return 0;
        }

        public int GenericConstraintMultiple<T>(T VarOne) where T : class, new()
        {
            Console.WriteLine($"Demo GenericConstraintMultiple: {VarOne}");
            return 0;
        }
    }
}
