using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class BatchActivity
    {

        private long _lngBatchActID;

        public long BatchActID
        {
            get { return _lngBatchActID; }
            set { _lngBatchActID = value; }
        }

        private MainActivity _objMainActivity;

        public MainActivity MainActivity
        {
            get { return _objMainActivity; }
            set { _objMainActivity = value; }
        }
	

        private Batch _objBatch;

        public Batch Batch
        {
            get { return _objBatch; }
            set { _objBatch = value; }
        }


        public enum Status : int
        {
            Initial = 0,
            Start = 1,
            Finished = 2,
            SecondaryPacking=3,
            Transferred=4,
            SecondaryPacking_Start = 5,
            SecondaryPacking_Finish= 6
        }

        private Status _enumBatchActStatus;

        public Status BatchActStatus
        {
            get { return _enumBatchActStatus; }
            set { _enumBatchActStatus = value; }
        }
	


        private int _SequenceNo;

        public int SequenceNo
        {
            get { return _SequenceNo; }
            set { _SequenceNo = value; }
        }

        private String _Part;

        public String Part
        {
            get { return _Part; }
            set { _Part = value; }
        }



        private DateTime _LastEdited;

        public DateTime LastEdited
        {
            get { return _LastEdited; }
            set { _LastEdited = value; }
        }


        private bool _BlockNextActivity;

        public bool BlockNextActivity
        {
            get { return _BlockNextActivity; }
            set { _BlockNextActivity = value; }
        }

        private Decimal _StartQty;

        public Decimal StartQty
        {
            get { return _StartQty; }
            set { _StartQty = value; }
        }

        private Decimal _StopQty;

        public Decimal StopQty
        {
            get { return _StopQty; }
            set { _StopQty = value; }
        }

        private Employee _SupervisedBy;

        public Employee SupervisedBy
        {
            get { return _SupervisedBy; }
            set { _SupervisedBy = value; }
        }

        private Decimal _SectionOverHeadRate;

        public Decimal SectionOverHeadRate
        {
            get { return _SectionOverHeadRate; }
            set { _SectionOverHeadRate = value; }
        }

        private string _ActType;

        public string ActType
        {
            get { return _ActType; }
            set { _ActType = value; }
        }


        private string _startProductCode;

        public string StartProductCode
        {
            get { return _startProductCode; }
            set { _startProductCode = value; }

        }


        private string _endProductCode;

        public string EndProductCode
        {
            get { return _endProductCode; }
            set { _endProductCode = value; }

        }


        private string _ActMethod;

        public string ActMethod
        {
            get { return _ActMethod; }
            set { _ActMethod = value; }

        }



    }

    public class BatchActivityCollec : CollectionBase
    {
        public void Add(BatchActivity objBatchActivity)
        {
            this.InnerList.Add(objBatchActivity);
        }
    }
}
