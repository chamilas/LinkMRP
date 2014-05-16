using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class PRMaterial
    {
        private long _PRItemID;

        public long PRItemID
        {
            get { return _PRItemID; }
            set { _PRItemID = value; }
        }
	

        private PR _objPR;

        public PR PR
        {
            get { return _objPR; }
            set { _objPR = value; }
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

        private String _objCondition;

        public String Condition
        {
            get { return _objCondition; }
            set { _objCondition = value; }
        }

        private Decimal _lngReqdQty;

        public Decimal ReqdQty
        {
            get { return _lngReqdQty; }
            set { _lngReqdQty = value; }
        }

        private Unit _objUnit;

        public Unit Unit
        {
            get { return _objUnit; }
            set { _objUnit = value; }
        }

        private DateTime _dtReqdDate;

        public DateTime ReqdDate
        {
            get { return _dtReqdDate; }
            set { _dtReqdDate = value; }
        }

        private String _strRemarks;

        public String Remarks
        {
            get { return _strRemarks; }
            set { _strRemarks = value; }
        }

        private String _strMatrialNameCode;
        public String MaterialNameCode
        {
            get
            {
                _strMatrialNameCode = this.Material.MaterialCode + " - " + this.Material.MaterialDescription;
                return _strMatrialNameCode; }
        }

        private String _strUnitCode;
        public String UnitCode
        {
            get
            {
                _strUnitCode = this.Unit.UnitCode; 
                return _strUnitCode; 
            
            }
        }


        private int _intPRMatStatus;

        public int PRMaterialStatus
        {
            get { return _intPRMatStatus; }
            set { _intPRMatStatus = value; }
        }



        private String _strSupplyRemarks;

        public String SupplyRemarks
        {
            get { return _strSupplyRemarks; }
            set { _strSupplyRemarks = value; }
        }


        private Decimal _decOrderdQty;

        public Decimal OrderdQty
        {
            get { return _decOrderdQty; }
            set { _decOrderdQty = value; }
        }

        private long _lngPRNo;
        public long PRNO
        {
            get 
            {
                _lngPRNo = PR.PRNO;
                return _lngPRNo; 
            }
        }


        private Decimal _ItemValue;

        public Decimal ItemValue
        {
            get { return _ItemValue; }
            set { _ItemValue = value; }
        }
	
	
    }

    public class PRMaterialCollec : CollectionBase
    {
        public void Add(PRMaterial objPRMaterial)
        {
            this.InnerList.Add(objPRMaterial);
        }

        public void Delete(PRMaterial objPRMaterial)
        {
            this.InnerList.Remove(objPRMaterial);
        }

    }
}
