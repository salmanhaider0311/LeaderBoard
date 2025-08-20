using App.LeaderBoard.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace App.LeaderBoard.Core
{
    public class UnitOfWork : IUnitOfWork
    {
        private IServiceProvider _serviceProvider;
        public UnitOfWork(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IPlayerRepository PlayerRepository => _serviceProvider.GetService<IPlayerRepository>();

        public IScoreRepository ScoreRepository => _serviceProvider.GetService<IScoreRepository>();
    }
}
