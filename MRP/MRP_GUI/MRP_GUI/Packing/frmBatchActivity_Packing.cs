using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SESD.MRP.REF;
using DL;
using MRP_GUI.Sales;


namespace MRP_GUI
{
    public partial class frmBatchActivity_Packing : System.Windows.Forms.Form
    {
        BatchActivity objBatchActivity = new BatchActivity();
        BatchActivity_DL objBatchActivity_DL = new BatchActivity_DL(ConnectionStringClass.GetConnection());

        public frmBatchActivity_Packing(BatchActivity obj)
        {
            InitializeComponent();
            objBatchActivity = obj;
        }

        private void frmBatchActivity_Load(object sender, EventArgs e)
        {
            try
            {
                txtActivity.Text = objBatchActivity.MainActivity.MainActivityTitle;
                txtFinishedProduct.Text = objBatchActivity.EndProductCode;
                lblUnit.Text = "Nos";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void txtFinalQty_KeyDown(object sender, KeyEventArgs e)
        {

            try
            {

            if (e.KeyCode == Keys.Enter)
            {
                if (DataValidation.IsNumericNumber(txtFinalQty.Text))
                {
                    objBatchActivity.StopQty = Convert.ToInt32(txtFinalQty.Text);

                if (objBatchActivity.MainActivity.MainActivityTitle == "Packing_Secondary")
                {
                    objBatchActivity.BatchActStatus = BatchActivity.Status.SecondaryPacking_Finish;
                }
                else
                {
                    objBatchActivity.BatchActStatus = BatchActivity.Status.Finished;
                }

              long x= objBatchActivity_DL.Update(objBatchActivity);
                }
                else
                {
                    MessageBox.Show(this, "Please Enter a Valid Qty", "Wrong Attempt", MessageBoxButtons.OK);

                }

              this.Close();
              

            }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
