using System;

namespace Module_3_Assignment
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Type exit to quit or \n");
            Console.WriteLine("Choose one of the options to continue: student, teacher, UProgram, degree or course.");

            var s = Console.ReadLine();
            GetInformation(s);

            try
            {
                validateStudentBirthday();
            }
            catch (NotImplementedException)
            {
                Console.WriteLine("\nException: This Function Has NOT been implemented yet.\n");
            }

            Console.ReadLine();
        }

        // User enter type first to tell the program which type of user information he would like to enter
        // i.e. student, teacher, UProgram, degree or course
        private static void GetInformation(string type)
        {
            switch (type)
            {
                case "student":
                case "teacher":
                {
                    Console.WriteLine("Enter first name: ");
                    var s1 = Console.ReadLine();
                    Console.WriteLine("Enter last name: ");
                    var s2 = Console.ReadLine();
                    Console.WriteLine("Enter birthdate: ");
                    var s3 = Console.ReadLine();

                    PrintDetails("student", s1, s2, s3);
                    break;
                }
                case "UProgram":
                {
                    Console.WriteLine("Enter program name: ");
                    var s1 = Console.ReadLine();
                    Console.WriteLine("Enter department head: ");
                    var s2 = Console.ReadLine();
                    Console.WriteLine("Enter degree: ");
                    var s3 = Console.ReadLine();

                    PrintDetails("UProgram", s1, s2, s3);
                    break;
                }
                case "degree":
                {
                    Console.WriteLine("Enter degree name: ");
                    var s1 = Console.ReadLine();
                    Console.WriteLine("Enter credits required: ");
                    var s2 = Console.ReadLine();
                    Console.WriteLine("Enter current tuition: ");
                    var s3 = Console.ReadLine();

                    PrintDetails("degree", s1, s2, s3);
                    break;
                }
                case "course":
                {
                    Console.WriteLine("Enter course name: ");
                    var s1 = Console.ReadLine();
                    Console.WriteLine("Enter credits: ");
                    var s2 = Console.ReadLine();
                    Console.WriteLine("Enter duration in weeks: ");
                    var s3 = Console.ReadLine();
                    Console.WriteLine("Enter teacher: ");
                    var s4 = Console.ReadLine();

                    PrintDetails("course", s1, s2, s3, s4);
                    break;
                }
                case "exit":
                {
                    break;
                }
                default:
                {
                    Console.WriteLine("Invalid Type. Please choose from student, teacher, UProgram, degree or course.\n");
                    var s = Console.ReadLine();
                    GetInformation(s);
                    break;
                }
            }
        }

        private static void PrintDetails(string type, string s1, string s2, string s3, string s4 = null)
        {
            Console.WriteLine("Print details: ");
            switch (type)
            {
                case "student":
                case "teacher":
                    Console.WriteLine("{0} {1} was born on: {2}", s1, s2, s3);
                    break;
                case "UProgram":
                    Console.WriteLine("Program is {0}, head of department is {1}, degree is {2}.", s1, s2, s3);
                    break;
                case "degree":
                    Console.WriteLine("You will spend {0} dollars for {1} credits to get a degree on {2}.", s3, s2, s1);
                    break;
                case "course":
                    Console.WriteLine("You will spend {0} weeks with teacher {1} in course \"{2}\" for {3} credits.", s3, s4,
                        s1, s2);
                    break;
                default:
                    break;
            }
        }

        private static void validateStudentBirthday()
        {
            var ex = new NotImplementedException();
            throw ex;
        }
    }
}
