namespace project
{
    partial class Report
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Blood_Donation_SystemDataSet = new project.Blood_Donation_SystemDataSet();
            this.PATIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PATIENTTableAdapter = new project.Blood_Donation_SystemDataSetTableAdapters.PATIENTTableAdapter();
            this.DOCTORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DOCTORTableAdapter = new project.Blood_Donation_SystemDataSetTableAdapters.DOCTORTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Blood_Donation_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PATIENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DOCTORBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DOCTORBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "project.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(66, 46);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(434, 334);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // Blood_Donation_SystemDataSet
            // 
            this.Blood_Donation_SystemDataSet.DataSetName = "Blood_Donation_SystemDataSet";
            this.Blood_Donation_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PATIENTBindingSource
            // 
            this.PATIENTBindingSource.DataMember = "PATIENT";
            this.PATIENTBindingSource.DataSource = this.Blood_Donation_SystemDataSet;
            // 
            // PATIENTTableAdapter
            // 
            this.PATIENTTableAdapter.ClearBeforeFill = true;
            // 
            // DOCTORBindingSource
            // 
            this.DOCTORBindingSource.DataMember = "DOCTOR";
            this.DOCTORBindingSource.DataSource = this.Blood_Donation_SystemDataSet;
            // 
            // DOCTORTableAdapter
            // 
            this.DOCTORTableAdapter.ClearBeforeFill = true;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 414);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Blood_Donation_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PATIENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DOCTORBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PATIENTBindingSource;
        private Blood_Donation_SystemDataSet Blood_Donation_SystemDataSet;
        private Blood_Donation_SystemDataSetTableAdapters.PATIENTTableAdapter PATIENTTableAdapter;
        private System.Windows.Forms.BindingSource DOCTORBindingSource;
        private Blood_Donation_SystemDataSetTableAdapters.DOCTORTableAdapter DOCTORTableAdapter;
    }
}