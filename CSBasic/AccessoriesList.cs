/*
 * This class is used to demonstrate Generic Interface.
 * This implements IAccessories
 * Also please look AccessoriesArray.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    // This classs in implements the generic interface IAccessories
    class AccessoriesList : IAccessories<string>
    {
        public List<string> ItemList;
        public AccessoriesList(List<string> itemlist)
        {
            ItemList = itemlist;
        }

       
        public void AddItem(string item)
        {
            ItemList.Add(item);
        }

        public void DisplayItem()
        {
            if (ItemList.Count > 0)
            {
                foreach (var item in ItemList)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("List is empty. There is nothing to display.");
            }
        }
    }
}
