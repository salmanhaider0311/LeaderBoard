using App.LeaderBoard.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.LeaderBoard.Core.Interfaces
{
    public interface IPlayerRepository
    {
        Task<Player?> GetAsync(Guid id);
        Task AddAsync(Player player);
    }
}
