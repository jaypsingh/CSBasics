/*
 * This class will be used to demo object initializers. 
 * See the other files on how to use or set object initializers. 
 * This class will just have the class and it's Constructor. 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    class SuperHero
    {        
        string HeroName;
        String City;
        String FightsWith;
        double Power;

        public SuperHero(string heroname, string city, string fightswith, double power)
        {
            heroname = HeroName;
            city = City;
            fightswith = FightsWith;
            power = Power;
        }
    }
}
