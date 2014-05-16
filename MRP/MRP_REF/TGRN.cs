using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class TGRN
    {
        private long _strTGRNNo;

        public long TGRNNO
        {
            get { return _strTGRNNo; }
            set { _strTGRNNo = value; }
        }

        private DeliverNote _objDeleveryNote;

        public DeliverNote TGRNDeleveryNote
        {
            get { return _objDeleveryNote; }
            set { _objDeleveryNote = value; }
        }

        private DateTime _dtTGRNDate;

        public DateTime TGRNDate
        {
            get { return _dtTGRNDate; }
            set { _dtTGRNDate = value; }
        }


        private Employee _objEnterdBy;

        public Employee TGRNEnterdBy
        {
            get { return _objEnterdBy; }
            set { _objEnterdBy = value; }
        }

        private DateTime _dtEnterdDate;

        public DateTime TGRNEnterdDate
        {
            get { return _dtEnterdDate; }
            set { _dtEnterdDate = value; }
        }
	

        public enum Status : int
        {
            Initial = 0,
            Lab = 1,
            Stores=2,
            GRN = 3
        }

        private Status _enumTGRNStatus;

        public Status TGRNStatus
        {
            get { return _enumTGRNStatus; }
            set { _enumTGRNStatus = value; }
        }
	
	
    }

    public class TGRNCollec : CollectionBase
    {
        public void Add(TGRN objTGRN)
        {
            this.InnerList.Add(objTGRN);
        }
    }
}
