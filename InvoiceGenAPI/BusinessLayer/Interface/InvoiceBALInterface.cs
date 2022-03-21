using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InvoiceGenAPI.RequestDTOs;
using InvoiceGenAPI.ResponseDTOs;

namespace InvoiceGenAPI.BusinessLayer.Interface
{
    public interface InvoiceBALInterface
    {
        public bool DeleteInvoice(int invoice_id);
        public InvoiceResponseDTO CreateInvoice(InvoiceDTO invoice);
        public List<InvoiceResponseDTO> GetInvoice();
        public InvoiceResponseDTO UpdateInvoice(InvoiceDTO invoice);
    }
}