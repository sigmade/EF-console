using Microsoft.EntityFrameworkCore;
using System;

namespace EF_console
{
    class AppContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database=EFconsole; Trusted_Connection=True;");
        }
    }
}
