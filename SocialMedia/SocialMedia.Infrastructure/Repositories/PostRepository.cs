using Microsoft.EntityFrameworkCore;
using SocialMedia.Api.Data;
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
        private readonly SocialMediaContext _context;
        public PostRepository(SocialMediaContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Post>> GetPosts()
        {
            var posts = await _context.Post.ToListAsync();
            
            return posts;
        }

        public async Task<Post> GetPost(int id)
        {
            var post = await _context.Post.FirstOrDefaultAsync(x=> x.UserId == id);

            return post;
        }


    }

}
