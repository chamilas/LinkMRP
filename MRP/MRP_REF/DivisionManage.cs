using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class DivisionManage
    {

        private long _DivisionID;

        public long DivisionID
        {
            get { return _DivisionID; }
            set { _DivisionID = value; }
        }

        private String _ManagerID;

        public String ManagerID
        {
            get { return _ManagerID; }
            set { _ManagerID = value; }
        }
	
    }

    public class DivisionManageCollec : CollectionBase
    {
        public void Add(DivisionManage obj)
        {
            this.InnerList.Add(obj);
        }
    }

}
