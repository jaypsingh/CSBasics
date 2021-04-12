/* 
* This is the main class.
* This is the entry point and all the objets and method calls are done here.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    /// <summary>
    /// This is a the main class used that is the entrey point
    /// This is xml style documention and a good practice to use.
    /// </summary>
    class CSBasic
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Welcome to C# Fundamentals");
            System.Console.WriteLine("---------------------------");
            System.Console.WriteLine("---------------------------\n");


            //This is TClassOne demo
            Console.WriteLine("--- Demo TClassOne ----");
            // Notice how the class name incudes the type so that any data type can be used as generic parameter.
            var tClassStrObj = new TClassOne<string>("Archer");
            var tClassDobuleObj = new TClassOne<Double>(21.19);
            var tClassIntObj = new TClassOne<int>(19);

            System.Console.WriteLine($"GenericClassVar :: {tClassStrObj.GenericClassVar}");
            System.Console.WriteLine($"GenericClassVar :: {tClassDobuleObj.GenericClassVar}");
            System.Console.WriteLine($"GenericClassVar :: {tClassIntObj.GenericClassVar}");
            Console.WriteLine("-----------------------------\n");

            //This is TClassMany demo
            Console.WriteLine("--- Demo TClassMany ----");
            // Notice how the class name incudes the type so that any data type can be used as generic parameter.
            var tObjOne = new TClassMany<string, int>("Archer", 21);
            var tObjTwo = new TClassMany<int, double>(19, 10.11);

            System.Console.WriteLine($"Var1: {tObjOne.VarOne}, var2: {tObjOne.VarTwo}");
            System.Console.WriteLine($"Var1: {tObjTwo.VarOne}, var2: {tObjTwo.VarTwo}");
            Console.WriteLine("-----------------------------\n");


            //This is LambdaMethod demo
            System.Console.WriteLine("----- LambdaMethod Demo -----");
            var lamdaObj = new LambdaMethod();
            var sumValue = lamdaObj.GetSum(11.1, 22.2);
            Console.WriteLine($"Sum is: {sumValue}");            
            System.Console.WriteLine("---------------------------\n");

            //This is NullChecking Demo
            System.Console.WriteLine("----- NullChecking Demo -----");
            var nullCheckObj = new NullCheckingDemo();
            var nullvar = nullCheckObj.CheckForNull();
            Console.WriteLine($"This is a null value: {nullvar}");
            var doubleVal = nullCheckObj.GetCostValue();
            Console.WriteLine($"This is a not a null value: {doubleVal}");
            System.Console.WriteLine("---------------------------\n");

            //This is NullableType Demo
            System.Console.WriteLine("----- NullableType Demo -----");
            var nullTypeObj = new NullableTypeDemo();
            var costAfterDiscount = nullTypeObj.ApplyFlatDiscount(10);
            Console.WriteLine($"Cost after first discount: {costAfterDiscount}");
            var costAfterMoreDiscount = nullTypeObj.ApplyPercentDiscount(10);
            Console.WriteLine($"Cost after More discount: {costAfterMoreDiscount}");
            System.Console.WriteLine("---------------------------\n");

            //This is Enums Demo
            System.Console.WriteLine("----- Enums Demo -----");
            var enumObj = new EnumDemo();
            enumObj.PrintEnumValues();
            System.Console.WriteLine("---------------------------\n");

            //This is ObjectInitializerDemo Demo
            System.Console.WriteLine("----- ObjectInitializerDemo -----");
            // This is example of Default constructor
            var dcObj = new DefaultConstructor();
            dcObj.SuperHeroName = "SuperMan";
            dcObj.Power = 9.0;
            System.Console.WriteLine("---------------------------\n");

            // This is example of Object Initializer constructor. Basically it is same as Default Constructor but with diffrent syntax.
            var objectInitializeObj = new ObjectInitializers
            {
                Power = 9.8,
                SuperHeroName = "DeadPool",
            };

            // This is example of Parameterized constructor
            var parameterizedObj = new ParameterizedConstructor(9.9, "BatMan");
            System.Console.WriteLine("---------------------------\n");

            // This is the GenercInterface Demo
            System.Console.WriteLine("----- GenercInterface Demo -----");
            var itemName = new List<string> { "pen", "pencil", "brush" };
            var itemID = new int[4];
            var itemSlNo = 101;
            var nameObj = new AccessoriesList(itemName);
            var idObj = new AccessoriesArray(itemID);
            Console.WriteLine(" ============> Calling Accessories List...");
            nameObj.AddItem("book");
            nameObj.DisplayItem();
            Console.WriteLine(" ============> Calling Accessories Array...");
            for(var i=0; i<itemID.Length; i++)
            {
                idObj.AddItem(itemSlNo);
                itemSlNo++;
            }
            idObj.DisplayItem();
            System.Console.WriteLine("---------------------------\n");

            // This is the ExceptionDemo demo
            System.Console.WriteLine("----- ExceptionDemo Demo -----");
            var exObj = new ExceptionDemo();
            exObj.AddItemToArray(1);
            exObj.AddItemToArray(2);
            exObj.AddItemToArray(3);
            exObj.DisplayArrayItems();
            System.Console.WriteLine("---------------------------\n");

            // This is the ReadFromConsole demo
            System.Console.WriteLine("----- ReadFromConsole Demo -----");
            var consoleObj = new ReadFromConsole();
            consoleObj.ReadStringFromConsole();
            System.Console.WriteLine("---------------------------\n");


            //This is the BreakContinue demo
            System.Console.WriteLine("----- BreakContinue Demo -----");
            var brkConObj = new BreakContinue();
            brkConObj.DemoBreak();
            brkConObj.DemoContinue();
            System.Console.WriteLine("---------------------------\n");

            //This is the ReadWriteFile demo
            System.Console.WriteLine("----- ReadWriteFile Demo -----");
            var fileObj = new ReadWriteFile("testfile.txt");
            var stringToWrite = new List<string>() {"This is", "something", "i want to", "write" };
            fileObj.WriteToFile(stringToWrite);
            System.Console.WriteLine("Review your current path should have a file testfile.txt with the content we just wrote.");
            System.Console.WriteLine("---------------------------\n");


            // This is Interface demo
            // Note that shippingObj and hotelObject hotel objet both are of type ICompany.
            ICompany shippingObj = new CompanyShipping("KShip", 190918);
            ICompany hotelObject = new CompanyHospitality("KStay", 210784);
            System.Console.WriteLine("----- Interface Demo -----");
            shippingObj.AddEmployee(1123);
            hotelObject.GetEmployeeCount();
            shippingObj.ListEmployeeNumbers();
            hotelObject.CalculateRevenues(210784.19);
            System.Console.WriteLine("---------------------------\n");

            ////This is the test to call python method from C#
            //System.Console.WriteLine("----- Python Test Demo -----");
            //var pyObj = new CallingPy();
            //pyObj.CallPy();
            //System.Console.WriteLine("---------------------------\n");

            // this is Inheritence demo
            var itCompObj = new CompanyIT(170926, "Kite");
            System.Console.WriteLine("----- Inheritence Demo -----");
            itCompObj.AddEmployee(1001);
            itCompObj.GetEmployeeCount();
            itCompObj.ListEmployeeNumbers();
            itCompObj.CalculateRevenues(1000.89);

            System.Console.WriteLine("---------------------------\n");


            // this is Properties demo
            var getsetObj = new Properties("BatMan");
            System.Console.WriteLine("----- GetSet Demo -----");
            getsetObj.Number = 21;
            System.Console.WriteLine($"Name: {getsetObj.Name}");
            System.Console.WriteLine($"Number: {getsetObj.Number}");
            System.Console.WriteLine("---------------------------\n");

            // Below line of code will not work since setter for Name field is private.
            //getsetObj.Name = "Bruce"; 
            getsetObj.Number = 19;
            System.Console.WriteLine($"Number is updated to: {getsetObj.Number}");
            System.Console.WriteLine("---------------------------\n");


            // this is OverLoading demo
            var overloadObj = new OverLoading();
            System.Console.WriteLine("----- OverLoading Class Demo -----");
            overloadObj.FindSum(1.1, 1.2);
            overloadObj.FindSum(1, 2);
            overloadObj.FindSum("Jay", "Kairav");
            System.Console.WriteLine("---------------------------\n");

            // this is FlowAndLoops demo
            var loopObj = new FlowAndLoop();
            System.Console.WriteLine("----- FlowAndLoops Class Demo -----");
            loopObj.PrintIfTrue();
            loopObj.AddListNumbersDoWhile();
            loopObj.AddListNumbersWhile();
            loopObj.AddListNumbersFor();
            loopObj.AddListNumbersForEach();
            System.Console.WriteLine("---------------------------\n");

            // this is MinMaxStatic demo
            var minmaxObj = new MinMaxStatic();
            System.Console.WriteLine("----- MinMaxStatic Class Demo -----");
            minmaxObj.FindMinMax();

            // this is Constuctor demo
            var constructorObj = new Constructor("StoryBook");
            System.Console.WriteLine("----- Constuctor Class Demo -----");
            constructorObj.AddNumber(1.3);
            System.Console.WriteLine("---------------------------\n");

            // this is a array demo
            var arrayObj = new ArrayDemo();
            System.Console.WriteLine("----- Array Class Demo -----");
            arrayObj.SumDoubleArray();
            arrayObj.SumIntArray();
            System.Console.WriteLine("---------------------------\n");

            // this is a list demo
            var listObj = new List();
            System.Console.WriteLine("----- List Class Demo -----");
            listObj.ListDemo();
            System.Console.WriteLine("---------------------------\n");

            // this is a foreach demo
            var foreachObj = new ForEach();
            System.Console.WriteLine("----- ForEach Class Demo -----");
            foreachObj.ForEachDemo();
            System.Console.WriteLine("---------------------------\n");

            // this is a StringInterpolation demo
            var strIntPolObj = new StringInterpolation();
            System.Console.WriteLine("----- StringInterpolation Class Demo -----");
            strIntPolObj.SayHello("Archer");
            System.Console.WriteLine("---------------------------\n");

            // this is FormattingSpecifier demo
            var formatingSpecObj = new FormattingSpecifier();
            System.Console.WriteLine("----- StringInterpolation Class Demo -----");
            formatingSpecObj.FormattingSpecifierDemo();
            System.Console.WriteLine("---------------------------\n");

            

        }
    }
}
