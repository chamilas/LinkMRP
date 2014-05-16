using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class SubStockIssueFinishProduct
    {
        private long _IssueID;

        public long IssueID
        {
            get { return _IssueID; }
            set { _IssueID = value; }
        }
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
        private String _BatchID;

        public String BatchID
        {
            get { return _BatchID; }
            set { _BatchID = value; }
        }
        private Decimal _Quantity;

        public Decimal Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }

    }
    public class SubStockIssueFinishProductCollec : CollectionBase
    {
        public void Add(SubStockIssueFinishProduct obj)
        {
            this.InnerList.Add(obj);
        }
    }
}
