using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{

    public class SubStockRecFinishProduct
    {
        private long _MRNO;

        public long MRNO
        {
            get { return _MRNO; }
            set { _MRNO = value; }
        }

        private String _FinishProductCode;

        public String FinishProductCode
        {
            get { return _FinishProductCode; }
            set { _FinishProductCode = value; }
        }
	


        private long _SubStockID;

        public long SubStockID
        {
            get { return _SubStockID; }
            set { _SubStockID = value; }
        }

        private Decimal _Quantity;

        public Decimal Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }

    }
    public class SubStockRecFinishProductCollec : CollectionBase
    {
        public void Add(SubStockRecFinishProduct obj)
        {
            this.InnerList.Add(obj);
        }
    }
}
