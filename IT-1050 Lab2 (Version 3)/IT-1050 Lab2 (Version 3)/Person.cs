﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_1050_Lab2__Version_3_
{
    class Person
    {
        public int Age;
        public string FirstName;
        public string LastName;
        public Person Spouse;

        public static double SumOfAllAges = 0;

   


        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;

        }

        public void PrintNameAndAge()
        {
            System.Console.WriteLine("Name: " + GetFullName() + " " + "Age: " + this.Age);

        }

        

        


    }
}
