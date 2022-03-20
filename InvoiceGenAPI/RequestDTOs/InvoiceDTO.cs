using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using InvoiceGenAPI.Entities;

namespace InvoiceGenAPI.RequestDTOs
{
    public class InvoiceDTO
    {
        [MaxLength(100)]
        public string Invoice_number { get; set; }
        public List<string> Contact_persons { get; set; }

        [Required]
        public int Customer_id { get; set; }
        public string Place_of_supply { get; set; }
        public string Gst_treatment { get; set; }
        public string Gst_no { get; set; }
        public DateTime Date { get; set; }
        public int Payment_terms { get; set; }
        public DateTime Due_date { get; set; }
        public string discount { get; set; }
        public bool is_discount_before_tax { get; set; }
        public string Salesperson_name { get; set; }
        public List<CustomFieldDTO> Custom_fields { get; set; }
        public List<LineItemDTO> Line_items { get; set; }
        public List<PaymentGatewayDTO> Payment_options { get; set; }
        public bool Allow_partial_payments { get; set; }
        public string Notes { get; set; }
        public string Terms { get; set; }
        public float Shipping_charge { get; set; }
    }
}