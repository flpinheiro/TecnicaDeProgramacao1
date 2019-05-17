using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UnBCineFlix.Models;

namespace UnBCineFlix.DAL 
{
    class UnBCineFlixContext : DbContext
    {
        public DbSet<Address> DbAddress { get; set; }
        public DbSet<Person>  DbPerson { get; set; }
        public DbSet<Movie> Dbmovie { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
