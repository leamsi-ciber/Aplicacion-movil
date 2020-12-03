using System;
using System.Collections.Generic;

namespace SocialMedia.core.Entities
{
    public partial class Post
    {
        public Post()
        {
            Likes = new HashSet<Like>();
        }
        public int PostId { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Like> Likes { get; }
    }
}
