using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class MaterialRework
    {
        private MaterialReworkBatch _objMaterialReworkBatch;

        public MaterialReworkBatch MaterialReworkBatch
        {
            get { return _objMaterialReworkBatch; }
            set { _objMaterialReworkBatch = value; }
        }

        private Rework _objRework;

        public Rework Rework
        {
            get { return _objRework; }
            set { _objRework = value; }
        }

        private MTN _objMTN;

        public MTN MTN
        {
            get { return _objMTN; }
            set { _objMTN = value; }
        }

        private Employee _objSuperviser;

        public Employee Superviser
        {
            get { return _objSuperviser; }
            set { _objSuperviser = value; }
        }

        private Employee _objInstructedBy;

        public Employee InstructedBy
        {
            get { return _objInstructedBy; }
            set { _objInstructedBy = value; }
        }


        private DateTime _dtInstructedDate;

        public DateTime InstructedDate
        {
            get { return _dtInstructedDate; }
            set { _dtInstructedDate = value; }
        }

        private DateTime _dtStartDate;

        public DateTime StartDate
        {
            get { return _dtStartDate; }
            set { _dtStartDate = value; }
        }

        private DateTime _dtEndDate;

        public DateTime EndDate
        {
            get { return _dtEndDate; }
            set { _dtEndDate = value; }
        }

        private long _lngFinalQty;

        public long FinalQty
        {
            get { return _lngFinalQty; }
            set { _lngFinalQty = value; }
        }

        public enum Status : int
        {
            Inprograss = 0,
            Finish = 1
        }

        private Status _enumStatus;

        public Status MatReStatus
        {
            get { return _enumStatus; }
            set { _enumStatus = value; }
        }
	
	
    }

    public class MaterialReworkCollec : CollectionBase
    {
        public void Add(MaterialRework objMaterialRework)
        {
            this.InnerList.Add(objMaterialRework);
        }
    }
}
