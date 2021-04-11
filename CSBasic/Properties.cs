/*
* This files demos the below concept:
* - Class Properties (getters and setters)
* - Autoimplemented Properties
* - Calculated value properties
* - Expression Value properties
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    class Properties
    {
        public Properties(string name)
        {
            Name = name;
            DeadPool = SetDeadPoolName();
        }

        // Setting the Name field private here.
        // Note that name is set in the constructor.
        // This will allow the user to set the name once while initializing the constructor 
        // but latter the name cannot be modified.
        public string Name
        {
            get;
            private set;
        }

        // Setting the number field using get and set
        // The NUmber field can be set and read back from outside the class
        public Double Number
        {
            get;
            set;
        }

        // Autoimplemented Properties
        // Note that here properties can be assigned a default value. 
        // In this case Batman is assigned a default vaue of Bruce
        public string BatMan
        {
            get;
            set;

        } = "Bruce";

        // Autoimplemented Properties
        // Properties can be assigned a default value not only by hardcoded values but aslo by method call. 
        // In this case Superman is assigned a default vaue of the SetSuperManName() return value.
        // Make sure that the method is static. 
        public string SuperMan
        {
            get;
            set;

        } = SetSuperManName();

        // Autoimplemented Properties
        // Properties can be assigned a default value by nonstatic method call. 
        // In this case DeadPoo is assigned a default vaue of the SetDeadPoolName() return value.
        // SetDeadPoolName method is non static in this case.
        // The method call is done from the constructor.
        public string DeadPool
        {
            get;
            set;

        }

        // Autoimplemented Properties
        // This is a static method since the return value of this method will 
        // be used for setting the autoimplemented property value. 
        public static string SetSuperManName()
        {
            return "Clark";
        }

        // Autoimplemented Properties
        // This is a static method since the return value of this method will 
        // be used for setting the autoimplemented property value. 
        public string SetDeadPoolName()
        {
            return "Wade";
        }

        // Using calculated value for propert
        public string FirstName
        {
            get;
            set;
        }
        public string LastName
        {
            get;
            set;
        }

        // See how the value of first name and last name are used to calculate the value of FUll Name
        // This demos expression bodied properties.
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        // Also using the same data see how full Name can be represented as expression-bodied properties   
        // This is same as Full Name but variabe name is change to avoid name collision. 
        // It is easy to represent it with a Lambda Operator
        // This demos expression bodied properties.
        public string CompleteName => FirstName + " " + LastName;
    }
}
