using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InvoiceGenAPI.RequestDTOs;
using InvoiceGenAPI.ResponseDTOs;

namespace InvoiceGenAPI.Helpers
{
    public class HelperClass
    {
        public InvoiceResponseDTO ObjectMapper(InvoiceResponseDTO response, InvoiceDTO request)
        {
            response.Allow_partial_payments = request.Allow_partial_payments;
            response.Contact_persons = request.Contact_persons;
            response.Customer_id = request.Customer_id;
            response.date = request.Date;
            response.Discount = request.discount;
            response.Due_date = request.Due_date;
            response.Gst_no = request.Gst_no;
            response.Gst_treatment = request.Gst_treatment;
            response.Invoice_number = request.Invoice_number;
            response.Is_discount_before_tax = request.is_discount_before_tax;
            response.Notes = request.Notes;
            response.Payment_terms = request.Payment_terms;
            response.Place_of_supply = request.Place_of_supply;
            response.Salesperson_name = request.Salesperson_name;
            response.Terms = request.Terms;
            
            return response;

        }
    }
}