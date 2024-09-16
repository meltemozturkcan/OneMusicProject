using Microsoft.EntityFrameworkCore;
using OneMusic.Application.Interfaces;
using OneMusic.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OneMusic.Persistence.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly OneMusicContext _context;

        public Repository(OneMusicContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(T entity)
        {
            _context.Set<T>().Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByFilterAsync(Expression<Func<T, bool>> filter)
        {
            return await _context.Set<T>().SingleOrDefaultAsync(filter);
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }
    }
}
