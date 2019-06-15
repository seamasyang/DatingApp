using DatingAppApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DatingAppApi.Data
{
    public interface IBlogRepostiory
    {
        Task<IEnumerable<Blog>> List();
    }

    public class BlogRepostiory : IBlogRepostiory
    {
        private readonly DatingContext _context;

        public BlogRepostiory(DatingContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Blog>> List()
        {
            return await _context.Blogs.ToListAsync();
        }
    }
}
