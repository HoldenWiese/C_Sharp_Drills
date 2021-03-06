﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step187Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //One way of instantiating Employee object.
            Employee<string> Holden = new Employee<string>(fName: "Holden", lName: "Wiese", id: 123)
            {
                things = new List<string>() { "Headphones", "Shoes", "Hats" }
            }; 

            //Another way of instantiating employee object.
            Employee<int> Jen = new Employee<int>("Jen", "Hardin", 111);
            Jen.things = new List<int>() { 50, 700, 9 };

            Holden.thingsLoop();
            Jen.thingsLoop();

            Console.Read();
            //Employee Thomas = new Employee("Thomas", "Wiese", 123);
        }
    }
}
//1. Make the Employee class take a generic type parameter.
//2. Add a property to the Employee class called "things" and 
//   have its data type be a generic list matching the generic type of the class.
//3. Instantiate an Employee object with type "string" as its generic parameter.
//   Assign a list of strings as the property value of Things.
//4. Instantiate an Employee object with type "int" as its generic parameter.
//   Assign a list of integers as the property value of Things.
//5. Create a loop that prints all of the Things to the Console.