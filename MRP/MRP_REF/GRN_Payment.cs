using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SESD.MRP.REF
{
   public class GRN_Payment
    {
        private long _strGRNNO;

        public long GRNNo
        {
            get { return _strGRNNO; }
            set { _strGRNNO = value; }
        }


        private string _strPONo;

        public string PONo
        {
            get { return _strPONo; }
            set { _strPONo = value; }
        }


        private string _strInvoiceNo;

        public string InvoiceNo
        {
            get { return _strInvoiceNo; }
            set { _strInvoiceNo = value; }
        }



        private string _strInvoiceType;

        public string InvoiceType
        {
            get { return _strInvoiceType; }
            set { _strInvoiceType = value; }
        }

        private string _strSupplier;

       public string Supplier
        {
            get { return _strSupplier; }
            set { _strSupplier = value; }
        }

       


    }
}
