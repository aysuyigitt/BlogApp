using System;
using System.Collections.Generic;
using System.Text;

namespace EntitiesLayer
{
   

    public class Tag
    {
       
        public int TagId {  get; set; }    

        public string? Text {  get; set; }  

        public string? Url {  get; set; }

        public ICollection<Post>Posts { get; set; }


    }
}
