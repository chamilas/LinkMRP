using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class FinishProduct
    {
        private String _strFinishProductCodr;

        public String FinishProductCode
        {
            get { return _strFinishProductCodr; }
            set { _strFinishProductCodr = value; }
        }

        private BasicProduct _objBasicProduct;

        public BasicProduct BasicProduct
        {
            get { return _objBasicProduct; }
            set { _objBasicProduct = value; }
        }

        private Formula _objFormula;

        public Formula FinishProductFormula
        {
            get { return _objFormula; }
            set { _objFormula = value; }
        }

        private PackingType _objPackingType;

        public PackingType FinishProductPackingType
        {
            get { return _objPackingType; }
            set { _objPackingType = value; }
        }

        private String _strDescription;

        public String FinishProductDescription
        {
            get { return _strDescription; }
            set { _strDescription = value; }
        }

        private Decimal _lngQty;

        public Decimal BasicProductQty
        {
            get { return _lngQty; }
            set { _lngQty = value; }
        }

        private Decimal _lngAvgCost;

        public Decimal FinishProductAvgCost
        {
            get { return _lngAvgCost; }
            set { _lngAvgCost = value; }
        }

        private bool _boolStatus;

        public bool FinishProductStatus
        {
            get { return _boolStatus; }
            set { _boolStatus = value; }
        }

        private String _strCode;
        public String Code
        {
            get
            {
                _strCode = FinishProductCode + " - " + BasicProduct.BasicProductDescription;
                return _strCode;
            }
        }

        private string _PrimaryFinishProductCode;

        public string PrimaryFinishProductCode
        {
            get { return _PrimaryFinishProductCode; }
            set { _PrimaryFinishProductCode = value; }
        }



         private Decimal _PrimaryFinishProductQty;

        public Decimal PrimaryFinishProductQty
        {
            get { return _PrimaryFinishProductQty; }
            set { _PrimaryFinishProductQty = value; }
        }


        private String _FinishProductType;

         public String FinishProductType
        {
            get { return _FinishProductType; }
            set { _FinishProductType = value; }
        }


         private int _SKUID;

        public int SKUID
        {
            get { return _SKUID; }
            set { _SKUID = value; }
        }    
    }

    public class FinishProductCollec : CollectionBase
    {
        public void Add(FinishProduct objFinishProduct)
        {
            this.InnerList.Add(objFinishProduct);
        }
    }
}
