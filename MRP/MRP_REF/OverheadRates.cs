using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class OverheadRates
    {
        private long _SectionID;

        public long SectionID
        {
            get { return _SectionID; }
            set { _SectionID = value; }
        }
	

        private Decimal _Rate;

        public Decimal Rate
        {
            get { return _Rate; }
            set { _Rate = value; }
        }

        private String _EnterdBy;

        public String EnterdBy
        {
            get { return _EnterdBy; }
            set { _EnterdBy = value; }
        }

        private DateTime _EnterdDate;

        public DateTime EnterdDate
        {
            get { return _EnterdDate; }
            set { _EnterdDate = value; }
        }
    }

    public class OverheadRatesCollec : CollectionBase
    {
        public void Add(OverheadRates obj)
        {
            this.InnerList.Add(obj);
        }
    }
}
