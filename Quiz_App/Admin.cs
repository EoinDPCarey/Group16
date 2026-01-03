using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_App
{
    internal class Admin
    {
        private DateTime loginDate;

        public Admin(string username, string password, string email, string role, DateTime loginDate)
        {
            Username = username;
            Password = password;
            Email = email;
            Role = role;
            this.loginDate = loginDate;
        }

        public string Username { get; private set; }
        public string Password { get; private set; }
        public string Email { get; private set; }
        public string Role { get; private set; }

        public void DisplayInfo()
        {
            Console.WriteLine("=== Admin ===");
            Console.WriteLine($"Username: {Username}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Role: {Role}");
            Console.WriteLine($"Login Date: {loginDate}");
        }

        public void UpdateUser(string username, string password, string email, string role, DateTime loginDate)
        {
            Username = username;
            Password = password;
            Email = email;
            Role = role;
            this.loginDate = loginDate;
        }
    }

}
