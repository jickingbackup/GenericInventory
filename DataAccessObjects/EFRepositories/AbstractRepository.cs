using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessObjects;
using DataAccessObjects.Models;
using System.Linq.Expressions;

namespace DataAccessObjects.EFRepositories
{
    internal abstract class AbstractRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        DataAppContext dbContext = null;

        public AbstractRepository(DataAppContext dbContext)
        {
            this.dbContext = dbContext;
        }

        #region IRepository<TEntity> Members

        public virtual TEntity GetByID(object id)
        {
            try
            {
                var entity = this.dbContext.Set<TEntity>().Find();
                return entity;
            }
            catch
            {
                throw;
            }
        }

        public virtual List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            try
            {
                IQueryable<TEntity> entities = this.dbContext.Set<TEntity>();

                if (filter != null)
                {
                    entities = entities.Where(filter);
                }

                return entities.ToList();
            }
            catch
            {
                throw;
            }
        }

        public virtual bool Add(TEntity entity)
        {
            bool isSuccess = false;

            try
            {
                dbContext.Set<TEntity>().Add(entity);
                dbContext.SaveChanges();
                isSuccess = true;
            }
            catch 
            {
                throw;
            }

            return isSuccess;
        }

        public virtual bool Update(TEntity entity)
        {
            bool isSuccess = false;

            try
            {
                this.dbContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                this.dbContext.SaveChanges();
                isSuccess = true;
            }
            catch
            {
                throw;
            }

            return isSuccess;
        }

        public virtual bool Delete(TEntity entity)
        {
            bool isSuccess = false;

            try
            {
                this.dbContext.Set<TEntity>().Remove(entity);
                this.dbContext.SaveChanges();
                isSuccess = true;
            }
            catch
            {
                throw;
            }

            return isSuccess;
        }

        #endregion
    }
}
