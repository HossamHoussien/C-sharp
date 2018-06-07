namespace project
{
    partial class Tables_Viewer
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
            System.Windows.Forms.Label dOCTOR_CONTACTNOLabel;
            System.Windows.Forms.Label dOCTOR_ADDRESSLabel;
            System.Windows.Forms.Label dOCTOR_NAMELabel;
            System.Windows.Forms.Label dOCTOR_IDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tables_Viewer));
            this.blood_Donation_SystemDataSet = new project.Blood_Donation_SystemDataSet();
            this.bloodDonationSystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bLOODBANKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bLOOD_BANKTableAdapter = new project.Blood_Donation_SystemDataSetTableAdapters.BLOOD_BANKTableAdapter();
            this.bloodDonationSystemDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dOCTORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dOCTORTableAdapter = new project.Blood_Donation_SystemDataSetTableAdapters.DOCTORTableAdapter();
            this.pATIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pATIENTTableAdapter = new project.Blood_Donation_SystemDataSetTableAdapters.PATIENTTableAdapter();
            this.dOCTORBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pATIENTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dOCTORBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new project.Blood_Donation_SystemDataSetTableAdapters.TableAdapterManager();
            this.pATIENTBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATIENTDataGridView = new System.Windows.Forms.DataGridView();
            this.dOCTOR_CONTACTNOTextBox = new System.Windows.Forms.TextBox();
            this.dOCTOR_ADDRESSTextBox = new System.Windows.Forms.TextBox();
            this.dOCTOR_NAMETextBox = new System.Windows.Forms.TextBox();
            this.dOCTOR_IDTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            dOCTOR_CONTACTNOLabel = new System.Windows.Forms.Label();
            dOCTOR_ADDRESSLabel = new System.Windows.Forms.Label();
            dOCTOR_NAMELabel = new System.Windows.Forms.Label();
            dOCTOR_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.blood_Donation_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodDonationSystemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bLOODBANKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodDonationSystemDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // blood_Donation_SystemDataSet
            // 
            this.blood_Donation_SystemDataSet.DataSetName = "Blood_Donation_SystemDataSet";
            this.blood_Donation_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bloodDonationSystemDataSetBindingSource
            // 
            this.bloodDonationSystemDataSetBindingSource.DataSource = this.blood_Donation_SystemDataSet;
            this.bloodDonationSystemDataSetBindingSource.Position = 0;
            // 
            // bLOODBANKBindingSource
            // 
            this.bLOODBANKBindingSource.DataMember = "BLOOD_BANK";
            this.bLOODBANKBindingSource.DataSource = this.blood_Donation_SystemDataSet;
            // 
            // bLOOD_BANKTableAdapter
            // 
            this.bLOOD_BANKTableAdapter.ClearBeforeFill = true;
            // 
            // bloodDonationSystemDataSetBindingSource1
            // 
            this.bloodDonationSystemDataSetBindingSource1.DataSource = this.blood_Donation_SystemDataSet;
            this.bloodDonationSystemDataSetBindingSource1.Position = 0;
            // 
            // dOCTORBindingSource
            // 
            this.dOCTORBindingSource.DataMember = "DOCTOR";
            this.dOCTORBindingSource.DataSource = this.bloodDonationSystemDataSetBindingSource;
            // 
            // dOCTORTableAdapter
            // 
            this.dOCTORTableAdapter.ClearBeforeFill = true;
            // 
            // pATIENTBindingSource
            // 
            this.pATIENTBindingSource.DataMember = "PATIENT";
            this.pATIENTBindingSource.DataSource = this.bloodDonationSystemDataSetBindingSource;
            // 
            // pATIENTTableAdapter
            // 
            this.pATIENTTableAdapter.ClearBeforeFill = true;
            // 
            // dOCTORBindingSource1
            // 
            this.dOCTORBindingSource1.DataMember = "DOCTOR";
            this.dOCTORBindingSource1.DataSource = this.bloodDonationSystemDataSetBindingSource;
            // 
            // pATIENTBindingSource1
            // 
            this.pATIENTBindingSource1.DataMember = "PATIENT";
            this.pATIENTBindingSource1.DataSource = this.bloodDonationSystemDataSetBindingSource;
            // 
            // dOCTORBindingSource2
            // 
            this.dOCTORBindingSource2.DataMember = "DOCTOR";
            this.dOCTORBindingSource2.DataSource = this.blood_Donation_SystemDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BLOOD_BANKTableAdapter = this.bLOOD_BANKTableAdapter;
            this.tableAdapterManager.DOCTORTableAdapter = this.dOCTORTableAdapter;
            this.tableAdapterManager.DONORTableAdapter = null;
            this.tableAdapterManager.HASTableAdapter = null;
            this.tableAdapterManager.PATIENTTableAdapter = this.pATIENTTableAdapter;
            this.tableAdapterManager.SPONSORTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = project.Blood_Donation_SystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WORKS_FORTableAdapter = null;
            // 
            // pATIENTBindingSource2
            // 
            this.pATIENTBindingSource2.DataMember = "FK_PATIENT_RESPONSIB_DOCTOR";
            this.pATIENTBindingSource2.DataSource = this.dOCTORBindingSource2;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PATIENT_CONTACTNO";
            this.dataGridViewTextBoxColumn6.HeaderText = "PATIENT_CONTACTNO";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PATIENT_DISEASE";
            this.dataGridViewTextBoxColumn5.HeaderText = "PATIENT_DISEASE";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PATIENT_BLOODTYPE";
            this.dataGridViewTextBoxColumn4.HeaderText = "PATIENT_BLOODTYPE";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PATIENT_NAME";
            this.dataGridViewTextBoxColumn3.HeaderText = "PATIENT_NAME";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DOCTOR_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "DOCTOR_ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PATIENT_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PATIENT_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // pATIENTDataGridView
            // 
            this.pATIENTDataGridView.AllowDrop = true;
            this.pATIENTDataGridView.AutoGenerateColumns = false;
            this.pATIENTDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pATIENTDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.pATIENTDataGridView.DataSource = this.pATIENTBindingSource2;
            this.pATIENTDataGridView.Location = new System.Drawing.Point(87, 178);
            this.pATIENTDataGridView.Name = "pATIENTDataGridView";
            this.pATIENTDataGridView.Size = new System.Drawing.Size(620, 220);
            this.pATIENTDataGridView.TabIndex = 8;
            // 
            // dOCTOR_CONTACTNOTextBox
            // 
            this.dOCTOR_CONTACTNOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dOCTORBindingSource2, "DOCTOR_CONTACTNO", true));
            this.dOCTOR_CONTACTNOTextBox.Location = new System.Drawing.Point(423, 153);
            this.dOCTOR_CONTACTNOTextBox.Name = "dOCTOR_CONTACTNOTextBox";
            this.dOCTOR_CONTACTNOTextBox.Size = new System.Drawing.Size(100, 20);
            this.dOCTOR_CONTACTNOTextBox.TabIndex = 16;
            // 
            // dOCTOR_CONTACTNOLabel
            // 
            dOCTOR_CONTACTNOLabel.AutoSize = true;
            dOCTOR_CONTACTNOLabel.Location = new System.Drawing.Point(291, 156);
            dOCTOR_CONTACTNOLabel.Name = "dOCTOR_CONTACTNOLabel";
            dOCTOR_CONTACTNOLabel.Size = new System.Drawing.Size(126, 13);
            dOCTOR_CONTACTNOLabel.TabIndex = 15;
            dOCTOR_CONTACTNOLabel.Text = "DOCTOR CONTACTNO:";
            // 
            // dOCTOR_ADDRESSTextBox
            // 
            this.dOCTOR_ADDRESSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dOCTORBindingSource2, "DOCTOR_ADDRESS", true));
            this.dOCTOR_ADDRESSTextBox.Location = new System.Drawing.Point(423, 127);
            this.dOCTOR_ADDRESSTextBox.Name = "dOCTOR_ADDRESSTextBox";
            this.dOCTOR_ADDRESSTextBox.Size = new System.Drawing.Size(100, 20);
            this.dOCTOR_ADDRESSTextBox.TabIndex = 14;
            // 
            // dOCTOR_ADDRESSLabel
            // 
            dOCTOR_ADDRESSLabel.AutoSize = true;
            dOCTOR_ADDRESSLabel.Location = new System.Drawing.Point(291, 130);
            dOCTOR_ADDRESSLabel.Name = "dOCTOR_ADDRESSLabel";
            dOCTOR_ADDRESSLabel.Size = new System.Drawing.Size(111, 13);
            dOCTOR_ADDRESSLabel.TabIndex = 13;
            dOCTOR_ADDRESSLabel.Text = "DOCTOR ADDRESS:";
            // 
            // dOCTOR_NAMETextBox
            // 
            this.dOCTOR_NAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dOCTORBindingSource2, "DOCTOR_NAME", true));
            this.dOCTOR_NAMETextBox.Location = new System.Drawing.Point(423, 101);
            this.dOCTOR_NAMETextBox.Name = "dOCTOR_NAMETextBox";
            this.dOCTOR_NAMETextBox.Size = new System.Drawing.Size(100, 20);
            this.dOCTOR_NAMETextBox.TabIndex = 12;
            // 
            // dOCTOR_NAMELabel
            // 
            dOCTOR_NAMELabel.AutoSize = true;
            dOCTOR_NAMELabel.Location = new System.Drawing.Point(291, 104);
            dOCTOR_NAMELabel.Name = "dOCTOR_NAMELabel";
            dOCTOR_NAMELabel.Size = new System.Drawing.Size(90, 13);
            dOCTOR_NAMELabel.TabIndex = 11;
            dOCTOR_NAMELabel.Text = "DOCTOR NAME:";
            // 
            // dOCTOR_IDTextBox
            // 
            this.dOCTOR_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dOCTORBindingSource2, "DOCTOR_ID", true));
            this.dOCTOR_IDTextBox.Location = new System.Drawing.Point(423, 75);
            this.dOCTOR_IDTextBox.Name = "dOCTOR_IDTextBox";
            this.dOCTOR_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.dOCTOR_IDTextBox.TabIndex = 10;
            // 
            // dOCTOR_IDLabel
            // 
            dOCTOR_IDLabel.AutoSize = true;
            dOCTOR_IDLabel.Location = new System.Drawing.Point(291, 78);
            dOCTOR_IDLabel.Name = "dOCTOR_IDLabel";
            dOCTOR_IDLabel.Size = new System.Drawing.Size(70, 13);
            dOCTOR_IDLabel.TabIndex = 9;
            dOCTOR_IDLabel.Text = "DOCTOR ID:";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.pATIENTBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DataBindings.Add(new System.Windows.Forms.Binding("BindingSource", this.dOCTORBindingSource, "DOCTOR_ID", true));
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(924, 25);
            this.bindingNavigator1.TabIndex = 9;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // Tables_Viewer
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 527);
            this.Controls.Add(dOCTOR_IDLabel);
            this.Controls.Add(this.dOCTOR_IDTextBox);
            this.Controls.Add(dOCTOR_NAMELabel);
            this.Controls.Add(this.dOCTOR_NAMETextBox);
            this.Controls.Add(dOCTOR_ADDRESSLabel);
            this.Controls.Add(this.dOCTOR_ADDRESSTextBox);
            this.Controls.Add(dOCTOR_CONTACTNOLabel);
            this.Controls.Add(this.dOCTOR_CONTACTNOTextBox);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.pATIENTDataGridView);
            this.Name = "Tables_Viewer";
            this.Text = "Tables_Viewer";
            this.Load += new System.EventHandler(this.Tables_Viewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.blood_Donation_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodDonationSystemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bLOODBANKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodDonationSystemDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bloodDonationSystemDataSetBindingSource;
        private Blood_Donation_SystemDataSet blood_Donation_SystemDataSet;
        private System.Windows.Forms.BindingSource bLOODBANKBindingSource;
        private Blood_Donation_SystemDataSetTableAdapters.BLOOD_BANKTableAdapter bLOOD_BANKTableAdapter;
        private System.Windows.Forms.BindingSource bloodDonationSystemDataSetBindingSource1;
        private System.Windows.Forms.BindingSource dOCTORBindingSource;
        private Blood_Donation_SystemDataSetTableAdapters.DOCTORTableAdapter dOCTORTableAdapter;
        private System.Windows.Forms.BindingSource pATIENTBindingSource;
        private Blood_Donation_SystemDataSetTableAdapters.PATIENTTableAdapter pATIENTTableAdapter;
        private System.Windows.Forms.BindingSource dOCTORBindingSource1;
        private System.Windows.Forms.BindingSource pATIENTBindingSource1;
        private System.Windows.Forms.BindingSource dOCTORBindingSource2;
        private Blood_Donation_SystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource pATIENTBindingSource2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView pATIENTDataGridView;
        private System.Windows.Forms.TextBox dOCTOR_CONTACTNOTextBox;
        private System.Windows.Forms.TextBox dOCTOR_ADDRESSTextBox;
        private System.Windows.Forms.TextBox dOCTOR_NAMETextBox;
        private System.Windows.Forms.TextBox dOCTOR_IDTextBox;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
    }
}