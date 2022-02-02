using System;
using ConsoleApp1.UIScreen;
namespace ConsoleApp1
{
    class Program {
        public static void Main(string[] args) {
            
            MethodExample methodExample = new MethodExample();
            int x=10,y=20;
            //string s;
            //methodExample.IsAuthenticate("smith", "tigers", out s);
            //Console.WriteLine(s);

            //string age = "39alksjlfjsd";
            //int a;
            //if(int.TryParse(age, out a))
            //    Console.WriteLine(a);
            //else
            //    Console.WriteLine("invalid value for age");


            //double area = methodExample.AreaOfCircle( extra: 1500, r:10);
            //Console.WriteLine(area);



            //Console.WriteLine($"Before passing x = {x} and y = {y}");
            //methodExample.PassingByValue(x,y);
            //Console.WriteLine($"after passing x = {x} and y = {y}");
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine($"Before passing x = {x} and y = {y}");
            //methodExample.PassingByReference(ref x,ref y);
            //Console.WriteLine($"after passing x = {x} and y = {y}");


            // methodExample.AddTwoIntegers(x,y);
            // double d1 = 29.15, d2 = 12.17;
            //double sub = methodExample.SubtractTwoNumbers(d1,d2);
            // Console.WriteLine("Subtraction = "+sub);

            // Console.WriteLine("Welcome");
            /*
             * value type = which stores the value directly
             * reference type = they store the memroy reference of the value
             * 
             * int, float, double, DateTime = value type
             * string, object =  reference type
             * 
             * value types are stored in stack memory
             * reference types are stored in heap memory
             * 
             * value type can not accept null but reference type can accept null
             * GC will collect only reference type
             * 
             * 
             * struct and enum are value types. Classes, interface and pointers are reference types
             * 
             * 
             * stack vs heap
             * 
             */

            //float f = 9.2f;
            //double d = 3.14;
            //decimal salary = 4500.50m;
            //Console.WriteLine(salary);
            //Console.WriteLine(int.MinValue);
           // methodExample.GetTotal(10, 20,30,40);

            ManageEmployee manageEmployee = new ManageEmployee();
            manageEmployee.AddEmployee();
            manageEmployee.PrintEmployeeDetail();

            Customer customer = new Customer("John");

        }


    }
}
