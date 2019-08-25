using System;
using System.Collections.Generic;
using System.Text;
using BookShelf.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookShelf.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {
        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Create a new user for Identity Framework
            ApplicationUser user1 = new ApplicationUser
            {
                FirstName = "admin",
                LastName = "admin",
                UserName = "admin@admin.com",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                Id = "00000000-ffff-ffff-ffff-ffffffffffff"
            };
            var passwordHash = new PasswordHasher<ApplicationUser>();
            user1.PasswordHash = passwordHash.HashPassword(user1, "Admin8*");
            modelBuilder.Entity<ApplicationUser>().HasData(user1);

            ApplicationUser user2 = new ApplicationUser
            {
                FirstName = "shelley",
                LastName = "arnold",
                UserName = "shelley@me.com",
                NormalizedUserName = "SHELLEY@ME.COM",
                Email = "shelley@me.com",
                NormalizedEmail = "SHELLEY@ME.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                Id = "00000000-tttt-ffff-ffff-ffffffffffff"
            };
            var passwordHash2 = new PasswordHasher<ApplicationUser>();
            user2.PasswordHash = passwordHash.HashPassword(user2, "Admin8*");
            modelBuilder.Entity<ApplicationUser>().HasData(user2);

            modelBuilder.Entity<Author>().HasData(
                new Author()
                {
                    Id = 1,
                    FirstName = "Cavy",
                    LastName = "Arnold",
                    Penname = "Woofie",
                    PreferredGenre = "Food",
                    ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff" 
                },
                new Author()
                {
                    Id = 2,
                    FirstName = "Cerin",
                    LastName = "Dog",
                    Penname = "Dark",
                    PreferredGenre = "Balls",
                    ApplicationUserId = "00000000-tttt-ffff-ffff-ffffffffffff"
                },
                new Author()
                {
                    Id = 3,
                    FirstName = "Scout",
                    LastName = "Arant",
                    Penname = null,
                    PreferredGenre = "Family",
                    ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                }
            );

            modelBuilder.Entity<Book>().HasData(
                new Book()
                {
                    Id = 1,
                    ISBN = 2375290724,
                    Title = "Getting More Treats",
                    Genre = "Food",
                    PublishDate = new DateTime(10/25/1984),
                    AuthorId = 1,
                    OwnerId = "00000000-tttt-ffff-ffff-ffffffffffff"
                },
                new Book()
                {
                    Id = 2,
                    ISBN = 7654329876,
                    Title = "Cathing the Ball",
                    Genre = "Games",
                    PublishDate = new DateTime(6 / 13 / 1986),
                    AuthorId = 2,
                    OwnerId = "00000000-tttt-ffff-ffff-ffffffffffff"
                }
            );
        }
    }
}
