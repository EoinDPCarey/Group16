using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_App
{
    public class User
    {
        public int UserID { get; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public int Points { get; set; }

        private static int idCount = 1;


        public User(string username, string password, string email, string role)
        {
            UserID = idCount++;
            Username = username;
            Password = password;
            Email = email;
            Role = role;
            Points = 0;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {UserID}, Username: {Username}, Role:{Role}, Points: {Points}");
        }
        public bool IsLoggedIn { get; private set; }

        public void Login()
        {
            IsLoggedIn = true;
            Console.WriteLine($"{Username} Logged In.");
        }

        public void Logout()
        {
            IsLoggedIn = false;
            Console.WriteLine($"{Username} Logged Out.");
        }
        public bool IsAdmin()
        {
            return Role.ToLower() == "admin";
        }
        public void UpdateUser(string username, string password, string email, string role)
        {
            Username = username;
            Password = password;
            Email = email;
            Role = role;
        }
    }
}
