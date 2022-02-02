using System;
using ConsoleApp1.Entities;

namespace ConsoleApp1.UIScreen
{
    class ManageEmployee
    {
        Employee employee;
        Employee employee2;
        public ManageEmployee()
        {
            employee = new Employee();
            employee2 = new Employee();
        }
        public void AddEmployee()
        {
            employee.Id = 1;
            employee.Name = "Peter";
            employee.Age = 37;
            employee.Mobile = "9876543210";
            employee.Salary = 4920.45m;
            employee.EmailId = "peter@gmail.com";
            employee.DeptId = 2;

            employee2.Id = 2;
            employee2.Age = 32;
            employee2.EmailId = "Ria@gmail.com";
            employee2.Name = "Ria";
            employee2.Mobile = "1234567890";
            employee2.Salary = 5000;
            employee2.DeptId = 2;
        }
        public void PrintEmployeeDetail()
        {
            Console.WriteLine($"{employee.Id} \t {employee.Name} \t {employee.DeptId} \t {employee.Salary}");
            Console.WriteLine($"{employee2.Id} \t {employee2.Name} \t {employee2.DeptId} \t {employee2.Salary}");
        }
    }
}
