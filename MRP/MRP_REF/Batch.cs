using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class Batch
    {
        private String _strBatchID;

        public String BatchID
        {
            get { return _strBatchID; }
            set { _strBatchID = value; }
        }


        private STDBatch _objSTDBatch;

        public STDBatch StandardBatch
        {
            get { return _objSTDBatch; }
            set { _objSTDBatch = value; }
        }

        private Employee _objSuperviser;

        public Employee BatchSuperviser
        {
            get { return _objSuperviser; }
            set { _objSuperviser = value; }
        }

        private Employee _objApprovedBy;

        public Employee BatchApprovedBy
        {
            get { return _objApprovedBy; }
            set { _objApprovedBy = value; }
        }

        private DateTime _dtApprovedDate;

        public DateTime BatchApprovedDate
        {
            get { return _dtApprovedDate; }
            set { _dtApprovedDate = value; }
        }

        private Employee _objGenerateBy;

        public Employee BatchGenerateBy
        {
            get { return _objGenerateBy; }
            set { _objGenerateBy = value; }
        }

        private DateTime _dtGenerateDate;

        public DateTime BatchGenerateDate
        {
            get { return _dtGenerateDate; }
            set { _dtGenerateDate = value; }
        }

        private DateTime _dtStartDate;

        public DateTime BatchStartDate
        {
            get { return _dtStartDate; }
            set { _dtStartDate = value; }
        }

        private DateTime _dtEndDate;

        public DateTime BatchEndDate
        {
            get { return _dtEndDate; }
            set { _dtEndDate = value; }
        }

        private int _intDivide;

        public int BatchDivideCount
        {
            get { return _intDivide; }
            set { _intDivide = value; }
        }

        private Status _intStatus;

        public Status BatchStatus
        {
            get { return _intStatus; }
            set { _intStatus = value; }
        }
        private String _strType;

        public String BatchType
        {
            get { return _strType; }
            set { _strType = value; }
        }

        private Batch _objBatch;

        public Batch BatchParentBatch
        {
            get { return _objBatch; }
            set { _objBatch = value; }
        }

        private long _lngQty;

        public long BatchQty
        {
            get { return _lngQty; }
            set { _lngQty = value; }
        }

        public enum Status : int
        {
            Initial = 1,
            Approved = 2,
            In_Progress = 3,
            QC = 4,
            QCPass = 5,
            To_Finish = 6,
            Finished = 7,
            Packing = 8,
            Packed = 9,
            QCFail = 10,
            Rework=11,
            Transferred=12

        }

        private String _InitiatedBy;

        public String InitiatedBy
        {
            get { return _InitiatedBy; }
            set { _InitiatedBy = value; }
        }

        private DateTime _InitiatedDate;

        public DateTime InitiatedDate
        {
            get { return _InitiatedDate; }
            set { _InitiatedDate = value; }
        }

        private Decimal _BatchSize;

        public Decimal BatchSize
        {
            get { return _BatchSize; }
            set { _BatchSize = value; }
        }

        private Decimal _BatchFinalQty;

        public Decimal BatchFinalQty
        {
            get { return _BatchFinalQty; }
            set { _BatchFinalQty = value; }
        }


        private Employee _FinalizedBy;

        public Employee FinalizedBy
        {
            get { return _FinalizedBy; }
            set { _FinalizedBy = value; }
        }


        private DateTime? _FinalizedDate;

        public DateTime? FinalizedDate
        {
            get { return _FinalizedDate; }
            set { _FinalizedDate = value; }
        }
	
	
    }

    public class BatchCollec : CollectionBase
    {
        public void Add(Batch objBatch)
        {
            this.InnerList.Add(objBatch);
        }
    }
}
