using DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MRP_GUI.Sales
{
    public partial class frmRegisterProject : Form
    {
        private Department_DL objDepartment_DL = new Department_DL(ConnectionStringClass.GetConnection());
        private Projects_DL objProjects_DL = new Projects_DL(ConnectionStringClass.GetConnection());


        public frmRegisterProject()
        {
            InitializeComponent();
            LoadDeparment();
            LoadDGVProjects();
        }

        private void LoadDeparment() 
        {
            bsDepList.DataSource = objDepartment_DL.GetDataView();
            cmbDepartment.DataSource = bsDepList;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrWhiteSpace(txtProName.Text))
            {
                objProjects_DL.Add(txtProName.Text, ((DataRowView)this.bsDepList.Current).Row["DepID"].ToString(), cmbProType.Text);
                MessageBox.Show(this, "Record successfully added", "successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            else 
            {
                MessageBox.Show(this, "Please Fill Project Name Field", "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        }

        private void LoadDGVProjects()
        {
            //objProjectMaterial.ProjectID = Convert.ToInt32(((DataRowView)this.bsProjets.Current).Row["ProjectID"].ToString());
            dgvProjects.AutoGenerateColumns = false;
            bsDGVProjects.DataSource = objProjects_DL.GetProjects();
            dgvProjects.DataSource = bsDGVProjects;
            bsDGVProjects.ResetBindings(true);
        }

        private void Clear() 
        {
            txtProName.Text = "";
        }
    }
}
