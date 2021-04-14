/*
This class is meant to serve as the interface class for the demo or ICompany
NOTE that C# support only single inheritence but more than 1 inerface can be implemented by the class

Below cocepts will be demoed using this file and the classes that implements this interface:
- Interface
*/

namespace CSBasic
{
    public interface ICompany
    {
        void AddEmployee(int employeeID);
        int GetEmployeeCount();
        void ListEmployeeNumbers();
        void CalculateRevenues(double netProfit);
        string CompanyName { get; set; }
        int CompanyID { get; set; }
        // Note that interface cannot contan fields hence variable declaration is not allowed.
    }
}
