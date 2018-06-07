namespace project
{
    partial class Sponser
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sPONSORIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPONSORNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPONSORORIGINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPONSORSHIPAMOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPONSORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.blood_Donation_SystemDataSet = new project.Blood_Donation_SystemDataSet();
            this.bloodDonationSystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPONSORTableAdapter = new project.Blood_Donation_SystemDataSetTableAdapters.SPONSORTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPONSORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blood_Donation_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodDonationSystemDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Origin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Amount";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(127, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(127, 88);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(127, 130);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 21);
            this.button1.TabIndex = 8;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(141, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 21);
            this.button2.TabIndex = 9;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(343, 405);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 21);
            this.button3.TabIndex = 10;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(444, 405);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 21);
            this.button4.TabIndex = 11;
            this.button4.Text = "Show Data";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sPONSORIDDataGridViewTextBoxColumn,
            this.sPONSORNAMEDataGridViewTextBoxColumn,
            this.sPONSORORIGINDataGridViewTextBoxColumn,
            this.sPONSORSHIPAMOUNTDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sPONSORBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(29, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(494, 171);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sPONSORIDDataGridViewTextBoxColumn
            // 
            this.sPONSORIDDataGridViewTextBoxColumn.DataPropertyName = "SPONSOR_ID";
            this.sPONSORIDDataGridViewTextBoxColumn.HeaderText = "SPONSOR_ID";
            this.sPONSORIDDataGridViewTextBoxColumn.Name = "sPONSORIDDataGridViewTextBoxColumn";
            // 
            // sPONSORNAMEDataGridViewTextBoxColumn
            // 
            this.sPONSORNAMEDataGridViewTextBoxColumn.DataPropertyName = "SPONSOR_NAME";
            this.sPONSORNAMEDataGridViewTextBoxColumn.HeaderText = "SPONSOR_NAME";
            this.sPONSORNAMEDataGridViewTextBoxColumn.Name = "sPONSORNAMEDataGridViewTextBoxColumn";
            // 
            // sPONSORORIGINDataGridViewTextBoxColumn
            // 
            this.sPONSORORIGINDataGridViewTextBoxColumn.DataPropertyName = "SPONSOR_ORIGIN";
            this.sPONSORORIGINDataGridViewTextBoxColumn.HeaderText = "SPONSOR_ORIGIN";
            this.sPONSORORIGINDataGridViewTextBoxColumn.Name = "sPONSORORIGINDataGridViewTextBoxColumn";
            // 
            // sPONSORSHIPAMOUNTDataGridViewTextBoxColumn
            // 
            this.sPONSORSHIPAMOUNTDataGridViewTextBoxColumn.DataPropertyName = "SPONSORSHIP_AMOUNT";
            this.sPONSORSHIPAMOUNTDataGridViewTextBoxColumn.HeaderText = "SPONSORSHIP_AMOUNT";
            this.sPONSORSHIPAMOUNTDataGridViewTextBoxColumn.Name = "sPONSORSHIPAMOUNTDataGridViewTextBoxColumn";
            // 
            // sPONSORBindingSource
            // 
            this.sPONSORBindingSource.DataMember = "SPONSOR";
            this.sPONSORBindingSource.DataSource = this.blood_Donation_SystemDataSet;
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
            // sPONSORTableAdapter
            // 
            this.sPONSORTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(241, 404);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 13;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(380, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Enter ID for updatable record:";
            // 
            // Sponser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 438);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Sponser";
            this.Text = "Sponser";
            this.Load += new System.EventHandler(this.Sponser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPONSORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blood_Donation_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodDonationSystemDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bloodDonationSystemDataSetBindingSource;
        private Blood_Donation_SystemDataSet blood_Donation_SystemDataSet;
        private System.Windows.Forms.BindingSource sPONSORBindingSource;
        private Blood_Donation_SystemDataSetTableAdapters.SPONSORTableAdapter sPONSORTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPONSORIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPONSORNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPONSORORIGINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPONSORSHIPAMOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}