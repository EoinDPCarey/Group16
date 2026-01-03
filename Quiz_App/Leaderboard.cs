using Quiz_App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_App
{
    public class Leaderboard
    {
        private User[] leaderBoard;
        public Leaderboard(User[] leaderBoard)
        {
            this.leaderBoard = leaderBoard;
        }
        public void DisplayLeaderboard()
        {
            Console.WriteLine("=== LEADERBOARD ===");

            foreach (var user in leaderBoard.OrderByDescending(u => u.Points))
            {
                Console.WriteLine($"{user.Username} - {user.Points} points");
            }
        }
    }
}
