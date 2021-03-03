using System;
using System.Linq;
using System.Reflection;
using Forum.EntityFramework.Configuration;
using Forum.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;

namespace Forum.EntityFramework
{
    public class ForumDbContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Thread> Threads { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Image> Images { get; set; }

        protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder )
        {
            optionsBuilder.UseSqlServer( "Server=(localdb)\\mssqllocaldb;Database=ForumProject;Trusted_Connection=True;" );
        }
    }
}