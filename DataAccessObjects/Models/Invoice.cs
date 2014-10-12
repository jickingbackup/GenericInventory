namespace DataAccessObjects.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Invoice
    {
        public Invoice()
        {
            this.InvoiceItems = new HashSet<InvoiceItem>();
        }
    
        public int ID { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Tax { get; set; }
        public decimal Total { get; set; }
        public decimal CashTendered { get; set; }
        public decimal Change { get; set; }
        public System.DateTime Date { get; set; }
        public int CustomerID { get; set; }
        public int EmployeeID { get; set; }
    
        public virtual Customer Customers { get; set; }
        public virtual Employee Employees { get; set; }
        public virtual ICollection<InvoiceItem> InvoiceItems { get; set; }
    }
}
