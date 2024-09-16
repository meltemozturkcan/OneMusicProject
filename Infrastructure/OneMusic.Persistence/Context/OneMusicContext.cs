using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneMusic.Domain.Entities;

namespace OneMusic.Persistence.Context
{
    public class OneMusicContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-IVNGDL6;initial Catalog=OneMusicDb;integrated Security=true;TrustServerCertificate=true;");
        }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<Music> Musics { get; set; }
    }
}
