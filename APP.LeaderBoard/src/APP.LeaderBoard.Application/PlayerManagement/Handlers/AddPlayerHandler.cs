using App.LeaderBoard.Core.Entities;
using App.LeaderBoard.Core.Interfaces;
using APP.LeaderBoard.Application.PlayerManagement.Requests;
using APP.LeaderBoard.Application.PlayerManagement.Responses;
using Ardalis.Result;
using MediatR;

namespace APP.LeaderBoard.Application.PlayerManagement.Handlers
{
    public class AddPlayerHandler : IRequestHandler<AddPlayerRequest, Result<AddPlayerResponse>>
    {
        private readonly IUnitOfWork _uow;
        public AddPlayerHandler(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }
        public Task<Result<AddPlayerResponse>> Handle(AddPlayerRequest request, CancellationToken cancellationToken)
        {
            var player = new Player
            {
                Name = request.Name,
            };
            _uow.PlayerRepository.AddAsync(player);
            throw new NotImplementedException();
        }
    }
}
