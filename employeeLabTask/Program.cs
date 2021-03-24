using System;

namespace employeeLabTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("David", "Busting", 5000m);
            Console.WriteLine($"{employee.FirstName} {employee.LastName}'s yearly salary is: {employee.EmployeeTest():C}");
            Console.WriteLine($"After 10% increment: {employee.EmployeeTest() + (employee.EmployeeTest()*0.10m):C}");


            Employee employee2 = new Employee("John", "Legend", 10000m);
            Console.WriteLine($"{employee2.FirstName} {employee2.LastName}'s yearly salary is: {employee2.EmployeeTest():C}");
            Console.WriteLine($"After 10% increment: {employee.EmployeeTest() + (employee.EmployeeTest()*0.10m):C}");
        }  
    }
}
