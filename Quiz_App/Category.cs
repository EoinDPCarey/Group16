using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_App
{
    public class Category
    {
        
        public int CategoryID { get; }          
        public string Name { get; private set; }
        public string Description { get; private set; }

        
        private static int _idCounter = 1;

       
        public Category(string name, string description)
        {
            CategoryID = _idCounter++;
            Name = name;
            Description = description;
        }

        public void DisplayCategory()
        {
            Console.WriteLine("=== Category Information ===");
            Console.WriteLine($"ID: {CategoryID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Description: {Description}");
        }

        public void UpdateCategory(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
