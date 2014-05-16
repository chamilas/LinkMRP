using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class Weighing
    {

        private long _WeighingID;

        public long WeighingID
        {
            get { return _WeighingID; }
            set { _WeighingID = value; }
        }

        private String _BatchID;

        public String BatchID
        {
            get { return _BatchID; }
            set { _BatchID = value; }
        }


        private String _OutsideOfficer;

        public String OutsideOfficer
        {
            get { return _OutsideOfficer; }
            set { _OutsideOfficer = value; }
        }

        private String _MissedItemsWeightBy;

        public String MissedItemsWeightBy
        {
            get { return _MissedItemsWeightBy; }
            set { _MissedItemsWeightBy = value; }
        }

        private DateTime? _StartDate;

        public DateTime? StartDate
        {
            get { return _StartDate; }
            set { _StartDate = value; }
        }

        private DateTime? _MissedItemWeighDate;

        public DateTime? MissedItemWeighDate
        {
            get { return _MissedItemWeighDate; }
            set { _MissedItemWeighDate = value; }
        }

        private String _CheckedBy;

        public String CheckedBy
        {
            get { return _CheckedBy; }
            set { _CheckedBy = value; }
        }

        private DateTime? _CheckedDate;

        public DateTime? CheckedDate
        {
            get { return _CheckedDate; }
            set { _CheckedDate = value; }
        }

        private String _Status;

        public String Status
        {
            get { return _Status; }
            set { _Status = value; }
        }


        private String _WeighingSupBy;

        public String WeighingSupBy
        {
            get { return _WeighingSupBy; }
            set { _WeighingSupBy = value; }
        }

        private String _WeighingFinalizeBy;

        public String WeighingFinalizeBy
        {
            get { return _WeighingFinalizeBy; }
            set { _WeighingFinalizeBy = value; }
        }

        private DateTime? _WeighingFinalizeDate;

        public DateTime? WeighingFinalizeDate
        {
            get { return _WeighingFinalizeDate; }
            set { _WeighingFinalizeDate = value; }
        }


	
    }

    public class WeighingCollec : CollectionBase
    {
        public void Add(Weighing obj)
        {
            this.InnerList.Add(obj);
        }
    }
}
