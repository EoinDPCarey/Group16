using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quiz_App;
using System;
using System.IO;

namespace Quiz_App.Tests
{
    [TestClass]
    public class LeaderboardTests
    {
        [TestMethod]
        public void DisplayLeaderboardTest()
        {
          
            User user1 = new User("Alice", "pass", "a@test.com", "user") { Points = 50 };
            User user2 = new User("Bob", "pass", "b@test.com", "user") { Points = 100 };
            User user3 = new User("Charlie", "pass", "c@test.com", "user") { Points = 75 };

            User[] users = { user1, user2, user3 };
            Leaderboard leaderboard = new Leaderboard(users);

            var output = new StringWriter();
            Console.SetOut(output);
   
            leaderboard.DisplayLeaderboard();
    
            string consoleOutput = output.ToString();

           
            Assert.IsTrue(consoleOutput.Contains("=== LEADERBOARD ==="));

            
            int bobIndex = consoleOutput.IndexOf("Bob - 100 points");
            int charlieIndex = consoleOutput.IndexOf("Charlie - 75 points");
            int aliceIndex = consoleOutput.IndexOf("Alice - 50 points");

            Assert.IsTrue(bobIndex < charlieIndex);
            Assert.IsTrue(charlieIndex < aliceIndex);

            
            Console.SetOut(new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true });
        }
    }
}
