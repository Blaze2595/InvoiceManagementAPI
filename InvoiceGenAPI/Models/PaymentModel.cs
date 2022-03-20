using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceGenAPI.Models
{
    public class PaymentModel
    {
        public int Payment_id { get; set; }
        public PaymentGatewayModel Payment_gateways { get; set; }

    }
}