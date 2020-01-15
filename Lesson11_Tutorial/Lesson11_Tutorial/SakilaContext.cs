using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Lesson11_Tutorial
{
    class SakilaContext : DbContext
    {
        public DbSet<Actor> Actor { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\sqlexpress;Database=sakila;Trusted_Connection=True;");
        }
    }
}
