namespace DataAccessObjects.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public Product()
        {
            this.InvoiceItems = new HashSet<InvoiceItem>();
            this.StocksRequests = new HashSet<StocksRequest>();
            this.Stocks = new HashSet<Stock>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    
        public virtual ICollection<InvoiceItem> InvoiceItems { get; set; }
        public virtual ICollection<StocksRequest> StocksRequests { get; set; }
        public virtual ICollection<Stock> Stocks { get; set; }
    }
}
