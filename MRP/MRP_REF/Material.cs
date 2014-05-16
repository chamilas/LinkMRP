using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class Material
    {
        private String _stringMatID;

        public String MaterialCode
        {
            get { return _stringMatID; }
            set { _stringMatID = value; }
        }

        private String _strDescription;

        public String MaterialDescription
        {
            get { return _strDescription; }
            set { _strDescription = value; }
        }

        private String _strMatMainType;

        public String MaterialMainType
        {
            get { return _strMatMainType; }
            set { _strMatMainType = value; }
        }
	

        private String _objCategory;

        public String MaterialCategory
        {
            get { return _objCategory; }
            set { _objCategory = value; }
        }


        private MaterialType _objType;

        public MaterialType MateialType
        {
            get { return _objType; }
            set { _objType = value; }
        }

        private Form _objForm;

        public Form MatForm
        {
            get { return _objForm; }
            set { _objForm = value; }
        }


        private Unit _objUnit;

        public Unit MatUnit
        {
            get { return _objUnit; }
            set { _objUnit = value; }
        }
        private Decimal _lngAvgCost;

        public Decimal MatCost
        {
            get { return _lngAvgCost; }
            set { _lngAvgCost = value; }
        }

        private bool _blSeasanal;

        public bool IsSeasanal
        {
            get { return _blSeasanal; }
            set { _blSeasanal = value; }
        }

        private bool _blLoacal;

        public bool IsLocal
        {
            get { return _blLoacal; }
            set { _blLoacal = value; }
        }

        private bool _boolExport;

        public bool IsExport
        {
            get { return _boolExport; }
            set { _boolExport = value; }
        }

        private String _strSeasanFrom;

        public String MatSeasonFrom
        {
            get { return _strSeasanFrom; }
            set { _strSeasanFrom = value; }
        }

        private String _strSeasonTo;

        public String MatSeasonTo
        {
            get { return _strSeasonTo; }
            set { _strSeasonTo = value; }
        }


        private string _objMaterial;

        public string MatBasicMaterial
        {
            get { return _objMaterial; }
            set { _objMaterial = value; }
        }

        private Decimal _lngBasicQty;

        public Decimal MatBasicQty
        {
            get { return _lngBasicQty; }
            set { _lngBasicQty = value; }
        }

        private String _lngParticleSize;

        public String MatParticleSize
        {
            get { return _lngParticleSize; }
            set { _lngParticleSize = value; }
        }

        private int _intStatus;

        public int MaterialStatus
        {
            get { return _intStatus; }
            set { _intStatus = value; }
        }

        public enum Status:int
        {
            Enable = 1,
            Disable = 2,

        }

        private String _strMatNameCode;
        public String MaterialNameCode
        {
            
            get 
            {
                _strMatNameCode = MaterialCode + " - " + MaterialDescription;
                return _strMatNameCode; 
            
            }
        }


        
        private string _MaterialType;

        public string MaterialType
        {
            get { return _MaterialType; }
            set { _MaterialType = value; }
        }


	
    }

    public class MaterialCollec : CollectionBase
    {
        public void Add(Material objMat)
        {
            this.InnerList.Add(objMat);
        }
    }
}
