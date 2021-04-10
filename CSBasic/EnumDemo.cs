using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    class EnumDemo
    { 
        public enum Options
        {
            yes,    //value is 0
            no      //value is 1
        };

        public enum SuperHero
        {
            BatMan = 1,     //value is 1
            Deadpool,       //value is 2
            SuperMan        //Value is 3
        };

        public void PrintEnumValues()
        {
            Options Yes = Options.yes;

            Console.WriteLine($"String value of Yes: {Options.yes}, No: {Options.no}");
            Console.WriteLine($"Integer value of Yes: {(int)Yes}, No: {(int)Options.no}");

            Console.WriteLine($"String Value of Batman: {SuperHero.BatMan}, DeadPool: {SuperHero.Deadpool}, SuperMan: {SuperHero.SuperMan}");
            Console.WriteLine($"Integer value of Batman: {(int)SuperHero.BatMan}, DeadPool: {(int)SuperHero.Deadpool}, SuperMan: {(int)SuperHero.SuperMan}");
        }
    }
}

