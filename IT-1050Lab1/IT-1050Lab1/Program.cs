using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_1050Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("What is your first name? ");
                string firstName = System.Console.ReadLine();
            System.Console.Write("What is your middle initial? ");
            string middleInitial = System.Console.ReadLine();
            System.Console.Write("What is your last name? ");
            string lastName = System.Console.ReadLine();
            string fullName = firstName + " " + middleInitial + ". " + lastName;

            System.Console.Write("What is your height in feet, rounded down to the nearest foot (without extra inches)? ");
            int heightInFeet = int.Parse(System.Console.ReadLine());
            System.Console.Write("Extra Inches? ");
            double extraInches = double.Parse(System.Console.ReadLine());
            double heightInInches = heightInFeet * 12;
                double totalInches = heightInInches + extraInches;
                double totalHeightCM = totalInches * 2.54;

            System.Console.WriteLine("What is your age?");
            int age = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Are you a citizen? (True or False)");
            bool isCitizen = bool.Parse(System.Console.ReadLine());
            bool canVote = age >= 18 && isCitizen;
 
            System.Console.WriteLine("Subject's name is: " + fullName);
            System.Console.WriteLine("Subject's height is: " + totalHeightCM + "cm");
            System.Console.WriteLine("Subject can vote: " + canVote);

            System.Threading.Thread.Sleep(10000); 
        }
    }
}
