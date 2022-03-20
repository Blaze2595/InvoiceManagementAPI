using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceGenAPI.Models
{
    public class CustomFieldModel
    {
        public int Custom_fields_id { get; set; }
        public string Label { get; set; }
        public int Value { get; set; }
    }
}