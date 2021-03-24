using System;

namespace employeeLabTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("David", "Busting", 5000m);
            Employee employee2 = new Employee("John", "Legend", 10000m);

            Console.WriteLine($"{employee1.GetAnnualSalary()}");
            Console.WriteLine($"{employee2.GetAnnualSalary()}");

            employee1.Give10Raise();
            employee2.Give10Raise();

            Console.WriteLine("Salaries after 10% raise!\n");

            Console.WriteLine(employee1.GetAnnualSalary());
            Console.WriteLine(employee2.GetAnnualSalary());

            
        }  
    }
}
