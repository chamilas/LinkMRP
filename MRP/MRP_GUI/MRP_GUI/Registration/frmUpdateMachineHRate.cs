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
    public partial class frmUpdateMachineHRate : Form
    {
        public frmUpdateMachineHRate()
        {
            InitializeComponent();
        }

        private void frmMachineRegistration_Load(object sender, EventArgs e)
        {
            ucMachine1.Initialize(ConnectionStringClass.GetConnection());
            ucMachine1.MachineLoad();
        }

        private void ucMachine1_Load(object sender, EventArgs e)
        {

        }
    }
}