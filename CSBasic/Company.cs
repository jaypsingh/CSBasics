/*
* This class is meant to serve as the base class for the demo or inheritence
* NOTE that C# support only single inheritence.
* 
* Below cocepts will be demoed using this file and it's derived classes:
* - Inheritence
* - Abstract Class
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    public abstract class Company
    {
        public Company(int ID, string Name)
        {
            CompanyID = ID;
            CompanyName = Name;          
        }

        public abstract void AddEmployee(int employeeNumber);
        public abstract void GetEmployeeCount();
        public abstract void ListEmployeeNumbers();

        public const double TAX = .3;
        public const double otherExpence = .6;

        public int CompanyID
        {
            get;
            set;
        }

        public string CompanyName
        {
            get;
            set;
        }

        public void CalculateRevenues(double pbt)
        {
            var profitAfterTax = pbt - (TAX * pbt);
            var netProfit = profitAfterTax - (profitAfterTax * otherExpence);
            System.Console.WriteLine($"Net profit is: {netProfit:N2}");
        }


    }
}
