namespace DataAccessObjects.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Supplier
    {
        public Supplier()
        {
            this.StocksRequested = new HashSet<StocksRequest>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
    
        public virtual ICollection<StocksRequest> StocksRequested { get; set; }
    }
}
