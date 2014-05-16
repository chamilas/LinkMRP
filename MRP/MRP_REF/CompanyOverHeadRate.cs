using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class CompanyOverHeadRate
    {
        private long _ID;

        public long ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private Decimal _Rate;

        public Decimal Rate
        {
            get { return _Rate; }
            set { _Rate = value; }
        }

        private Employee _EnterdBy;

        public Employee EnterdBy
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

    public class CompanyOverHeadRateCollec : CollectionBase
    {
        public void Add(CompanyOverHeadRate obj)
        {
            this.InnerList.Add(obj);
        }
    }
}
