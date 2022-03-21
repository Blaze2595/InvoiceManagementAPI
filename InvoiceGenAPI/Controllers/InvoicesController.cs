using System.Collections.Generic;
using System.Linq;
using InvoiceGenAPI.RequestDTOs;
using Microsoft.AspNetCore.Mvc;
using InvoiceGenAPI.ResponseDTOs;
using InvoiceGenAPI.Data;
using InvoiceGenAPI.BusinessLayer.Interface;
using System.Net;

namespace InvoiceGenAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InvoicesController : ControllerBase
    {
        private readonly DataContext _dbcontext;
        private readonly InvoiceBALInterface _invoiceBAL;
        public InvoicesController(DataContext dbcontext, InvoiceBALInterface invoiceBAL)
        {
            _invoiceBAL = invoiceBAL;
            _dbcontext = dbcontext;

        }

        [HttpGet]
        //Gets the list of existing invoices
        public List<InvoiceResponseDTO> Get()
        {
            List<InvoiceResponseDTO> response = _invoiceBAL.GetInvoice();
            return response;
        }

        [HttpPost]
        //Create new invoice
        public InvoiceResponseDTO Post(InvoiceDTO invoiceDTO)
        {
            if (!_dbcontext.Invoices.Any(x => x.InvoiceNumber == invoiceDTO.Invoice_number))
            {
                InvoiceResponseDTO response = _invoiceBAL.CreateInvoice(invoiceDTO);
                return response;
            }
            else
            {
                return new InvoiceResponseDTO { StatusCode = HttpStatusCode.Conflict, Message = "Invoice Number Already Exist" };
            }
        }

        [HttpDelete]
        //Delete an existing invoice
        public DeleteInvoiceResponseDTO Delete(int invoice_id)
        {
            if (_dbcontext.Invoices.Any(x => x.InvoiceId == invoice_id))
            {
                if (_invoiceBAL.DeleteInvoice(invoice_id))
                {
                    return new DeleteInvoiceResponseDTO
                    {
                        Code = true,
                        Message = "Invoice #" + invoice_id + " is deleted successfully"
                    };
                }
                else
                {
                    return new DeleteInvoiceResponseDTO
                    {
                        Code = false,
                        Message = "Error deleting invoice #" + invoice_id
                    };
                }
            }
            else
            {
                return new DeleteInvoiceResponseDTO
                {
                    Code = false,
                    Message = "Invalid Invoice Id"
                };
            }
        }

        [HttpPut]
        //Edit an existing invoice
        public InvoiceResponseDTO Put(InvoiceDTO invoice)
        {
            if (_dbcontext.Invoices.Any(x => x.InvoiceNumber == invoice.Invoice_number))
            {
                InvoiceResponseDTO response = _invoiceBAL.UpdateInvoice(invoice);
                return response;
            }
            else
            {
                return new InvoiceResponseDTO { StatusCode = HttpStatusCode.NotFound, Message = "Invoice Details Not Found" };
            }
        }
    }
}