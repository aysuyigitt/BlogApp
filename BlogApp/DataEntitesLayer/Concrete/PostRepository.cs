using DataEntitesLayer.Abstract;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataEntitesLayer.Concrete
{
    public class PostRepository : IPostRepository
    {
        private readonly BlogContext _context;

        public PostRepository(BlogContext context)
        {
            _context = context;
        }

        
        public IQueryable<Post> Posts => _context.Posts;

        public void CreatePost(Post post)
        {
          
            _context.Posts.Add(post);
            _context.SaveChanges(); 
        }

        public void EditPost(Post post)
        {
            var entity = _context.Posts.FirstOrDefault(i => i.PostId == post.PostId);

            if (entity != null)
            {
                entity.Title = post.Title;  
                entity.Description = post.Description;  
                entity.Content = post.Content;  
                entity.Url = entity.Url;
                entity.IsActive = post.IsActive;

                _context.SaveChanges();
            }
        }
    }
    }