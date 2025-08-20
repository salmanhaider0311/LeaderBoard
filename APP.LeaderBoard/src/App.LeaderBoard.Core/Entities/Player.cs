using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.LeaderBoard.Core.Entities
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Score> Scores { get; set; } = new List<Score>();

        public Player()
        {
            Name = string.Empty;
        }
    }
}
