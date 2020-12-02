using SocialMedia.core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.core.Interfaces
{
   public interface IPostRepository
    {
         Task<IEnumerable<Publicacion>> GetPosts();

    }
}
