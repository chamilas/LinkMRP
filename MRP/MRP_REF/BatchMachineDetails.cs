using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class BatchMachineDetails
    {   

        private long _machineRecID;

        public long MachineRecID
        {
            get { return _machineRecID; }
            set { _machineRecID = value; }
        }
	

        private BatchActivity _objBatchAct;

        public BatchActivity BatchAct
        {
            get { return _objBatchAct; }
            set { _objBatchAct = value; }
        }


        private Machine _objMachine;

        public Machine TheMachine
        {
            get { return _objMachine; }
            set { _objMachine = value; }
        }

        private string _StartTime;

        public string StartTime
        {
            get { return _StartTime; }
            set { _StartTime = value; }
        }


        private string _StopTime;

        public string StopTime
        {
            get { return _StopTime; }
            set { _StopTime = value; }
        }


        private Decimal _HourlyRate;

        public Decimal HourlyRate
        {
            get { return _HourlyRate; }
            set { _HourlyRate = value; }
        }
	
    }

    public class BatchMachineDetailsCollec : CollectionBase
    {
        public void Add(BatchMachineDetails objBatchMachineDetails)
        {
            this.InnerList.Add(objBatchMachineDetails);
        }
    }
}
