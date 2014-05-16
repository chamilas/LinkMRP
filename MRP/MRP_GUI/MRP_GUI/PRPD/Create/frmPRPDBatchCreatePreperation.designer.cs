namespace MRP_GUI
{
    partial class frmPRPDBatchCreatePreperation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdbRework = new System.Windows.Forms.RadioButton();
            this.rdbPPOutsource = new System.Windows.Forms.RadioButton();
            this.rdbPP = new System.Windows.Forms.RadioButton();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInstructedBy = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtStore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNewBatchQuantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpActivityInstructions = new System.Windows.Forms.GroupBox();
            this.cmbMachine = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbActivityID = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtInstruction = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvActivityInstructions = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instructions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objSourceMaterial = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpActivityInstructions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivityInstructions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceMaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1004, 614);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Primary Preparation Batch Create";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(808, 585);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 23);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Create Batch";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(917, 585);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.rdbRework);
            this.groupBox4.Controls.Add(this.rdbPPOutsource);
            this.groupBox4.Controls.Add(this.rdbPP);
            this.groupBox4.Controls.Add(this.cmbMaterial);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtInstructedBy);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.lblUnit);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtNewBatchQuantity);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.grpActivityInstructions);
            this.groupBox4.Location = new System.Drawing.Point(12, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(980, 559);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Batch";
            // 
            // rdbRework
            // 
            this.rdbRework.AutoSize = true;
            this.rdbRework.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRework.Location = new System.Drawing.Point(755, 57);
            this.rdbRework.Name = "rdbRework";
            this.rdbRework.Size = new System.Drawing.Size(68, 17);
            this.rdbRework.TabIndex = 44;
            this.rdbRework.TabStop = true;
            this.rdbRework.Text = "Rework";
            this.rdbRework.UseVisualStyleBackColor = true;
            // 
            // rdbPPOutsource
            // 
            this.rdbPPOutsource.AutoSize = true;
            this.rdbPPOutsource.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPPOutsource.Location = new System.Drawing.Point(755, 34);
            this.rdbPPOutsource.Name = "rdbPPOutsource";
            this.rdbPPOutsource.Size = new System.Drawing.Size(205, 17);
            this.rdbPPOutsource.TabIndex = 44;
            this.rdbPPOutsource.TabStop = true;
            this.rdbPPOutsource.Text = "Primary Preparation (Outsource)";
            this.rdbPPOutsource.UseVisualStyleBackColor = true;
            // 
            // rdbPP
            // 
            this.rdbPP.AutoSize = true;
            this.rdbPP.Checked = true;
            this.rdbPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPP.Location = new System.Drawing.Point(755, 14);
            this.rdbPP.Name = "rdbPP";
            this.rdbPP.Size = new System.Drawing.Size(135, 17);
            this.rdbPP.TabIndex = 44;
            this.rdbPP.TabStop = true;
            this.rdbPP.Text = "Primary Preparation";
            this.rdbPP.UseVisualStyleBackColor = true;
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMaterial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMaterial.DisplayMember = "Material";
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(121, 49);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(349, 21);
            this.cmbMaterial.TabIndex = 43;
            this.cmbMaterial.ValueMember = "MaterialCode";
            this.cmbMaterial.SelectedIndexChanged += new System.EventHandler(this.cmbMaterial_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Material";
            // 
            // txtInstructedBy
            // 
            this.txtInstructedBy.Location = new System.Drawing.Point(121, 93);
            this.txtInstructedBy.Name = "txtInstructedBy";
            this.txtInstructedBy.ReadOnly = true;
            this.txtInstructedBy.Size = new System.Drawing.Size(349, 20);
            this.txtInstructedBy.TabIndex = 42;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtStore);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(540, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 50);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select the Store for Requisition";
            this.groupBox2.Visible = false;
            // 
            // txtStore
            // 
            this.txtStore.Location = new System.Drawing.Point(109, 19);
            this.txtStore.Name = "txtStore";
            this.txtStore.ReadOnly = true;
            this.txtStore.Size = new System.Drawing.Size(349, 20);
            this.txtStore.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Store";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(130, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 38;
            this.label3.Text = "[Auto]";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(246, 119);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(32, 13);
            this.lblUnit.TabIndex = 33;
            this.lblUnit.Text = "[Unit]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "New Batch Quantity";
            // 
            // txtNewBatchQuantity
            // 
            this.txtNewBatchQuantity.Location = new System.Drawing.Point(121, 116);
            this.txtNewBatchQuantity.Name = "txtNewBatchQuantity";
            this.txtNewBatchQuantity.Size = new System.Drawing.Size(119, 20);
            this.txtNewBatchQuantity.TabIndex = 27;
            this.txtNewBatchQuantity.Text = "0.00";
            this.txtNewBatchQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewBatchQuantity_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "InstructedBy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "PRPDBatchID";
            // 
            // grpActivityInstructions
            // 
            this.grpActivityInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpActivityInstructions.Controls.Add(this.cmbMachine);
            this.grpActivityInstructions.Controls.Add(this.label11);
            this.grpActivityInstructions.Controls.Add(this.cmbActivityID);
            this.grpActivityInstructions.Controls.Add(this.label7);
            this.grpActivityInstructions.Controls.Add(this.btnDelete);
            this.grpActivityInstructions.Controls.Add(this.btnAdd);
            this.grpActivityInstructions.Controls.Add(this.txtInstruction);
            this.grpActivityInstructions.Controls.Add(this.label9);
            this.grpActivityInstructions.Controls.Add(this.dgvActivityInstructions);
            this.grpActivityInstructions.Location = new System.Drawing.Point(6, 157);
            this.grpActivityInstructions.Name = "grpActivityInstructions";
            this.grpActivityInstructions.Size = new System.Drawing.Size(965, 394);
            this.grpActivityInstructions.TabIndex = 8;
            this.grpActivityInstructions.TabStop = false;
            this.grpActivityInstructions.Text = "Add Instructions";
            // 
            // cmbMachine
            // 
            this.cmbMachine.DisplayMember = "MachineName";
            this.cmbMachine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMachine.FormattingEnabled = true;
            this.cmbMachine.Location = new System.Drawing.Point(101, 47);
            this.cmbMachine.Name = "cmbMachine";
            this.cmbMachine.Size = new System.Drawing.Size(336, 21);
            this.cmbMachine.TabIndex = 24;
            this.cmbMachine.ValueMember = "MachineID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Machine";
            // 
            // cmbActivityID
            // 
            this.cmbActivityID.DisplayMember = "MainActivity";
            this.cmbActivityID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActivityID.FormattingEnabled = true;
            this.cmbActivityID.Location = new System.Drawing.Point(101, 20);
            this.cmbActivityID.Name = "cmbActivityID";
            this.cmbActivityID.Size = new System.Drawing.Size(336, 21);
            this.cmbActivityID.TabIndex = 22;
            this.cmbActivityID.ValueMember = "MainActID";
            this.cmbActivityID.SelectedIndexChanged += new System.EventHandler(this.cmbActivityID_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Activity";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(584, 115);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 23);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(463, 116);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 23);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtInstruction
            // 
            this.txtInstruction.Location = new System.Drawing.Point(101, 74);
            this.txtInstruction.Multiline = true;
            this.txtInstruction.Name = "txtInstruction";
            this.txtInstruction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInstruction.Size = new System.Drawing.Size(336, 65);
            this.txtInstruction.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Instruction";
            // 
            // dgvActivityInstructions
            // 
            this.dgvActivityInstructions.AllowUserToAddRows = false;
            this.dgvActivityInstructions.AllowUserToDeleteRows = false;
            this.dgvActivityInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvActivityInstructions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivityInstructions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.Column1,
            this.Instructions});
            this.dgvActivityInstructions.Location = new System.Drawing.Point(6, 144);
            this.dgvActivityInstructions.Name = "dgvActivityInstructions";
            this.dgvActivityInstructions.ReadOnly = true;
            this.dgvActivityInstructions.RowTemplate.Height = 23;
            this.dgvActivityInstructions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActivityInstructions.Size = new System.Drawing.Size(953, 215);
            this.dgvActivityInstructions.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ActivityName";
            this.dataGridViewTextBoxColumn3.FillWeight = 150F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Activity";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "MachineName";
            this.Column1.HeaderText = "Machine Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Instructions
            // 
            this.Instructions.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Instructions.DataPropertyName = "InstructionDesc";
            this.Instructions.FillWeight = 150F;
            this.Instructions.HeaderText = "Instructions";
            this.Instructions.Name = "Instructions";
            this.Instructions.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ActivityName";
            this.dataGridViewTextBoxColumn1.FillWeight = 150F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Activity";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MachineName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Machine";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // frmPRPDBatchCreatePreperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 614);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPRPDBatchCreatePreperation";
            this.Text = "PRPD Batch Create - Primary Preparation  ";
            this.Load += new System.EventHandler(this.frmPrimaryPreperationBatchCreateIndependent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpActivityInstructions.ResumeLayout(false);
            this.grpActivityInstructions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivityInstructions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceMaterial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNewBatchQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpActivityInstructions;
        private System.Windows.Forms.ComboBox cmbMachine;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbActivityID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtInstruction;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvActivityInstructions;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtStore;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instructions;
        private System.Windows.Forms.TextBox txtInstructedBy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.BindingSource objSourceMaterial;
        private System.Windows.Forms.RadioButton rdbRework;
        private System.Windows.Forms.RadioButton rdbPPOutsource;
        private System.Windows.Forms.RadioButton rdbPP;
       // private MRP_GUI.Components.MaterialSelection.MaterialSelect materialSelect;
    }
}