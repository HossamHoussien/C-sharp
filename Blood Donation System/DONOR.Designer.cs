namespace project
{
    partial class DONOR
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dONORIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bANKIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dONORNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dONORBLOODTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dONORMEDICALREPORTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dONORADDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dONORCONTACTNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dONORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.blood_Donation_SystemDataSet = new project.Blood_Donation_SystemDataSet();
            this.dONORTableAdapter = new project.Blood_Donation_SystemDataSetTableAdapters.DONORTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bLOODBANKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bLOOD_BANKTableAdapter = new project.Blood_Donation_SystemDataSetTableAdapters.BLOOD_BANKTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dONORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blood_Donation_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bLOODBANKBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Blood Bank Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Donor Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Blood Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Medical Report";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Contact Number";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(203, 407);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(557, 407);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(683, 406);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Show Data";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(266, 91);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(266, 143);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 15;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(266, 169);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 16;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(266, 195);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dONORIDDataGridViewTextBoxColumn,
            this.bANKIDDataGridViewTextBoxColumn,
            this.dONORNAMEDataGridViewTextBoxColumn,
            this.dONORBLOODTYPEDataGridViewTextBoxColumn,
            this.dONORMEDICALREPORTDataGridViewTextBoxColumn,
            this.dONORADDRESSDataGridViewTextBoxColumn,
            this.dONORCONTACTNODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dONORBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(746, 150);
            this.dataGridView1.TabIndex = 18;
            // 
            // dONORIDDataGridViewTextBoxColumn
            // 
            this.dONORIDDataGridViewTextBoxColumn.DataPropertyName = "DONOR_ID";
            this.dONORIDDataGridViewTextBoxColumn.HeaderText = "DONOR_ID";
            this.dONORIDDataGridViewTextBoxColumn.Name = "dONORIDDataGridViewTextBoxColumn";
            // 
            // bANKIDDataGridViewTextBoxColumn
            // 
            this.bANKIDDataGridViewTextBoxColumn.DataPropertyName = "BANK_ID";
            this.bANKIDDataGridViewTextBoxColumn.HeaderText = "BANK_ID";
            this.bANKIDDataGridViewTextBoxColumn.Name = "bANKIDDataGridViewTextBoxColumn";
            // 
            // dONORNAMEDataGridViewTextBoxColumn
            // 
            this.dONORNAMEDataGridViewTextBoxColumn.DataPropertyName = "DONOR_NAME";
            this.dONORNAMEDataGridViewTextBoxColumn.HeaderText = "DONOR_NAME";
            this.dONORNAMEDataGridViewTextBoxColumn.Name = "dONORNAMEDataGridViewTextBoxColumn";
            // 
            // dONORBLOODTYPEDataGridViewTextBoxColumn
            // 
            this.dONORBLOODTYPEDataGridViewTextBoxColumn.DataPropertyName = "DONOR_BLOODTYPE";
            this.dONORBLOODTYPEDataGridViewTextBoxColumn.HeaderText = "DONOR_BLOODTYPE";
            this.dONORBLOODTYPEDataGridViewTextBoxColumn.Name = "dONORBLOODTYPEDataGridViewTextBoxColumn";
            // 
            // dONORMEDICALREPORTDataGridViewTextBoxColumn
            // 
            this.dONORMEDICALREPORTDataGridViewTextBoxColumn.DataPropertyName = "DONOR_MEDICALREPORT";
            this.dONORMEDICALREPORTDataGridViewTextBoxColumn.HeaderText = "DONOR_MEDICALREPORT";
            this.dONORMEDICALREPORTDataGridViewTextBoxColumn.Name = "dONORMEDICALREPORTDataGridViewTextBoxColumn";
            // 
            // dONORADDRESSDataGridViewTextBoxColumn
            // 
            this.dONORADDRESSDataGridViewTextBoxColumn.DataPropertyName = "DONOR_ADDRESS";
            this.dONORADDRESSDataGridViewTextBoxColumn.HeaderText = "DONOR_ADDRESS";
            this.dONORADDRESSDataGridViewTextBoxColumn.Name = "dONORADDRESSDataGridViewTextBoxColumn";
            // 
            // dONORCONTACTNODataGridViewTextBoxColumn
            // 
            this.dONORCONTACTNODataGridViewTextBoxColumn.DataPropertyName = "DONOR_CONTACTNO";
            this.dONORCONTACTNODataGridViewTextBoxColumn.HeaderText = "DONOR_CONTACTNO";
            this.dONORCONTACTNODataGridViewTextBoxColumn.Name = "dONORCONTACTNODataGridViewTextBoxColumn";
            // 
            // dONORBindingSource
            // 
            this.dONORBindingSource.DataMember = "DONOR";
            this.dONORBindingSource.DataSource = this.blood_Donation_SystemDataSet;
            // 
            // blood_Donation_SystemDataSet
            // 
            this.blood_Donation_SystemDataSet.DataSetName = "Blood_Donation_SystemDataSet";
            this.blood_Donation_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dONORTableAdapter
            // 
            this.dONORTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.blood_Donation_SystemDataSet;
            this.comboBox1.DisplayMember = "BLOOD_BANK.BANK_NAME";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(266, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.ValueMember = "DONOR.BANK_ID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "A",
            "B",
            "AB",
            "O"});
            this.comboBox2.Location = new System.Drawing.Point(266, 117);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(428, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Enter ID for Updatable row;";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(625, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(105, 20);
            this.textBox1.TabIndex = 22;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(385, 407);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 23;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // DONOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 441);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "DONOR";
            this.Text = "DONOR";
            this.Load += new System.EventHandler(this.DONOR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dONORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blood_Donation_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bLOODBANKBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Blood_Donation_SystemDataSet blood_Donation_SystemDataSet;
        private System.Windows.Forms.BindingSource dONORBindingSource;
        private Blood_Donation_SystemDataSetTableAdapters.DONORTableAdapter dONORTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dONORIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bANKIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dONORNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dONORBLOODTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dONORMEDICALREPORTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dONORADDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dONORCONTACTNODataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource bLOODBANKBindingSource;
        private Blood_Donation_SystemDataSetTableAdapters.BLOOD_BANKTableAdapter bLOOD_BANKTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;
    }
}