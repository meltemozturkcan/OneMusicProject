﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using OneMusic.Application.Mediator.Queries;

namespace OneMusic.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MusicsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]

        public async Task<IActionResult> MusicList()
        {
            var values = await _mediator.Send(new GetMusicQuery());
            return Ok(values);
        }

        [HttpGet("MusicListByRoleId")]
        public async Task<IActionResult> MusicListByRoleId()
        {
            var values = await _mediator.Send(new GetMusicByRoleIdQuery());
            return Ok(values);
        }
    }
}
