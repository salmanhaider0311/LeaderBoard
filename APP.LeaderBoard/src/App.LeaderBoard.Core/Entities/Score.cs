using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.LeaderBoard.Core.Entities
{
    public class Score
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public Player Player { get; set; }
        public int ScoreRecord { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
