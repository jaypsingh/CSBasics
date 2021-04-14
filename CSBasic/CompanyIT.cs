/*
* This class is used to demonstrate the concept of Inheritence.
* This inherits the class Company.
* 
* Please notice that the methods in Company class is re-used, 
* abstract classes are impemented 
* and virtual methods are over-riddedn.
* 
* Below cocepts will be demoed using this file and it's interface:
* - Inheritence
* - Abstract class
* - Virtual Methods
* - Method over-riding
*/
using System.Collections.Generic;

namespace CSBasic
{
    class CompanyIT : Company
    {
        public CompanyIT(int id, string name) : base(id, name)
        {
            CompanyID = id;
            CompanyName = name;
            EmployeeList = new List<int> { 100, 101, 102, 103 };
        }

        private List<int> EmployeeList;

        // This is a method to add an employee number to employee database
        public override void AddEmployee(int employeeNumber)
        {
            EmployeeList.Add(employeeNumber);

        }

        // This method lists the employee count
        public override void GetEmployeeCount()
        {
            System.Console.WriteLine($"No of employees in the company is {EmployeeList.Count}");
        }

        // This method will list all the employee numbers
        public override void ListEmployeeNumbers()
        {
            System.Console.WriteLine($"Listing the employee for {CompanyName}");
            foreach (var empNo in EmployeeList)
            {
                System.Console.WriteLine(empNo);
            }
        }
    }
}
