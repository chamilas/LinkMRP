using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class PackingBatch
    {

        private String _BatchID;

        public String BatchID
        {
            get { return _BatchID; }
            set { _BatchID = value; }
        }


        private String _PackingBatchID;

        public String PackingBatchID
        {
            get { return _PackingBatchID; }
            set { _PackingBatchID = value; }
        }

        private long _SubContractorID;

        public long SubContractorID
        {
            get { return _SubContractorID; }
            set { _SubContractorID = value; }
        }

        private long _MTNNO;

        public long MTNNO
        {
            get { return _MTNNO; }
            set { _MTNNO = value; }
        }


        private long _PackingSTDBatchID;

        public long PackingSTDBatchID
        {
            get { return _PackingSTDBatchID; }
            set { _PackingSTDBatchID = value; }
        }


        private String _FinishProduct;

        public String FinishProduct
        {
            get { return _FinishProduct; }
            set { _FinishProduct = value; }
        }

        private Decimal _BulkQty;

        public Decimal BulkQty
        {
            get { return _BulkQty; }
            set { _BulkQty = value; }
        }


        private Decimal _BatchQty;

        public Decimal BatchQty
        {
            get { return _BatchQty; }
            set { _BatchQty = value; }
        }

        private Decimal _ActualQty;

        public Decimal ActualQty
        {
            get { return _ActualQty; }
            set { _ActualQty = value; }
        }


        private Decimal _SubContractInitialQty;

        public Decimal SubContractInitialQty
        {
            get { return _SubContractInitialQty; }
            set { _SubContractInitialQty = value; }
        }


        private Decimal _SubContractFinalQty;

        public Decimal SubContractFinalQty
        {
            get { return _SubContractFinalQty; }
            set { _SubContractFinalQty = value; }
        }


        public enum Type
        {
            Inhouse,
            Outsource
        }

        private Type _BatchType;

        public Type BatchType
        {
            get { return _BatchType; }
            set { _BatchType = value; }
        }


        private String _InstructedBy;

        public String InstructedBy
        {
            get { return _InstructedBy; }
            set { _InstructedBy = value; }
        }

        private DateTime _InstructedDate;

        public DateTime InstructedDate
        {
            get { return _InstructedDate; }
            set { _InstructedDate = value; }
        }


        private String _ApproveBy;

        public String ApproveBy
        {
            get { return _ApproveBy; }
            set { _ApproveBy = value; }
        }


        private DateTime? _ApprovedDate;

        public DateTime? ApprovedDate
        {
            get { return _ApprovedDate; }
            set { _ApprovedDate = value; }
        }

        private String _FinalizedBy;

        public String FinalizedBy
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

        private String _TransferdBy;

        public String TransferdBy
        {
            get { return _TransferdBy; }
            set { _TransferdBy = value; }
        }

        private DateTime? _TransferdDate;

        public DateTime? TransferdDate
        {
            get { return _TransferdDate; }
            set { _TransferdDate = value; }
        }

        public enum Status
        {
            Initial,
            Inprograss,
            Finish,
            QAPass,
            QAFail,
            Transferd
        }

        public enum SubStatus
        {
            Issued,
            Received,
            None

        }

        private SubStatus _SubContractStatus;

        public SubStatus SubContractStatus
        {
            get { return _SubContractStatus; }
            set { _SubContractStatus = value; }
        }
	

        private Status _BatchStatus;

        public Status BatchStatus
        {
            get { return _BatchStatus; }
            set { _BatchStatus = value; }
        }

        private String _Remarks;

        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }


        private DateTime? _SubContractDate;

        public DateTime? SubContractDate
        {
            get { return _SubContractDate; }
            set { _SubContractDate = value; }
        }

        private String _SubContractReceivedBy;

        public String SubContractReceivedBy
        {
            get { return _SubContractReceivedBy; }
            set { _SubContractReceivedBy = value; }
        }

        private DateTime? _SubContractReceivedDate;

        public DateTime? SubContractReceivedDate
        {
            get { return _SubContractReceivedDate; }
            set { _SubContractReceivedDate = value; }
        }

        private Decimal _SubContractCost;

        public Decimal SubContractCost
        {
            get { return _SubContractCost; }
            set { _SubContractCost = value; }
        }


        private Decimal _BulkLostQty;

        public Decimal BulkLostQty
        {
            get { return _BulkLostQty; }
            set { _BulkLostQty = value; }
        }
	
    }

    public class PackingBatchCollec : CollectionBase
    {
        public void Add(PackingBatch obj)
        {
            this.InnerList.Add(obj);
        }
    }
}
