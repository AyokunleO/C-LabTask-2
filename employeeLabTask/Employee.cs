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

        public decimal EmployeeTest()
        {
            return Convert.ToDecimal(Salary * 12);
        }
        
    }
}