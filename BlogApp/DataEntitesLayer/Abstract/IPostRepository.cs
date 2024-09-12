using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataEntitesLayer.Abstract
{
    public interface IPostRepository
    {
        IQueryable<Post> Posts { get; }

        void CreatePost(Post post);

        void EditPost(Post post);   


    }
}
