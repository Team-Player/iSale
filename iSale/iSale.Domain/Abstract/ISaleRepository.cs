using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iSale.Domain.Entities;

namespace iSale.Domain.Abstract
{
    public interface ISaleRepository
    {
        // public DbSet<User> Users { get; set; }
        IEnumerable<User> Users { get; }
        int SaveUser(User user);
        User DeleteUser(long userID);

        // public DbSet<UserLogin> UserLogins { get; set; }
        IEnumerable<UserLogin> UserLogins { get; }
        int AddUserLogin(UserLogin userLogin);
        // long ChangeUserLogin(string loginProvider, long userLoginID); - не актуален, изменение через удаление и создание
        UserLogin DeleteUserLogin(string loginProvider, long userLoginID);

        // public DbSet<UserPhoto> UserPhotos { get; set; }
        IEnumerable<UserPhoto> UserPhotos { get; }
        // long SaveUserPhoto(UserPhoto userPhoto);
        // User DeleteUserPhoto(long userID);

        // public DbSet<UserWallpaper> UserWallpapers { get; set; }
        IEnumerable<UserWallpaper> UserWallpapers { get; }
        // long SaveUserWallpaper(UserWallpaper userWallpaper);
        // User DeleteUserWallpaper(long userID);

        // public DbSet<UserEvent> UserEvents { get; set; }
        // IEnumerable<UserEvent> UserEvents { get; }
        // long AddUserEvent(UserEvent userEvent);
        // long ChangeUserLogin(UserEvent userEvent);
        // User DeleteUserLogin(long userLoginID);

        // public DbSet<UserFriend> UserFriends { get; set; }


        // public DbSet<Event> Events { get; set; }
        IEnumerable<Event> Events { get; }
        // long SaveEvent(Event evnt);
        // Event DeleteEvent(long eventID);

        // public DbSet<EventMessage> EventMessages { get; set; }


        // public DbSet<Interest> Interests { get; set; }

        // public DbSet<Location> Locations { get; set; }

        // public DbSet<Photo> Photos { get; set; }

    }
}
