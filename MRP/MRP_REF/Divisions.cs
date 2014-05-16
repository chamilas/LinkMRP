using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
   public class Divisions
    {

        private long _DivisionID;

        public long DivisionID
        {
            get { return _DivisionID; }
            set { _DivisionID = value; }
        }

        private String _DivisionName;

        public String DivisionName
        {
            get { return _DivisionName; }
            set { _DivisionName = value; }
        }


        private String _DivisionType;

        public String DivisionType
        {
            get { return _DivisionType; }
            set { _DivisionType = value; }
        }
	

    }

    public class DivisionsCollec : CollectionBase
    {
        public void Add(Divisions objDivisions)
        {
            this.InnerList.Add(objDivisions);
        }

        public void Delete(Divisions objDivisions)
        {
            this.InnerList.Remove(objDivisions);
        }

    }
}
