using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class ReworkBatch
    {
        private String _lngReworkBatchID;

        public String ReworkBatchID
        {
            get { return _lngReworkBatchID; }
            set { _lngReworkBatchID = value; }
        }


        private Employee _objSuperviser;

        public Employee ReworkBatchSupervisedBy
        {
            get { return _objSuperviser; }
            set { _objSuperviser = value; }
        }

        private Employee _objinstructedBy;

        public Employee ReworkBatchInstructedBy
        {
            get { return _objinstructedBy; }
            set { _objinstructedBy = value; }
        }

        private DateTime _dtInstructedDate;

        public DateTime ReworkBatchInstructedDate
        {
            get { return _dtInstructedDate; }
            set { _dtInstructedDate = value; }
        }

        private DateTime _dtStartDate;

        public DateTime ReworkBatchStartDate
        {
            get { return _dtStartDate; }
            set { _dtStartDate = value; }
        }

        private DateTime _dtEndDate;

        public DateTime ReworkBatchEndDate
        {
            get { return _dtEndDate; }
            set { _dtEndDate = value; }
        }

        private Decimal _lngFinalQty;

        public Decimal ReworkBatchFinalQty
        {
            get { return _lngFinalQty; }
            set { _lngFinalQty = value; }
        }

        public enum ReworkBatchStatus
        {
            Initial = 1,
            InPrograss = 2,
            Finish = 3,
            Finalized = 4
        }

        private ReworkBatchStatus _Status;

        public ReworkBatchStatus Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
	
	

	
    }

    public class ReworkBatchCollec : CollectionBase
    {
        public void Add(ReworkBatch objReworkBatch)
        {
            this.InnerList.Add(objReworkBatch);
        }
    }
}
