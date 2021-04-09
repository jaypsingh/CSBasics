/*
 * This class is used to demo object initializers for C#.
 * NOTE that this file will hav 3 classes for the demo purpose.
 * There are three ways how object can be initialized. 
 * Default Constructor, Parameterized Constructor and Object Initializers.  * 
 * CSBasic.cs and Unit Test will demonstate the object initilization
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    // This class will be used to demo Default Consturctor 
    class DefaultConstructor
    {
        public double Power;
        public string SuperHeroName;       
        
    }

    // This class will be used to demo Object Initializers
    class ObjectInitializers
    {
        public double Power;
        public string SuperHeroName;

    }

    // This class will be used to demo Parameterized Consturctor 
    class ParameterizedConstructor
    {
        double Power;
        string SuperHeroName;

        public ParameterizedConstructor(double power, string superHeroName)
        {
            Power = power;
            SuperHeroName = superHeroName;

        }

    }


}
