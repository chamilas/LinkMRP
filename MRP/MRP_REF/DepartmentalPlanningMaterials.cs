using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
   public class DepartmentalPlanningMaterials
    {

        private int _MonthlyDeptPlanningID;

        public int MonthlyDeptPlanningID
        {
            get { return _MonthlyDeptPlanningID; }
            set { _MonthlyDeptPlanningID = value; }
        }

    
        private int _WeekID;

        public int WeekID
        {
            get { return _WeekID; }
            set { _WeekID = value; }
        }
        private string _MaterialCode;

        public string MaterialCode
        {
            get { return _MaterialCode; }
            set { _MaterialCode = value; }
        }

        private string _MaterialName;

        public string MaterialName
        {
            get { return _MaterialName; }
            set { _MaterialName = value; }
        }

        private string _MaterialType;

        public string MaterialType
        {
            get { return _MaterialType; }
            set { _MaterialType = value; }
        }



        private decimal _RequiredQty;

        public decimal RequiredQty
        {
            get { return _RequiredQty; }
            set { _RequiredQty = value; }
        }

        private string _UnitCode;

        public string UnitCode
        {
            get { return _UnitCode; }
            set { _UnitCode = value; }
        }

        public class DepartmentalPlanningMaterialsCollec : CollectionBase
        {
            public void Add(DepartmentalPlanningMaterials objDepartmentalPlanningMaterials)
            {
                this.InnerList.Add(objDepartmentalPlanningMaterials);
            }
        }



    
    }
}
