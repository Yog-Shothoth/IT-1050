using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_1050_Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {

// Instuctors///////////////////////////////
            Instructor John = new Instructor("John", "English");
            Instructor Mike = new Instructor("Mike", "Math");

// Students////////////////////////////////
            Student Jane = new Student("Jane", John);
            Student Joe = new Student("Joe", John);
            Student Melissa = new Student("Melissa", Mike);
            Student Matt = new Student("Matt", Mike);
//Student Grades///////////////////////////
            John.SetGrade(Jane, 95);
            John.SetGrade(Joe, 85);
            Mike.SetGrade(Melissa, 90);
            Mike.SetGrade(Matt, 92);

            //All students print their info

            Jane.PrintAllInfo();
            Joe.PrintAllInfo();
            Melissa.PrintAllInfo();
            Matt.PrintAllInfo();

            System.Console.ReadKey();


        }
    }
}
