using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkOOP
{
    public class Goalkeeper : FootballPlayer
    {
        public Goalkeeper(string name, int age, int number, double height, Team team) : base(name, age, number, height)
        {
            Team = team;
        }
    }
}
