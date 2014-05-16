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


namespace MRP_GUI.Production
{
    public partial class frmBatchActivity : System.Windows.Forms.Form
    {
        BatchActivity objBatchActivity = new BatchActivity();
        BatchActivity_DL objBatchActivity_DL = new BatchActivity_DL(ConnectionStringClass.GetConnection());

        public frmBatchActivity(BatchActivity obj)
        {
            InitializeComponent();
            objBatchActivity = obj;
        }

        private void frmBatchActivity_Load(object sender, EventArgs e)
        {
            try
            {
                txtActivity.Text = objBatchActivity.MainActivity.MainActivityTitle;
                lblUnit.Text = "kg";


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
                objBatchActivity.StopQty = Convert.ToDecimal(txtFinalQty.Text);
                objBatchActivity.BatchActStatus = BatchActivity.Status.Finished;

              long x= objBatchActivity_DL.Update(objBatchActivity);

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
