using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceGenAPI.Entities
{
    public class Item
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string ProductType { get; set; }
        public float Rate { get; set; }
        public string TaxType { get; set; }
        public float TaxPercent { get; set; }
    }
}