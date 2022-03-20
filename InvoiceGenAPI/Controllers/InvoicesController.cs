using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using InvoiceGenAPI.RequestDTOs;
using InvoiceGenAPI.Models;
using Microsoft.AspNetCore.Mvc;
using InvoiceGenAPI.ResponseDTOs;
using InvoiceGenAPI.Data;
using InvoiceGenAPI.BusinessLayer;

namespace InvoiceGenAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InvoicesController : ControllerBase
    {
        private readonly InvoiceBusinessLayer _invoiceBAL;
        private readonly DataContext _dbcontext;
        public InvoicesController(DataContext dbcontext, InvoiceBusinessLayer invoiceBAL)
        {
            _dbcontext = dbcontext;
            _invoiceBAL = invoiceBAL;

        }

        [HttpGet]
        //Gets the list of existing invoices
        public List<InvoiceResponseDTO> Get()
        {
            var x = new List<InvoiceResponseDTO>();
            return x;
        }

        [HttpPost]
        //Create new invoice
        public InvoiceResponseDTO Post(InvoiceDTO invoiceDTO)
        {
            return null;
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
            return null;
        }
    }
}