using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessObjects.Models;

namespace DataAccessObjects
{
    public interface IDALController:IDisposable
    {
        IRepository<Account> AccountRepo { get; }
        IRepository<Category> CategoryRepo { get; }
        IRepository<Customer> CustomerRepo { get; }
        IRepository<Employee> EmployeeRepo { get; }
        IRepository<Invoice> InvoiceRepo { get; }
        IRepository<InvoiceItem> InvoiceItemRepo { get; }
        IRepository<Product> ProductRepo { get; }
        IRepository<StocksRequest> StockRequestRepo { get; }
        IRepository<Supplier> SupplierRepo { get; }
    }
}
