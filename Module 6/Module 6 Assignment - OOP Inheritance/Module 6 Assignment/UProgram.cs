namespace Module_6_Assignment
{
    public class UProgram
    {
        public Degree myDegrees { get; set; }
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
}