using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class STDBatch
    {
        private string _lngSTDBatchID;

        public string STDBatchID
        {
            get { return _lngSTDBatchID; }
            set { _lngSTDBatchID = value; }
        }

        private String _strDescription;

        public String STDBatchDescription
        {
            get { return _strDescription; }
            set { _strDescription = value; }
        }
	
        private BasicProduct _objBasicProduct;

        public BasicProduct STDBatchBasicProduct
        {
            get { return _objBasicProduct; }
            set { _objBasicProduct = value; }
        }

        private FinishProduct _objFinishProduct;

        public FinishProduct STDBatchFinishProduct
        {
            get { return _objFinishProduct; }
            set { _objFinishProduct = value; }
        }

        private Decimal _lngBatchSize;

        public Decimal STDBatchSize
        {
            get { return _lngBatchSize; }
            set { _lngBatchSize = value; }
        }

        private Employee _objInstructed;

        public Employee STDBatchInstructedBy
        {
            get { return _objInstructed; }
            set { _objInstructed = value; }
        }

        private DateTime _dtInstructedDate;

        public DateTime STDInstructedDate
        {
            get { return _dtInstructedDate; }
            set { _dtInstructedDate = value; }
        }

        private String _strSTDBatchType;

        public String STDBatchType
        {
            get { return _strSTDBatchType; }
            set { _strSTDBatchType = value; }
        }


        private Decimal _STDDuration;

        public Decimal STDDuration
        {
            get { return _STDDuration; }
            set { _STDDuration = value; }
        }


        private bool _EditableBatch;

        public bool EditableBatch
        {
            get { return _EditableBatch; }
            set { _EditableBatch = value; }
        }

        private Decimal _LabourHours;

        public Decimal LabourHours
        {
            get { return _LabourHours; }
            set { _LabourHours = value; }
        }


        private Decimal _MachineHours;

        public Decimal MachineHours
        {
            get { return _MachineHours; }
            set { _MachineHours = value; }
        }


        private Decimal _OutputQty;

        public Decimal OutputQty
        {
            get { return _OutputQty; }
            set { _OutputQty = value; }
        }


        private Decimal _InputQty;

        public Decimal InputQty
        {
            get { return _InputQty; }
            set { _InputQty = value; }
        }



        private bool _SpecificGravity;

        public bool SpecificGravity
        {
            get { return _SpecificGravity; }
            set { _SpecificGravity = value; }
        }


        private Decimal _Water;

        public Decimal Water
        {
            get { return _Water; }
            set { _Water = value; }
        }
	


	
    }

    public class STDBatchCollec : CollectionBase
    {
        public void Add(STDBatch objSTDBatch)
        {
            this.InnerList.Add(objSTDBatch);
        }
    }
}
