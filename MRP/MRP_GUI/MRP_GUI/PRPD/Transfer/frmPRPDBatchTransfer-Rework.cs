using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SESD.MRP.DL;
using SESD.MRP.REF;

namespace MRP_GUI
{
    public partial class frmPRPDBatchTransfer_Rework : System.Windows.Forms.Form
    {
        Department_DL objDepartment_DL = new Department_DL(ConnectionStringClass.GetConnection());
        MTN_DL objMTN_DL = new MTN_DL(ConnectionStringClass.GetConnection());
        Material_DL objMaterial_DL = new Material_DL(ConnectionStringClass.GetConnection());
        Employee_DL objEmployee_DL = new Employee_DL(ConnectionStringClass.GetConnection());
        MTNMaterial_DL objMTNMaterial_DL = new MTNMaterial_DL(ConnectionStringClass.GetConnection());
        Store_DL objStore_DL = new Store_DL(ConnectionStringClass.GetConnection());
        PRPDBatchActivityInstructions_DL objPRPDBatchActivityInstructions_DL = new PRPDBatchActivityInstructions_DL(ConnectionStringClass.GetConnection());

        
        PRPDBatch_DL objPRPDBatch_DL = new PRPDBatch_DL(ConnectionStringClass.GetConnection());
        PRPDBatchActivity_DL objPRPDBatchActivity_DL = new PRPDBatchActivity_DL(ConnectionStringClass.GetConnection());

        PRPDBatchCollec objPRPDBatchCollec = new PRPDBatchCollec();

        BindingSource objBindingSourceBatchDetails = new BindingSource();
        //BindingSource objBindingSourceActivities = new BindingSource();

        PRPDBatch objPRPDBatch = new PRPDBatch();

        DataTable dtPRPDBatchCollec = new DataTable();
        DataTable dtPRPDBatchCollecTransfered = new DataTable();
        private Label label11;
        private Label label10;
        private TextBox txtAfterReworkQty;
        private TextBox txtStopDate;
        private TextBox txtStartDate;
        private TextBox txtInstructedBy;
        private GroupBox groupBox4;
        private DataGridView dgvActivities;
        private DataGridViewTextBoxColumn ActivityName;
        private BindingSource objBindingSourceActivities;
        private IContainer components;
        private Label label9;
        private Button btnExit;
        private Button btnTransfer;
        private Label label13;
        private Label label12;
        private TextBox txtPRPDBatchQty;
        private Label label8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private TextBox txtMaterialCode;
        private Label label7;
        private TextBox txtBatchState;
        private Label label6;
        private Label label5;
        private ComboBox cmbPRPDBatch;
        private TextBox txtAddedUnitCost;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private TextBox txtMaterialName;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private Label label4;
        private GroupBox groupBox2;
        private TextBox txtDescription;
        private TextBox txtSupplierName;
        private TextBox txtPONo;
        private Label label3;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private Label label14;
        private GroupBox groupBox3;
        private GroupBox groupBox1;
        DataTable dtPRPDBatchActivity = new DataTable();

        public frmPRPDBatchTransfer_Rework()
        {
            InitializeComponent();
        }

        public frmPRPDBatchTransfer_Rework(User objUser)
        {

            InitializeComponent();
            CurrentUser = objUser;
        }


        private User _objCurrentUser;

        public User CurrentUser
        {
            get { return _objCurrentUser; }
            set { _objCurrentUser = value; }
        }



     

        private void frmPRPDRework_Load(object sender, EventArgs e)
        {
            try
            {
                dtPRPDBatchCollec = objPRPDBatch_DL.GetDataByState(PRPDBatch.PRPDBatchStatus.Cost, PRPDBatch.PRPDType.Rework);
                cmbPRPDBatch.DataSource = dtPRPDBatchCollec;
              
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }

            
        }

      
        private void btnSaveTransfer_Click(object sender, EventArgs e)
        {

        }

 

        private void txtMaterialCode_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (txtMaterialCode.Text.Equals(""))
            //    {
            //                      txtMaterialName.Text = ((Material)objMaterial_DL.Get(txtMaterialCode.Text)).MaterialDescription;
  
            //    }
            //}
            //catch (Exception ex)
            //{
                
            //   MessageBox.Show(ex.Message.ToString());
            //}
        }

        private void cmbPRPDBatch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        public void Clear()
        {

          
            objBindingSourceActivities.DataSource = null;
            objBindingSourceActivities.ResetBindings(false);

            txtBatchState.Text ="";
            txtPONo.Text = "";
            txtSupplierName.Text = "";
            
            txtMaterialName.Text = "";
            txtMaterialCode.Text = "";
            txtPRPDBatchQty.Text = "";
            txtInstructedBy.Text = "";
            txtAddedUnitCost.Text = "";

            txtAfterReworkQty.Text = "";
            txtDescription.Text = "";
            objBindingSourceActivities.DataSource = null;
            try
            {
                dtPRPDBatchCollec = objPRPDBatch_DL.GetDataByState(PRPDBatch.PRPDBatchStatus.Finished, PRPDBatch.PRPDType.Rework);
                cmbPRPDBatch.DataSource = dtPRPDBatchCollec;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAfterReworkQty = new System.Windows.Forms.TextBox();
            this.txtStopDate = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtInstructedBy = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvActivities = new System.Windows.Forms.DataGridView();
            this.ActivityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objBindingSourceActivities = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPRPDBatchQty = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaterialCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBatchState = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPRPDBatch = new System.Windows.Forms.ComboBox();
            this.txtAddedUnitCost = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaterialName = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.txtPONo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objBindingSourceActivities)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(54, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Description";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Unit Cost(Rs.)";
            // 
            // txtAfterReworkQty
            // 
            this.txtAfterReworkQty.BackColor = System.Drawing.SystemColors.Control;
            this.txtAfterReworkQty.Location = new System.Drawing.Point(120, 28);
            this.txtAfterReworkQty.Name = "txtAfterReworkQty";
            this.txtAfterReworkQty.Size = new System.Drawing.Size(192, 20);
            this.txtAfterReworkQty.TabIndex = 35;
            // 
            // txtStopDate
            // 
            this.txtStopDate.BackColor = System.Drawing.SystemColors.Control;
            this.txtStopDate.Enabled = false;
            this.txtStopDate.Location = new System.Drawing.Point(101, 187);
            this.txtStopDate.Name = "txtStopDate";
            this.txtStopDate.Size = new System.Drawing.Size(200, 20);
            this.txtStopDate.TabIndex = 42;
            // 
            // txtStartDate
            // 
            this.txtStartDate.BackColor = System.Drawing.SystemColors.Control;
            this.txtStartDate.Enabled = false;
            this.txtStartDate.Location = new System.Drawing.Point(101, 162);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(200, 20);
            this.txtStartDate.TabIndex = 41;
            // 
            // txtInstructedBy
            // 
            this.txtInstructedBy.Location = new System.Drawing.Point(101, 236);
            this.txtInstructedBy.Name = "txtInstructedBy";
            this.txtInstructedBy.ReadOnly = true;
            this.txtInstructedBy.Size = new System.Drawing.Size(320, 20);
            this.txtInstructedBy.TabIndex = 38;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.dgvActivities);
            this.groupBox4.Location = new System.Drawing.Point(548, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(426, 314);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Processed Activities";
            // 
            // dgvActivities
            // 
            this.dgvActivities.AllowUserToAddRows = false;
            this.dgvActivities.AllowUserToDeleteRows = false;
            this.dgvActivities.AutoGenerateColumns = false;
            this.dgvActivities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ActivityName});
            this.dgvActivities.DataSource = this.objBindingSourceActivities;
            this.dgvActivities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvActivities.Location = new System.Drawing.Point(3, 16);
            this.dgvActivities.Name = "dgvActivities";
            this.dgvActivities.ReadOnly = true;
            this.dgvActivities.Size = new System.Drawing.Size(420, 295);
            this.dgvActivities.TabIndex = 0;
            // 
            // ActivityName
            // 
            this.ActivityName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ActivityName.DataPropertyName = "MainActivity";
            this.ActivityName.HeaderText = "ActivityName";
            this.ActivityName.Name = "ActivityName";
            this.ActivityName.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "After Rework Qty.";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(939, 579);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnTransfer
            // 
            this.btnTransfer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.ForeColor = System.Drawing.Color.Maroon;
            this.btnTransfer.Location = new System.Drawing.Point(848, 579);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(85, 23);
            this.btnTransfer.TabIndex = 14;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(308, 217);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "Kg";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 243);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Instructed By";
            // 
            // txtPRPDBatchQty
            // 
            this.txtPRPDBatchQty.BackColor = System.Drawing.SystemColors.Control;
            this.txtPRPDBatchQty.Enabled = false;
            this.txtPRPDBatchQty.Location = new System.Drawing.Point(101, 211);
            this.txtPRPDBatchQty.Name = "txtPRPDBatchQty";
            this.txtPRPDBatchQty.Size = new System.Drawing.Size(200, 20);
            this.txtPRPDBatchQty.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "PRPDBatch Qty";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PRPDBatchID";
            this.dataGridViewTextBoxColumn1.HeaderText = "BatchNo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // txtMaterialCode
            // 
            this.txtMaterialCode.BackColor = System.Drawing.SystemColors.Control;
            this.txtMaterialCode.Enabled = false;
            this.txtMaterialCode.Location = new System.Drawing.Point(101, 95);
            this.txtMaterialCode.Name = "txtMaterialCode";
            this.txtMaterialCode.Size = new System.Drawing.Size(154, 20);
            this.txtMaterialCode.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Material ";
            // 
            // txtBatchState
            // 
            this.txtBatchState.BackColor = System.Drawing.SystemColors.Control;
            this.txtBatchState.Enabled = false;
            this.txtBatchState.Location = new System.Drawing.Point(101, 45);
            this.txtBatchState.Name = "txtBatchState";
            this.txtBatchState.Size = new System.Drawing.Size(264, 20);
            this.txtBatchState.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Batch End Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-7, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Batch Started Date";
            // 
            // cmbPRPDBatch
            // 
            this.cmbPRPDBatch.DisplayMember = "PRPDBatchID";
            this.cmbPRPDBatch.FormattingEnabled = true;
            this.cmbPRPDBatch.Location = new System.Drawing.Point(101, 19);
            this.cmbPRPDBatch.Name = "cmbPRPDBatch";
            this.cmbPRPDBatch.Size = new System.Drawing.Size(264, 21);
            this.cmbPRPDBatch.TabIndex = 24;
            this.cmbPRPDBatch.ValueMember = "PRPDBatchID";
            // 
            // txtAddedUnitCost
            // 
            this.txtAddedUnitCost.BackColor = System.Drawing.SystemColors.Control;
            this.txtAddedUnitCost.Location = new System.Drawing.Point(120, 50);
            this.txtAddedUnitCost.Name = "txtAddedUnitCost";
            this.txtAddedUnitCost.Size = new System.Drawing.Size(192, 20);
            this.txtAddedUnitCost.TabIndex = 37;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Item";
            this.dataGridViewTextBoxColumn2.HeaderText = "Item Code";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Gross";
            this.dataGridViewTextBoxColumn3.HeaderText = "Gross Received Qty";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Unit";
            this.dataGridViewTextBoxColumn4.HeaderText = "Unit";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "After";
            this.dataGridViewTextBoxColumn5.HeaderText = "After Rework Qty";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Added";
            this.dataGridViewTextBoxColumn6.HeaderText = "Added Cost per Unit";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // txtMaterialName
            // 
            this.txtMaterialName.BackColor = System.Drawing.SystemColors.Control;
            this.txtMaterialName.Enabled = false;
            this.txtMaterialName.Location = new System.Drawing.Point(255, 95);
            this.txtMaterialName.Name = "txtMaterialName";
            this.txtMaterialName.Size = new System.Drawing.Size(273, 20);
            this.txtMaterialName.TabIndex = 31;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Comments";
            this.dataGridViewTextBoxColumn8.HeaderText = "Description";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Batch No";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtAddedUnitCost);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtAfterReworkQty);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(12, 394);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1002, 179);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rework Details";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.Control;
            this.txtDescription.Location = new System.Drawing.Point(120, 72);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(507, 89);
            this.txtDescription.TabIndex = 39;
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.BackColor = System.Drawing.SystemColors.Control;
            this.txtSupplierName.Enabled = false;
            this.txtSupplierName.Location = new System.Drawing.Point(101, 120);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(427, 20);
            this.txtSupplierName.TabIndex = 22;
            // 
            // txtPONo
            // 
            this.txtPONo.BackColor = System.Drawing.SystemColors.Control;
            this.txtPONo.Enabled = false;
            this.txtPONo.Location = new System.Drawing.Point(101, 70);
            this.txtPONo.Name = "txtPONo";
            this.txtPONo.Size = new System.Drawing.Size(264, 20);
            this.txtPONo.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Supplier Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "PO No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Batch State";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Desc";
            this.dataGridViewTextBoxColumn7.HeaderText = "Description";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(139, 17);
            this.label14.TabIndex = 47;
            this.label14.Text = "Rework - Transfer";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtStopDate);
            this.groupBox3.Controls.Add(this.txtStartDate);
            this.groupBox3.Controls.Add(this.txtInstructedBy);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtPRPDBatchQty);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtMaterialCode);
            this.groupBox3.Controls.Add(this.txtMaterialName);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtBatchState);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cmbPRPDBatch);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtSupplierName);
            this.groupBox3.Controls.Add(this.txtPONo);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1002, 331);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rework Batch Details";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnTransfer);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1020, 608);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transfer Details";
            // 
            // frmPRPDBatchTransfer_Rework
            // 
            this.ClientSize = new System.Drawing.Size(1020, 608);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPRPDBatchTransfer_Rework";
            this.Text = "PRPD Batch Transfer - Rework";
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objBindingSourceActivities)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }


    }
}