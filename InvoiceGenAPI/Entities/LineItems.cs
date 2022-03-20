using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceGenAPI.Entities
{
    public class LineItems
    {
        public int LineItemsId { get; set; }
        public int InvoiceId { get; set; }
        public int ItemId { get; set; }
        public int ProjectId { get; set; }
        public int Quantity { get; set; }
        public string Discount { get; set; }
        public int Itemtotal { get; set; }
    }
}