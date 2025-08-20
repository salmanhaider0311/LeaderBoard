using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.LeaderBoard.Core.Interfaces
{
    public interface IUnitOfWork
    {
        IPlayerRepository PlayerRepository { get; }
        IScoreRepository ScoreRepository { get; }
    }
}
