using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceGenAPI.ResponseDTOs
{
    public class LineItemResponseDTO
    {
        public int Line_item_id { get; set; }
        public int item_id { get; set; }
        public int Project_id { get; set; }
        public string Product_type { get; set; }
        public string Name { get; set; }
        public float Rate { get; set; }
        public int Quantity { get; set; }
        public string Discount { get; set; }
        public string Tax_type { get; set; }
        public float Tax_percentage { get; set; }
        public float Item_total { get; set; }
    }
}