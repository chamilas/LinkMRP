using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class MaterialCategory
    {
       
        private String _lngMatCatID;

        public String MatCatID
        {
            get { return _lngMatCatID; }
            set { _lngMatCatID = value; }
        }

        private String _strMaterialCategory;

        public String MaterialCategoryName
        {
            get { return _strMaterialCategory; }
            set { _strMaterialCategory = value; }
        }

    }
    public class MaterialCategoryCollec : CollectionBase
    {
        public void Add(MaterialCategory objMatCat)
        {
            this.InnerList.Add(objMatCat);
        }
    }
}
