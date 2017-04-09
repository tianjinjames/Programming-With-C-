namespace Module_6_Assignment
{
    public class Degree
    {
        public Course myCourses { get; set; }
        public string degreeName { get; }
        public string credits { get; }

        public Degree(string s1, string s2)
        {
            degreeName = s1;
            credits = s2;
        }
    }
}