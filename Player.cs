using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign3_rad
{
    public class Player
    {
        public string Name { get; set; }
        public string Team { get; set; }
        public string PhotoPath { get; set; }
        public int Goals { get; set; }
        public int Assists { get; set; }
        public int MatchesPlayed { get; set; }
        public double AverageRating { get; set; }
    }

}
