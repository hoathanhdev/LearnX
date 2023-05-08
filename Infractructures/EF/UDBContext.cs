using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infractructures.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infractructures.EF
{
    public class UDBContext : DbContext
    {
        public UDBContext(DbContextOptions<UDBContext> options) : base(options)
        {

        }

        public DbSet<User> users { get; set; }



    }
}
