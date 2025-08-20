using App.LeaderBoard.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.LeaderBoard.Core.Interfaces
{
    public interface IScoreRepository
    {
        Task AddAsync(Score entry);
        Task<List<Score>> GetTopScoresAsync(int score);
    }
}
