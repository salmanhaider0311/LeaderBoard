using App.LeaderBoard.Core.Entities;
using App.LeaderBoard.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.LeaderBoard.Infrastructure.Data.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        public Task AddAsync(Player player)
        {
            throw new NotImplementedException();
        }

        public Task<Player?> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
