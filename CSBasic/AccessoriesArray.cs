/*
 * This class is used to demonstrate Generic Interface.
 * This implements IAccessories
 * Also please look AccessoriesList.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    // This classs in implements the generic interface IAccessories
    class AccessoriesArray : IAccessories<int>
    {
        public int[] ItemList;
        int index;

        public AccessoriesArray(int[] itemlist)
        {
            ItemList = itemlist;
            index = 0;
        }

        
        public void AddItem(int item)
        {
            ItemList[index] = item;
            index++;
        }

        public void DisplayItem()
        {
            if (ItemList.Length > 0)
            {
                foreach (var item in ItemList)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Array is empty. There is nothing to display.");
            }
        }
    }
}