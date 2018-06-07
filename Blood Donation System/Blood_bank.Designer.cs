namespace project
{
    partial class Blood_bank
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bANKIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bANKNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bANKADDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bANKCONTACTNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bLOODBANKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.blood_Donation_SystemDataSet = new project.Blood_Donation_SystemDataSet();
            this.bLOOD_BANKTableAdapter = new project.Blood_Donation_SystemDataSetTableAdapters.BLOOD_BANKTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bLOODBANKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blood_Donation_SystemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bank Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bank Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bank Contact Number";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(247, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(247, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(247, 145);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(155, 414);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(342, 414);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(558, 414);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "Show Data";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bANKIDDataGridViewTextBoxColumn,
            this.bANKNAMEDataGridViewTextBoxColumn,
            this.bANKADDRESSDataGridViewTextBoxColumn,
            this.bANKCONTACTNODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bLOODBANKBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(621, 184);
            this.dataGridView1.TabIndex = 13;
            // 
            // bANKIDDataGridViewTextBoxColumn
            // 
            this.bANKIDDataGridViewTextBoxColumn.DataPropertyName = "BANK_ID";
            this.bANKIDDataGridViewTextBoxColumn.HeaderText = "BANK_ID";
            this.bANKIDDataGridViewTextBoxColumn.Name = "bANKIDDataGridViewTextBoxColumn";
            // 
            // bANKNAMEDataGridViewTextBoxColumn
            // 
            this.bANKNAMEDataGridViewTextBoxColumn.DataPropertyName = "BANK_NAME";
            this.bANKNAMEDataGridViewTextBoxColumn.HeaderText = "BANK_NAME";
            this.bANKNAMEDataGridViewTextBoxColumn.Name = "bANKNAMEDataGridViewTextBoxColumn";
            // 
            // bANKADDRESSDataGridViewTextBoxColumn
            // 
            this.bANKADDRESSDataGridViewTextBoxColumn.DataPropertyName = "BANK_ADDRESS";
            this.bANKADDRESSDataGridViewTextBoxColumn.HeaderText = "BANK_ADDRESS";
            this.bANKADDRESSDataGridViewTextBoxColumn.Name = "bANKADDRESSDataGridViewTextBoxColumn";
            // 
            // bANKCONTACTNODataGridViewTextBoxColumn
            // 
            this.bANKCONTACTNODataGridViewTextBoxColumn.DataPropertyName = "BANK_CONTACTNO";
            this.bANKCONTACTNODataGridViewTextBoxColumn.HeaderText = "BANK_CONTACTNO";
            this.bANKCONTACTNODataGridViewTextBoxColumn.Name = "bANKCONTACTNODataGridViewTextBoxColumn";
            // 
            // bLOODBANKBindingSource
            // 
            this.bLOODBANKBindingSource.DataMember = "BLOOD_BANK";
            this.bLOODBANKBindingSource.DataSource = this.blood_Donation_SystemDataSet;
            // 
            // blood_Donation_SystemDataSet
            // 
            this.blood_Donation_SystemDataSet.DataSetName = "Blood_Donation_SystemDataSet";
            this.blood_Donation_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bLOOD_BANKTableAdapter
            // 
            this.bLOOD_BANKTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(469, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Enter ID:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(533, 64);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 15;
            // 
            // Blood_bank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 478);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Blood_bank";
            this.Text = "Blood_bank";
            this.Load += new System.EventHandler(this.Blood_bank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bLOODBANKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blood_Donation_SystemDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Blood_Donation_SystemDataSet blood_Donation_SystemDataSet;
        private System.Windows.Forms.BindingSource bLOODBANKBindingSource;
        private Blood_Donation_SystemDataSetTableAdapters.BLOOD_BANKTableAdapter bLOOD_BANKTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bANKIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bANKNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bANKADDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bANKCONTACTNODataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
    }
}