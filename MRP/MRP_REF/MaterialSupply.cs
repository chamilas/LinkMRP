using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class MaterialSupply
    {
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

        private Decimal _lngUnitPrice;

        public Decimal AVGUnitPrice
        {
            get { return _lngUnitPrice; }
            set { _lngUnitPrice = value; }
        }


        private Decimal _lngLastUnitPrice;

        public Decimal LastUnitPrice
        {
            get { return _lngLastUnitPrice; }
            set { _lngLastUnitPrice = value; }
        }

        private int _intLeadTime;

        public int LeadTime
        {
            get { return _intLeadTime; }
            set { _intLeadTime = value; }
        }

        private String _strQualitu;

        public String Quality
        {
            get { return _strQualitu; }
            set { _strQualitu = value; }
        }

        private String _strRemarks;

        public String Remarks
        {
            get { return _strRemarks; }
            set { _strRemarks = value; }
        }

        private long _lngID;

        public long ID
        {
            get { return _lngID; }
            set { _lngID = value; }
        }
	
	
	
	
    }

    public class MaterialSupplyCollec : CollectionBase
    {
        public void Add(MaterialSupply objMaterialSupply)
        {
            this.InnerList.Add(objMaterialSupply);
        }
    }
}
