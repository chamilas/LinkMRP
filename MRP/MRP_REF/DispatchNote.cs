using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
     public class DispatchNote
    {
        private String _strDispatchID;

        public String DispatchID
        {
            get { return _strDispatchID; }
            set { _strDispatchID = value; }
        }

        private String _DistributorID;

        public String DistributorID
        {
            get { return _DistributorID; }
            set { _DistributorID = value; }
        }

        private DateTime _EnteredDate;

        public DateTime EnteredDate
        {
            get { return _EnteredDate; }
            set { _EnteredDate = value; }
        }


        private String _EnteredBy;

        public string EnteredBy
        {
            get { return _EnteredBy; }
            set { _EnteredBy = value; }
        }

        private int _TerritoryID;

        public int TerritoryID
        {
            get { return _TerritoryID; }
            set { _TerritoryID = value; }
        }


    }

     public class DispathcNoteCollec : CollectionBase
     {
         public void Add(DispatchNote objDispatch)
         {
             this.InnerList.Add(objDispatch);
         }
     }
}
