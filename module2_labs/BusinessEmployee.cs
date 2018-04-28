using System;
namespace module2_labs
{
    public class BusinessEmployee : Employee
    {
        public BusinessEmployee(string name) : base(name, 50000)
        {
        }

        //creates double var called bonusBudget and assigns value to 1000
        public double bonusBudget = 1000;

        //this method returns the toString() method - which is the employee's ID number and name - and prints the bonus budget
        public override string employeeStatus()
        {
            return toString() + " with a budget of " + this.bonusBudget;
        }


    }
}
