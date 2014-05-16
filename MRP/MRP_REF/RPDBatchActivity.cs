using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class RPDBatchActivity
    {
        private long _RPDBatchActID;

        public long RPDBatchActID
        {
            get { return _RPDBatchActID; }
            set { _RPDBatchActID = value; }
        }

        private String _RPDBatchID;

        public String RPDBatchID
        {
            get { return _RPDBatchID; }
            set { _RPDBatchID = value; }
        }

        private long _MainActID;

        public long MainActID
        {
            get { return _MainActID; }
            set { _MainActID = value; }
        }
	


        private String _Comments;

        public String Comments
        {
            get { return _Comments; }
            set { _Comments = value; }
        }

        public enum Status : int
        {
            Initial = 0,
            Started = 1,
            Finalized = 2,
            Lab = 3
        }

        private Status _ActivityStatus;

        public Status ActivityStatus
        {
            get { return _ActivityStatus; }
            set { _ActivityStatus = value; }
        }

        private DateTime _StartDate;

        public DateTime StartDate
        {
            get { return _StartDate; }
            set { _StartDate = value; }
        }

        private DateTime _StopDate;

        public DateTime StopDate
        {
            get { return _StopDate; }
            set { _StopDate = value; }
        }

        private String _SupervisedBy;

        public String SupervisedBy
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


    }



    public class RPDBatchActivityCollec : CollectionBase
    {
        public void Add(RPDBatchActivity obj)
        {
            this.InnerList.Add(obj);
        }
    }
}
