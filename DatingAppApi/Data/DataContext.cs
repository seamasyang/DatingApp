using Microsoft.EntityFrameworkCore;
using DatingAppApi.Models;

namespace DatingAppApi.Data
{

    public class DatingContext : DbContext
    {
        public DatingContext(DbContextOptions<DatingContext> options) :
            base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<User>();
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Blog> Blogs { get; set; }
    }

}