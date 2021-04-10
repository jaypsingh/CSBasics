/*
 * Nullable type is a value type that allows defination of a value or null.
 * Thisi class helps us to demo the below concepts
 * - Nullable Types
 */ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    class NullableTypeDemo
    {
        
        private double? cost = 100;

        //Note that nullableCost is not initialized. hence it will be null instead of 0
        //since we are using double?
        public double? nullableCost;        

        /// <summary>
        /// This method demo Nullable types
        /// i;e a variable that can hold a value or null
        /// Specified by adding ? 
        /// </summary>
        /// <returns></returns>
        public double? ApplyPercentDiscount(double discount)
        {
            cost -= (cost * discount / 100);
            return cost;
        }

        public double? ApplyFlatDiscount(double discount)
        {
            cost -= discount;
            return cost;
        }


        //Note that return type is double? 
        //Hence our method is capale of returning both null and double.
        public double? GetCost()
        {
            if (cost < 0)
                return null;
            else
                return cost;
        }

        //Note that return type is double? 
        //Hence it can retur double or null
        public double? GetNullableCost()
        {
            return nullableCost;
        }        
    }
}
