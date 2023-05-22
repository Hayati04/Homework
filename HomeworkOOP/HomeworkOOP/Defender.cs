using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkOOP
{
    public class Defender : FootballPlayer
    {
        public Defender(string name, int age, int number, double height, Team team) : base(name, age, number, height)
        {
            Team = team;
        }
    }
}

