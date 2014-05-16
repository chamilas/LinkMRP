using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class PackingBatchActivity
    {
        private long _PackingActID;

        public long PackingActID
        {
            get { return _PackingActID; }
            set { _PackingActID = value; }
        }

        private String _PackingBatchID;

        public String PackingBatchID
        {
            get { return _PackingBatchID; }
            set { _PackingBatchID = value; }
        }
	
        private String _Name;

        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private DateTime? _StartDate;

        public DateTime? StartDate
        {
            get { return _StartDate; }
            set { _StartDate = value; }
        }

        private DateTime? _FinishDate;

        public DateTime? FinishDate
        {
            get { return _FinishDate; }
            set { _FinishDate = value; }
        }


        private String _SupBy;

        public String SupBy
        {
            get { return _SupBy; }
            set { _SupBy = value; }
        }

        private String _Remarks;

        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        private Decimal _StartQty;

        public Decimal StartQty
        {
            get { return _StartQty; }
            set { _StartQty = value; }
        }

        private Decimal _FinalQty;

        public Decimal FinalQty
        {
            get { return _FinalQty; }
            set { _FinalQty = value; }
        }

        private Decimal _SectionOverHead;

        public Decimal SectionOverHead
        {
            get { return _SectionOverHead; }
            set { _SectionOverHead = value; }
        }
	
    }

    public class PackingBatchActivityCollec : CollectionBase
    {
        public void Add(PackingBatchActivity obj)
        {
            this.InnerList.Add(obj);
        }
    }

}
