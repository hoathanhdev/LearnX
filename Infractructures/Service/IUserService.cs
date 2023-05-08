using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infractructures.Entities;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace Infractructures.Service
{
    public interface IUserService
    {
        IQueryable<User> GetUsers(int id);
        User GetUser(int id);
        void UpdateUser(User user);
        void DeleteUser(User user);
        void InsertUser(User user);
    }
}
