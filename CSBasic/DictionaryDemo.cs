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
                ("BatMan", "Bruce"),
                ("SpiderMan", "Peter"),
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
            Bruce = new SuperHero() { heroname = "BatMan", City = "Gotham", FightsWith = "Joker", Power = 10.00 };
            Peter = new SuperHero() { heroname = "SpiderMan", City = "New York", FightsWith = "Dr", Power = 7.00 };

            // Create dictionary of objects. This dictionary NewHero have values SuperHero class object.
            var NewHero = new Dictionary<string, SuperHero>()
            {
                ("Bruce", Bruce),
                ("Peter", Peter),
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
            string outVar;
            if (Hero.TryGetValue(key))
            {
                return Hero[key];
            }
            return ("None");
        }

        public void LoopDictKeys()
        {
            foreach(var key in Hero.Keys)
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
