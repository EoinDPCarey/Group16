using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_App
{
    internal class Student
    {
        private string status;

        public string Username { get; private set; }
        public string Password { get; private set; }
        public string Email { get; private set; }
        public string Role { get; private set; }

        public Student(string username, string password, string email, string role, string status)
        {
            Username = username;
            Password = password;
            Email = email;
            Role = role;
            this.status = status;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("=== Student ===");
            Console.WriteLine($"Username: {Username}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Role: {Role}");
            Console.WriteLine($"Status: {status}");
        }

        public void UpdateUser(string username, string password, string email, string role, string status)
        {
            Username = username;
            Password = password;
            Email = email;
            Role = role;
            this.status = status;
        }
    }

}
