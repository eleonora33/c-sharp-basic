using SEDC.Workshop.AcademyManagement.App.Enums;

namespace SEDC.Workshop.AcademyManagement.App.Models
{
    public class User
    {
        public virtual Role Role { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public User(string userName, string password, Role role)
        {
            UserName = userName;
            Password = password;
            Role = role;
        }
    }
}
