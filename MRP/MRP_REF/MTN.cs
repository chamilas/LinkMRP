using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class MTN
    {
        private long _lngMTN;

        public long MTNNo
        {
            get { return _lngMTN; }
            set { _lngMTN = value; }
        }

        private String _objBatch;

        public String MTNBatch
        {
            get { return _objBatch; }
            set { _objBatch = value; }
        }

        private long _objPackingBatch;

        public long PackingBatch
        {
            get { return _objPackingBatch; }
            set { _objPackingBatch = value; }
        }


        private DateTime _dtDate;

        public DateTime MTNDate
        {
            get { return _dtDate; }
            set { _dtDate = value; }
        }

        private Employee _objApprovedBy;

        public Employee MTNApprovedBy
        {
            get { return _objApprovedBy; }
            set { _objApprovedBy = value; }
        }

        private DateTime _dtApprovedDate;

        public DateTime MTNApprovedDate
        {
            get { return _dtApprovedDate; }
            set { _dtApprovedDate = value; }
        }

        private Employee _objEnterdBy;

        public Employee MTNEnterdBy
        {
            get { return _objEnterdBy; }
            set { _objEnterdBy = value; }
        }


        private Department _objFrom;

        public Department MTNDepartmentFrom
        {
            get { return _objFrom; }
            set { _objFrom = value; }
        }


        private string _objFromName;

        public string MTNDepartmentFromName
        {
            get { return _objFromName; }
            set { _objFromName = value; }
        }

        private Department _objTo;

        public Department MTNDepartmentTo
        {
            get { return _objTo; }
            set { _objTo = value; }
        }

        private Employee _objReceivedBy;

        public Employee MTNReceivedBy
        {
            get { return _objReceivedBy; }
            set { _objReceivedBy = value; }
        }


        private DateTime _dtReceivedDate;

        public DateTime MTNReceivedDate
        {
            get { return _dtReceivedDate; }
            set { _dtReceivedDate = value; }
        }


        public enum Status:int
        {
            Initial = 0,
            Approved = 1,
            Received = 2,
            Cost = 3,
            ReceviedGRN = 4,
            Reject = 5
        }

        private Status _boolStatus;

        public Status MTNStatus
        {
            get { return _boolStatus; }
            set { _boolStatus = value; }
        }

        public enum Type :int
        {
            General=1,
            PRPD = 2,
            Batch = 3,
            Packing=4,
            Dispose = 5,
            Reject=6

            
        }

        private Type _intMTNType;

        public Type MTNType
        {
            get { return _intMTNType; }
            set { _intMTNType = value; }
        }

        public enum ItemType:int
        {
            Material = 1,
            Basic_Product = 2,
            Finish_Product = 3
        }

        private ItemType _enumMTNItemType;

        public ItemType MTNItemType
        {
            get { return _enumMTNItemType; }
            set { _enumMTNItemType = value; }
        }


        private Store _objStore;

        public Store MTNStore
        {
            get { return _objStore; }
            set { _objStore = value; }
        }

	
	
    }

    public class MTNCollec : CollectionBase
    {
        public void Add(MTN objMTN)
        {
            this.InnerList.Add(objMTN);
        }
    }
}
