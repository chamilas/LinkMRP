using System;
using System.Collections.Generic;
using System.Text;
using SESD.MRP.REF;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class Section_DL
    {

        SqlConnection Connection = new SqlConnection();

        public Section_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }

        public long Add(Sections obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@SectionName", obj.SectionName),
                new SqlParameter("@DepID", obj.DepID),
                new SqlParameter("@SuperviserID", obj.SectionHead.EmployeeID)};

                return Execute.RunSP_RowsEffected(Connection, "SPADD_Section", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Delete(long SectionID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Original_SectionID", SectionID)};

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_Section", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public SectionsCollec Get()
        {
            Employee_DL objEmployee_DL = new Employee_DL(Connection);

            SectionsCollec objSectionsCollec = new SectionsCollec();

            try
            {


                DataTable dt= Execute.RunSP_DataTable(Connection, "SPGET_Section");

                
                for(int i=0;i<dt.Rows.Count;i++)
                {
                Sections objSections = new Sections();


                objSections.DepID = Convert.ToInt64(dt.Rows[i]["DepID"]);
                objSections.SectionHead = objEmployee_DL.Get( Convert.ToString(dt.Rows[i]["SuperviserID"]));
                objSections.SectionName = Convert.ToString(dt.Rows[i]["SectionName"]);
                objSections.SectionID = Convert.ToInt64(dt.Rows[i]["SectionID"]);

                objSectionsCollec.Add(objSections);

                }


                return objSectionsCollec;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
               
        }

        public Sections Get(long SectionID)
        {
            Employee_DL objEmployee_DL = new Employee_DL(Connection);

            SectionsCollec objSectionsCollec = new SectionsCollec();

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@SectionID", SectionID)};

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_Section_By_ID",paramList);


               
                    Sections objSections = new Sections();

                    if (dt.Rows.Count > 0)
                    {
                        objSections.DepID = Convert.ToInt64(dt.Rows[0]["DepID"]);
                        objSections.SectionHead = objEmployee_DL.Get(Convert.ToString(dt.Rows[0]["SuperviserID"]));
                        objSections.SectionName = Convert.ToString(dt.Rows[0]["SectionName"]);
                        objSections.SectionID = Convert.ToInt64(dt.Rows[0]["SectionID"]);
                    }


                    return objSections;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }



        public System.Data.DataTable GetData_ByDepType(string DepType1, string DepType2, string DepType3, string DepType4)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@DepType1", DepType1),
                new SqlParameter("@DepType2", DepType2),
                 new SqlParameter("@DepType3", DepType3),
                new SqlParameter("@DepType4", DepType4)};

                return Execute.RunSP_DataTable(Connection, "SPGET_Section_ByDepType",paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public System.Data.DataTable GetDataView()
        {
            try
            {

                return Execute.RunSP_DataTable(Connection, "SPGET_Section");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public System.Data.DataTable GetDataView(long DepID)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@DepID", DepID)};

                return Execute.RunSP_DataTable(Connection, "SPGET_Section_By_Dep",paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public System.Data.DataTable GetData(String DivisionType)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@DivisionType", DivisionType)};

                return Execute.RunSP_DataTable(Connection, "SPGET_Section_By_DivisionType",paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public System.Data.DataTable GetDataView(String EmpID)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@EmpID", EmpID)};

                return Execute.RunSP_DataTable(Connection, "SPGET_Section_View_Employee");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

    }
}
