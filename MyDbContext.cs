using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkSample1
{
    public class MyDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public MyDbContext()
        {
            Users = this.Set<User>();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=UsersDb;Trusted_Connection=True;");
        }

    }
}
