using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class GRN
    {
        private long _strGRNNO;

        public long GRNNo
        {
            get { return _strGRNNO; }
            set { _strGRNNO = value; }
        }



        private long _objMTN;

        public long GRNMTNNo
        {
            get { return _objMTN; }
            set { _objMTN = value; }
        }

        private long _objMR;

        public long GRNMR
        {
            get { return _objMR; }
            set { _objMR = value; }
        }

        private string _objRPDBatch;

        public string GRNRPDBatch
        {
            get { return _objRPDBatch; }
            set { _objRPDBatch = value; }
        }

        private DateTime _dtDate;

        public DateTime GRNDate
        {
            get { return _dtDate; }
            set { _dtDate = value; }
        }


        private string _objApproved;

        public string GRNApprovedBy
        {
            get { return _objApproved; }
            set { _objApproved = value; }
        }

        private DateTime _dtApprvedDate;

        public DateTime GRNApprovedDate
        {
            get { return _dtApprvedDate; }
            set { _dtApprvedDate = value; }
        }

        private string _objEnterd;

        public string GRNEnterdBy
        {
            get { return _objEnterd; }
            set { _objEnterd = value; }
        }

        private Store _objStore;

        public Store GRNStore
        {
            get { return _objStore; }
            set { _objStore = value; }
        }


        public enum Status :int
        {
            Initial = 0,
            Approved = 1,
            Finalized = 2,
            Reject = 3
        }


        private int _GRNCategory;

        public int GRNCategory
        {
            get { return _GRNCategory; }
            set { _GRNCategory = value; }
        }
	

        private Status _enumGRNStatus;

        public Status GRNStatus
        {
            get { return _enumGRNStatus; }
            set { _enumGRNStatus = value; }
        }

        private string _DeliverNoteID;

        public string DeliverNoteID
        {
            get { return _DeliverNoteID; }
            set { _DeliverNoteID = value; }
        }


        public enum Type : int
        {
            Material = 1,
            BasicProduct = 2,
            FinishProduct = 3
        }

        private Type _enumGRNType;

        public Type GRNType
        {
            get { return _enumGRNType; }
            set { _enumGRNType = value; }
        }
	
    }

    public class GRNCollec : CollectionBase
    {
        public void Add(GRN objGRN)
        {
            this.InnerList.Add(objGRN);
        }
    }
}
