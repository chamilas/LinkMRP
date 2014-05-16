using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SESD.MRP.DL;
using SESD.MRP.REF;

namespace MRP_GUI.RPD.RPDBatchActivityForms
{
    public partial class frmAddActivity : System.Windows.Forms.Form
    {
        private RPDBatchActivity_DL objRPDBatchActivityDL = new RPDBatchActivity_DL(ConnectionStringClass.GetConnection());
        private Employee_DL objEmployeeDL = new Employee_DL(ConnectionStringClass.GetConnection());
        private MainActivity_DL objMainActivityDL = new MainActivity_DL(ConnectionStringClass.GetConnection()); 
        private User _CurrentUser;
        private SESD.MRP.REF.RPDBatchActivity objRPDBatchActivity = new SESD.MRP.REF.RPDBatchActivity();
        private GroupBox groupBox3;
        private Button btnSave;
        private Button btnClose;
        private Label label15;
        private TextBox txtComment;
        private ComboBox cmbSupervisedBy;
        private Label label14;
        private ComboBox cmbInstructedBy;
        private Label label13;
        private ComboBox cmbActivity;
        private Label label12;
    
        public User CurrentUser
        {
            get { return _CurrentUser; }
            set { _CurrentUser = value; }
        }
        private RPDBatch objRPDBatch = null;
        public frmAddActivity()
        {
            InitializeComponent();
        }



        public frmAddActivity(User objuser, RPDBatch objRpdbatch)
        {
            objRPDBatch = objRpdbatch;
            CurrentUser = objuser;
            objRPDBatchActivity.RPDBatchActID = 0;
            InitializeComponent();
        }

        public frmAddActivity(User objuser, RPDBatch objRpdbatch,SESD.MRP.REF.RPDBatchActivity objRPDBatchAct)
        {
            objRPDBatch = objRpdbatch;
            CurrentUser = objuser;
            objRPDBatchActivity = objRPDBatchAct;
            InitializeComponent();
            txtComment.Text = objRPDBatchActivity.Comments;
            //cmbInstructedBy.SelectedValue = objRPDBatchActivity.InspectedBy;
            cmbSupervisedBy.SelectedValue = objRPDBatchActivity.SupervisedBy;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddActivity_Load(object sender, EventArgs e)
        {
            try
            {
                cmbActivity.DataSource = objMainActivityDL.Get_Data_RPD_Activity(objRPDBatch.RPDBatchID);
                cmbInstructedBy.DataSource = objEmployeeDL.Get_By_RoleType(EmployeeRole.RoleType.Manager.ToString(),"Production", true);
                cmbSupervisedBy.DataSource = objEmployeeDL.Get_By_RoleType(EmployeeRole.RoleType.Manager.ToString(),EmployeeRole.RoleType.Staff.ToString(),"Production", true);
            }
            catch (Exception)
            {

                MessageBox.Show(this,"Error occured while loading New RPD Batch Activity","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.cmbSupervisedBy = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbInstructedBy = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbActivity = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.btnClose);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtComment);
            this.groupBox3.Controls.Add(this.cmbSupervisedBy);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.cmbInstructedBy);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.cmbActivity);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(512, 190);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add/Edit Activity";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(326, 160);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 44;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(407, 160);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 43;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(28, 76);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 42;
            this.label15.Text = "Comments";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(93, 73);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(389, 81);
            this.txtComment.TabIndex = 41;
            // 
            // cmbSupervisedBy
            // 
            this.cmbSupervisedBy.DisplayMember = "Employee";
            this.cmbSupervisedBy.FormattingEnabled = true;
            this.cmbSupervisedBy.Location = new System.Drawing.Point(93, 46);
            this.cmbSupervisedBy.Name = "cmbSupervisedBy";
            this.cmbSupervisedBy.Size = new System.Drawing.Size(268, 21);
            this.cmbSupervisedBy.TabIndex = 40;
            this.cmbSupervisedBy.ValueMember = "EmpID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 39;
            this.label14.Text = "Supervised By";
            // 
            // cmbInstructedBy
            // 
            this.cmbInstructedBy.DisplayMember = "Employee";
            this.cmbInstructedBy.FormattingEnabled = true;
            this.cmbInstructedBy.Location = new System.Drawing.Point(93, 159);
            this.cmbInstructedBy.Name = "cmbInstructedBy";
            this.cmbInstructedBy.Size = new System.Drawing.Size(81, 21);
            this.cmbInstructedBy.TabIndex = 38;
            this.cmbInstructedBy.ValueMember = "EmpID";
            this.cmbInstructedBy.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 162);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "Inspected By";
            this.label13.Visible = false;
            // 
            // cmbActivity
            // 
            this.cmbActivity.DisplayMember = "MainActivity";
            this.cmbActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActivity.FormattingEnabled = true;
            this.cmbActivity.Location = new System.Drawing.Point(93, 19);
            this.cmbActivity.Name = "cmbActivity";
            this.cmbActivity.Size = new System.Drawing.Size(268, 21);
            this.cmbActivity.TabIndex = 1;
            this.cmbActivity.ValueMember = "MainActID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(42, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Activity";
            // 
            // frmAddActivity
            // 
            this.ClientSize = new System.Drawing.Size(533, 210);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmAddActivity";
            this.Text = "RPD Batch Activity";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}