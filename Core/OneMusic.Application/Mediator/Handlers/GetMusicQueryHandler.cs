using MediatR;
using OneMusic.Application.Interfaces;
using OneMusic.Application.Mediator.Queries;
using OneMusic.Application.Mediator.Results;
using OneMusic.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneMusic.Application.Mediator.Handlers
{
    public class GetMusicQueryHandler : IRequestHandler<GetMusicQuery, List<GetMusicQueryResult>>
    {
        private readonly IRepository<Music> _repository;

        public GetMusicQueryHandler(IRepository<Music> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetMusicQueryResult>> Handle(GetMusicQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetMusicQueryResult
            {
                AppRoleId = x.AppRoleId,
                MusicId = x.MusicId,
                MusicName = x.MusicName,
                AudioUrl = x.AudioUrl,
                ImageUrl = x.ImageUrl
            }).ToList();
        }
    }
}
