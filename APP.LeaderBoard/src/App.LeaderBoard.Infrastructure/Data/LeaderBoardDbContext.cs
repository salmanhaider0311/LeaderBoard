using App.LeaderBoard.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.LeaderBoard.Infrastructure.Data
{
    public class LeaderBoardDbContext : DbContext
    {
        public LeaderBoardDbContext(DbContextOptions<LeaderBoardDbContext> options)
            : base(options) { }
        public DbSet<Player> Players => Set<Player>();
        public DbSet<Score> ScoreEntries => Set<Score>();
    }
}
