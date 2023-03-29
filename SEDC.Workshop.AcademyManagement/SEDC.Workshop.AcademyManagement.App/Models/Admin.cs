using SEDC.Workshop.AcademyManagement.App.Enums;

namespace SEDC.Workshop.AcademyManagement.App.Models
{
    public class Admin : User
    {
        public Admin(string userName, string password)
            : base(userName, password, Role.Admin)
        {
        }

        public void AddUser<T>(List<T> users, T user) 
            where T : User
        {
            users.Add(user);
        }

        public void RemoveUser<T>(List<T> users, string userName)
            where T : User
        {
            if (userName == UserName)
            {
                throw new Exception("Can Not Remove Yourself");
            }

            var user = users.FirstOrDefault(u => u.UserName == userName);

            if (user == null) 
            {
                throw new Exception($"User Not Found With UserName: {userName}");
            }

            users.Remove(user);
        }
    }
}
