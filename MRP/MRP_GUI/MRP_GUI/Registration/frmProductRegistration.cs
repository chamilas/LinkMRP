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
    public partial class frmProductRegistration : Form
    {
        public frmProductRegistration()
        {
            InitializeComponent();
        }

        private void frmProductRegistration_Load(object sender, EventArgs e)
        {
            usProductInsert1.Initialize(ConnectionStringClass.GetConnection());
            usProductInsert1.ProductLoad();
        }
    }
}