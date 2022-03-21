using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InvoiceGenAPI.BusinessLayer.Interface;
using InvoiceGenAPI.Data;
using InvoiceGenAPI.RequestDTOs;
using InvoiceGenAPI.ResponseDTOs;

namespace InvoiceGenAPI.BusinessLayer.Implementation
{
    public class InvoiceBALImplementaion : InvoiceBALInterface
    {
        private readonly DataContext _dbcontext;
        public InvoiceBALImplementaion(DataContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public InvoiceResponseDTO CreateInvoice(InvoiceDTO invoice)
        {
            return null;
        }

        //Delete Invoice details from all the tables
        public bool DeleteInvoice(int invoice_id)
        {
            try
            {
                //Removes Custom Field Entities
                var customField = _dbcontext.CustomFields.Where(x => x.InvoiceId == invoice_id);
                foreach (var field in customField)
                {
                    _dbcontext.CustomFields.Remove(field);
                }

                //Removes Line Items
                var items = _dbcontext.lineItems.Where(x => x.InvoiceId == invoice_id);
                foreach (var item in items)
                {
                    _dbcontext.lineItems.Remove(item);
                }

                //Remove Invoice
                var invoice = _dbcontext.Invoices.FirstOrDefault(x => x.InvoiceId == invoice_id);
                _dbcontext.Invoices.Remove(invoice);

                //Save Changes to db
                _dbcontext.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<InvoiceResponseDTO> GetInvoice()
        {
            throw new NotImplementedException();
        }

        public InvoiceResponseDTO UpdateInvoice(InvoiceDTO invoice)
        {
            throw new NotImplementedException();
        }
    }
}