using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceGenAPI.RequestDTOs
{
    public class LineItemDTO
    {
        [Required]
        public int Item_id { get; set; }
        public int Project_id { get; set; }
        
        [MaxLength(100)]
        public string Name { get; set; }
        public string Product_type { get; set; }
        
        [Required]
        public float Rate { get; set; }
        
        [Required]
        public int Quantity { get; set; }
        
        [MaxLength(100)]
        public string Discount { get; set; }
        public float Item_total { get; set; }
        public string Tax_type { get; set; }
        public string Tax_percentage { get; set; }
    }
}