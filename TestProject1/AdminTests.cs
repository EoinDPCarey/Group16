using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quiz_App;

namespace Quiz_App.Tests
{
    [TestClass]
    public class AdminTests
    {
        [TestMethod]
        public void TestAdminClass()         {

            string username = "test";
            string password = "password";
            string email = "email";
            string role = "user";

            User user = new User(username, password, email, role);

            Assert.AreEqual(username, user.Username);
            Assert.AreEqual(password, user.Password);
            Assert.AreEqual(email, user.Email);
            Assert.AreEqual(role, user.Role);

        }
        [TestMethod]
        public void TestAdminLogOn()
        {
            User user = new User("user1", "pass", "email", "user");

            user.Login();

            Assert.IsTrue(user.IsLoggedIn);

        }
        [TestMethod]
        public void TestAdminLogOut()
        {
            User user = new User("user1", "pass", "email", "user");

            user.Logout();

            Assert.IsFalse(user.IsLoggedIn);
        }
        [TestMethod]
        public void TestAdminLogin()
        {
            User user = new User("user1", "pass", "email", "user");

            user.UpdateUser("newU", "NewP", "NewE", "user");

            Assert.AreEqual("newU", user.Username);
            Assert.AreEqual("newP", user.Password);
            Assert.AreEqual("newE", user.Email);
            Assert.AreEqual("user", user.Role);
        }


    }
}