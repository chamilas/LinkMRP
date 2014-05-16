using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;


namespace SESD.MRP.REF
{
   public class PRPDActivityDetailsLabour
    {


        private long _lngActivityDetailsLabourID;

        public long ActivityDetailsLabourID
        {
            get { return _lngActivityDetailsLabourID; }
            set { _lngActivityDetailsLabourID = value; }
        }



        private Employee _Helper;

        public Employee Helper
       {
           get { return _Helper; }
           set { _Helper = value; }
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



        private DateTime _dtstartTime_D;
 
        public DateTime StartTime_D
       {
           get { return _dtstartTime_D; }
           set { _dtstartTime_D = value; }
       }




        private DateTime _dtstopTime_D;

        public DateTime StopTime_D
       {
           get { return _dtstopTime_D; }
           set { _dtstopTime_D = value; }
       }


        private decimal _lngOTHours;

        public decimal OTHours
        {
            get { return _lngOTHours; }
            set { _lngOTHours = value; }
        }




        private Decimal _OTRate;

        public Decimal OTRate
        {
            get { return _OTRate; }
            set { _OTRate = value; }
        }




        private Decimal _HourlyRate;

        public Decimal HourlyRate
        {
            get { return _HourlyRate; }
            set { _HourlyRate = value; }
        }




        private string _remarks;

        public string Remarks
        {
            get { return _remarks; }
            set { _remarks = value; }
        }




        private long _objPRPDBatchActivityDetails;

        public long PRPDBatchActivityDetails
        {
            get { return _objPRPDBatchActivityDetails; }
            set { _objPRPDBatchActivityDetails = value; }
        }





       public class PRPDActivityDetailsLabourCollc : CollectionBase
        {
           public void Add(PRPDActivityDetailsLabour objPRPDActivityDetailsLabour)
            {
                this.InnerList.Add(objPRPDActivityDetailsLabour);
            }

           public void Delete(PRPDActivityDetailsLabour objPRPDActivityDetailsLabour)
            {
                this.InnerList.Remove(objPRPDActivityDetailsLabour);
            }

        }
    }
}
