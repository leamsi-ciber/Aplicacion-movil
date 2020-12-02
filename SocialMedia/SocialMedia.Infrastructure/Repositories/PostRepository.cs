using SocialMedia.core.Entities;
using SocialMedia.core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Infrastructure.Repositories
{
    public class PostRepository:IPostRepository
    {
        public async Task<IEnumerable<Posts>> GetPosts()
        {
            var posts = Enumerable.Range(1, 10).Select(x => new Posts
            {
                PostId = x,
                Description = $"Description{x}",
                Date = DateTime.Now,
                Image = $"https://miapis.com{x}",
                UserId = x * 2

            });
            await Task.Delay(10);
            return posts;
        }

    
    }

}
