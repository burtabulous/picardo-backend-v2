using Microsoft.EntityFrameworkCore;
using backend.Models;

namespace backend
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public DbSet<User> Users { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //    // => options.UseSqlite("Data Source=sqlitedemo.db");
        //    => options.UseSqlite("Data Source=picardov2.db");
    }
}