using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InvoiceGenAPI.BusinessLayer.Interface;
using InvoiceGenAPI.Data;
using InvoiceGenAPI.Entities;
using InvoiceGenAPI.Helpers;
using InvoiceGenAPI.RequestDTOs;
using InvoiceGenAPI.ResponseDTOs;

namespace InvoiceGenAPI.BusinessLayer.Implementation
{
    public class InvoiceBALImplementaion : InvoiceBALInterface
    {
        private readonly DataContext _dbcontext;
        private HelperClass helpers;
        public InvoiceBALImplementaion(DataContext dbcontext)
        {
            _dbcontext = dbcontext;
            helpers = new HelperClass();
        }

        public InvoiceResponseDTO CreateInvoice(InvoiceDTO invoice)
        {
            try
            {
                InvoiceResponseDTO response = new InvoiceResponseDTO();
                List<CustomFiledResponseDTO> customResponse = new List<CustomFiledResponseDTO>();
                List<LineItemResponseDTO> liResponse = new List<LineItemResponseDTO>();
                List<PaymentGatewayResponseDTO> paymentResponse = new List<PaymentGatewayResponseDTO>();

                //Add invoice details
                Invoice inv = new Invoice
                {
                    InvoiceNumber = invoice.Invoice_number,
                    CustomerId = invoice.Customer_id,
                    PlaceOfSupply = invoice.Place_of_supply,
                    GstTreatment = invoice.Gst_treatment,
                    Date = invoice.Date,
                    PaymentTerms = invoice.Payment_terms,
                    Discount = invoice.discount,
                    DiscountBeforeTax = invoice.is_discount_before_tax,
                    Salesman = invoice.Salesperson_name,
                    ShippingCharge = invoice.Shipping_charge,
                    Notes = invoice.Notes,
                    Terms = invoice.Terms
                };

                _dbcontext.Invoices.Add(inv);

                //Add Custom Field Details
                foreach(var field in invoice.Custom_fields)
                {
                    CustomField cust = new CustomField{
                        InvoiceId = inv.InvoiceId,
                        Label = field.Label,
                        Value = field.Value                        
                    };
                    _dbcontext.CustomFields.Add(cust);

                    customResponse.Add(new CustomFiledResponseDTO{
                        Customfield_id = cust.CustomFieldId,
                        Label = cust.Label,
                        Value = cust.Value
                    });
                }

                //Add LineItems
                foreach (var item in invoice.Line_items)
                {
                    LineItems li = new LineItems{
                        InvoiceId = inv.InvoiceId,
                        ItemId = item.Item_id,
                        ProjectId = item.Project_id,
                        Quantity = item.Quantity,
                        Discount = item.Discount,
                        Itemtotal = Convert.ToInt32(item.Item_total)
                    };
                    _dbcontext.lineItems.Add(li);

                    liResponse.Add(new LineItemResponseDTO{
                        Line_item_id = li.LineItemsId,
                        Discount = li.Discount,
                        item_id = li.ItemId,
                        Item_total = li.Itemtotal,
                        Name = _dbcontext.Items.First(x => x.ItemId == li.ItemId).Name,
                        Product_type = _dbcontext.Items.First(x => x.ItemId == li.ItemId).ProductType,
                        Project_id = li.ProjectId,
                        Quantity = li.Quantity,
                        Rate = _dbcontext.Items.First(x => x.ItemId == li.ItemId).Rate,
                        Tax_percentage = _dbcontext.Items.First(x => x.ItemId == li.ItemId).TaxPercent,
                        Tax_type = _dbcontext.Items.First(x => x.ItemId == li.ItemId).TaxType
                    });
                }

                foreach(var pay in invoice.Payment_options)
                {
                    paymentResponse.Add(new PaymentGatewayResponseDTO{
                        Gateway_name = pay.Gateway_name,
                        Additional_field1 = pay.Additional_field1,
                        Configured = pay.Configured
                    });
                }

                response.Line_items = liResponse;
                response.Payment_options = paymentResponse;
                response.Custom_fields = customResponse;
                response.Invoice_Id = inv.InvoiceId;
                response.StatusCode = System.Net.HttpStatusCode.OK;
                response.Message = "The Invoice has been saved Successfully";

                response = helpers.ObjectMapper(response, invoice);

                _dbcontext.SaveChanges();

                return response;

            }
            catch (Exception)
            {
                return new InvoiceResponseDTO
                {
                    StatusCode = System.Net.HttpStatusCode.BadRequest,
                    Message = "Error Occured While Saving the Invoice"
                };
            }
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