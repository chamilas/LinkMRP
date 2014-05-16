using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class BasicProduct
    {
        private String _strBasicProductCode;

        public String BasicProductCode
        {
            get { return _strBasicProductCode; }
            set { _strBasicProductCode = value; }
        }

        private String _strName;

        public String BasicProductName
        {
            get { return _strName; }
            set { _strName = value; }
        }

        private String _strDescription;

        public String BasicProductDescription
        {
            get { return _strDescription; }
            set { _strDescription = value; }
        }

        private ProductCategory _objCategory;

        public ProductCategory BasicProductCategory
        {
            get { return _objCategory; }
            set { _objCategory = value; }
        }

        private ProductSubCategory _objSubCat;

        public ProductSubCategory BasicProductSubCategory
        {
            get { return _objSubCat; }
            set { _objSubCat = value; }
        }

        private Unit _objUnit;

        public Unit BasicProductUnit
        {
            get { return _objUnit; }
            set { _objUnit = value; }
        }


        private Form _objForm;

        public Form BasicProductForm
        {
            get { return _objForm; }
            set { _objForm = value; }
        }

        private Formula _objFormula;

        public Formula BasicProductFormula
        {
            get { return _objFormula; }
            set { _objFormula = value; }
        }

        private Decimal _lngAvgCost;

        public Decimal BasicProductAVGCost
        {
            get { return _lngAvgCost; }
            set { _lngAvgCost = value; }
        }

        private Decimal _STDBatchSize;

        public Decimal STDBatchSize
        {
            get { return _STDBatchSize; }
            set { _STDBatchSize = value; }
        }


        private bool _boolStatus;

        public bool BasicProductStatus
        {
            get { return _boolStatus; }
            set { _boolStatus = value; }
        }

        private String _strType;

        public String BasicProductType
        {
            get { return _strType; }
            set { _strType = value; }
        }

        private String _strCode;
        public String Code
        {
            get 
            {
                _strCode = BasicProductCode + " - " + BasicProductDescription;
                return _strCode; 
            }
        }
	
    }

    public class BasicProductCollec : CollectionBase
    {
        public void Add(BasicProduct objBasicProduct)
        {
            this.InnerList.Add(objBasicProduct);
        }
    }
}
