using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InvoiceGenAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace InvoiceGenAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<PaymentGateway> Paymentgateway { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerContactPerson> CustomerContact { get; set; }
        public DbSet<CustomField> CustomFields { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<LineItems> lineItems { get; set; }

    }
}