using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_4_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] myArrayStudents = new Student[5];
            myArrayStudents[0] = new Student("Barack","Obama","2017-01-01");
            myArrayStudents[1] = new Student("George", "Bush", "2017-01-01");
            myArrayStudents[2] = new Student("Bill", "Clinton", "2017-01-01");
            myArrayStudents[3] = new Student("George", "Bush", "2017-01-01");
            myArrayStudents[4] = new Student("Jimmy", "Carter", "2017-01-01");

            foreach (Student s in myArrayStudents)
            {
                System.Console.WriteLine("Student {0} {1} was born on {2}", s.firstName, s.lastName, s.birthday);
            }

            Console.ReadLine();
        }

        struct Student
        {
            public string firstName { get; }
            public string lastName { get; }
            public string birthday { get; }

            public Student (string s1, string s2, string s3) : this()
            {
                this.firstName = s1;
                this.lastName = s2;
                this.birthday = s3;
            }
        }

        struct Teacher
        {
            public string firstName { get; }
            public string lastName { get; }
            public string birthday { get; }

            public Teacher(string s1, string s2, string s3)
            {
                this.firstName = s1;
                this.lastName = s2;
                this.birthday = s3;
            }
        }

        // Avoid duplicate "Program" name
        struct ProgramStruct
        {
            private string name { get; }
            private string degree { get; }
            private string duration { get; }

            public ProgramStruct(string s1, string s2, string s3)
            {
                this.name = s1;
                this.degree = s2;
                this.duration = s3;
            }
        }

        struct course
        {
            private string name { get; }

            public course(string s1)
            {
                this.name = s1;
            }
        }
    }

}
