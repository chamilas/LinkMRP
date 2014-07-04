using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SESD.MRP.REF
{
    public class SalesFinishProducts
    {
        public string finishProductCode { set; get; }
        public string finishProductName { set; get; }
        public int isSellable { set; get; }
        public double price { set; get; }
    }
}
