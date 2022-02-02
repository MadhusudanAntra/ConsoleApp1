
using System;


namespace ConsoleApp1
{
     class MethodExample
    {
         
        /*[access-modifier] return-type MethodName([parameters])  //formal parameters
         * {
         * 
         *     statements
         * }
         * 
         * 
         * classObject.MethodName([parameters]);    //actual parameters
         * 
         */


        public void AddTwoIntegers(int a, int b)  //formal parameters
        { 
           Console.WriteLine("Addition = "+(a + b));
        }
        public double SubtractTwoNumbers(double a, double b)
        { 
          return a - b;
        }
        /*
         * modes of parameters
         * passing by value ( default mode)
         * passing by reference
         * out mode of parameter
         * optional parameter
         * variable length parameter
         * 
         */

        /// <summary>
        /// Passing by value mode will create a copy of actual parameter and pass them to
        /// formal parameters. changing the value of formal parameters will not reflect into
        /// actual parameters
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void PassingByValue(int a, int b) //formal parameters
        {
            a = 28;
            b = 37;
            // Console.WriteLine("a = "+a+" and b = "+b);
            Console.WriteLine($" inside method value of a = {a} and b = {b}");
           
        }

        public void PassingByReference(ref int a,ref int b)
        {
            a = 28;
            b = 37;
            // Console.WriteLine("a = "+a+" and b = "+b);
            Console.WriteLine($" inside method value of a = {a} and b = {b}");
        }

        public bool IsAuthenticate(string username, string password, out string msg) {
            msg = "";
            if (username == "scott" && password == "tiger")
            {
                msg = " You have been authenticated successfully";
                return true;
            }
            if (username != "scott")
            {
                msg = "invalid username. ";
            }
            if (password != "tiger")
            {
                msg = msg + "Invalid password ";
            }
            return false; 
        }

        public double AreaOfCircle(double r, double pi=3.14, double extra=20)
        {
            Console.WriteLine(extra);
            return pi * r * r;
        }

        public void AddIntegers(int a, int b)
        {
            Console.WriteLine($"Sum  = {a+b}");
        }

        public void AddIntegers(int a, int b, int c)
        {
            Console.WriteLine($"Sum = {a+b+c}");
        }

        public void GetTotal(params int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            { 
            sum = sum + nums[i];
            }
            Console.WriteLine(sum);
        }
    }
}
