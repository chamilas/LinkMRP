using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
   public class RPDBatchActivityInstructions
    {
        private long _ID;

        public long ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
	

        private RPDBatch _rpdBatch;

        public RPDBatch RPDBatch
        {
            get { return _rpdBatch; }
            set { _rpdBatch = value; }
        }

        private MainActivity _activity;

        public MainActivity Activity
        {
            get { return _activity; }
            set { _activity = value; }
        }


        private Machine _machine;

        public Machine Machine
        {
            get { return _machine; }
            set { _machine = value; }
        }



        private String _ParticleSize;

        public String ParticleSize
        {
            get { return _ParticleSize; }
            set { _ParticleSize = value; }
        }


        private String _Description;

        public String Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
	

        private string _type;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
    }  
      
    public class RPDBatchActivityInstructionsCollec : CollectionBase
    {
        public void Add(RPDBatchActivityInstructions objRPDBatchActivityInstructions)
        {
            this.InnerList.Add(objRPDBatchActivityInstructions);
        }

        public void Delete(RPDBatchActivityInstructions objRPDBatchActivityInstructions)
        {
            this.InnerList.Remove(objRPDBatchActivityInstructions);
        }
      
    }
}
