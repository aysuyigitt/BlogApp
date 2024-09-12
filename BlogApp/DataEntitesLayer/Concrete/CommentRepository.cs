using DataEntitesLayer.Abstract;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataEntitesLayer.Concrete
{
    public class CommentRepository : ICommentRepository
    {
        private readonly BlogContext _context;

        public CommentRepository(BlogContext context)
        {
            _context = context; 
        }
        public IQueryable<Comment> Comments => _context.Comments;

        public void createComment(Comment comment)
        {
           _context.Comments.Add(comment);  
            _context.SaveChanges(); 
        }
    }
}
