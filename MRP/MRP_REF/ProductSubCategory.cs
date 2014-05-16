using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class ProductSubCategory
    {
        private String _strCatID;

        public String CategoryID
        {
            get { return _strCatID; }
            set { _strCatID = value; }
        }

        private String _strCategory;

        public String Category
        {
            get { return _strCategory; }
            set { _strCategory = value; }
        }
    }

    public class ProductSubCategoryCollec : CollectionBase
    {
        public void Add(ProductSubCategory objCat)
        {
            this.InnerList.Add(objCat);
        }
    }
}
