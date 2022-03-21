using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace InvoiceGenAPI.ResponseDTOs
{
    public class InvoiceResponseDTO
    {
        public int Invoice_Id { get; set; }
        public string Invoice_number { get; set; }
        public int Customer_id { get; set; }
        public List<int> Contact_persons { get; set; }
        public string Salesperson_name { get; set; }
        public List<CustomFiledResponseDTO> Custom_fields { get; set; }
        public List<LineItemResponseDTO> Line_items { get; set; }
        public DateTime date { get; set; }
        public int Payment_terms { get; set; }
        public DateTime Due_date { get; set; }
        public string Place_of_supply { get; set; }
        public string Gst_treatment { get; set; }
        public string Gst_no { get; set; }
        public string Discount { get; set; }
        public bool Is_discount_before_tax { get; set; }
        public string Shipping_charges { get; set; }
        public bool Allow_partial_payments { get; set; }
        public List<PaymentGatewayResponseDTO> Payment_options { get; set; }
        public string Notes { get; set; }
        public string Terms { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public string Message { get; set; }
    }
}