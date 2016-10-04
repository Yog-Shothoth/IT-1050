using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_1050_Lab2__Version_3_
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person();
            Person p2 = new Person();


            //sorry about it not being particularly clean, I had some computer issues and didn't have as much time as I wanted to work on this

            System.Console.WriteLine("What is your first name?");
            p1.FirstName = System.Console.ReadLine();
            System.Console.WriteLine("What is your last name?");
            p1.LastName = System.Console.ReadLine();
            System.Console.WriteLine("What is your age?");
            p1.Age = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("What is first name of your spouse?");
            p1.Spouse = new Person();
            p1.Spouse.FirstName = System.Console.ReadLine();
            System.Console.WriteLine("What is the age of your spouse?");
            p1.Spouse.Age = int.Parse(System.Console.ReadLine());
            p1.Spouse.LastName = p1.LastName;
            p1.Spouse.Spouse = p1;
       
            System.Console.WriteLine("What is your first name?");
            p2.FirstName = System.Console.ReadLine();
            System.Console.WriteLine("What is your last name?");
            p2.LastName = System.Console.ReadLine();
            System.Console.WriteLine("What is your age?");
            p2.Age = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("What is first name of your spouse?");
            p2.Spouse = new Person();
            p2.Spouse.FirstName = System.Console.ReadLine();
            System.Console.WriteLine("What is the age of your spouse?");
            p2.Spouse.Age = int.Parse(System.Console.ReadLine());
            p2.Spouse.LastName = p2.LastName;
            p2.Spouse.Spouse = p2;


            Person.SumOfAllAges = p1.Age + p2.Age + p1.Spouse.Age + p2.Spouse.Age;
            double AverageAge = Person.SumOfAllAges / 4;

            p1.PrintNameAndAge();
            p2.PrintNameAndAge();
            p1.Spouse.PrintNameAndAge();
            p2.Spouse.PrintNameAndAge();


            System.Console.WriteLine(AverageAge);

            System.Console.ReadKey();



           
            

 


        }






    }
}
    

