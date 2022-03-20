using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceGenAPI.Models
{
    public class PaymentGatewayModel
    {
        public int Payment_gateway_id { get; set; }
        public bool Configured { get; set; }
        public string Additional_field { get; set; }
        public string Gateway_name { get; set; }
    }
}