using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataEntitesLayer.Abstract
{
    public interface IUserRepository
    {
        IQueryable<User> Users { get; }

        void CreateUser(User user);
        }
    }
