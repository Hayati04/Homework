using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkOOP
{
    public class Team
    {
        public Coach Coach { get; set; }
        public FootballPlayer[] Players { get; set; }
        public double AverageAge => Math.Round(Players.Average(p => p.Age));

        public Team(Coach coach, FootballPlayer[] players)
        {
            Coach = coach;
            Players = players;
        }
        public double PrintAverageAge()
        {
            int totalAge = 0;
            int playerCount = 0;

            foreach (FootballPlayer player in Players)
            {
                if (player != null)
                {
                    totalAge += player.Age;
                    playerCount++;
                }
            }

            if (playerCount > 0)
            {
                return (double)totalAge / playerCount;
            }
            else
            {
                return 0;
            }
        }
    }
}
