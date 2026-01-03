using System;
using System.Collections.Generic;
using System.Linq;

namespace QuizApplication
{
    public class QuizSystem
    {
        // Fields
        private List<Quiz> quizzes;
        private List<Admin> admins;
        private List<Student> students;
        private List<Category> categories;

        // Constructor
        public QuizSystem()
        {
            quizzes = new List<Quiz>();
            admins = new List<Admin>();
            students = new List<Student>();
            categories = new List<Category>();
        }

        // Main entry point for quiz system
        public void StartQuiz()
        {
            MainMenu();
        }

        public void MainMenu()
        {
            Console.WriteLine("=== Quiz System ===");
            Console.WriteLine("1. Admin Login");
            Console.WriteLine("2. Student Login");
            Console.WriteLine("3. Exit");

            Console.Write("Select option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AuthAdmin();
                    break;
                case "2":
                    StudentMenu();
                    break;
                case "3":
                    Quit();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    MainMenu();
                    break;
            }
        }

        private void AuthAdmin()
        {
            Console.Write("Username: ");
            string username = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();

            Admin admin = admins.FirstOrDefault(a =>
                a.Username == username && a.Password == password);

            if (admin != null)
            {
                Console.WriteLine("Admin authenticated.");
                AdminMenu();
            }
            else
            {
                Console.WriteLine("Authentication failed.");
                MainMenu();
            }
        }

        private void AdminMenu()
        {
            Console.WriteLine("\n=== Admin Menu ===");
            Console.WriteLine("1. Create Quiz");
            Console.WriteLine("2. Create Category");
            Console.WriteLine("3. Add User");
            Console.WriteLine("4. Logout");

            Console.Write("Choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateQuiz();
                    break;
                case "2":
                    CreateCategory();
                    break;
                case "3":
                    AddUser();
                    break;
                case "4":
                    MainMenu();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    AdminMenu();
                    break;
            }
        }

        private void StudentMenu()
        {
            Console.WriteLine("\n=== Student Menu ===");
            Console.WriteLine("Available quizzes:");

            foreach (var quiz in quizzes)
            {
                Console.WriteLine($"{quiz.QuizID}: {quiz.Title}");
            }

            Console.Write("Enter Quiz ID to start or 0 to exit: ");
            int quizId = int.Parse(Console.ReadLine());

            if (quizId == 0)
            {
                MainMenu();
                return;
            }

            LoadQuiz(quizId);
        }

        private void CreateQuiz()
        {
            Console.Write("Quiz Title: ");
            string title = Console.ReadLine();

            Console.Write("Description: ");
            string description = Console.ReadLine();

            Quiz quiz = new Quiz(title, description);
            quizzes.Add(quiz);

            Console.WriteLine("Quiz created successfully.");
            AdminMenu();
        }

        private void LoadQuiz(int quizID)
        {
            Quiz quiz = quizzes.FirstOrDefault(q => q.QuizID == quizID);

            if (quiz != null)
            {
                quiz.DisplayQuiz();
            }
            else
            {
                Console.WriteLine("Quiz not found.");
            }

            MainMenu();
        }

        private void CreateCategory()
        {
            Console.Write("Category Name: ");
            string name = Console.ReadLine();

            Console.Write("Description: ");
            string description = Console.ReadLine();

            categories.Add(new Category(name, description));
            Console.WriteLine("Category created.");
            AdminMenu();
        }

        private void UpdateCategory(int categoryID)
        {
            Category category = categories.FirstOrDefault(c => c.CategoryID == categoryID);
            if (category != null)
            {
                Console.Write("New Name: ");
                category.UpdateCategory(Console.ReadLine(), category.Description);
            }
        }

        private void RemoveCategory(int categoryID)
        {
            categories.RemoveAll(c => c.CategoryID == categoryID);
        }

        private void AddUser()
        {
            Console.Write("Username: ");
            string username = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Role (Admin/Student): ");
            string role = Console.ReadLine();

            if (role.ToLower() == "admin")
            {
                admins.Add(new Admin(username, password, email, role, DateTime.Now));
            }
            else
            {
                students.Add(new Student(username, password, email, role, "Active"));
            }

            Console.WriteLine("User added successfully.");
            AdminMenu();
        }

        private void UpdateUser(int userID)
        {
            Console.WriteLine("Update user logic goes here.");
        }

        private void RemoveUser(int userID)
        {
            students.RemoveAll(s => s.UserID == userID);
            admins.RemoveAll(a => a.UserID == userID);
        }

        private void Quit()
        {
            Console.WriteLine("Exiting Quiz System...");
            Environment.Exit(0);
        }
    }
}
