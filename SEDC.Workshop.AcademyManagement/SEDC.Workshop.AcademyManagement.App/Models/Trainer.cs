using SEDC.Workshop.AcademyManagement.App.Enums;

namespace SEDC.Workshop.AcademyManagement.App.Models
{
    public class Trainer : User
    {
        public Trainer(string userName, string password)
            : base(userName, password, Role.Trainer)
        {

        }

        public void PrintAllStudents(List<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student.FullName + "\n");
            }
        }

        public void PrintAttendingStudentsForSubject(List<Student> students)
        {
            var subjectNames = students.Select(s => s.CurrentSubject.Name).Distinct().ToList();

            foreach (var subjectName in subjectNames)
            {
                var attendingStudentsCount = students.Count(s => s.CurrentSubject.Name == subjectName);

                Console.WriteLine($"Subject: {subjectName}; Attending Students: {attendingStudentsCount}");
            }
        }

        public void PrintUserSubjects(List<Student> students, string userName)
        {
            var student = students.FirstOrDefault(s => s.UserName == userName);

            foreach (var grade in student.Grades)
            {
                Console.WriteLine($"Subject Name = {grade.Key}: Grade = {grade.Value}");
            }
        }
    }
}
