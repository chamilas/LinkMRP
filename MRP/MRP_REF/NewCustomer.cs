using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SESD.MRP.REF
{
    public class NewCustomer
    {
        public int Customer_Code { get; set;}
        public string Date { get; set; }
        public string Name { get; set; }
        public string OtherNames { get; set; }
        public string Address { get; set; }
        public string Customer_Type { get; set; }
        public string Category { get; set; }
        public int Area { get; set; }
        public int Discount_Type { get; set; }
        public string Discount_Apply { get; set; }
        public float Credits_Limits { get; set; }
        public int Status { get; set; }
        public int UserID { get; set; }
        public int Active { get; set; }
    }
}
