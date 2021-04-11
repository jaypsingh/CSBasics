/*
 * This file demonstrates the use of Dictionary. 
 * Dictionaries are datatype in C# that can be used to keep key-value pair.
 * 
 * This file demonstrates the below concepts:
 * - Initializing a dictionary.
 * - Additng item to dictionary
 * - Get Item from dictionary
 * - Check if an item exists in a dictionary
 * - Return item from dictionay only if it exists.
 * - Loop a dictionary on Key
 * - Loop a dictionary on Value
 * - Loop dictionary on elements
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    class DictionaryDemo
    {
        Dictionary<string, string> Hero;

        public DictionaryDemo()
        {
            Hero = new Dictionary<string, string>()
            {
                { "BatMan", "Bruce" },
                { "SpiderMan", "Peter" },
            };
        }

        public void AddItemToDict(string realName, string superHeroName)
        {
            try
            {
                Hero.Add(realName, superHeroName);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Not Adding the (Key, Value) pair since duplicate key Exists");
                Console.WriteLine(ex.Message);
            }
        }

        public void DictOfObject()
        {
            // Initialize the objects
            var Bruce = new SuperHero( "BatMan", "Gotham", "Joker", 10.00 );
            var Peter = new SuperHero( "SpiderMan", "New York", "Dr", 7.00 );

            // Create dictionary of objects. This dictionary NewHero have values SuperHero class object.
            var NewHero = new Dictionary<string, SuperHero>()
            {
                { "Bruce", Bruce },
                { "Peter", Peter},
            };
        }

        public void ViewDict()
        {
            Console.WriteLine(Hero);
        }

        public string GetDictItem(string key)
        {
            return Hero[key];
        }

        public string GetDictItemContains(string key)
        {
            if (Hero.ContainsKey(key))
            {
                return Hero[key];
            }
            return ("None");
        }

        public string GetDictItemTryGet(string key)
        {
            if (Hero.TryGetValue(key, out string value))
            {
                return value;
            }
            return ("None");
        }

        public void LoopDictKeys()
        {
            foreach (var key in Hero.Keys)
            {
                Console.WriteLine(Hero[key]);
            }
        }

        public void LoopDictVaues()
        {
            foreach (var value in Hero.Values)
            {
                Console.WriteLine(value);
            }
        }

        public void LoopDict()
        {
            foreach (var element in Hero)
            {
                var key = element.Key;
                var value = element.Value;
                Console.WriteLine($"key: {key}, value: {value}");
            }
        }
    }
}
