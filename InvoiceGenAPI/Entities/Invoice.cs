using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceGenAPI.Entities
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public string InvoiceNumber { get; set; }
        public int CustomerId { get; set; }
        public string PlaceOfSupply { get; set; }
        public string GstTreatment { get; set; }
        public DateTime Date { get; set; }
        public int PaymentTerms { get; set; }
        public string Discount { get; set; }
        public bool DiscountBeforeTax { get; set; }
        public string Salesman { get; set; }
        public float ShippingCharge { get; set; }
        public string Notes { get; set; }
        public string Terms { get; set; }
    }
}