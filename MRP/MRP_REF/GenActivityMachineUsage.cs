using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class GenActivityMachineUsage
    {
        private GeneralActivity _objGenAct;

        public GeneralActivity GeneralActivity
        {
            get { return _objGenAct; }
            set { _objGenAct = value; }
        }

        private Machine _objMachine;

        public Machine Machine
        {
            get { return _objMachine; }
            set { _objMachine = value; }
        }

        private DateTime _lngStart;

        public DateTime MachineStart
        {
            get { return _lngStart; }
            set { _lngStart = value; }
        }

        private DateTime _lngStop;

        public DateTime MachineStop
        {
            get { return _lngStop; }
            set { _lngStop = value; }
        }

        private long _ID;

        public long ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private Decimal _MachineHourlyRate;

        public Decimal MachineHourlyRate
        {
            get { return _MachineHourlyRate; }
            set { _MachineHourlyRate = value; }
        }
	
	}

    public class GenActivityMachineUsageCollec : CollectionBase
    {
        public void Add(GenActivityMachineUsage objGenActivityMachineUsage)
        {
            this.InnerList.Add(objGenActivityMachineUsage);
        }
    }
}
