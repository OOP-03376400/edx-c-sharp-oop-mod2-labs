using System;

namespace module2_labs
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiates Employee object with name Libby and salary 2000 called employee1
            var employee1 = new Employee("Libby", 2000);
            //instantiates TechnicalEmployee object employee2
            var employee2 = new TechnicalEmployee("Zaynah");
            //instantiates BusinessEmployee object as employee3
            var employee3 = new BusinessEmployee("Winter");

            //output to the console
            Console.WriteLine(employee1.employeeStatus() + "..." + employee2.employeeStatus() + "..." + employee3.employeeStatus());
        }
    }
}
