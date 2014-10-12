namespace DataAccessObjects.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stock
    {
        public int ID { get; set; }
        public int Quantity { get; set; }
        public Decimal Price { get; set; }
        public int StocksRequestedID { get; set; }
        public int ProductID { get; set; }

        //public virtual StocksRequest StocksRequested { get; set; }
        public virtual Product Product { get; set; }
    }
}
