using System;
using System.Collections.Generic;

namespace SocialMedia.core.Entities
{
    public partial class Like
    {
      
        public int LikeId { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public bool IsActive { get; set; }
        public virtual Post Post { get; set; }
        public virtual User User { get; set; }
    }
}
