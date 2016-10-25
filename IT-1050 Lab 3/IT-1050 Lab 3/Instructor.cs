using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_1050_Lab_3
{
    class Instructor
    {

        //Name
        //CourseName
        private string firstName;
        private string courseName;
        

        

        //created with name and course name
        public Instructor(string firstName,string courseName)
        {
            this.firstName = firstName;
            this.courseName = courseName;

            }


        public void SetStudentGrade(Student Student, int Grade)
        {
           
        }

        //can set student grade of any student (2 perameters (Student, Int))

        public void SetGrade(Student Student, int Grade)
        {
            Student.SetGrade(Grade);
        }


        //can Print first name, last name, course name
        public string GetInstructorNameAndCourse()
        {
            return
              this.firstName + " who teaches " + this.courseName + ". ";
        }

        public void PrintInstructorInfo()
        {
            System.Console.WriteLine(GetInstructorNameAndCourse());
        }




    }
    }

