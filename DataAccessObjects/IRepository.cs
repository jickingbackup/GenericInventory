using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public interface IRepository<TEntity>
    {
        TEntity GetByID(object id);
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);
        bool Add(TEntity entity);
        bool Update(TEntity entity);
        bool Delete(TEntity entity);
    }
}
