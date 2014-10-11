using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects.Models
{
    public class Category:BaseModel
    {
        public string Name { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
