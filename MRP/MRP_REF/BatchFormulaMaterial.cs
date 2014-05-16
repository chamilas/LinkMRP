using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class BatchFormulaMaterial
    {

        private String _MaterialCode;

        public String MaterialCode
        {
            get { return _MaterialCode; }
            set { _MaterialCode = value; }
        }
	


        private String _BatchID;

        public String BatchID
        {
            get { return _BatchID; }
            set { _BatchID = value; }
        }

        private Decimal _Qty;

        public Decimal Qty
        {
            get { return _Qty; }
            set { _Qty = value; }
        }

        private String _Part;

        public String Part
        {
            get { return _Part; }
            set { _Part = value; }
        }

        private String _Type;

        public String Type
        {
            get { return _Type; }
            set { _Type = value; }
        }

        private String _AddedBy;

        public String AddedBy
        {
            get { return _AddedBy; }
            set { _AddedBy = value; }
        }

        private DateTime _AddedDate;

        public DateTime AddedDate
        {
            get { return _AddedDate; }
            set { _AddedDate = value; }
        }


        private String _Remarks;

        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }


        private bool _Status;

        public bool Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        private bool _Weigh;

        public bool Weigh
        {
            get { return _Weigh; }
            set { _Weigh = value; }
        }

        private String _WeighBy;

        public String WeighBy
        {
            get { return _WeighBy; }
            set { _WeighBy = value; }
        }

        private DateTime _WeighDate;

        public DateTime WeighDate
        {
            get { return _WeighDate; }
            set { _WeighDate = value; }
        }


        private bool _WeighingCheck;

        public bool WeighingCheck
        {
            get { return _WeighingCheck; }
            set { _WeighingCheck = value; }
        }

        private String _WeighingCheckBy;

        public String WeighingCheckBy
        {
            get { return _WeighingCheckBy; }
            set { _WeighingCheckBy = value; }
        }


        private DateTime _WeighingCheckDate;

        public DateTime WeighingCheckDate
        {
            get { return _WeighingCheckDate; }
            set { _WeighingCheckDate = value; }
        }


        private bool _Missed;

        public bool Missed
        {
            get { return _Missed; }
            set { _Missed = value; }
        }

        private String _MissedWeighBy;

        public String MissedWeighBy
        {
            get { return _MissedWeighBy; }
            set { _MissedWeighBy = value; }
        }

        private DateTime _MissedWeighDate;

        public DateTime MissedWeighDate
        {
            get { return _MissedWeighDate; }
            set { _MissedWeighDate = value; }
        }
	
    }

    public class BatchFormulaMaterialCollec : CollectionBase
    {
        public void Add(BatchFormulaMaterial obj)
        {
            this.InnerList.Add(obj);
        }
    }
}
