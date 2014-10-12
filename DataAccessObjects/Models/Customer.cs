namespace DataAccessObjects.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        public Customer()
        {
            this.Invoices = new HashSet<Invoice>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    
        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
