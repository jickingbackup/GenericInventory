using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessObjects;
namespace DataAccessObjects.EFRepositories
{
    internal class RepositoryFactory : IRepositoryFactory
    {
        DataAppContext dbContext = null;

        public RepositoryFactory( DataAppContext dbContext)
        {
            this.dbContext = dbContext;
        }
        
        #region IRepositoryFactory Members

        public IRepository<T> CreateRepo<T>() where T:class
        {
            return new GenericRepo<T>(this.dbContext);
        }

        #endregion
    }
}
