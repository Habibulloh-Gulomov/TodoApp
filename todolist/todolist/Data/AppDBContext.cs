using Microsoft.EntityFrameworkCore;
using System;

namespace todolist.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }
        public DbSet<todoTask> Todos { get; set; }
    }
}
