using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class ProductCategory
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

    public class ProductCategoryCollec : CollectionBase
    {
        public void Add(ProductCategory objCat)
        {
            this.InnerList.Add(objCat);
        }
    }
}
