namespace DataAccessObjects.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class InvoiceItem
    {
        public int ID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int InvoiceID { get; set; }
        public int ProductID { get; set; }
    
        public virtual Invoice Invoice { get; set; }
        public virtual Product Product { get; set; }
    }
}
