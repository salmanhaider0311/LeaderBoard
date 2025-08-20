using App.LeaderBoard.Core;
using App.LeaderBoard.Core.Interfaces;
using App.LeaderBoard.Infrastructure.Data;
using App.LeaderBoard.Infrastructure.Data.Repositories;
using Autofac;
using AutoMapper.Contrib.Autofac.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace App.LeaderBoard.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<LeaderBoardDbContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddScoped<IPlayerRepository, PlayerRepository>();
            services.AddScoped<IScoreRepository, ScoreRepository>();

            return services;
        }
    }
}
