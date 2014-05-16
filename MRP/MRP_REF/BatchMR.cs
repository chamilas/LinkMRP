using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class BatchMR
    {
        private String _BatchID;

        public String BatchID
        {
            get { return _BatchID; }
            set { _BatchID = value; }
        }

        private long _MRNO;

        public long MRNO
        {
            get { return _MRNO; }
            set { _MRNO = value; }
        }

        public enum Status : int
        {
            Request = 1,
            Recevied = 2,
            Issued = 3,
            Rejected = 4
        }

        private Status _MRStatus;

        public Status MRStaus
        {
            get { return _MRStatus; }
            set { _MRStatus = value; }
        }
	
    }
    public class BatchMRCollec : CollectionBase
    {
        public void Add(BatchMR obj)
        {
            InnerList.Add(obj);
        }
    }
}
