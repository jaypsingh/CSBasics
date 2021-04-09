/*
* This class is used to demonstrate the concept of Interface.
* This implements the interface ICompany.
* 
* You can notice how this is different from an Abstract class.
* Also please notice that all the methods and getters and setters are declared in the interface. 
* All the implementation is done here.
* 
* Below cocepts will be demoed using this file and it's interface:
* - Interface
* - more than once class can implememt interface
* - a class can implement more than one interface as well
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    // ICompany is an interface. That we are inmplementing here.
    class CompanyShipping : ICompany
    {
        public CompanyShipping(string companyName, int companyID)
        {
            CompanyName = companyName;
            CompanyID = companyID;
            employeeList = new List<int> {101, 102, 103 };
        }
        public string CompanyName { get ; set ; }
        public int CompanyID { get ; set ; }
        List<int> employeeList;

        public void AddEmployee(int employeeID)
        {
            employeeList.Add(employeeID);
        }

        public void CalculateRevenues(double pbt)
        {
            var tax = .3 * pbt;
            var expence = .4 * pbt;
            var netProfit = pbt - (tax + expence);
            System.Console.WriteLine($"Net profit is: {netProfit}");

        }

        public int GetEmployeeCount()
        {
            return employeeList.Count;
        }

        public void ListEmployeeNumbers()
        {
           System.Console.WriteLine("Listing emplyee for KShip");
           foreach(var employeeID in employeeList)
            {
                System.Console.WriteLine(employeeID);
            }
        }
    }
}
