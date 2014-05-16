using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class RepackBatch
    {
        private String _lngRepackID;

        public String RepackBatchID
        {
            get { return _lngRepackID; }
            set { _lngRepackID = value; }
        }

        private Employee _objSuperviser;

        public Employee RepackSuperviser
        {
            get { return _objSuperviser; }
            set { _objSuperviser = value; }
        }

        private FinishProduct _objFinishProduct;

        public FinishProduct RepackFinishProduct
        {
            get { return _objFinishProduct; }
            set { _objFinishProduct = value; }
        }

        private Decimal _lngQty;

        public Decimal RepackQty
        {
            get { return _lngQty; }
            set { _lngQty = value; }
        }

        private MR _objMR;

        public MR RepackMR
        {
            get { return _objMR; }
            set { _objMR = value; }
        }

        private Employee _objInstructer;

        public Employee RepackInstructedBy
        {
            get { return _objInstructer; }
            set { _objInstructer = value; }
        }

        private DateTime _dtInstructedDate;

        public DateTime RepackInstructedDate
        {
            get { return _dtInstructedDate; }
            set { _dtInstructedDate = value; }
        }

        private DateTime _dtStartDate;

        public DateTime RepackStartDate
        {
            get { return _dtStartDate; }
            set { _dtStartDate = value; }
        }

        private DateTime _dtEndDate;

        public DateTime RepackEndDate
        {
            get { return _dtEndDate; }
            set { _dtEndDate = value; }
        }

        public enum RepackStatus
        {
            Initial = 1,
            InPrograss = 2,
            Finish = 3,
            Finalized = 4
        }

        private RepackStatus _Status;

        public RepackStatus Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        private String _CAPNO;

        public String CAPNO
        {
            get { return _CAPNO; }
            set { _CAPNO = value; }
        }

        private String _FinishProductBatchID;

        public String FinishProductBatchID
        {
            get { return _FinishProductBatchID; }
            set { _FinishProductBatchID = value; }
        }

        private Decimal _FinalQty;

        public Decimal FinalQty
        {
            get { return _FinalQty; }
            set { _FinalQty = value; }
        }
	
	
    }

    public class RepackBatchCollec : CollectionBase
    {
        public void Add(RepackBatch objRepackBatch)
        {
            this.InnerList.Add(objRepackBatch);
        }
    }
}
