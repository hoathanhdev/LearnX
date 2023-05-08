using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Infractructures.Generic
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _dbContext;
        private DbSet<T> _entities;

        public Repository(DbContext dbcontext)
        {
            this._dbContext = dbcontext;
        }

        public DbSet<T> Entities
        {
            get
            {
                if(_entities == null)
                {
                    _entities = _dbContext.Set<T>();
                }
                return _entities;
            }
        }

        public void Delete(T Entity)
        {
            try
            {
                if(Entity == null)
                {
                    throw new ArgumentNullException("Entity");
                }
                this.Entities.Remove(Entity);
                this._dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IQueryable<T> GetAll()
        {
            return this.Entities;
        }

        public T GetById(object id)
        {
            return this.Entities.Find(id);
        }

        public void Insert(T Entity)
        {
            try
            {
                if (Entity == null)
                {
                    throw new ArgumentNullException("Entity");
                }
                this.Entities.Add(Entity);
                this._dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(T Entity)
        {
            try
            {
                if (Entity == null)
                {
                    throw new ArgumentNullException("Entity");
                }
                this.Entities.Update(Entity);
                this._dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
