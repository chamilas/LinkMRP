using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SESD.MRP.REF
{
    public class AuthorizedNotes
    {
        public int Customer_Code { get; set; }
        public string Note_From_Sales { get; set; }
        public int UserID_Sales { get; set; }
        public string Date_Sales { get; set; }
        public string Note_From_Finance { get; set; }
        public int UserID_Finace { get; set; }
        public string Date_Finace { get; set; }
    }
}
