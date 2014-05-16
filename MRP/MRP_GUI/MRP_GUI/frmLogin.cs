using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SESD.MRP.BL;
using SESD.MRP.REF;
using DL;

namespace MRP_GUI
{
    public partial class frmLogin : System.Windows.Forms.Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User objUser = new User();
            User_BL objUserBL = new User_BL(ConnectionStringClass.GetConnection());

            try
            {
                
                    objUser = objUserBL.Login(txtUserName.Text, txtPassword.Text);
               

                if (objUser.UserID == 0)
                {
                    MessageBox.Show(this, "Invalid User Name or Password,Contact System Administrator for more information", "Incorrect User Name or Password", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    if (objUser.LastLoggedIn.ToString() == "1/1/0001 12:00:00 AM")
                    {
                        frmChangePassword objFrm = new frmChangePassword(objUser, 0);
                        //Production.BatchFile.frmBatchFile objFrm = new MRP_GUI.Production.BatchFile.frmBatchFile(objUser);
                        objFrm.Show();
                        this.Hide();
                    }
                    else
                    {
                        User_DL objUser_DL = new User_DL(ConnectionStringClass.GetConnection());
                        int y = objUser_DL.CheckForPasswordExpiry(objUser);

                        if (y == 1)
                        {
                            frmChangePassword objFrm = new frmChangePassword(objUser, 0);
                            //Production.BatchFile.frmBatchFile objFrm = new MRP_GUI.Production.BatchFile.frmBatchFile(objUser);
                            objFrm.Show();
                            this.Hide();
                        }
                        else
                        {
                            if (objUser.Online == true)
                            {
                                MessageBox.Show(this, "This User has already Logged-In. Please Contact System Administrator", "Already Logged-In", MessageBoxButtons.OK);
                            }
                            else
                            {
                                MRP_Main objFrm = new MRP_Main(objUser);
                                //Production.BatchFile.frmBatchFile objFrm = new MRP_GUI.Production.BatchFile.frmBatchFile(objUser);
                                objFrm.Show();
                                this.Hide();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(this,"Database error, " + ex.Message, "Logging Failure",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }


        }


        private void frmLogin_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //frmAdmin objfrm = new frmAdmin();
            
            //objfrm.Show(this);
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
                txtPassword.SelectAll();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
            txtUserName.SelectAll();
            
           
        }
    }
}