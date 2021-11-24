using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewInvoiceManager_v1.BLL
{
    class LineItemBLL
    {
        public int Invoice_No { get; set; }

        public int LineItem_No { get; set; }

        public int Part_No { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

    }
}
