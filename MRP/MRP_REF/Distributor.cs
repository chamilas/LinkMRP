using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    class Distributor
    {

        private String _strDistributorID;

        public String DistributorID
        {
            get { return _strDistributorID; }
            set { _strDistributorID = value; }
        }

        private String _strDistributorName;

        public String DistributorName
        {
            get { return _strDistributorName; }
            set { _strDistributorName = value; }
        }


        private Int32 _intTerritoryID;

        public Int32 TerritoryID
        {
            get { return _intTerritoryID; }
            set { _intTerritoryID = value; }
        }


    }

    //public class DistributorCollec : CollectionBase
    //{
    //    public void Add(Distributor objDistributor)
    //    {
    //        this.InnerList.Add(objDistributor);
    //    }
    //}
}
