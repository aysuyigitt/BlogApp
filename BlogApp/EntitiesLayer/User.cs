﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EntitiesLayer
{
    public class User
    {
        public int UserId {  get; set; }    

        public string? UserName {  get; set; }  

        public string? Name {  get; set; }

        public string? Email {  get; set; }   

        public string? Password {  get; set; }  

        public string? Image {  get; set; }

        public ICollection<Post> Posts { get; set; } 

        public ICollection<Comment> Comments { get; set; } 



    }
}
