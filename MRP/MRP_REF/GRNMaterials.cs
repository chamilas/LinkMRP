using System;
using System.Collections.Generic;
using System.Text;
using SESD.MRP.REF;
using System.Collections;

namespace SESD.MRP.REF
{
    public class GRNMaterials
    {
        private GRN _objGRN;

        public GRN GRN
        {
            get { return _objGRN; }
            set { _objGRN = value; }
        }

        private Material _objMaterial;

        public Material Material
        {
            get { return _objMaterial; }
            set { _objMaterial = value; }
        }

        private Decimal _decGrossQty;

        public Decimal GrossQty
        {
            get { return _decGrossQty; }
            set { _decGrossQty = value; }
        }

        private Decimal _decNetQty;

        public Decimal NetQty
        {
            get { return _decNetQty; }
            set { _decNetQty = value; }
        }

        private Decimal _decUnitPrice;

        public Decimal UnitPrice
        {
            get { return _decUnitPrice; }
            set { _decUnitPrice = value; }
        }

        private String _strRemarks;

        public String Remarks
        {
            get { return _strRemarks; }
            set { _strRemarks = value; }
        }

        private String _strItem;
        public String Item
        {
            get 
            {
                _strItem = Material.MaterialCode + " - " + Material.MaterialDescription;
                return _strItem; 
            }
        }
	
    }

    public class GRNMaterialsCollec : CollectionBase
    {
        public void Add(GRNMaterials obj)
        {
            this.InnerList.Add(obj);
        }

        public void Delete(GRNMaterials obj)
        {
            this.InnerList.Remove(obj);
        }
    }
}
