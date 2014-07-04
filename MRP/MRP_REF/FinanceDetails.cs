using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SESD.MRP.REF
{
    public class FinanceDetails
    {
        public int Customer_Code { get; set; }
        public string Bank_Guaranty_Amount { get; set; }
        public string Guaranty_Bank { get; set; }
        public string Branch { get; set; }
        public float Bank_Guaranty_Exceed_Pre { get; set; }
        public string Renew_Date { get; set; }
        public int Remaing_Dates { get; set; }
        public int Status { get; set; }
        public int UserID { get; set; }
    }
}
