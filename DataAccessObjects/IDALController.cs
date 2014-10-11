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
        IRepository<Product> ProductRepo { get; }
        IRepository<Category> CategoryRepo { get; }
    }
}
