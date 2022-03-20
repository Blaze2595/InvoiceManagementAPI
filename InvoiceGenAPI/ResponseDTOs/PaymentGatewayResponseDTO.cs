using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceGenAPI.ResponseDTOs
{
    public class PaymentGatewayResponseDTO
    {
        public bool Configured { get; set; }
        public string Additional_field1 { get; set; }
        public string Gateway_name { get; set; }
    }
}