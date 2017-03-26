using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_5_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Barack", "Obama", "2017");
            Student s2 = new Student("George", "Bush", "2017");
            Student s3 = new Student("Bill", "Clinton", "2017");

            Teacher t1 = new Teacher("Kobe", "Bryant", "2015");

            Course myCourse = new Course("Programming With C#", "15", t1);
            myCourse.myStudents = new Student[] {s1,s2,s3};

            Degree myDegree = new Degree("Bachelor of Applied Science", "5");
            myDegree.myCourses = new Course[] {myCourse};

            UProgram myUProgram = new UProgram("Information Technology", "Alien", "BASC");
            myUProgram.myDegrees = new Degree[] {myDegree};
            
            printInfo(myUProgram);
        }

        static void printInfo(UProgram myProgram)
        {
            Console.WriteLine("The {0} program contains: ", myProgram.programName);
            foreach (var myDegree in myProgram.myDegrees)
            {
                Console.WriteLine("{0} degree \n", myDegree.degreeName);

                Console.WriteLine("{0} degree contains the course: ", myDegree.degreeName);
                foreach (var myCourse in myDegree.myCourses)
                {
                    Console.WriteLine("{0} \n", myCourse.courseName);
                    Console.WriteLine("The {0} course contains {1} students.\n", myCourse.courseName, Student.registeredStudent);
                }
            }
        }
    }

    class Student
    {
        public static int registeredStudent = 0;
        public string firstName { get; }
        public string lastName { get; }
        public string birthday { get; }

        public Student(string s1, string s2, string s3)
        {
            firstName = s1;
            lastName = s2;
            birthday = s3;
            registeredStudent++;
        }
    }

    class Teacher
    {
        public string firstName { get; }
        public string lastName { get; }
        public string birthday { get; }

        public Teacher(string s1, string s2, string s3)
        {
            firstName = s1;
            lastName = s2;
            birthday = s3;
        }
    }

    class UProgram
    {
        public Degree[] myDegrees { get; set; }
        public string programName { get; }
        public string departmentHead { get; }
        public string degree { get; }

        public UProgram(string s1, string s2, string s3)
        {
            programName = s1;
            departmentHead = s2;
            degree = s3;
        }
    }

    class Degree
    {
        public Course[] myCourses { get; set; }
        public string degreeName { get; }
        public string credits { get; }

        public Degree(string s1, string s2)
        {
            degreeName = s1;
            credits = s2;
        }
    }

    class Course
    {
        public Student[] myStudents { get; set; }
        public Teacher teacher { get; }
        public string courseName { get; }
        public string credits { get; }

        public Course(string s1, string s2, Teacher t1)
        {
            courseName = s1;
            credits = s2;
            teacher = t1;
        }
    }
}
