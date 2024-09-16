using MediatR;
using Microsoft.AspNetCore.Mvc;
using OneMusic.Application.Mediator.Commands;

namespace OneMusic.WebApi.Controllers
{
        [Route("api/[controller]")]
        [ApiController]
        public class RegisterController : ControllerBase
        {
            private readonly IMediator _mediator;

            public RegisterController(IMediator mediator)
            {
                _mediator = mediator;
            }

            [HttpPost]
            public async Task<IActionResult> CreateUser(CreateAppUserCommand command)
            {
                await _mediator.Send(command);
                return Ok("Kullanıcı başarıyla oluşturuldu");

            }
        }
    
}
