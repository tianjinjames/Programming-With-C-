using System;
using System.Collections;

namespace Module_6_Assignment
{
    public class Course
    {
        private ArrayList studentsList = new ArrayList();
        public Teacher teacher { get; }
        public string courseName { get; }
        public string credits { get; }

        public Course(string s1, string s2, Teacher t1)
        {
            courseName = s1;
            credits = s2;
            teacher = t1;
        }

        // Pass in an array of Student object, push each object into the arraylist
        public void AddStudents(Student student)
        {
                studentsList.Add(student);
        }

        public void ListStudents()
        {
            foreach (Student student in studentsList)
            {
                Console.WriteLine("FirstName: {0}, LastName: {1}", student.firstName, student.lastName);
            }
        }
    }
}