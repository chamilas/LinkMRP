using System;
using System.Collections.Generic;
using System.Text;

namespace SESD.MRP.REF
{
    public class TempPOMaterials
    {
        private long _lngID;

        public long ID
        {
            get { return _lngID; }
            set { _lngID = value; }
        }

        private Supplier _objSupplier;

        public Supplier Supplier
        {
            get { return _objSupplier; }
            set { _objSupplier = value; }
        }

        private Material _objMaterial;

        public Material Material
        {
            get { return _objMaterial; }
            set { _objMaterial = value; }
        }

        private String _strDescription;

        public String Description
        {
            get { return _strDescription; }
            set { _strDescription = value; }
        }

        private Decimal _decReqdQty;

        public Decimal ReqdQty
        {
            get { return _decReqdQty; }
            set { _decReqdQty = value; }
        }

        private Decimal _decUnitRate;

        public Decimal UnitRate
        {
            get { return _decUnitRate; }
            set { _decUnitRate = value; }
        }

        private DateTime _dtDate;

        public DateTime Date
        {
            get { return _dtDate; }
            set { _dtDate = value; }
        }

        private Employee _objEnterdBy;

        public Employee EnterdBy
        {
            get { return _objEnterdBy; }
            set { _objEnterdBy = value; }
        }

        private String _strSupplierName;
        public String SupplierName
        {
            get { return _strSupplierName = Supplier.SupplieName; }
        }

        private String _strMaterialCode;
        public String MaterialCode
        {
            get { return _strMaterialCode = Material.MaterialNameCode; }
        }

        private long _lnPRCode;
        public long PRCode
        {
            get 
            {
                _lnPRCode = PR.PRNO;
                return _lnPRCode; 
            }
        }
	

        private PR _objPR;

        public PR PR
        {
            get { return _objPR; }
            set { _objPR = value; }
        }

        private String _strGenID;

        public String GENID
        {
            get { return _strGenID; }
            set { _strGenID = value; }
        }
	
	

    }

    public class TempPOMaterialsCollec : System.Collections.CollectionBase
    {
        public void Add(TempPOMaterials obj)
        {
            this.InnerList.Add(obj);
        }

        public void Delete(TempPOMaterials obj)
        {
            this.InnerList.Remove(obj);
        }
    }
}
