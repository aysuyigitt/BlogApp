using EntitiesLayer;
using System.Collections.Generic;

namespace BlogApp.Models
{
    public class PostViewModel
    {
        public List<Post> Posts { get; set; } = new List<Post>();

        public List<Tag> Tags { get; set; } = new List<Tag>();

        public List<Comment> Comments { get; set; } = new List<Comment>(); 

    }
}
