using MediatR;
using OneMusic.Application.Interfaces;
using OneMusic.Application.Mediator.Queries;
using OneMusic.Application.Mediator.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneMusic.Application.Mediator.Handlers
{
    
    public class GetMusicByRoleIdQueryHandler : IRequestHandler<GetMusicByRoleIdQuery, List<GetMusicByRoleIdQueryResult>>
    {
        private readonly IMusicRepository _musicRepository;

        public GetMusicByRoleIdQueryHandler(IMusicRepository musicRepository)
        {
            _musicRepository = musicRepository;
        }

        public async Task<List<GetMusicByRoleIdQueryResult>> Handle(GetMusicByRoleIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _musicRepository.GetMusicByRoleId();
            return values.Select(x => new GetMusicByRoleIdQueryResult
            {
                AppRoleId = x.AppRoleId,
                AudioUrl = x.AudioUrl,
                ImageUrl = x.ImageUrl,
                MusicId = x.MusicId,
                MusicName = x.MusicName
            }).ToList();
        }
    }
}
