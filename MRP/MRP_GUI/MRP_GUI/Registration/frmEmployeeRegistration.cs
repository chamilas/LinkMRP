using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DL;


namespace MRP_GUI
{
    public partial class frmEmployeeRegistration : Form
    {
        public frmEmployeeRegistration()
        {
            InitializeComponent();
        }

        private void frmEmployeeRegistration_Load(object sender, EventArgs e)
        {
            ucEmployee1.Initialize(ConnectionStringClass.GetConnection());
            ucEmployee1.EmployeeLoad();
        }

        private void ucEmployee1_Load(object sender, EventArgs e)
        {

        }
    }
}