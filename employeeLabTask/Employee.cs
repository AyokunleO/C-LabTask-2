using System;

namespace employeeLabTask
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private decimal salary;

        public Employee(string fname, string lname, decimal msalary)
        {
            FirstName = fname;
            LastName = lname;
            Salary = msalary;
        }
        public decimal Salary
        {
            get { return salary; }
            private set 
            { 
                if(value > 0){
                    salary = value;
                } 
            }
        }

        public string GetAnnualSalary()
        {
            return $"{FirstName} {LastName}\n Annual Salary -{(Salary * 12):C}\n";
        }
        
        public void Give10Raise()
        {
           Salary= Salary * 0.1m + Salary;
        }
    }
}