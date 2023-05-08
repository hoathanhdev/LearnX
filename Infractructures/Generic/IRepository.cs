using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infractructures.Generic
{
    public interface IRepository<T> where T : class
    {
        T GetById(object id);
        void Insert(T Entity);
        void Update(T Entity);
        void Delete(T Entity);
        IQueryable<T> GetAll();

    }
}
