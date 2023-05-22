using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkOOP
{
    public class Striker : FootballPlayer
    {
        public Striker(string name, int age, int number, double height, Team team) : base(name, age, number, height)
        {
            Team = team;
        }
    }
}
