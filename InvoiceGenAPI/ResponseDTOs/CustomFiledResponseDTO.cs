using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceGenAPI.ResponseDTOs
{
    public class CustomFiledResponseDTO
    {
        public int Customfield_id { get; set; }
        public string Label { get; set; }
        public string Value { get; set; }
    }
}