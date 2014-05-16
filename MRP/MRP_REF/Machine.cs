using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class Machine
    {
        private String _lngMachineCode;

        public String MachineCode
        {
            get { return _lngMachineCode; }
            set { _lngMachineCode = value; }
        }

        private String _strName;

        public String MachineName
        {
            get { return _strName; }
            set { _strName = value; }
        }

        private String _Supplier;

        public String MachineSupplier
        {
            get { return _Supplier; }
            set { _Supplier = value; }
        }

        private MachineType _objMachineType;

        public MachineType MachineType
        {
            get { return _objMachineType; }
            set { _objMachineType = value; }
        }

        private String _strMachineDescription;

        public String MachineDescription
        {
            get { return _strMachineDescription; }
            set { _strMachineDescription = value; }
        }

        private Decimal _lngHourCost;

        public Decimal MachineHourCost
        {
            get { return _lngHourCost; }
            set { _lngHourCost = value; }
        }

        private Decimal _lngCapacity;

        public Decimal MachineCapacity
        {
            get { return _lngCapacity; }
            set { _lngCapacity = value; }
        }

        private Unit _objUnit;

        public Unit MachineCapacityUnit
        {
            get { return _objUnit; }
            set { _objUnit = value; }
        }

        private Decimal _lngMachineValue;

        public Decimal MachineValue
        {
            get { return _lngMachineValue; }
            set { _lngMachineValue = value; }
        }

        private DateTime _dtPurchaseDate;

        public DateTime MachinePurchaseDate
        {
            get { return _dtPurchaseDate; }
            set { _dtPurchaseDate = value; }
        }

        private String _strTransferDetails;

        public String MachineTransferDetails
        {
            get { return _strTransferDetails; }
            set { _strTransferDetails = value; }
        }

        private String _strMachinePropertyTag;

        public String MachinePropertyTag
        {
            get { return _strMachinePropertyTag; }
            set { _strMachinePropertyTag = value; }
        }

        private String _strBranch;

        public String MachineBranch
        {
            get { return _strBranch; }
            set { _strBranch = value; }
        }

        private Decimal _decMachineWastage;

        public Decimal MachineWastage
        {
            get { return _decMachineWastage; }
            set { _decMachineWastage = value; }
        }
	
    }

    public class MachineCollec : CollectionBase
    {
        public void Add(Machine objMachine)
        {
            this.InnerList.Add(objMachine);
        }
    }
}
