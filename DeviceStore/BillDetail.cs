using System;
using System.Collections.Generic;
using System.Text;

namespace DeviceStore
{
    class BillDetail
    {
        private Bill bill;
        private Product[] prods;
        private Customer cus;
        internal Bill Bill { get => bill; set => bill = value; }
        internal Product[] Prods { get => prods; set => prods = value; }
        internal Customer Cus { get => cus; set => cus = value; }
    }
}
