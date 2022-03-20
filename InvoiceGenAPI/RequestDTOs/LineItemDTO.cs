using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceGenAPI.RequestDTOs
{
    public class LineItemDTO
    {
        public int Item_id { get; set; }
        public int Project_id { get; set; }
        public string Name { get; set; }
        public string Product_type { get; set; }
        public float Rate { get; set; }
        public int Quantity { get; set; }
        public string Discount { get; set; }
        public float Item_total { get; set; }
        public string Tax_type { get; set; }
        public string Tax_percentage { get; set; }
    }
}