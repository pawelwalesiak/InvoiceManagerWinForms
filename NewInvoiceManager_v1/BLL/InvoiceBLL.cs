using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewInvoiceManager_v1.BLL
{
    class InvoiceBLL
    {
        public int Invoice_No { get; set; }

        public int Customer_ID { get; set; }

        public DateTime Invoice_Date { get; set; }

        public decimal Vat { get; set; }

        public decimal Total { get; set; }
    }
}
