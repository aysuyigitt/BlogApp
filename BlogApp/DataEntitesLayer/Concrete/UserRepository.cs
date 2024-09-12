using DataEntitesLayer.Abstract;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataEntitesLayer.Concrete
{
    public class UserRepository : IUserRepository
    {
        private readonly BlogContext _context;

        public UserRepository(BlogContext context)
        {
            _context = context;
        }
        public IQueryable<User> Users => _context.Users;

        public void CreateUser(User user)
        {
           _context.Users.Add(user);    
            _context.SaveChanges(); 
        }
    }
}
