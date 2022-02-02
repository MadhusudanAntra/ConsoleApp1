using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /*
     * Constructor is a special member function which shares the name of the class.
     * Constructor is used to create an instance of the class
     * Constructor doesn't have any return type.
     * if there is no constructor in the class then compiler will provide the default constructor
     * if you have a custom constructor then it will replace the default constructor.
     * a constructor can be overloaded
     * it can be used to initialize the class fields
     * you can chain constructors
     * a constructor can be used to pass object of derived type to work with dependency injection.
     * 
     */
     class Customer
    {
        private string cname;
        public Customer() {
            Console.WriteLine("customer constructor is executed");
        }
        public Customer(string name):this() {
            this.cname= name;
            Console.WriteLine($"name = {this.cname}");
        }
    }
}
