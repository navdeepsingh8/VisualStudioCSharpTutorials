﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyExample
{
    class Person
    {
        private string myName = "N/A";
        private int myAge = 0;

        // Declare a Name property of type string:
        public string Name
        {
            get
            {
                return myName;
            }
            set
            {
                myName = value;
            }
        }

        // Declare an Age property of type int:
        public int Age
        {
            get
            {
                return myAge;
            }
            set
            {
                myAge = value;
            }
        }

        //public override string ToString()
        //{
        //    return "Name = " + Name + ", Age = " + Age;
        //}

        public static void Main()
        {
            Console.WriteLine("Simple Properties");

            // Create a new Person object:
            Person person = new Person();

            person.ToString()

            // Print out the name and the age associated with the person:
            Console.WriteLine("Person details - {0}", person);

            // Set some values on the person object:
            person.Name = "Joe";
            person.Age = 99;
            Console.WriteLine("Person details - {0}", person);

            // Increment the Age property:
            person.Age += 1;
            Console.WriteLine("Person details - {0}", person);

            Console.ReadKey();
        }

    }

}
