using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quiz_App;
using System.Linq;

namespace Quiz_App.Tests
{
    [TestClass]
    public class CategoryTests
    {
        [TestMethod]
        public void TestCategory()
        {
            string name = "name";
            string description = "description";

            Category category = new Category(name, description);

            Assert.AreEqual(name, category.Name);
            Assert.AreEqual(description, category.Description);
            Assert.IsTrue(category.CategoryID > 0);
        }
        [TestMethod]
        public void TestUpdateCategory()
        {
            Category category = new Category("Old1", "Old2");

            category.UpdateCategory("New1", "New2");

            Assert.AreEqual("New Name", category.Name);
            Assert.AreEqual ("description", category.Description);
        }
        [TestMethod]
        public void DisplayCategoryTest()
        {
            Category category = new Category("Test", "TestDescription");
            var output = new StringWriter();
            Console.SetOut(output);

            category.DisplayCategory();

            string consoleOutput = output.ToString();

            Assert.IsTrue(consoleOutput.Contains("=== Category Information ==="));
            Assert.IsTrue(consoleOutput.Contains($"ID: {category.CategoryID}"));
            Assert.IsTrue(consoleOutput.Contains("Name : Test"));
            Assert.IsTrue(consoleOutput.Contains("Description: TestDescription"));



        }
    }
}