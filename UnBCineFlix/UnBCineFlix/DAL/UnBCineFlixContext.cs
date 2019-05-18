using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UnBCineFlix.Models;

namespace UnBCineFlix.DAL 
{
    public class UnBCineFlixContext : DbContext
    {
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Artist> Artist { get; set; }
        public virtual DbSet<Chair> Chair { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Employee> Employee {get;set;}
        public virtual DbSet<Movie> Movie {get;set;}
        public virtual DbSet<MovieTheater> MovieTheater {get;set;}
        public virtual DbSet<Person> Person {get;set;}
        public virtual DbSet<Rating> Rating{get;set;}
        public virtual DbSet<Session> Session{get;set;}
        public virtual DbSet<Ticket> Ticket{get;set;}

        public UnBCineFlixContext(DbContextOptions<UnBCineFlixContext> option)
            :base(option)
        {
        }
        //http://www.macoratti.net/17/05/efcore_mysql1.htm

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
