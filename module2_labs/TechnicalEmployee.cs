using System;
namespace module2_labs
{
    public class TechnicalEmployee : Employee
    {
        public TechnicalEmployee(string name) : base(name, 75000)
        {

        }

        //creates int variable successfulCheckIns and asigns value to 5
        public int successfulCheckIns = 5;

        //method returns the toString() method - which is the employee's ID 
        //number and name - and prints number of successfull checkins the employee has had
        public override string employeeStatus()
        {
            return this.toString() + " has " + this.successfulCheckIns + " succesful check ins";

        }
    }
}
