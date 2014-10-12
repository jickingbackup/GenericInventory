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

        public IRepository<Account> AccountRepo { get { return this.repoFactory.CreateRepo<Account>(); } }

        public IRepository<Category> CategoryRepo { get { return this.repoFactory.CreateRepo<Category>(); } }

        public IRepository<Customer> CustomerRepo { get { return this.repoFactory.CreateRepo<Customer>(); } }

        public IRepository<Employee> EmployeeRepo { get { return this.repoFactory.CreateRepo<Employee>(); } }

        public IRepository<Invoice> InvoiceRepo { get { return this.repoFactory.CreateRepo<Invoice>(); } }

        public IRepository<InvoiceItem> InvoiceItemRepo { get { return this.repoFactory.CreateRepo<InvoiceItem>(); } }

        public IRepository<Product> ProductRepo { get { return this.repoFactory.CreateRepo<Product>(); } }

        public IRepository<Stock> StockRepo { get { return this.repoFactory.CreateRepo<Stock>(); } }

        public IRepository<StocksRequest> StockRequestRepo { get { return this.repoFactory.CreateRepo<StocksRequest>(); } }

        public IRepository<Supplier> SupplierRepo { get { return this.repoFactory.CreateRepo<Supplier>(); } }

        public DALController()
        {
            this.dbContext = new DataAppContext();
            this.repoFactory = new RepositoryFactory(this.dbContext);

            //REMOVE ON DEPLOYMENT, THIS IS FOR SEEDING TEST DATA
            //SEED Category
            if (!(this.dbContext.Categories.Count() > 0))
            {
                this.dbContext.Categories.Add(new Category() { Name = "Foods" });
                this.dbContext.Categories.Add(new Category() { Name = "Condoms" });
                this.dbContext.SaveChanges();
            }

            //SEED Product
            if (!(this.dbContext.Products.Count() > 0))
            {
                this.dbContext.Products.Add(new Product() { Name = "Canton Chili", Description = "Chili Falvor", CategoryID = 1 });
                this.dbContext.Products.Add(new Product() { Name = "Canton Calamansi", Description = "Calamansi Falvor", CategoryID = 1 });
                this.dbContext.Products.Add(new Product() { Name = "PUKA PORN Condom", Description = "Make PUKA PORN!", CategoryID = 1 });
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
