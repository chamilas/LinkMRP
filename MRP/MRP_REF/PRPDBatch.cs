using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class PRPDBatch
    {
        private String _lngPRPDBatchID;

        public String PRPDBatchID
        {
            get { return _lngPRPDBatchID; }
            set { _lngPRPDBatchID = value; }
        }

        private Employee _objPRPDBatchSuperviser;

        public Employee PRPDBatchSuperviser
        {
            get { return _objPRPDBatchSuperviser; }
            set { _objPRPDBatchSuperviser = value; }
        }


        private Material _objPRPDBatchMaterial;

        public Material PRPDBatchMaterial
        {
            get { return _objPRPDBatchMaterial; }
            set { _objPRPDBatchMaterial = value; }
        }

        private string _objPRPDBatchMaterialName;

        public string PRPDBatchMaterialName
        {
            get { return _objPRPDBatchMaterialName; }
            set { _objPRPDBatchMaterialName = value; }
        }

        private decimal _lngQty;

        public decimal PRPDBatchQty
        {
            get { return _lngQty; }
            set { _lngQty = value; }
        }

        private Employee _objInstructedBy;

        public Employee PRPDBatchInstructedBy
        {
            get { return _objInstructedBy; }
            set { _objInstructedBy = value; }
        }

        private DateTime _dtinstructedDate;

        public DateTime PRPDBatchInstructedDate
        {
            get { return _dtinstructedDate; }
            set { _dtinstructedDate = value; }
        }

        private Employee _objStartedBy;

        public Employee PRPDBatchStartedBy
        {
            get { return _objStartedBy; }
            set { _objStartedBy = value; }
        }
        private DateTime _dtstartDate;

        public DateTime PRPDBatchStartDate
        {
            get { return _dtstartDate; }
            set { _dtstartDate = value; }
        }

        private Employee _objApprovedBy;

        public Employee PRPDBatchApprovedBy
        {
            get { return _objApprovedBy; }
            set { _objApprovedBy = value; }
        }
        private DateTime _dtApprovedDate;

        public DateTime PRPDBatchApprovedDate
        {
            get { return _dtApprovedDate; }
            set { _dtApprovedDate = value; }
        }

        private Employee _objEndBy;

        public Employee PRPDBatchEndBy
        {
            get { return _objEndBy; }
            set { _objEndBy = value; }
        }
        private DateTime _dtendDate;

        public DateTime PRPDBatchEndDate
        {
            get { return _dtendDate; }
            set { _dtendDate = value; }
        }

      

        private long _objMTNIN;

        public long PRPDBatchMTNIN
        {
            get { return _objMTNIN; }
            set { _objMTNIN = value; }
        }

        private MTN _objMTNOUT;

        public MTN PRPDBatchMTNOUT
        {
            get { return _objMTNOUT; }
            set { _objMTNOUT = value; }
        }

        
        private long _objMRIN;

        public long MRIN
        {
            get { return _objMRIN; }
            set { _objMRIN = value; }
        }

        private decimal _lngUnitCost;

        public decimal UnitCost
        {
            get { return _lngUnitCost; }
            set { _lngUnitCost = value; }
        }
      

        private Employee _objInspectedBy;

        public Employee PRPDBatchInspectedBy
        {
            get { return _objInspectedBy; }
            set { _objInspectedBy = value; }
        }

        private DateTime _dtInspectedDate;

        public DateTime PRPDBatchInspectedDate
        {
            get { return _dtInspectedDate; }
            set { _dtInspectedDate = value; }
        }

        private Employee _objHandOverBy;

        public Employee PRPDBatchHandOverBy
        {
            get { return _objHandOverBy; }
            set { _objHandOverBy = value; }
        }
        private DateTime _dtHandOverDate;

        public DateTime PRPDBatchHandOverDate
        {
            get { return _dtHandOverDate; }
            set { _dtHandOverDate = value; }
        }
       
        private decimal _lngFinalQty;

        public decimal PRPDBatchFinalQty
        {
            get { return _lngFinalQty; }
            set { _lngFinalQty = value; }
        }

        private string _lngSampleSize;

        public string PRPDSampleSize
        {
            get { return _lngSampleSize; }
            set { _lngSampleSize = value; }
        }

        private string _comments;

        public string PRPDBatchComments
        {
            get { return _comments; }
            set { _comments = value; }
        }

        private decimal _TotalImpurities;

        public decimal PRPDBatchTotalImpurities
        {
            get { return _TotalImpurities; }
            set { _TotalImpurities = value; }
        }

        private decimal _PRPDCAPID;

        public decimal PRPDCAPID
        {
            get { return _PRPDCAPID; }
            set { _PRPDCAPID = value; }
        }

        public enum PRPDBatchStatus
        {
            Created = 0,
            Started=1,
            Approved = 2,
            Finished = 3,
            Transfered=4,
            Cost=5,
            Discarded=6
        
        }

        private PRPDBatchStatus _enumBatchStatus;

        public PRPDBatchStatus Status
        {
            get { return _enumBatchStatus; }
            set { _enumBatchStatus = value; }
        }


        public enum PRPDType : int
        { 
        
            Rework= 0,
            PrimaryPreperation = 1,
            PrimaryOutsource=2
        }

        private PRPDType _Type;

        public PRPDType Type
        {
            get { return _Type; }
            set { _Type = value; }
        }


        private decimal _OutSourceQty;
        
        public decimal OutSourceQty
        {
            get { return _OutSourceQty; }
            set { _OutSourceQty = value; }
        }
    }

    public class PRPDBatchCollec : CollectionBase
    {
        public void Add(PRPDBatch objPRPDBatch)
        {
            this.InnerList.Add(objPRPDBatch);
        }
        public void Delete(PRPDBatch objPRPDBatch)
        {
            this.InnerList.Remove(objPRPDBatch);
        }

    }
}
