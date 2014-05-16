using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class FormulaMaterial
    {
        private Formula _objFormula;

        public Formula Formula
        {
            get { return _objFormula; }
            set { _objFormula = value; }
        }

        private Material _objMaterial;

        public Material Material
        {
            get { return _objMaterial; }
            set { _objMaterial = value; }
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

    public class FormulaMaterialCollec : CollectionBase
    {
        public void Add(FormulaMaterial objFormulaMaterial)
        {
            this.InnerList.Add(objFormulaMaterial);
        }
    }
}
