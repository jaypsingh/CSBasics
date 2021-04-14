/*
 * This file demos the below concepts
 * - exception
 * - handling exception
 * - throwing exception
 * - finally block
 * 
 */
using System;

namespace CSBasic
{
    class ExceptionDemo
    {
        public ExceptionDemo()
        {            
            numbers = new int[2];
            index = 0;
        }

        int[] numbers;
        int index;

        public void AddItemToArray(int item)
        {    
            // Below is the block of code that you want to put under try.
            try
            {
                numbers[index] = item;
                index = index + 1;
            }
            // this is how you catch a speciffic exception.
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Handling the IndexOutOfRangeException Exception ::\n " + ex.Message);
                numbers[0] = item;
                index = 0;
            }
            // this is how you catch the general exception. 
            catch (Exception ex)
            {
                Console.WriteLine("Handling the other Exceptions ::\n " + ex.Message);
                // this is how you throw the exception if you need to.
                throw;
            }
            // this is finally block.
            // it gets executed even if there is an exception happening.
            finally
            {
                Console.WriteLine("I am in finally block");
            }
        }

        public void DisplayArrayItems()
        {
            foreach(var item in numbers)
            {
                Console.WriteLine(item);
            }
        }

    }
}
