using App.LeaderBoard.Core.Entities;
using App.LeaderBoard.Core.Interfaces;
namespace App.LeaderBoard.Infrastructure.Data.Repositories
{
    public class ScoreRepository : IScoreRepository
    {
        public Task AddAsync(Score entry)
        {
            throw new NotImplementedException();
        }

        public Task<List<Score>> GetTopScoresAsync(int score)
        {
            throw new NotImplementedException();
        }
    }
}
