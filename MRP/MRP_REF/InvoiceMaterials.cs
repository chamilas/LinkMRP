using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class InvoiceMaterials
    {

        private long _ID;

        public long ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        private String _InvoiceNo;

        public String InvoiceNo
        {
            get { return _InvoiceNo; }
            set { _InvoiceNo = value; }
        }
        private String _MaterialID;

        public String MaterialID
        {
            get { return _MaterialID; }
            set { _MaterialID = value; }
        }
        private Decimal _Quantity;

        public Decimal Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }
        private Decimal _UnitRate;

        public Decimal UnitRate
        {
            get { return _UnitRate; }
            set { _UnitRate = value; }
        }

        private String _Remark;

        public String Remark
        {
            get { return _Remark; }
            set { _Remark = value; }
        }
	
    }

    public class InvoiceMaterialsCollec : CollectionBase
    {
        public void Add(InvoiceMaterials obj)
        {
            this.InnerList.Add(obj);
        }
    }
}
