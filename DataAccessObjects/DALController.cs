using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccessObjects.EFRepositories;
using DataAccessObjects.Models;
namespace DataAccessObjects
{
    internal class DALController:IDALController
    {
        DataAppContext dbContext = null;
        IRepositoryFactory repoFactory = null;

        public IRepository<Product> ProductRepo { get { return this.repoFactory.CreateRepo<Product>(); } }

        public IRepository<Category> CategoryRepo { get { return this.repoFactory.CreateRepo<Category>(); } }

        public DALController()
        {
            this.dbContext = new DataAppContext();
            this.repoFactory = new RepositoryFactory(this.dbContext);

            //REMOVE ON DEPLOYMENT, THIS IS FOR SEEDING TEST DATA
            //SEED Category
            if(!(this.dbContext.Categories.Count() > 0))
            {
                this.dbContext.Categories.Add(new Category() { ID=1, Name = "Foods"});
                this.dbContext.Categories.Add(new Category() { ID=2, Name = "Condoms" });
                this.dbContext.SaveChanges();
            }

            //SEED Product
            if (!(this.dbContext.Products.Count() > 0))
            {
                this.dbContext.Products.Add(new Product() { Name = "XXX",Description = "XXX" ,CategoryID = 1});
                this.dbContext.Products.Add(new Product() { Name = "PUKA PORN", Description = "PUKA PORN", CategoryID = 1 });
                this.dbContext.SaveChanges();
            }
        }


        #region IDisposable Members

        public void Dispose()
        {
            this.dbContext.Dispose();
        }

        #endregion
    }
}
