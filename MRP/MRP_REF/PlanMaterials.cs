using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class PlanMaterials
    {

        private Int32 _intYear;

        public Int32 Year
        {
            get { return _intYear; }
            set { _intYear = value; }
        }


        private string _strMonth;

        public string Month
        {
            get { return _strMonth; }
            set { _strMonth = value; }
        }



        private Int32 _intWeekID;

        public Int32 WeekID
        {
            get { return _intWeekID; }
            set { _intWeekID = value; }
        }


        private Int32 _intRevisionID;

        public Int32 RevisionID
        {
            get { return _intRevisionID; }
            set { _intRevisionID = value; }
        }


        private string _MaterialCode;

        public string MaterialCode
        {
            get { return _MaterialCode; }
            set { _MaterialCode = value; }
        }


        private decimal _Qty;

        public decimal Qty
        {
            get { return _Qty; }
            set { _Qty = value; }
        }


        private string _Type;

        public string Type
        {
            get { return _Type; }
            set { _Type = value; }
        }



    }


    public class PlanMaterialCollec : CollectionBase
    {
        public void Add(PlanMaterials objPlanMaterials)
        {
            this.InnerList.Add(objPlanMaterials);
        }
    }
}
