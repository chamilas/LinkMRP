using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SESD.MRP.REF
{
    public class CustomerTerritoryList
    {

        private String _CustomerID;

        public String CustomerID
        {
            get { return _CustomerID; }
            set { _CustomerID = value; }
        }
        private String _TerritoryName;

        public String TerritoryName
        {
            get { return _TerritoryName; }
            set { _TerritoryName = value; }
        }

        private int _TerritoryID;

        public int TerritoryID
        {
            get { return _TerritoryID; }
            set { _TerritoryID = value; }
        }
    }


    public class CustomerTerritoryListCollec : CollectionBase
    {
        public void Add(CustomerTerritoryList objActIns)
        {
            this.InnerList.Add(objActIns);
        }
    }
}
