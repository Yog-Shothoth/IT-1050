using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_1050_Lab_3
{
    class Student
    {

        //Name
        //Grade
        //Teacher
        private string Name;
        private int Grade;
        private Instructor Teacher;

        //Created with Name and Teacher, Grade default 0
        public Student(string Name, Instructor Teacher)
        {
            this.Name = Name;
            this.Teacher = Teacher;
        }
        
        public Student()
        {
            int Grade = 0;
        }
    
//GRADES////////////////////////////////////
        public int getStudentGrade()
        {
            return this.Grade;
        }

        public void SetGrade(int studentGrade)
        {
            this.Grade = studentGrade;
        }

     
        //Can print their name, grade, and teacher info

        public string PrintStudentInfo()
        {

           return this.Name + " recieved a grade of " + this.Grade + " from their teacher ";
  
        }


        //Part where I screamed "F*ck" for a full hour because I couldn't figure out what I'd done wrong
        public void PrintAllInfo()
        {
            System.Console.WriteLine(PrintStudentInfo() + this.Teacher.GetInstructorNameAndCourse());
        }
        
        
    }
}
