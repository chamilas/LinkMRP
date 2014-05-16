using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SESD.MRP.REF;
using SESD.MRP.DL;

namespace MRP_GUI.PRPD.PRPDBatchActivityForms
{
    public partial class frmPRPDActDetails : System.Windows.Forms.Form
    {
        private PRPDBatchActivity_DL objPRPDBatchActivityDL = new PRPDBatchActivity_DL(ConnectionStringClass.GetConnection());
        private Employee_DL objEmployeeDL = new Employee_DL(ConnectionStringClass.GetConnection());
        private MainActivity_DL objMainActivityDL = new MainActivity_DL(ConnectionStringClass.GetConnection());
        private User _CurrentUser;
        private PRPDBatchActivity objPRPDBatchActivity ;
        public User CurrentUser
        {
            get { return _CurrentUser; }
            set { _CurrentUser = value; }
        }
        private PRPDBatch objPRPDBatch = null;
        private PRPDBatchActivityDetails objPRPDBatchActivityDetails;
        private Button btnDelete;
        private Button btnClear;
        private Button btnSave;
        private DataGridView gvDetails;
        private DataGridViewButtonColumn colLabour;
        private DataGridViewButtonColumn colMachine;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn colID;
        private Button btnClose;
        private TextBox txtStartQty;
        private Label lblStopQty;
        private Label lblStartQty;
        private TextBox txtStopQty;
        private Label txtActivity;
        private TextBox txtActComments;
        private Label label1; 
        private PRPDBatchActivityDetails_DL objPRPDBatchActivityDetailsDL = new PRPDBatchActivityDetails_DL(ConnectionStringClass.GetConnection());


        public frmPRPDActDetails(User objUser, PRPDBatchActivity objPRPDBatchAct)
        {
            objPRPDBatchActivity = objPRPDBatchAct;
            CurrentUser = objUser;
            InitializeComponent();


        }



        private void frmPRPDActDetails_Load(object sender, EventArgs e)
        {
            try
            {
                if (objPRPDBatchActivity != null)
                {
                    txtStartQty.Focus();
                    txtStartQty.SelectAll();
                    MainActivity obj = objMainActivityDL.Get(objPRPDBatchActivity.MainActID);
                    txtActComments.Text = objPRPDBatchActivity.Comments;
                    txtActivity.Text = obj.MainActivityTitle;
                    bindDetails.DataSource = objPRPDBatchActivityDetailsDL.GetView(objPRPDBatchActivity.PRPDBatchActivityID);

                    if (obj.Type == MainActivity.LayoutType.Template2)
                    {
                        colMachine.Visible = true;
                    }
                    else
                    {
                        colMachine.Visible = false;
                    }

                    if (objPRPDBatchActivity.State == PRPDBatchActivity.ActStatus.Finished)
                    {
                        btnClear.Enabled = false;
                        btnDelete.Enabled = false;
                        btnSave.Enabled = false; 
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Clear()
        {
            lblStopQty.Visible = false;
           // lblStopTime.Visible = false;

           // dtStopTime.Visible = false;
            txtStopQty.Visible = false;
            txtStopQty.Text = "0.00";
            txtStartQty.Text = "0.00";
           // txtComment.Text = "";
            objPRPDBatchActivityDetails = null;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gvDetails = new System.Windows.Forms.DataGridView();
            this.colLabour = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colMachine = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtStartQty = new System.Windows.Forms.TextBox();
            this.lblStopQty = new System.Windows.Forms.Label();
            this.lblStartQty = new System.Windows.Forms.Label();
            this.txtStopQty = new System.Windows.Forms.TextBox();
            this.txtActivity = new System.Windows.Forms.Label();
            this.txtActComments = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(113, 109);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 63;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(27, 109);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 23);
            this.btnClear.TabIndex = 64;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(191, 109);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 62;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // gvDetails
            // 
            this.gvDetails.AllowUserToAddRows = false;
            this.gvDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLabour,
            this.colMachine,
            this.Column1,
            this.Column2,
            this.colID});
            this.gvDetails.Location = new System.Drawing.Point(18, 138);
            this.gvDetails.Name = "gvDetails";
            this.gvDetails.ReadOnly = true;
            this.gvDetails.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDetails.RowTemplate.Height = 30;
            this.gvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvDetails.Size = new System.Drawing.Size(472, 125);
            this.gvDetails.TabIndex = 59;
            // 
            // colLabour
            // 
            this.colLabour.HeaderText = "Labour";
            this.colLabour.Name = "colLabour";
            this.colLabour.ReadOnly = true;
            this.colLabour.Text = "Labour";
            this.colLabour.UseColumnTextForButtonValue = true;
            this.colLabour.Width = 75;
            // 
            // colMachine
            // 
            this.colMachine.HeaderText = "Machine";
            this.colMachine.Name = "colMachine";
            this.colMachine.ReadOnly = true;
            this.colMachine.Text = "Machine";
            this.colMachine.UseColumnTextForButtonValue = true;
            this.colMachine.Width = 75;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "StartQty";
            this.Column1.HeaderText = "Start Qty";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "StopQty";
            this.Column2.HeaderText = "Stop Qty";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // colID
            // 
            this.colID.DataPropertyName = "PRPDBatchActDetailsID";
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            this.colID.Width = 25;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(415, 269);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 65;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // txtStartQty
            // 
            this.txtStartQty.Location = new System.Drawing.Point(116, 59);
            this.txtStartQty.Name = "txtStartQty";
            this.txtStartQty.Size = new System.Drawing.Size(96, 20);
            this.txtStartQty.TabIndex = 60;
            this.txtStartQty.Text = "0";
            // 
            // lblStopQty
            // 
            this.lblStopQty.AutoSize = true;
            this.lblStopQty.Location = new System.Drawing.Point(58, 88);
            this.lblStopQty.Name = "lblStopQty";
            this.lblStopQty.Size = new System.Drawing.Size(48, 13);
            this.lblStopQty.TabIndex = 67;
            this.lblStopQty.Text = "Stop Qty";
            this.lblStopQty.Visible = false;
            // 
            // lblStartQty
            // 
            this.lblStartQty.AutoSize = true;
            this.lblStartQty.Location = new System.Drawing.Point(35, 62);
            this.lblStartQty.Name = "lblStartQty";
            this.lblStartQty.Size = new System.Drawing.Size(71, 13);
            this.lblStartQty.TabIndex = 66;
            this.lblStartQty.Text = "Start Quantity";
            // 
            // txtStopQty
            // 
            this.txtStopQty.Location = new System.Drawing.Point(116, 85);
            this.txtStopQty.Name = "txtStopQty";
            this.txtStopQty.Size = new System.Drawing.Size(96, 20);
            this.txtStopQty.TabIndex = 61;
            this.txtStopQty.Text = "0";
            this.txtStopQty.Visible = false;
            // 
            // txtActivity
            // 
            this.txtActivity.AutoSize = true;
            this.txtActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActivity.Location = new System.Drawing.Point(15, 15);
            this.txtActivity.Name = "txtActivity";
            this.txtActivity.Size = new System.Drawing.Size(74, 16);
            this.txtActivity.TabIndex = 70;
            this.txtActivity.Text = "<Activity>";
            // 
            // txtActComments
            // 
            this.txtActComments.Location = new System.Drawing.Point(116, 12);
            this.txtActComments.Multiline = true;
            this.txtActComments.Name = "txtActComments";
            this.txtActComments.ReadOnly = true;
            this.txtActComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtActComments.Size = new System.Drawing.Size(218, 19);
            this.txtActComments.TabIndex = 69;
            this.txtActComments.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(379, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 68;
            this.label1.Text = "Activity Details";
            // 
            // frmPRPDActDetails
            // 
            this.ClientSize = new System.Drawing.Size(502, 294);
            this.Controls.Add(this.txtActivity);
            this.Controls.Add(this.txtActComments);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gvDetails);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtStartQty);
            this.Controls.Add(this.lblStopQty);
            this.Controls.Add(this.lblStartQty);
            this.Controls.Add(this.txtStopQty);
            this.Name = "frmPRPDActDetails";
            this.Text = "PRPD Activity Details";
            this.Load += new System.EventHandler(this.frmPRPDActDetails_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.gvDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmPRPDActDetails_Load_1(object sender, EventArgs e)
        {

        }
    }
}