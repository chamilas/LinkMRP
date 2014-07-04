using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SESD.MRP.REF
{
    public class TransactionDetails
    {
        public int Customer_Code { get; set; }
        public float Opening_Balanace { get; set; }
        public int Recived_Cheques { get; set; }
        public int Return_Cheques { get; set; }
        public float Due_Amount { get; set; }
        public string Customer_Status { get; set; }
        public int Status { get; set; }
        public int UserID { get; set; }
    }
}
