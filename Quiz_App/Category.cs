using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_App
{
    public class Category
    {
        // Fields / Properties
        public int CategoryID { get; }          // read-only
        public string Name { get; private set; }
        public string Description { get; private set; }

        // Static counter to auto-generate IDs
        private static int _idCounter = 1;

        // Constructor
        public Category(string name, string description)
        {
            CategoryID = _idCounter++;
            Name = name;
            Description = description;
        }

        // DisplayCategory()
        public void DisplayCategory()
        {
            Console.WriteLine("=== Category Information ===");
            Console.WriteLine($"ID: {CategoryID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Description: {Description}");
        }

        // UpdateCategory(name: string, description: string)
        public void UpdateCategory(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
