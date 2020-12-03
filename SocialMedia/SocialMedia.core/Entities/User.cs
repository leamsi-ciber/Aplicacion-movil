using System;
using System.Collections.Generic;

namespace SocialMedia.core.Entities
{
    public partial class User
    {
        public User()
        {
            Likes = new HashSet<Like>();
            Posts = new HashSet<Post>();
        }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateBirth { get; set; }
        public string Telephone { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Like> Likes { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}
