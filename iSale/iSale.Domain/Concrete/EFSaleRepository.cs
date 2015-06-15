using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iSale.Domain.Abstract;
using iSale.Domain.Entities;


namespace iSale.Domain.Concrete
{
    public class EFSaleRepository : IEventRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<User> Users
        {
            get { return context.Users; }
        }

        public IEnumerable<Event> Events
        {
            get { return context.Events; }
        }

        public IEnumerable<EventMessage> EventMessages
        {
            get { return context.EventMessages; }
        }

        public IEnumerable<Interest> Interests
        {
            get { return context.Interests; }
        }

        public IEnumerable<Location> Locations
        {
            get { return context.Locations; }
        }

        public IEnumerable<Photo> Photos
        {
            get { return context.Photos; }
        }

        public IEnumerable<UserEvent> UserEvents
        {
            get { return context.UserEvents; }
        }

        public IEnumerable<UserFriend> UserFriends
        {
            get { return context.UserFriends; }
        }

        public IEnumerable<UserLogin> UserLogins
        {
            get { return context.UserLogins; }
        }

        public IEnumerable<UserPhoto> UserPhotos
        {
            get { return context.UserPhotos; }
        }
    }
}
