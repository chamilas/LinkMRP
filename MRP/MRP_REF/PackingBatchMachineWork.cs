using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class PackingBatchMachineWork
    {
        private long _PackingBatchMachineWorkID;

        public long PackingBatchMachineWorkID
        {
            get { return _PackingBatchMachineWorkID; }
            set { _PackingBatchMachineWorkID = value; }
        }


        private long _PackingBatchActID;

        public long PackingBatchActID
        {
            get { return _PackingBatchActID; }
            set { _PackingBatchActID = value; }
        }

        private String _MachineID;

        public String MachineID
        {
            get { return _MachineID; }
            set { _MachineID = value; }
        }

        private DateTime _Date;

        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }

        private DateTime _StartTime;

        public DateTime StartTime
        {
            get { return _StartTime; }
            set { _StartTime = value; }
        }

        private DateTime _StopTime;

        public DateTime StopTime
        {
            get { return _StopTime; }
            set { _StopTime = value; }
        }

        private String _SupBy;

        public String SupBy
        {
            get { return _SupBy; }
            set { _SupBy = value; }
        }

        private String _Remarks;

        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }
	
    }

    public class PackingBatchMachineWorkCollec : CollectionBase
    {
        public void Add(PackingBatchMachineWork obj)
        {
            this.InnerList.Add(obj);
        }
    }
}
