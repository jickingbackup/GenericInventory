using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual List<Product> Products { get; set; }

        public Category()
        {
            this.Products = new List<Product>();
        }
    }
}
