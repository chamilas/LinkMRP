using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class ReworkBatchCAP
    {
        private String _ReworkBatchNo;

        public String ReworkBatch
        {
            get { return _ReworkBatchNo; }
            set { _ReworkBatchNo = value; }
        }

        private String _CAPNO;

        public String CAPNO
        {
            get { return _CAPNO; }
            set { _CAPNO = value; }
        }
	
    }

    public class ReworkBatchCAPCollec : CollectionBase
    {
        public void Add(ReworkBatchCAP obj)
        {
            this.InnerList.Add(obj);
        }
    }
}
