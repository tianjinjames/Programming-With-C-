using System;

namespace Module_6_Assignment
{
    public class Teacher : Person
    {
        public void GradeTest()
        {
            Console.WriteLine("Teacher grades tests.");
        }

        public Teacher(string s1, string s2, string s3)
        {
            firstName = s1;
            lastName = s2;
            birthday = s3;
        }
    }
}