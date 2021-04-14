/*
 * This file demos how we can create generic class with multiple variable that is generic.
 * Follow through the comments and you will see what all is required to have a generic class.
 * NOTE that using 'T' is a common practice to represent generic parameters.
 * You can also use other name like 'TMessage', 'TValue' etc to be more descriptive, especially when there are more than 1 generic parameter.
 */

namespace CSBasic
{
    /// <summary>
    /// This a demo of generic class. Here i am showing how you can include multiple generic Parameters
    /// Notice how <T> is included in class defination to represent it is a generic class.    /// 
    /// </summary>
    /// <typeparam name="TVarOne">This is one generic parameter</typeparam>
    /// <typeparam name="TVarTwo">This is second generic parameter</typeparam>
    class TClassMany<TVarOne, TVarTwo>
    {
        // Variable is defined as type T to tell the users that it is a generic parameter.
        public TVarOne VarOne { get; set; }
        public TVarTwo VarTwo { get; set; }
        // Notice how the constructer include the T type variable.
        public TClassMany(TVarOne varone, TVarTwo vartwo)
        {
            VarOne = varone;
            VarTwo = vartwo;
        }
    }
}
