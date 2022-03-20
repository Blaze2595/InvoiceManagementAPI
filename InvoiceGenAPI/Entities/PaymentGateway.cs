using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceGenAPI.Entities
{
    public class PaymentGateway
    {
        public int PaymentGatewayId { get; set; }
        public bool Configured { get; set; }
        public string Additional_field { get; set; }
        public string Gateway_name { get; set; }
    }
}