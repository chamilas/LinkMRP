using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SESD.MRP.REF
{
    public class CustomerProducts
    {
        public int Customer_Code { set; get; }
        public string Basic_Product_ID { set; get; }
        public int Discount_Type { set; get; }
        public float Price_Per_Quantity { set; get; }
        public float Discount_Per_Quantity { set; get; }
    }
}
