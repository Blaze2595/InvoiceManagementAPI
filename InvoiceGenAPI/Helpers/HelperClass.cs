using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InvoiceGenAPI.Entities;
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

        public List<int> GetCustomerContactList(List<CustomerContactPerson> cust)
        {
            List<int> response = new List<int>();

            foreach (var item in cust)
            {
                response.Add(item.CustomerContactPersonId);
            }

            return response;
        }

        public List<CustomFiledResponseDTO> GetCustomFields(List<CustomField> customFields)
        {
            List<CustomFiledResponseDTO> response = new List<CustomFiledResponseDTO>();

            foreach (var field in customFields)
            {
                CustomFiledResponseDTO cust = new CustomFiledResponseDTO
                {
                    Customfield_id = field.CustomFieldId,
                    Label = field.Label,
                    Value = field.Value
                };

                response.Add(cust);
            }

            return response;
        }

        public List<LineItemResponseDTO> GetLineItems(List<LineItems> lineItems)
        {
            List<LineItemResponseDTO> response = new List<LineItemResponseDTO>();

            foreach (var item in lineItems)
            {
                LineItemResponseDTO li = new LineItemResponseDTO
                {
                    Discount = item.Discount,
                    item_id = item.ItemId,
                    Item_total = item.Itemtotal,
                    Line_item_id = item.LineItemsId,
                    Project_id = item.ProjectId,
                    Quantity = item.Quantity
                };

                response.Add(li);
            }

            return response;
        }

        public List<PaymentGatewayResponseDTO> GetPaymentOptions(List<PaymentGateway> paymentGateways)
        {
            List<PaymentGatewayResponseDTO> response = new List<PaymentGatewayResponseDTO>();

            foreach (var payment in paymentGateways)
            {
                PaymentGatewayResponseDTO pay = new PaymentGatewayResponseDTO
                {
                    Additional_field1 = payment.Additional_field,
                    Configured = payment.Configured,
                    Gateway_name = payment.Gateway_name
                };

                response.Add(pay);
            }

            return response;
        }
    }
}