/* 
This files demos the below concept:
 - ReadOnly Fields
 - Constant Fields
*/

namespace CSBasic
{
    /// <summary>
    /// This is a ReadOnlyAndConstant class used for the demo.
    /// This is xml style documention and a good practice to use.
    /// </summary>
    class ReadOnlyAndConstant
    {
        public ReadOnlyAndConstant(int newNumber)
        {
            // Read only fields can only be assigned in a constructor but not in a method.
            number = newNumber;

            // Const field cannot be changed inside the cosntructor as well. hence the below line of code will not work.
            //ID = 1123;
        }

        public void ChangeReadOnlyField(int updateNumber)
        {
            // Below line of code will not work since read only fields cannot be updated in method
            //number = updateNumber;
            System.Console.WriteLine("ReadOnly fields cannot be updated inside a method.");

        }

        public readonly int number = 21;

        // Please note that constants can only be accessed with classname and not objects.
        // It behaves like Static.
        public const int ID = 170926;
    }

   
}
