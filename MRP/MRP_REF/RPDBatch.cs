using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class RPDBatch
    {
        private string _lngRPDBatchID;

        public string RPDBatchID
        {
            get { return _lngRPDBatchID; }
            set { _lngRPDBatchID = value; }
        }

        private Employee _objSuperviser;

        public Employee RPDBatchSupervisedBy
        {
            get { return _objSuperviser; }
            set { _objSuperviser = value; }
        }


        private Material _objMaterial;

        public Material RPDBatchMaterial
        {
            get { return _objMaterial; }
            set { _objMaterial = value; }
        }

        private decimal _lngQty;

        public decimal RPDBatchQty
        {
            get { return _lngQty; }
            set { _lngQty = value; }
        }

        private MR _objMR;

        public MR RPDBatchMR
        {
            get { return _objMR; }
            set { _objMR = value; }
        }

        private Employee _objInstructedBy;

        public Employee RPDBatchInstructedBy
        {
            get { return _objInstructedBy; }
            set { _objInstructedBy = value; }
        }

        private DateTime? _dtinstructedDate;

        public DateTime? RPDBatchInstructedDate
        {
            get { return _dtinstructedDate; }
            set { _dtinstructedDate = value; }
        }


        private DateTime? _dtStartDate;

        public DateTime? RPDBatchStartDate
        {
            get { return _dtStartDate; }
            set { _dtStartDate = value; }
        }

        private DateTime? _dtEndDate;

        public DateTime? RPDBatchEndDate
        {
            get { return _dtEndDate; }
            set { _dtEndDate = value; }
        }

        private decimal _lngFinalQty;

        public decimal RPDBatchFinalQty
        {
            get { return _lngFinalQty; }
            set { _lngFinalQty = value; }
        }

        public enum RPDBatchStatus
        {
            Created=0,
            Approved=1,
            Started=2,
            Finished = 3,
            Transfered=4,
            Discarded=5,
            Cost=6
        }

        private RPDBatchStatus _enumBatchStatus;

        public RPDBatchStatus Status
        {
            get { return _enumBatchStatus; }
            set { _enumBatchStatus = value; }
        }


        private String _Type;

        public String Type
        {
            get { return _Type; }
            set { _Type = value; }
        }

        private Employee _ApporvedBy;

        public Employee ApprovedBy
        {
            get { return _ApporvedBy; }
            set { _ApporvedBy = value; }
        }


        private DateTime? _ApprovedDate;

        public DateTime? ApprovedDate
        {
            get { return _ApprovedDate; }
            set { _ApprovedDate = value; }
        }

        private Employee _EndBy;

        public Employee EndBy
        {
            get { return _EndBy; }
            set { _EndBy = value; }
        }
	
	
    }

    public class RPDBatchCollec : CollectionBase
    {
        public void Add(RPDBatch objRPDBatch)
        {
            this.InnerList.Add(objRPDBatch);
        }
    }
}
