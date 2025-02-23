﻿using Anotai.Data.Extensions;
using Anotai.Data.Mappings;
using Anotai.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Anotai.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) 
        {

        }

        public DbSet<Gender> Genders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Note> Notes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new GenderMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new BookMap());
            modelBuilder.ApplyConfiguration(new NoteMap());

            modelBuilder.ApplyGlobalConfiguration();
            modelBuilder.SeedData();

            base.OnModelCreating(modelBuilder);
        }
    }
}
