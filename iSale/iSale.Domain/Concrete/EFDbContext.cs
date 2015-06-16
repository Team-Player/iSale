using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using iSale.Domain.Entities;

namespace iSale.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<UserLogin> UserLogins { get; set; }

        public DbSet<UserPhoto> UserPhotos { get; set; }

        public DbSet<UserWallpaper> UserWallpapers { get; set; }

        public DbSet<UserFriend> UserFriends { get; set; }

        public DbSet<UserEvent> UserEvents { get; set; }


        public DbSet<Event> Events { get; set; } 

        public DbSet<EventMessage> EventMessages { get; set; }


        public DbSet<Interest> Interests { get; set; }

        public DbSet<Location> Locations { get; set; }

        public DbSet<Photo> Photos { get; set; }

        public DbSet<AccessToken> AccessTokens { get; set; } 

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserFriend>()
                .HasRequired(uf => uf.User)
                .WithMany(u => u.Friends)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserFriend>()
                .HasRequired(uf => uf.Friend)
                .WithMany(u => u.RequestingFriends)
                .WillCascadeOnDelete();
        }
    }
}
