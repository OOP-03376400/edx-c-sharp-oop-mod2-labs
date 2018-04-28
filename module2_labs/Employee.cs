using System;
namespace module2_labs
{
    public class Employee
    {
        //private member variables
        private string employeeName;
        private double employeeBaseSalary;
        private int employeeId;

        //Public properties
        public string Name
        {
            get
            {
                return employeeName;
            }

            set
            {
                employeeName = value;
            }
        }

        public double BaseSalary
        {
            get
            {
                return employeeBaseSalary;
            }

            set
            {
                employeeBaseSalary = value;
            }
        }

        public int ID
        {
            get
            {
                return employeeId;
            }

            set
            {
                employeeId = value;
            }
        }

        //creates integer variable called employeeCount and assigns value to 1
        private static int employeeCount = 1;

        //constructor
        public Employee(string name, double baseSalary)
        {
            this.Name = name;
            this.BaseSalary = baseSalary;
            this.ID = employeeCount++;
        }

        //method to return employee base salary
        public double getBaseSalary()
        {
            return this.BaseSalary;
        }

        // This method returns the employee name
        public string getName()
        {
            return this.Name;
        }
        //this method returns the employee's ID
        public int getEmployeeID()
        {
            return this.ID;
        }

        //this method returns the employee's ID and Name
        public string toString()
        {
            return this.ID + " " + this.Name;
        }

        //this method returns the employee's ID and confirms that the employee is in the system
        public virtual string employeeStatus()
        {
            return toString() + " is in the company's system";
        }

    }
}
