using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceGenAPI.BusinessLayer.Interface
{
    public interface InvoiceBALInterface
    {
        public bool DeleteInvoice(int invoice_id);
    }
}