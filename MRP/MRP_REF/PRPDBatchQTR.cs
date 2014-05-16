using System;
using System.Collections.Generic;
using System.Text;

namespace SESD.MRP.REF
{
   public class PRPDBatchQTR
    {

        private long _TestID;

        public long TestID
        {
            get { return _TestID; }
            set { _TestID = value; }
        }

        private String _PRPDBatchID;

        public String PRPDBatchID
        {
            get { return _PRPDBatchID; }
            set { _PRPDBatchID = value; }
        }


        private String _SandContent;

        public String SandContent
        {
            get { return _SandContent; }
            set { _SandContent = value; }
        }

        private String _ForiegnMatter;

        public String ForiegnMatter
        {
            get { return _ForiegnMatter; }
            set { _ForiegnMatter = value; }
        }


        private String _MoistureContent;

        public String MoistureContent
        {
            get { return _MoistureContent; }
            set { _MoistureContent = value; }
        }


        private String _AnalyzedBy;

        public String AnalyzedBy
        {
            get { return _AnalyzedBy; }
            set { _AnalyzedBy = value; }
        }


        private String _RDQAOfficer;

        public String RDQAOfficer
        {
            get { return _RDQAOfficer; }
            set { _RDQAOfficer = value; }
        }


        private DateTime _Date;

        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }

        private String _SampleSize;

        public String SampleSize
        {
            get { return _SampleSize; }
            set { _SampleSize = value; }
        }

        private bool _Acceptance;

       public bool Acceptance
        {
            get { return _Acceptance; }
            set { _Acceptance = value; }
        }

        private String _SandContentState;

        public String SandContentState
        {
            get { return _SandContentState; }
            set { _SandContentState = value; }
        }

        private String _ForiegnMatterState;

        public String ForiegnMatterState
        {
            get { return _ForiegnMatterState; }
            set { _ForiegnMatterState = value; }
        }

        private String _MoistureContentState;

        public String MoistureContentState
        {
            get { return _MoistureContentState; }
            set { _MoistureContentState = value; }
        }

        private String _Remarks;

        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        private String _Status;

        public String Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
	
    }


}
