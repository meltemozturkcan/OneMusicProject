using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneMusic.Domain.Entities;

namespace OneMusic.Application.Interfaces
{
    public interface IMusicRepository
    {
        Task<List<Music>> GetMusicByRoleId();
    }
}
