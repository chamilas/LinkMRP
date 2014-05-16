using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class CAPProduct
    {
        private long _ID;

        public long ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
	

        private CAP _objCAP;

        public CAP CAP
        {
            get { return _objCAP; }
            set { _objCAP = value; }
        }

        private FinishProduct _objFinishProduct;

        public FinishProduct FinishProduct
        {
            get { return _objFinishProduct; }
            set { _objFinishProduct = value; }
        }

        private Batch _objBatchNo;

        public Batch Batch
        {
            get { return _objBatchNo; }
            set { _objBatchNo = value; }
        }

        private Decimal _lngQty;

        public Decimal ProductQty
        {
            get { return _lngQty; }
            set { _lngQty = value; }
        }


        private String _strInstruction;

        public String Instruction
        {
            get { return _strInstruction; }
            set { _strInstruction = value; }
        }
	
    }

    public class CAPProductCollec : CollectionBase
    {
        public void Add(CAPProduct objCAPProduct)
        {
            this.InnerList.Add(objCAPProduct);
        }
    }
}
