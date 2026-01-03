using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_App
{
    internal class Admin : User
    {
        private DateTime loginDate;

        public Admin(string username, string password, string email, string role) : base(username, password, email, role)
        {

        }

        public override void Login()
        {
            base.Login();
            loginDate = DateTime.Now;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("=== Admin ===");
            base.DisplayInfo();
            Console.WriteLine($"Login Date: {loginDate}");
        }

    }

}
