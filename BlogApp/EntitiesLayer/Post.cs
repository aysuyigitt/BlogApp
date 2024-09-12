using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;
using System.Xml.Linq;

namespace EntitiesLayer
{
    public class Post
    {
        public int PostId { get; set; }

        public string? Title {  get; set; } 

        public string? Description {  get; set; }    

        public string? Content { get; set; }

        public string? Url {  get; set; }   

        public string? Image { get; set; }

        public DateTime PublishedOn { get; set; }

        public bool IsActive { get; set; }

        public int UserId {  get; set; }

        public User User { get; set; } = null!;


        //public ICollection<Tag> Tags { get; set; }


        public ICollection<Comment> Comments { get; set; }
        
    }
}
