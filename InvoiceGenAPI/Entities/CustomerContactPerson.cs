using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceGenAPI.Entities
{
    public class CustomerContactPerson
    {
        public int CustomerContactPersonId { get; set; }
        public int CustomerId { get; set; }
        public int ContactCustomerId { get; set; }
    }
}