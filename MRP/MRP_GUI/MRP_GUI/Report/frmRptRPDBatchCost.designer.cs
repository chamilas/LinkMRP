namespace MRP_GUI
{
    partial class frmRptRPDBatchCost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRptRPDBatchCost));
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.rptViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // btnApprove
            // 
            this.btnApprove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApprove.Location = new System.Drawing.Point(558, 530);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(75, 23);
            this.btnApprove.TabIndex = 4;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Visible = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(639, 530);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // rptViewer
            // 
            this.rptViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rptViewer.LocalReport.ReportEmbeddedResource = "MRP_GUI.Report.rptRPDBatchCost.rdlc";
            this.rptViewer.Location = new System.Drawing.Point(12, 12);
            this.rptViewer.Name = "rptViewer";
            this.rptViewer.Size = new System.Drawing.Size(690, 512);
            this.rptViewer.TabIndex = 5;
            // 
            // frmRptRPDBatchCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 562);
            this.Controls.Add(this.rptViewer);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.btnClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRptRPDBatchCost";
            this.Text = "RPD Batch Cost";
            this.Load += new System.EventHandler(this.frmRptRPDBatchCost_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnClose;
        private Microsoft.Reporting.WinForms.ReportViewer rptViewer;
    }
}