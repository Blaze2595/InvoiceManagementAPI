using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceGenAPI.Entities
{
    public class CustomField
    {
        public int CustomFieldId { get; set; }
        public int InvoiceId { get; set; }
        public string Label { get; set; }
        public string Value { get; set; }
    }
}