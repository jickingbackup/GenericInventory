using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public static class DALFactory
    {
        public static IDALController CreateDALController()
        {
            return new DALController();
        }
    }
}
