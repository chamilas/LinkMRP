 using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
   public class PRPDActivityDetailsMachine
    {
       private long _lngActivityDetailsMachineID;

       public long ActivityDetailsMachineID
        {
            get { return _lngActivityDetailsMachineID; }
            set { _lngActivityDetailsMachineID = value; }
        }



       private long _PRPDBatchActDetailsID;

       public long PRPDBatchActDetailsID
        {
            get { return _PRPDBatchActDetailsID; }
            set { _PRPDBatchActDetailsID = value; }
        }



        private string _strMachineCode;

       public string MachineCode
        {
            get { return _strMachineCode; }
            set { _strMachineCode = value; }
        }


       
       private string _strMeshSize;

       public string MeshSize
        {
            get { return _strMeshSize; }
            set { _strMeshSize = value; }
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



       private DateTime _StartTime_D;

       public DateTime StartTime_D
       {
           get { return _StartTime_D; }
           set { _StartTime_D = value; }
       }



       private DateTime _StopTime_D;

       public DateTime StopTime_D
       {
           get { return _StopTime_D; }
           set { _StopTime_D = value; }
       }



        private Decimal _HourlyRate;

        public Decimal HourlyRate
        {
            get { return _HourlyRate; }
            set { _HourlyRate = value; }
        }



        private String _Remarks;

        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }




       public class PRPDActivityDetailsMachineCollc : CollectionBase
        {
           public void Add(PRPDActivityDetailsMachine objPRPDActivityDetailsMachine)
            {
                this.InnerList.Add(objPRPDActivityDetailsMachine);
            }

           public void Delete(PRPDActivityDetailsMachine objPRPDActivityDetailsMachine)
            {
                this.InnerList.Remove(objPRPDActivityDetailsMachine);
            }

        }

    }
}
