using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
   public class PRPDBatchActivityInstructions
    {




       private long _PRPDBatchActivityInstructionsID;

       public long PRPDBatchActivityInstructionsID
        {
            get { return _PRPDBatchActivityInstructionsID; }
            set { _PRPDBatchActivityInstructionsID = value; }
        }

        private PRPDBatch _prpdBatch;

        public PRPDBatch PRPDBatch
        {
            get { return _prpdBatch; }
            set { _prpdBatch = value; }
        }

        private MainActivity _activity;

        public MainActivity Activity
        {
            get { return _activity; }
            set { _activity = value; }
        }

        private long _activityID;

        public long ActivityID
        {
            get { return _activityID; }
            set { _activityID = value; }
        }

        private string _activityName;

        public string ActivityName
        {
            get 
            {
                _activityName = Activity.MainActivityTitle;
                return _activityName; 
            }

        }


       private Machine _machine;

       public Machine Machine
        {
            get { return _machine; }
            set { _machine = value; }
        }


        private string _machineCode;

        public string MachineCode
        {
            get { return _machineCode; }
            set { _machineCode = value; }
        }

        private string _machineName;

        public string MachineName
        {
            get { return _machineName; }
            set { _machineName = value; }
        }


       private string _ParticleSize;

       public string ParticleSize
        {
            get { return _ParticleSize; }
            set { _ParticleSize = value; }
        }

       private string _InstructionDesc;

       public string InstructionDesc
        {
            get { return _InstructionDesc; }
            set { _InstructionDesc = value; }
        }

       public class PRPDBatchActivityInstructionsCollec : CollectionBase
        {
           public void Add(PRPDBatchActivityInstructions objPRPDBatchActivityInstructions)
            {
                this.InnerList.Add(objPRPDBatchActivityInstructions);
            }

           public void Delete(PRPDBatchActivityInstructions objPRPDBatchActivityInstructions)
            {
                this.InnerList.Remove(objPRPDBatchActivityInstructions);
            }
          
        }
    }
}
