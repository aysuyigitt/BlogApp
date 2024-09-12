using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataEntitesLayer.Abstract
{
    public interface ICommentRepository
    {
        IQueryable<Comment> Comments { get; }   

        void createComment(Comment comment);        
    }
}
