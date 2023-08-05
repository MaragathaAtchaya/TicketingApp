using Microsoft.EntityFrameworkCore;
using System;
using Ticketing.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ticketing.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) 
        { 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Actor_Movie>().HasKey(x=> new
            {
                x.MovieId,
                x.ActorId    
            });    

            modelBuilder.Entity<Actor_Movie>().HasOne(m=>m.Movie)
                .WithMany(x=>x.Actors_Movies).HasForeignKey(m=>m.MovieId);

            modelBuilder.Entity<Actor_Movie>().HasOne(a => a.Actor)
               .WithMany(x => x.Actors_Movies).HasForeignKey(a => a.ActorId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Actor_Movie> Actors_Movies { get;set; }
    }
}


