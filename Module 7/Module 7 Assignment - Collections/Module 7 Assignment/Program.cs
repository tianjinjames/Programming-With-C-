using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_6_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Barack", "Obama", "2017");
            Student s2 = new Student("George", "Bush", "2017");
            Student s3 = new Student("Bill", "Clinton", "2017");
            s1.TakeTest();

            Teacher t1 = new Teacher("Kobe", "Bryant", "2015");
            t1.GradeTest();
            Course myCourse = new Course("Programming With C#", "15", t1);

            for (int i = 1; i <= 5; i++)
            {
                s1.GradesAccessor.Push(i);
            }
            for (int i = 6; i <= 10; i++)
            {
                s2.GradesAccessor.Push(i);
            }
            for (int i = 11; i <= 15; i++)
            {
                s3.GradesAccessor.Push(i);
            }

            myCourse.AddStudents(s1);
            myCourse.AddStudents(s2);
            myCourse.AddStudents(s3);

            Degree myDegree = new Degree("Bachelor of Applied Science", "5");
            myDegree.myCourses = myCourse;

            UProgram myUProgram = new UProgram("Information Technology", "Alien", "BASC");
            myUProgram.myDegrees = myDegree;

            printInfo(myUProgram);
        }

        static void printInfo(UProgram myProgram)
        {
            var myDegree = myProgram.myDegrees;
            var myCourse = myDegree.myCourses;
            Console.WriteLine("The {0} program contains: {1}", myProgram.programName, myDegree.degreeName);
            Console.WriteLine("{0} degree contains the course: {1}", myDegree.degreeName, myCourse.courseName);
            Console.WriteLine("The {0} course contains {1} students. Their names are: \n", myCourse.courseName, Student.registeredStudent);
            myCourse.ListStudents();
        }
    }
}
