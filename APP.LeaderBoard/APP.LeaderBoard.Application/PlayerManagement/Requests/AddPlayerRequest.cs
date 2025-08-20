using APP.LeaderBoard.Application.PlayerManagement.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Result;
using MediatR;

namespace APP.LeaderBoard.Application.PlayerManagement.Requests
{
    public class AddPlayerRequest : IRequest<Result<AddPlayerResponse>>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
