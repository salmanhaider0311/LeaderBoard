using APP.LeaderBoard.Application.PlayerManagement.Requests;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.LeaderBoard.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly IMediator _mediator;
        public PlayerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("player")]
        public async Task<IActionResult> PostScore(AddPlayerRequest request)
        {
            await _mediator.Send(request);
            return Ok();
        }
    }
}
