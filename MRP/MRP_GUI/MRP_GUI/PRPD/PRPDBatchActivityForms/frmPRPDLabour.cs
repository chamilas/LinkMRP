using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SESD.MRP.DL;
using SESD.MRP.REF;

namespace MRP_GUI.PRPD.PRPDBatchActivityForms
{
    public partial class frmPRPDLabour : System.Windows.Forms.Form
    {
        private Employee_DL objEmployeeDL = new Employee_DL(ConnectionStringClass.GetConnection());
        private User _CurrentUser;
        public User CurrentUser
        {
            get { return _CurrentUser; }
            set { _CurrentUser = value; }
        }
        private MainActivity_DL objMainActivityDL = new MainActivity_DL(ConnectionStringClass.GetConnection());
        private PRPDBatchActivityDetails objPRPDBatchActivityDetails = null;
        private PRPDBatchActivityDetails_DL objPRPDBatchActivityDetailsDL = new PRPDBatchActivityDetails_DL(ConnectionStringClass.GetConnection());
        private PRPDActivityDetailsLabour objPRPDActivityDetailsLabour = null;
        private PRPDActivityDetailsLabour_DL objPRPDActivityDetailsLabourDL = new PRPDActivityDetailsLabour_DL(ConnectionStringClass.GetConnection());
        private Machine_DL objMachineDL = new Machine_DL(ConnectionStringClass.GetConnection());
        private PRPDBatchActivity_DL objPRPDBatchActivityDL = new PRPDBatchActivity_DL(ConnectionStringClass.GetConnection());
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn colID;
        private BindingSource bindLabours;
        private IContainer components;
        private Label label4;
        private Label lblActivity;
        private DateTimePicker dtStopDate;
        private Label lblStopDate;
        private Button btnClose;
        private DateTimePicker dtStartDate;
        private Label lblStartDate;
        private Label label5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn Column3;
        private GroupBox groupBox1;
        private TextBox txtNoofRec;
        private Label lblNoofRec;
        private CheckBox cbMultiple;
        private Label lblOT;
        private Button btnClear;
        private Button btnDelete;
        private Button btnSave;
        private TextBox txtOT;
        private TextBox txtDescription;
        private DateTimePicker dtpStopTime;
        private DateTimePicker dtpStartTime;
        private Label lblStopTime;
        private TextBox txtStopQty;
        private Label lblStopQty;
        private Label label34;
        private TextBox txtStartQty;
        private Label label35;
        private DataGridView gvLabours;
        private DataGridViewTextBoxColumn Column1;
        private GroupBox groupBox2;
        private TextBox txtComments;
        private Label label2;
        private TextBox txtID;
        private Label label1;
        private TextBox txtPacketSize;
        private TextBox txtNoofPackets;
        private TextBox txtFinalQty;
        private Section_DL objSectionDL = new Section_DL(ConnectionStringClass.GetConnection());

        public frmPRPDLabour(User objUser, PRPDBatchActivityDetails objPRPDBatchAcDetails)
        {
            this.objPRPDBatchActivityDetails = objPRPDBatchAcDetails;
            CurrentUser = objUser;
            InitializeComponent();
        }

        private void frmPRPDLabour_Load(object sender, EventArgs e)
        {

            try
            {
                if (objPRPDBatchActivityDetails != null)
                {
                    MainActivity obj = objMainActivityDL.Get(objPRPDBatchActivityDetails.PRPDBatchActivity.MainActID);
                    lblActivity.Text = obj.MainActivityTitle;
                    txtID.Text = objPRPDBatchActivityDetails.PRPDBatchActDetailsID.ToString();
                    txtComments.Text = objPRPDBatchActivityDetails.Remarks;
                    bindLabours.DataSource = objPRPDActivityDetailsLabourDL.GetDataView(objPRPDBatchActivityDetails.PRPDBatchActDetailsID);
                    //cmbHelper.DataSource = objEmployeeDL.Get_By_RoleType(EmployeeRole.RoleType.Workforce.ToString(),
                    //"Production",
                    //true);
                    ucEmployeeSelect1.LoadForm(EmployeeRole.RoleType.Workforce.ToString(), "Production");
                    ucEmployeeSelect1.SetDefault(objMainActivityDL.Get(objPRPDBatchActivityDetails.PRPDBatchActivity.MainActID).SectionID);
                    //cmbSection.DataSource = objSectionDL.GetDataView(
                    ucEmployeeSelect1_EmployeeSelectedIndexChanged_1(sender, e);
                    txtStartQty.Focus();
                    txtStartQty.SelectAll();
                }

            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading labor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void ClearForm()
        {
            objPRPDActivityDetailsLabour = null;
            txtDescription.Text = "";
            txtFinalQty.Text = "0.00";
            txtNoofPackets.Text = "0";
            txtOT.Text = "0.00";
            txtPacketSize.Text = "0.00";
            txtStartQty.Text = "0.00";
            txtStopQty.Text = "0.00";
            dtpStartTime.Value = Convert.ToDateTime("7/15/2009 8:00 AM"); ;
            dtpStopTime.Value = Convert.ToDateTime("7/15/2009 5:00 PM"); ;
            btnDelete.Enabled = false;
            ucEmployeeSelect1.Clear();
            bindLabours.DataSource = objPRPDActivityDetailsLabourDL.GetDataView(objPRPDBatchActivityDetails.PRPDBatchActDetailsID);
            dtStopDate.Value = DateTime.Now;
            dtStartDate.Value = DateTime.Now;

            dtStopDate.Visible = false;
            dtpStopTime.Visible = false;
            lblStopDate.Visible = false;
            lblStopTime.Visible = false;

            txtStopQty.Visible = false;
            lblStopQty.Visible = false;

            lblOT.Visible = false;
            txtOT.Visible = false;


            cbMultiple.Visible = false;
            lblNoofRec.Visible = false;
            txtNoofRec.Visible = false;
            txtNoofRec.Text = "0";
            ucEmployeeSelect1_EmployeeSelectedIndexChanged_1(this, new EventArgs());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void gvLabours_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ucEmployeeSelect1_Load(object sender, EventArgs e)
        {

        }

        private void ucEmployeeSelect1_EmployeeSelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    Employee obj = ucEmployeeSelect1.Employee;
            //    if (obj.EmpType.Equals("Outsource"))
            //    {

            //    }
            //}
            //catch (Exception)
            //{

            //    MessageBox.Show(this, "Error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}


        }

        private void ucEmployeeSelect1_EmployeeSelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (ucEmployeeSelect1.Employee != null && ucEmployeeSelect1.Employee.EmpType == "Outsource")
                {
                    cbMultiple.Visible = true;
                    lblNoofRec.Visible = true;
                    txtNoofRec.Visible = true;
                }
                else
                {
                    cbMultiple.Visible = false;
                    lblNoofRec.Visible = false;
                    txtNoofRec.Visible = false;
                }
            }
            catch (Exception)
            {

                MessageBox.Show(this,"Error occured while selecting Employe","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindLabours = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.lblActivity = new System.Windows.Forms.Label();
            this.dtStopDate = new System.Windows.Forms.DateTimePicker();
            this.lblStopDate = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNoofRec = new System.Windows.Forms.TextBox();
            this.lblNoofRec = new System.Windows.Forms.Label();
            this.cbMultiple = new System.Windows.Forms.CheckBox();
            this.lblOT = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtOT = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dtpStopTime = new System.Windows.Forms.DateTimePicker();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.lblStopTime = new System.Windows.Forms.Label();
            this.txtStopQty = new System.Windows.Forms.TextBox();
            this.lblStopQty = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.txtStartQty = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.gvLabours = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPacketSize = new System.Windows.Forms.TextBox();
            this.txtNoofPackets = new System.Windows.Forms.TextBox();
            this.txtFinalQty = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindLabours)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvLabours)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "OTHours";
            this.dataGridViewTextBoxColumn7.HeaderText = "OT Hours";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "StartQty";
            this.Column6.HeaderText = "Start Qty";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "StopQty";
            this.Column7.HeaderText = "Stop Qty";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "OTHours";
            this.Column5.HeaderText = "OT Hours";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ActivityDetailsLabourID";
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(803, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 126;
            this.label4.Text = "Labour Details";
            // 
            // lblActivity
            // 
            this.lblActivity.AutoSize = true;
            this.lblActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivity.Location = new System.Drawing.Point(12, 9);
            this.lblActivity.Name = "lblActivity";
            this.lblActivity.Size = new System.Drawing.Size(74, 16);
            this.lblActivity.TabIndex = 123;
            this.lblActivity.Text = "<Activity>";
            // 
            // dtStopDate
            // 
            this.dtStopDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStopDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStopDate.Location = new System.Drawing.Point(423, 66);
            this.dtStopDate.Name = "dtStopDate";
            this.dtStopDate.Size = new System.Drawing.Size(99, 22);
            this.dtStopDate.TabIndex = 121;
            this.dtStopDate.Visible = false;
            // 
            // lblStopDate
            // 
            this.lblStopDate.AutoSize = true;
            this.lblStopDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStopDate.Location = new System.Drawing.Point(337, 69);
            this.lblStopDate.Name = "lblStopDate";
            this.lblStopDate.Size = new System.Drawing.Size(77, 16);
            this.lblStopDate.TabIndex = 131;
            this.lblStopDate.Text = "Stop Date";
            this.lblStopDate.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(852, 500);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 122;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // dtStartDate
            // 
            this.dtStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStartDate.Location = new System.Drawing.Point(95, 65);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(99, 22);
            this.dtStartDate.TabIndex = 120;
            this.dtStartDate.Visible = false;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(12, 68);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(77, 16);
            this.lblStartDate.TabIndex = 130;
            this.lblStartDate.Text = "Start Date";
            this.lblStartDate.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-3004, -25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(7088, 73);
            this.label5.TabIndex = 132;
            this.label5.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "___________________________________";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Helper";
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Helper";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "StartTime";
            dataGridViewCellStyle1.Format = "HH:mm";
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn2.HeaderText = "Start Time";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "StopTime";
            dataGridViewCellStyle2.Format = "HH:mm";
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn3.HeaderText = "Stop Time";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "StartQty";
            this.dataGridViewTextBoxColumn4.HeaderText = "Start Qty";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "StopQty";
            this.dataGridViewTextBoxColumn5.HeaderText = "Stop Qty";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Remarks";
            this.dataGridViewTextBoxColumn6.HeaderText = "Remarks";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 250;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "StopTime";
            dataGridViewCellStyle3.Format = "HH:mm";
            this.Column4.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column4.HeaderText = "Stop Time";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ActivityDetailsLabourID";
            this.dataGridViewTextBoxColumn8.HeaderText = "ID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "StartTime";
            dataGridViewCellStyle4.Format = "HH:mm";
            this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column3.HeaderText = "Start Time";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNoofRec);
            this.groupBox1.Controls.Add(this.lblNoofRec);
            this.groupBox1.Controls.Add(this.cbMultiple);
            this.groupBox1.Controls.Add(this.lblOT);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtOT);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.dtpStopTime);
            this.groupBox1.Controls.Add(this.dtpStartTime);
            this.groupBox1.Controls.Add(this.lblStopTime);
            this.groupBox1.Controls.Add(this.txtStopQty);
            this.groupBox1.Controls.Add(this.lblStopQty);
            this.groupBox1.Controls.Add(this.label34);
            this.groupBox1.Controls.Add(this.txtStartQty);
            this.groupBox1.Controls.Add(this.label35);
            this.groupBox1.Controls.Add(this.gvLabours);
            this.groupBox1.Location = new System.Drawing.Point(15, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(915, 319);
            this.groupBox1.TabIndex = 124;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Labour Details";
            // 
            // txtNoofRec
            // 
            this.txtNoofRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoofRec.Location = new System.Drawing.Point(340, 123);
            this.txtNoofRec.Name = "txtNoofRec";
            this.txtNoofRec.Size = new System.Drawing.Size(99, 21);
            this.txtNoofRec.TabIndex = 118;
            this.txtNoofRec.Text = "0";
            this.txtNoofRec.Visible = false;
            // 
            // lblNoofRec
            // 
            this.lblNoofRec.AutoSize = true;
            this.lblNoofRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoofRec.Location = new System.Drawing.Point(236, 126);
            this.lblNoofRec.Name = "lblNoofRec";
            this.lblNoofRec.Size = new System.Drawing.Size(98, 15);
            this.lblNoofRec.TabIndex = 117;
            this.lblNoofRec.Text = "No of Records";
            this.lblNoofRec.Visible = false;
            // 
            // cbMultiple
            // 
            this.cbMultiple.AutoSize = true;
            this.cbMultiple.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMultiple.Location = new System.Drawing.Point(80, 131);
            this.cbMultiple.Name = "cbMultiple";
            this.cbMultiple.Size = new System.Drawing.Size(135, 19);
            this.cbMultiple.TabIndex = 116;
            this.cbMultiple.Text = "Multiple Records";
            this.cbMultiple.UseVisualStyleBackColor = true;
            this.cbMultiple.Visible = false;
            // 
            // lblOT
            // 
            this.lblOT.AutoSize = true;
            this.lblOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOT.Location = new System.Drawing.Point(23, 83);
            this.lblOT.Name = "lblOT";
            this.lblOT.Size = new System.Drawing.Size(80, 16);
            this.lblOT.TabIndex = 114;
            this.lblOT.Text = "OT(Hours)";
            this.lblOT.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(834, 126);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Maroon;
            this.btnDelete.Location = new System.Drawing.Point(753, 126);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(584, 126);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtOT
            // 
            this.txtOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOT.Location = new System.Drawing.Point(109, 80);
            this.txtOT.MaxLength = 2;
            this.txtOT.Name = "txtOT";
            this.txtOT.Size = new System.Drawing.Size(99, 22);
            this.txtOT.TabIndex = 7;
            this.txtOT.Text = "0.00";
            this.txtOT.Visible = false;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(462, 18);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(447, 98);
            this.txtDescription.TabIndex = 6;
            // 
            // dtpStopTime
            // 
            this.dtpStopTime.CustomFormat = "HH:mm";
            this.dtpStopTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStopTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStopTime.Location = new System.Drawing.Point(109, 44);
            this.dtpStopTime.Name = "dtpStopTime";
            this.dtpStopTime.ShowUpDown = true;
            this.dtpStopTime.Size = new System.Drawing.Size(99, 22);
            this.dtpStopTime.TabIndex = 5;
            this.dtpStopTime.Value = new System.DateTime(2009, 7, 15, 17, 0, 0, 0);
            this.dtpStopTime.Visible = false;
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.CustomFormat = "HH:mm";
            this.dtpStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(109, 19);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.ShowUpDown = true;
            this.dtpStartTime.Size = new System.Drawing.Size(99, 22);
            this.dtpStartTime.TabIndex = 2;
            this.dtpStartTime.Value = new System.DateTime(2009, 7, 15, 8, 0, 0, 0);
            // 
            // lblStopTime
            // 
            this.lblStopTime.AutoSize = true;
            this.lblStopTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStopTime.Location = new System.Drawing.Point(24, 46);
            this.lblStopTime.Name = "lblStopTime";
            this.lblStopTime.Size = new System.Drawing.Size(79, 16);
            this.lblStopTime.TabIndex = 94;
            this.lblStopTime.Text = "Stop Time";
            this.lblStopTime.Visible = false;
            // 
            // txtStopQty
            // 
            this.txtStopQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStopQty.Location = new System.Drawing.Point(340, 44);
            this.txtStopQty.Name = "txtStopQty";
            this.txtStopQty.Size = new System.Drawing.Size(99, 22);
            this.txtStopQty.TabIndex = 4;
            this.txtStopQty.Text = "0.00";
            this.txtStopQty.Visible = false;
            // 
            // lblStopQty
            // 
            this.lblStopQty.AutoSize = true;
            this.lblStopQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStopQty.Location = new System.Drawing.Point(257, 47);
            this.lblStopQty.Name = "lblStopQty";
            this.lblStopQty.Size = new System.Drawing.Size(67, 16);
            this.lblStopQty.TabIndex = 93;
            this.lblStopQty.Text = "Stop Qty";
            this.lblStopQty.Visible = false;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(24, 21);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(79, 16);
            this.label34.TabIndex = 92;
            this.label34.Text = "Start Time";
            // 
            // txtStartQty
            // 
            this.txtStartQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartQty.Location = new System.Drawing.Point(340, 18);
            this.txtStartQty.Name = "txtStartQty";
            this.txtStartQty.Size = new System.Drawing.Size(99, 22);
            this.txtStartQty.TabIndex = 1;
            this.txtStartQty.Text = "0.00";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(234, 21);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(100, 16);
            this.label35.TabIndex = 91;
            this.label35.Text = "Start Quantity";
            // 
            // gvLabours
            // 
            this.gvLabours.AllowUserToAddRows = false;
            this.gvLabours.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvLabours.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gvLabours.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvLabours.AutoGenerateColumns = false;
            this.gvLabours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvLabours.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column7,
            this.Column5,
            this.colID});
            this.gvLabours.DataSource = this.bindLabours;
            this.gvLabours.Location = new System.Drawing.Point(5, 155);
            this.gvLabours.Name = "gvLabours";
            this.gvLabours.ReadOnly = true;
            this.gvLabours.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvLabours.RowTemplate.Height = 30;
            this.gvLabours.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvLabours.Size = new System.Drawing.Size(904, 158);
            this.gvLabours.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Employee";
            this.Column1.HeaderText = "Helper";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtComments);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(688, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(88, 46);
            this.groupBox2.TabIndex = 133;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Activity Details";
            this.groupBox2.Visible = false;
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(272, 15);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.ReadOnly = true;
            this.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComments.Size = new System.Drawing.Size(370, 22);
            this.txtComments.TabIndex = 3;
            this.txtComments.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            this.label2.Visible = false;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(71, 17);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(114, 20);
            this.txtID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detail ID";
            // 
            // txtPacketSize
            // 
            this.txtPacketSize.Location = new System.Drawing.Point(810, 112);
            this.txtPacketSize.Name = "txtPacketSize";
            this.txtPacketSize.Size = new System.Drawing.Size(93, 20);
            this.txtPacketSize.TabIndex = 136;
            this.txtPacketSize.Text = "0.00";
            this.txtPacketSize.Visible = false;
            // 
            // txtNoofPackets
            // 
            this.txtNoofPackets.Location = new System.Drawing.Point(810, 91);
            this.txtNoofPackets.Name = "txtNoofPackets";
            this.txtNoofPackets.Size = new System.Drawing.Size(93, 20);
            this.txtNoofPackets.TabIndex = 135;
            this.txtNoofPackets.Text = "0";
            this.txtNoofPackets.Visible = false;
            // 
            // txtFinalQty
            // 
            this.txtFinalQty.Location = new System.Drawing.Point(688, 112);
            this.txtFinalQty.Name = "txtFinalQty";
            this.txtFinalQty.Size = new System.Drawing.Size(93, 20);
            this.txtFinalQty.TabIndex = 134;
            this.txtFinalQty.Text = "0.00";
            this.txtFinalQty.Visible = false;
            // 
            // frmPRPDLabour
            // 
            this.ClientSize = new System.Drawing.Size(939, 535);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtPacketSize);
            this.Controls.Add(this.txtNoofPackets);
            this.Controls.Add(this.txtFinalQty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblActivity);
            this.Controls.Add(this.dtStopDate);
            this.Controls.Add(this.lblStopDate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dtStartDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPRPDLabour";
            this.Text = "PRPD Labour";
            ((System.ComponentModel.ISupportInitialize)(this.bindLabours)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvLabours)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNoofPackets_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPacketSize_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFinalQty_TextChanged(object sender, EventArgs e)
        {

        }


    }
}