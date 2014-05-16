using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class MaterialReworkBatch
    {
        private String _lngMatReBatchID;

        public String MatReBatchID
        {
            get { return _lngMatReBatchID; }
            set { _lngMatReBatchID = value; }
        }

        private Rework _objRework;

        public Rework MatReRework
        {
            get { return _objRework; }
            set { _objRework = value; }
        }

        private MTN _objMTN;

        public MTN MatReMTN
        {
            get { return _objMTN; }
            set { _objMTN = value; }
        }

        private Employee _objSuperviser;

        public Employee MatReSuperviser
        {
            get { return _objSuperviser; }
            set { _objSuperviser = value; }
        }

        private Employee _objInstructer;

        public Employee MatReInstructedBy
        {
            get { return _objInstructer; }
            set { _objInstructer = value; }
        }

        private DateTime _dtStartDate;

        public DateTime MatReStartDate
        {
            get { return _dtStartDate; }
            set { _dtStartDate = value; }
        }

        private DateTime _dtEndDate;

        public DateTime MatReEndDate
        {
            get { return _dtEndDate; }
            set { _dtEndDate = value; }
        }

        private long _lngFinalQty;

        public long MatReFinalQty
        {
            get { return _lngFinalQty; }
            set { _lngFinalQty = value; }
        }

        private DateTime _dtMatReInstructedDate;

        public DateTime MatReInstructedDate
        {
            get { return _dtMatReInstructedDate; }
            set { _dtMatReInstructedDate = value; }
        }
	

        public enum MatReStatus : int
        {
            InPrograss = 0,
            Finish = 1,
            Finalized = 2
        }

        private MatReStatus _enumStatus;

        public MatReStatus Status
        {
            get { return _enumStatus; }
            set { _enumStatus = value; }
        }
	


	
    }

    public class MaterialReworkBatchCollec : CollectionBase
    {
        public void Add(MaterialReworkBatch objMatReWork)
        {
            this.InnerList.Add(objMatReWork);
        }
    }
}
