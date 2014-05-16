using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class FormulaFinishProduct
    {
        private Formula _objFormula;

        public Formula Formula
        {
            get { return _objFormula; }
            set { _objFormula = value; }
        }

        private FinishProduct _objFinishProduct;

        public FinishProduct FinishProduct
        {
            get { return _objFinishProduct; }
            set { _objFinishProduct = value; }
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

    public class FormulaFinishProductCollec : CollectionBase
    {
        public void Add(FormulaFinishProduct objFormulaFinishProduct)
        {
            this.InnerList.Add(objFormulaFinishProduct); 
        }
    }
}
