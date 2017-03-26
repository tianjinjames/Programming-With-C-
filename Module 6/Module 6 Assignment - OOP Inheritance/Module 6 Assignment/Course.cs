namespace Module_6_Assignment
{
    public class Course
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