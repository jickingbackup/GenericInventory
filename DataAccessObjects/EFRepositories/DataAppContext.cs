using System;
using System.Data.Entity;
using System.Linq;
using DataAccessObjects.Models;

namespace DataAccessObjects.EFRepositories
{

    internal class DataAppContext : DbContext
    {
        public virtual DbSet<UserAccount> UserAccounts { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }

        public DataAppContext()
            : base("name=DataAppContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }


    }

}