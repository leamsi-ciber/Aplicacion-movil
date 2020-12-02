using System;

namespace SocialMedia.core.Entities
{
    public class Posts
    {
        public int PostId { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
     

    }
}
