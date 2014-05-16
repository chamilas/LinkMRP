using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DL;
using SESD.MRP.REF;

namespace MRP_GUI.Production
{
    public partial class frmMultipleLabour_PRPD : System.Windows.Forms.Form
    {
        public frmMultipleLabour_PRPD(PRPDBatchActivity obj,int _SectionID)
        {
            InitializeComponent();
            objPRPDBatchActivity = obj;
            SectionID = _SectionID;
        }

        Section_DL objSection_DL = new Section_DL(ConnectionStringClass.GetConnection());
        Employee_DL objEmployee_DL = new Employee_DL(ConnectionStringClass.GetConnection());
        PRPDActivityDetailsLabour_DL objPRPDActivityDetailsLabour_DL = new PRPDActivityDetailsLabour_DL(ConnectionStringClass.GetConnection());

        PRPDBatchActivity objPRPDBatchActivity = new PRPDBatchActivity();
        int SectionID = 0;

        private void frmMultipleLabour_Load(object sender, EventArgs e)
        {
            try
            {
                if (SectionID != 0)
                {
                    DataTable dt = objEmployee_DL.Get_Workers_BySection(SectionID);

                    objSourceEmp.DataSource = dt;
                    dgvEmployeeList.AutoGenerateColumns = false;
                    dgvEmployeeList.DataSource = objSourceEmp;
                    objSourceEmp.ResetBindings(true);



                     
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTo.Select();
            }
        }

        private void txtTo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtOT.Select();
            }
        }

        private void txtOT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtOTMinutes.Select();
            }
        }

        private void Clear_Labour()
        {
            txtFrom.Text = "";
            txtTo.Text = "";
            txtOT.Text = "";
            txtOTMinutes.Text = "";
        }


        private void txtOTMinutes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (objPRPDBatchActivity.State == PRPDBatchActivity.ActStatus.Finished)
                    {
                        MessageBox.Show(this, "Activity is already Finished", "Wrong Attempt", MessageBoxButtons.OK);

                        Clear_Labour();
                    }
                    else
                    {
                        try
                        {

                            Decimal OTHours = 0;
                            Decimal OTMinutes = 0;

                            if (txtOT.Text != "")
                            {
                                OTHours = Convert.ToDecimal(txtOT.Text);
                            }
                            if (txtOTMinutes.Text != "")
                            {
                                OTMinutes = Convert.ToDecimal(txtOTMinutes.Text);
                            }

                            PRPDActivityDetailsLabour obj = new PRPDActivityDetailsLabour();


                            obj.PRPDBatchActivityDetails = objPRPDBatchActivity.PRPDBatchActivityID;
                            
                            obj.OTHours = Calculate.CalOTHours(OTHours, OTMinutes);
                            obj.StartTime = txtFrom.Text;
                            obj.StopTime = txtTo.Text;
                            obj.Remarks = "No";

                            int count=0;


                                for (int i = 0; i < dgvEmployeeList.Rows.Count; i++)
                                {
                                    if (Convert.ToBoolean(dgvEmployeeList.Rows[i].Cells["Select"].Value) == true)
                                    {
                                        obj.Helper = objEmployee_DL.Get(dgvEmployeeList.Rows[i].Cells["EmpID"].Value.ToString());
                                        count++;

                                        objPRPDActivityDetailsLabour_DL.Add(obj);

                                    }
                                }

                            Clear_Labour();

                            this.Close();


                        }
                        catch (Exception)
                        {

                            MessageBox.Show(this, "Error occured while loading Labour Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                }
            }
        }
    }
}
