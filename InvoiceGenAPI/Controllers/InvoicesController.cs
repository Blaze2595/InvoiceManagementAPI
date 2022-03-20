using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using InvoiceGenAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceGenAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InvoicesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<InvoiceModel> Get()
        {
            return null;
        }

        [HttpPost]
        public InvoiceModel Post()
        {
            return null;
        }
        
        [HttpDelete]
        public HttpResponseMessage Delete()
        {
            return null;
        }

        [HttpPost]
        public InvoiceModel Update()
        {
            return null;
        }
    }
}