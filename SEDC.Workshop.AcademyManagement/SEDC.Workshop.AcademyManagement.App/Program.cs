using SEDC.Workshop.AcademyManagement.App.Enums;
using SEDC.Workshop.AcademyManagement.App.Models;

var admins = GenerateAdmins(5);
var trainers = GenerateTrainers(10);
var students = GenerateStudents(30);

bool quit = false;

while (!quit)
{
    Console.WriteLine("Choose your role and log in:\n1. Admin\n2. Trainer\n3. Student");
    var userRole = (Role)int.Parse(Console.ReadLine());

    Console.WriteLine("Enter userName:");
    var userNameInput = Console.ReadLine();

    Console.WriteLine("Enter password:");
    var passwordInput = Console.ReadLine();

    bool logout = false;
    while (!logout)
    {
        switch (userRole)
        {
            case Role.Admin:
                var admin = admins.FirstOrDefault(a => a.UserName.ToLower() == userNameInput.ToLower() && a.Password == passwordInput);
                if (ValidCredentials(admin))
                {
                    logout = LoadAdminActions(admins, trainers, students, admin);
                }
                else
                {
                    logout = true;
                }
                break;
            case Role.Trainer:
                var trainer = trainers.FirstOrDefault(t => t.UserName.ToLower() == userNameInput.ToLower() && t.Password == passwordInput);
                if (ValidCredentials(trainer))
                {
                    logout = LoadTrainerActions(students, trainer);
                }
                else
                {
                    logout = true;
                }
               
                break;
            case Role.Student:
                var student = students.FirstOrDefault(s => s.UserName.ToLower() == userNameInput.ToLower() && s.Password == passwordInput);
                if (ValidCredentials(student))
                {
                    logout = LoadStudentActions(student);
                }
                else
                {
                    logout = true;
                }
              
                break;
        }
    }
}

bool LoadStudentActions(Student student)
{
    bool quit = false;
    while (!quit)
    {
        Console.WriteLine(@"What would you like to do?
1. Show Current Subject
2. Show Grades
3. Logout");
        var actionInput = int.Parse(Console.ReadLine());

        switch (actionInput)
        {
            case 1:
                student.PrintCurrentSubject();
                break;
            case 2:
                student.PrintGrades();
                break;
            case 3:
                quit = true;
                break;
            default:
                break;
        }
    }

    return quit;
}

Student CreateNewStudent()
{
    Console.WriteLine("Please enter first name:");
    var firstNameInput = Console.ReadLine();

    Console.WriteLine("Please enter last name:");
    var lastNameInput = Console.ReadLine();

    Console.WriteLine("Please enter userName name:");
    var userNameInput = Console.ReadLine();

    Console.WriteLine("Please enter password name:");
    var passwordInput = Console.ReadLine();

    Console.WriteLine("Please enter current subject name:");
    var subjectNameInput = Console.ReadLine();

    var student = new Student(userNameInput, passwordInput, firstNameInput, lastNameInput);
    student.CurrentSubject = new Subject { Name = subjectNameInput };

    return student;
}

Trainer CreateNewTrainer()
{
    Console.WriteLine("Please enter userName name:");
    var userNameInput = Console.ReadLine();

    Console.WriteLine("Please enter password name:");
    var passwordInput = Console.ReadLine();

    var trainer = new Trainer(userNameInput, passwordInput);

    return trainer;
}

Admin CreateNewAdmin()
{
    Console.WriteLine("Please enter userName name:");
    var userNameInput = Console.ReadLine();

    Console.WriteLine("Please enter password name:");
    var passwordInput = Console.ReadLine();

    var admin = new Admin(userNameInput, passwordInput);

    return admin;
}

List<Admin> GenerateAdmins(int numberOfUsers)
{
    var users = new List<Admin>();

    for (int i = 1; i <= numberOfUsers; i++)
    {
        users.Add(new Admin($"username{i}", $"password{i}"));
    }

    return users;
}

List<Trainer> GenerateTrainers(int numberOfUsers)
{
    var users = new List<Trainer>();

    for (int i = 1; i <= numberOfUsers; i++)
    {
        users.Add(new Trainer($"username{i}", $"password{i}"));
    }

    return users;
}

List<Student> GenerateStudents(int numberOfUsers)
{
    var subjects = new Subject[] { new Subject { Name = "C#" }, new Subject { Name = "JS Basic" }, new Subject { Name = "HTML" }, new Subject { Name = "CSS" } };

    var users = new List<Student>();


    for (int i = 1; i <= numberOfUsers; i++)
    {
        Random rand = new Random();
        int subjectsIndex = rand.Next(1, subjects.Length - 1);

        var user = new Student($"username{i}", $"password{i}", $"firstName{i}", $"lastName{i}");
        user.CurrentSubject = subjects[subjectsIndex];
        user.Grades = GenerateRandomGrades(subjects, subjectsIndex);

        users.Add(user);
    }

    return users;
}

Dictionary<string, int> GenerateRandomGrades(Subject[] subjects, int subjectsIndexToExclude)
{
    var grades = new Dictionary<string, int>();

    for (int i = 0; i < subjects.Length; i++)
    {
        if (i == subjectsIndexToExclude)
        {
            continue;
        }

        Random rand = new Random();
        int randomGrade = rand.Next(5, 10);

        grades.Add(subjects[i].Name, randomGrade);
    }

    return grades;
}

bool LoadAdminActions(List<Admin> admins, List<Trainer> trainers, List<Student> students, Admin? admin)
{
    bool quit = false;
    while (!quit)
    {
        Console.WriteLine("What would you like to do?\n1. Add User\n2. Remove User\n3.Logout");
        var actionInput = int.Parse(Console.ReadLine());
        Console.WriteLine("What role is the user?\n1. Admin\n2. Trainer\n1. Student");
        var userRoleToAction = (Role)int.Parse(Console.ReadLine());

        if (actionInput == 1)
        {
            switch (userRoleToAction)
            {
                case Role.Admin:
                    admin.AddUser(admins, CreateNewAdmin());
                    break;
                case Role.Trainer:
                    admin.AddUser(trainers, CreateNewTrainer());
                    break;
                case Role.Student:
                    admin.AddUser(students, CreateNewStudent());
                    break;
            }
        }
        else if (actionInput == 2)
        {
            Console.WriteLine("Write the users userName:");
            var userNameToRemove = Console.ReadLine();

            switch (userRoleToAction)
            {
                case Role.Admin:
                    admin.RemoveUser(admins, userNameToRemove);
                    break;
                case Role.Trainer:
                    admin.RemoveUser(trainers, userNameToRemove);
                    break;
                case Role.Student:
                    admin.RemoveUser(students, userNameToRemove);
                    break;
            }
        }
        else if (actionInput == 3)
        {
            quit = true;
        }
    }

    return quit;
}

static bool LoadTrainerActions(List<Student> students, Trainer trainer)
{
    bool quit = false;
    while (!quit)
    {
        Console.WriteLine(@"What would you like to do?
1. Print Student Names
2. Print user subjects for user
3.Print attending students for each subject
4. Logout");
        var actionInput = int.Parse(Console.ReadLine());

        switch (actionInput)
        {
            case 1:
                trainer.PrintAllStudents(students);
                break;
            case 2:
                Console.WriteLine("What is the student userName:");
                var userNameInput = Console.ReadLine();
                trainer.PrintUserSubjects(students, userNameInput);
                break;
            case 3:
                trainer.PrintAttendingStudentsForSubject(students);
                break;
            case 4:
                quit = true;
                break;
            default:
                break;
        }
    }

    return quit;
}

static bool ValidCredentials(User? user)
{
    if (user == null)
    {
        Console.WriteLine("Invalid Credentials. Please try again!");
        return false;
    }

    return true;
}