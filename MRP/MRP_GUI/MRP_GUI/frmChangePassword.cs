using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DL;
using SESD.MRP.REF;
using SESD.MRP.BL;

namespace MRP_GUI
{
    public partial class frmChangePassword : System.Windows.Forms.Form
    {
        private User _objCurrentUser;

        public User CurrentUser
        {
            get { return _objCurrentUser; }
            set { _objCurrentUser = value; }
        }
        User_BL objUserBL = new User_BL(ConnectionStringClass.GetConnection());
        User_DL objUser_DL = new User_DL(ConnectionStringClass.GetConnection());

        int Origin;

        public frmChangePassword(User objUser,int _origin)
        {
            InitializeComponent();
            CurrentUser = objUser;
            Origin = _origin;

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirm user wants to close
            switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    CurrentUser.Online = false;
                    objUser_DL.Update_OnlineState(CurrentUser);

                    if (Origin == 0)
                    {
                        Application.Exit();
                    }
                    else
                    {
                        this.Close();
                    }
                    break;

            }
        }
        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            txtEmployeeID.Text = CurrentUser.UserEmp.EmployeeID;
            txtName.Text = CurrentUser.UserEmp.EmployeeName;
            txtUserName.Text = CurrentUser.UserName;
            txtEmpRole.Text = CurrentUser.UserEmp.EmployeeRole.RoleTitle;

            if (CurrentUser.ExpiryDate.ToString() == "1/1/0001 12:00:00 AM")
            {
                txtExpiryDate.Text = "Not Set";
            }
            else
            {
                txtExpiryDate.Text = CurrentUser.ExpiryDate.ToString();
            }

            if (Origin == 1)
            {

            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                User temp = CurrentUser;
                String current = objUserBL.Encrypt(txtCurrentPassword.Text, true);
   
                if (current.Equals(CurrentUser.UserPassword))
                {
                    
                    if (txtNewPassword.Text.Equals(txtRepassword.Text))
                    {
                        if (txtCurrentPassword.Text != txtNewPassword.Text)
                        {
                            temp.UserPassword = objUserBL.Encrypt(txtNewPassword.Text, true);
                            int dd = objUserBL.Update(temp);
                            if (dd > 0)
                            {
                                MessageBox.Show(this, "Successfully changed the Password, You will be asked new password next time you Log to system", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                        else
                        {
                            MessageBox.Show(this, "New Password and the Existing Password is Same", "Use a Different Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else
                    {
                        MessageBox.Show(this,"The passwords you type do not match,Please retype the new password in both boxes.","Change Password",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(this, "The passwords you typed is incorrect,Please retype your current password.", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                txtCurrentPassword.Text = "";
                txtNewPassword.Text = "";
                txtRepassword.Text = "";
            }
            catch (Exception ex)
            {
                
               MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}