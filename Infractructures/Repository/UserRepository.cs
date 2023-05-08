using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infractructures.Entities;
using Infractructures.Generic;
using Microsoft.EntityFrameworkCore;

namespace Infractructures.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(DbContext dbcontext) : base(dbcontext)
        {
        }
    }
}
