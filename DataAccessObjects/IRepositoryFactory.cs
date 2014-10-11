using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccessObjects.Models;
using DataAccessObjects.EFRepositories;
namespace DataAccessObjects
{
    public interface IRepositoryFactory
    {
        IRepository<T> CreateRepo<T>() where T : class;


    }
}
