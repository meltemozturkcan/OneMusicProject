using Microsoft.EntityFrameworkCore;
using OneMusic.Application.Interfaces;
using OneMusic.Domain.Entities;
using OneMusic.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneMusic.Persistence.Repositories
{
    public class MusicRepository : IMusicRepository
    {
        private readonly OneMusicContext _context;

        public MusicRepository(OneMusicContext context)
        {
            _context = context;
        }

        public async Task<List<Music>> GetMusicByRoleId()
        {
            var roleId = await _context.AppUsers.Select(x => x.AppRoleId).FirstOrDefaultAsync();
            var values = await _context.Musics.Where(x => x.AppRoleId == roleId).ToListAsync();
            return values;
        }
    }
}
