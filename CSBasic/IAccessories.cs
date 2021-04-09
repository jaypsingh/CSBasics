/*
 * This is a generic iterface.
 * The idea is to demo how this same interface can be used work on diffrent kind of data.
 * Please note that here only one generic <T> is used. 
 * But more than one generic can also be used in similar faishon. 
 * 
 * AccessoriesList and AccessoriesArray class implements this interface.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    // Here <T> is used to represent the generic that the method accepts
    public interface IAccessories<T>
    {
        void AddItem(T Item);
        void DisplayItem();       

    }
}
