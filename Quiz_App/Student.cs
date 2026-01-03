using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_App
{
    internal class Student : User
    {
        private string status;
        public string Status { get; private set; }

        public Student(string username, string password, string email, string role, string status) :base(username, password, email,role)
        {
            this.status = status;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("=== Student ===");
            base.DisplayInfo();
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
