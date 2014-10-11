using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects.Models
{
    public class Product:BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
