using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    class Employee
    {
        private int id;
        private string name;
        private int age;
        private decimal salary;
        private int deptId;

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }
        public int Age
        {
            get { return age; }
            set { 
                if(value < 18 || value>56)
                    age = 18;
                else
                age = value; }
        }

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public int DeptId
        {
            get { return deptId; }
            set { deptId = value; }
        }

        public string Mobile { get; set; }
        public string EmailId { get; set; }
    }
}
