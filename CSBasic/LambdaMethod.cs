/*
 * This class demons the Lamda Methods
 * (also called as expression bodied methods)
 * 
 * If your method code is just a line and is used to return a value you can use lamda methods.
 * The syntax is simple and the operator is =>
 * 
 */
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    class LambdaMethod
    {
        public double GetSum(double principle, double intrest) => principle + intrest;
    }
}
