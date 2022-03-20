using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using InvoiceGenAPI.RequestDTOs;
using InvoiceGenAPI.Models;
using Microsoft.AspNetCore.Mvc;
using InvoiceGenAPI.ResponseDTOs;

namespace InvoiceGenAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InvoicesController : ControllerBase
    {
        [HttpGet]
        //Gets the list of existing invoices
        public List<InvoiceResponseDTO> Get()
        {
            var x = new List<InvoiceResponseDTO>();
            return x;
        }
        
        [HttpPost]
        //Create new invoice
        public async Task<ActionResult<InvoiceResponseDTO>> Post(InvoiceDTO invoiceDTO)
        {
            return null;
        }
        
        [HttpDelete]
        //Delete an existing invoice
        public DeleteInvoiceResponseDTO Delete(int invoice_id)
        {
            return null;
        }

        [HttpPut]
        //Edit an existing invoice
        public InvoiceResponseDTO Put(InvoiceDTO invoice)
        {
            return null;
        }
    }
}