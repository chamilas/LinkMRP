using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class InstructedMachines
    {
        private String _InstructedMachineID;

        public String InstructedMachineID
        {
            get { return _InstructedMachineID; }
            set { _InstructedMachineID = value; }
        }


        private long _BatchActID;

        public long BatchActID
        {
            get { return _BatchActID; }
            set { _BatchActID = value; }
        }

        private Decimal _EstimatedHours;

        public Decimal EstimatedHours
        {
            get { return _EstimatedHours; }
            set { _EstimatedHours = value; }
        }
	
    }

    public class InstructedMachinesCollec : CollectionBase
    {
        public void Add(InstructedMachines obj)
        {
            this.InnerList.Add(obj);
        }
    }
}
