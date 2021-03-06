﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iSale.Domain.Abstract;
using iSale.Domain.Entities;


namespace iSale.Domain.Concrete
{
    public class EFSaleRepository : ISaleRepository
    {
        private EFDbContext context = new EFDbContext();

        // **************************************************** User
        public IEnumerable<User> Users
        {
            get { return context.Users; }
        }

        public int SaveUser(User user)
        {
            if (user.Id == 0)
            {
                // Register new user - Add date of registration
                user.RegistrationDate = DateTime.UtcNow;
                context.Users.Add(user);
            }
            else
            {
                User dbEntry = context.Users.Find(user.Id);
                if (dbEntry != null)
                {
                    // Update user without changing date
                    dbEntry.Email = user.Email;
                    dbEntry.FirstName = user.FirstName;
                    dbEntry.LastName = user.LastName;
                    dbEntry.NickName = user.NickName;
                    dbEntry.PhoneNumber = user.PhoneNumber;
                    dbEntry.Rating = user.Rating;
                    dbEntry.Interests = user.Interests;
                }
            }
            return context.SaveChanges();
        }

        public User DeleteUser(long userID)
        {
            User dbEntry = context.Users.Find(userID);
            if (dbEntry != null)
            {
                context.Users.Remove(dbEntry);
            }
            context.SaveChanges();
            return dbEntry;
        }

        // **************************************************** UserLogin
        public IEnumerable<UserLogin> UserLogins
        {
            get { return context.UserLogins; }
        }

        public int AddUserLogin(UserLogin userLogin)
        {
            // В данной таблице должен использоваться составной ключ: UserId и ProviderKey
            if (userLogin.ProviderKey != "")
            {
                context.UserLogins.Add(userLogin);
            }
            return context.SaveChanges();
        }

        public void UpdateUserLogin(string accessToken, UserLogin userLogin, string avatar)
        {
            var dbEntry = context.UserLogins.Find(userLogin.Id);
            if (dbEntry != null)
            {
                dbEntry.AccessToken = accessToken;
                dbEntry.Avatar = avatar;
                context.SaveChanges();
            }
        }

        public UserLogin DeleteUserLogin(string loginProvider, long userID)
        {
            UserLogin dbEntry = context.UserLogins.Where(u => u.Id == userID && u.LoginProvider == loginProvider).FirstOrDefault();
            if (dbEntry != null)
            {
                context.UserLogins.Remove(dbEntry);
            }
            context.SaveChanges();
            return dbEntry;
        }

        //*****************************************************

        public AccessToken CreateAccessToken(AccessToken accessToken, User user)
        {
            if (accessToken != null)
            {
                context.AccessTokens.Add(accessToken);
                
                context.SaveChanges();
            }
            return accessToken;
        }

        public void DeleteAccessToken(AccessToken accessToken)
        {
            AccessToken dbEntry = context.AccessTokens.Find(accessToken.Id);
            if (dbEntry != null)
            {
                context.AccessTokens.Remove(dbEntry);
                context.SaveChanges();
            }
        }

        // ****************************************************
        public IEnumerable<UserPhoto> UserPhotos
        {
            get { return context.UserPhotos; }
        }

        // ****************************************************
        public IEnumerable<UserWallpaper> UserWallpapers
        {
            get { return context.UserWallpapers; }
        }

        // ****************************************************
        public IEnumerable<UserFriend> UserFriends
        {
            get { return context.UserFriends; }
        }

        // ****************************************************
        public IEnumerable<UserEvent> UserEvents
        {
            get { return context.UserEvents; }
        }

        // ****************************************************
        public IEnumerable<Event> Events
        {
            get { return context.Events; }
        }

        // ****************************************************
        public IEnumerable<EventMessage> EventMessages
        {
            get { return context.EventMessages; }
        }

        // ****************************************************
        public IEnumerable<Interest> Interests
        {
            get { return context.Interests; }
        }

        // ****************************************************
        public IEnumerable<Location> Locations
        {
            get { return context.Locations; }
        }

        // ****************************************************
        public IEnumerable<Photo> Photos
        {
            get { return context.Photos; }
        }

        public IEnumerable<AccessToken> AccessTokens
        {
            get { return context.AccessTokens; }
        }
    }
}
