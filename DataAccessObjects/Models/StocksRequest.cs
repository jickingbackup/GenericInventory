namespace DataAccessObjects.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class StocksRequest
    {
        public StocksRequest()
        {
            //this.Stocks = new HashSet<Stock>();
        }
    
        public int ID { get; set; }
        public int Quantity { get; set; }
        public decimal Cost { get; set; }
        public decimal TotalCost { get; set; }
        public System.DateTime Date { get; set; }
        public System.DateTime ExpiresOn { get; set; }
        public int ProductID { get; set; }
        public int EmployeeID { get; set; }
        public int SuppliersID { get; set; }
    
        //public virtual ICollection<Stock> Stocks { get; set; }
        public virtual Product Product { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Supplier Suppliers { get; set; }
    }
}
