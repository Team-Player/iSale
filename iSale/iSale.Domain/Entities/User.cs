using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSale.Domain.Entities
{
    public class User
    {
        public long Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime RegistrationDate { get; set; }

        public int Rating { get; set; }

        public virtual ICollection<UserEvent> UserEvents { get; set; }

        public virtual ICollection<Interest> Interests { get; set; }

        public virtual ICollection<UserLogin> UserLogins { get; set; }

        public virtual ICollection<UserPhoto> Photos { get; set; }

        public virtual ICollection<EventMessage> EventMessages { get; set; }

        public virtual ICollection<UserFriend> Friends { get; set; }

        public virtual ICollection<UserFriend> RequestingFriends { get; set; }

    }


}
