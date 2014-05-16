using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class PackingBatchMaterial
    {
        private String _MaterialCode;

        public String MaterialCode
        {
            get { return _MaterialCode; }
            set { _MaterialCode = value; }
        }
        private long _MRNO;

        public long MRNO
        {
            get { return _MRNO; }
            set { _MRNO = value; }
        }
        private String _PackingBatchID;

        public String PackingBatchID
        {
            get { return _PackingBatchID; }
            set { _PackingBatchID = value; }
        }
        private Decimal _Quantity;

        public Decimal Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }
        private Decimal _RamainingQty;

        public Decimal RamainingQty
        {
            get { return _RamainingQty; }
            set { _RamainingQty = value; }
        }
        private Decimal _DamagedQty;

        public Decimal DamagedQty
        {
            get { return _DamagedQty; }
            set { _DamagedQty = value; }
        }
        private Decimal _SubQty;

        public Decimal SubQty
        {
            get { return _SubQty; }
            set { _SubQty = value; }
        }
        private Decimal _SubReturnedQty;

        public Decimal SubReturnedQty
        {
            get { return _SubReturnedQty; }
            set { _SubReturnedQty = value; }
        }


        private String _Status;

        public String Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
	
    }

    public class PackingBatchMaterialCollec : CollectionBase
    {
        public void Add(PackingBatchMaterial obj)
        {
            this.InnerList.Add(obj);
        }
    }
}
