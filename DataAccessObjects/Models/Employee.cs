namespace DataAccessObjects.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public Employee()
        {
            this.Accounts = new HashSet<Account>();
            this.Invoices = new HashSet<Invoice>();
            this.StocksRequests = new HashSet<StocksRequest>();
        }
    
        public int ID { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
    
        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<StocksRequest> StocksRequests { get; set; }
    }
}
