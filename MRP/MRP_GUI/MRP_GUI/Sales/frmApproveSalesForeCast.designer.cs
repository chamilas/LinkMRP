namespace MRP_GUI.Sales
{
    partial class frmApproveSalesForeCast
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
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinishProdutDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSalesForcast = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeekID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accuracy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RevisionNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnteredBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnteredDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnApprove = new System.Windows.Forms.Button();
            this.bsSalesForecast = new System.Windows.Forms.BindingSource(this.components);
            this.bssalesFrocastProductList = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesForcast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSalesForecast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bssalesFrocastProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductCode,
            this.FinishProdutDescription,
            this.Qty});
            this.dgvProduct.Location = new System.Drawing.Point(12, 231);
            this.dgvProduct.MultiSelect = false;
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(810, 292);
            this.dgvProduct.TabIndex = 10;
            // 
            // ProductCode
            // 
            this.ProductCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductCode.DataPropertyName = "ProductCode";
            this.ProductCode.HeaderText = "Product Code";
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.ReadOnly = true;
            // 
            // FinishProdutDescription
            // 
            this.FinishProdutDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FinishProdutDescription.DataPropertyName = "FinishProdutDescription";
            this.FinishProdutDescription.HeaderText = "Produt Description";
            this.FinishProdutDescription.Name = "FinishProdutDescription";
            this.FinishProdutDescription.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Qty.DataPropertyName = "Qty";
            this.Qty.HeaderText = "Quantity";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // dgvSalesForcast
            // 
            this.dgvSalesForcast.AllowUserToAddRows = false;
            this.dgvSalesForcast.AllowUserToDeleteRows = false;
            this.dgvSalesForcast.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSalesForcast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesForcast.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Year,
            this.Month,
            this.WeekID,
            this.Accuracy,
            this.RevisionNo,
            this.EnteredBy,
            this.EnteredDate});
            this.dgvSalesForcast.Location = new System.Drawing.Point(12, 41);
            this.dgvSalesForcast.MultiSelect = false;
            this.dgvSalesForcast.Name = "dgvSalesForcast";
            this.dgvSalesForcast.ReadOnly = true;
            this.dgvSalesForcast.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalesForcast.Size = new System.Drawing.Size(810, 184);
            this.dgvSalesForcast.TabIndex = 11;
            this.dgvSalesForcast.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesForcast_CellClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Year
            // 
            this.Year.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Year.DataPropertyName = "Year";
            this.Year.HeaderText = "Year";
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            // 
            // Month
            // 
            this.Month.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Month.DataPropertyName = "Month";
            this.Month.HeaderText = "Month";
            this.Month.Name = "Month";
            this.Month.ReadOnly = true;
            // 
            // WeekID
            // 
            this.WeekID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WeekID.DataPropertyName = "WeekID";
            this.WeekID.HeaderText = "Week";
            this.WeekID.Name = "WeekID";
            this.WeekID.ReadOnly = true;
            // 
            // Accuracy
            // 
            this.Accuracy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Accuracy.DataPropertyName = "Accuracy";
            this.Accuracy.HeaderText = "Accuracy";
            this.Accuracy.Name = "Accuracy";
            this.Accuracy.ReadOnly = true;
            // 
            // RevisionNo
            // 
            this.RevisionNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RevisionNo.DataPropertyName = "RevisionNo";
            this.RevisionNo.HeaderText = "Revision No";
            this.RevisionNo.Name = "RevisionNo";
            this.RevisionNo.ReadOnly = true;
            // 
            // EnteredBy
            // 
            this.EnteredBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EnteredBy.DataPropertyName = "EnteredBy";
            this.EnteredBy.HeaderText = "Entered By";
            this.EnteredBy.Name = "EnteredBy";
            this.EnteredBy.ReadOnly = true;
            // 
            // EnteredDate
            // 
            this.EnteredDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EnteredDate.DataPropertyName = "EnteredDate";
            this.EnteredDate.HeaderText = "Entered Date";
            this.EnteredDate.Name = "EnteredDate";
            this.EnteredDate.ReadOnly = true;
            // 
            // btnApprove
            // 
            this.btnApprove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApprove.Location = new System.Drawing.Point(737, 6);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(85, 29);
            this.btnApprove.TabIndex = 12;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // frmApproveSalesForeCast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 535);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.dgvSalesForcast);
            this.Controls.Add(this.dgvProduct);
            this.Name = "frmApproveSalesForeCast";
            this.Text = "frmApproveSalesForeCast";
            this.Load += new System.EventHandler(this.frmApproveSalesForeCast_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesForcast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSalesForecast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bssalesFrocastProductList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.DataGridView dgvSalesForcast;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.BindingSource bsSalesForecast;
        private System.Windows.Forms.BindingSource bssalesFrocastProductList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeekID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Accuracy;
        private System.Windows.Forms.DataGridViewTextBoxColumn RevisionNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnteredBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnteredDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinishProdutDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
    }
}