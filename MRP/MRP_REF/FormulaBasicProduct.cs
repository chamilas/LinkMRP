using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class FormulaBasicProduct
    {
        private Formula _objFormula;

        public Formula Formula
        {
            get { return _objFormula; }
            set { _objFormula = value; }
        }

        private BasicProduct _objBasicProduct;

        public BasicProduct BasicProduct
        {
            get { return _objBasicProduct; }
            set { _objBasicProduct = value; }
        }

        private String _strPart;

        public String FormulaPart
        {
            get { return _strPart; }
            set { _strPart = value; }
        }

        private Decimal _lngProductQty;

        public Decimal FormulaProductQty
        {
            get { return _lngProductQty; }
            set { _lngProductQty = value; }
        }
	
    }

    public class FormulaBasicProductCollec : CollectionBase
    {
        public void Add(FormulaBasicProduct objFormulaBasicProduct)
        {
            this.InnerList.Add(objFormulaBasicProduct);
        }
    }
}
