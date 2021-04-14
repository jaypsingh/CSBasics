/*
 * This file demos how we can create generic class with single variable that is generic.
 * follow through the comments and you will see what all is required to have a generic class.
 * NOTE that using 'T' is a common practice to represent generic parameters.
 * You can also use other name like 'TMessage', 'TValue' etc to be more descriptive, especially when there are more than 1 generic parameter.
 */

namespace CSBasic
{
    /// <summary>
    /// This a demo of generic class. 
    /// Notice how <T> is included in class defination to represent it is a generic class.
    /// </summary>
    /// <typeparam name="T">This is a generic parameter</typeparam>
    class TClassOne<T>
    {
        // Variable is defined as type T to tell the users that it is a generic parameter.
        public T GenericClassVar { get; set; }
        // Notice how the constructer include the T type variable.
        public TClassOne(T genericClassVar)
        {
            GenericClassVar = genericClassVar;
        }
    }
}
