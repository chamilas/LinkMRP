using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class MachineActivity
    {
        private string _MachineID;

        public string MachineID
        {
            get { return _MachineID; }
            set { _MachineID = value; }
        }

        private long _MainActivityID;

        public long MainActivityID
        {
            get { return _MainActivityID; }
            set { _MainActivityID = value; }
        }
    }

    public class MachineActivityCollec : CollectionBase
    {
        public void Add(MachineActivity obj)
        {
            this.InnerList.Add(obj);
        }
    }
}
