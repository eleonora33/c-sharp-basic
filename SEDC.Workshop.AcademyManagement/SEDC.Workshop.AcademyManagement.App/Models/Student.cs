using SEDC.Workshop.AcademyManagement.App.Enums;

namespace SEDC.Workshop.AcademyManagement.App.Models
{
    public class Student : User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public Subject CurrentSubject { get; set; }
        public Dictionary<string, int> Grades { get; set; }

        public Student(string userName, string password, string firstName, string lastName)
            : base(userName, password, Role.Student)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void PrintCurrentSubject()
        {
            Console.WriteLine($"Current subject is: {CurrentSubject.Name}");
        }

        public void PrintGrades()
        {
            foreach (var grade in Grades)
            {
                Console.WriteLine($"Subject: {grade.Key} => Grade: {grade.Value}");
            }
        }
    }
}
