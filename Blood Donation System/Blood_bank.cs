using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Blood_bank : Form
    {
        public Blood_bank()
        {
            InitializeComponent();
        }
        public string table;
        private void Blood_bank_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'blood_Donation_SystemDataSet.BLOOD_BANK' table. You can move, or remove it, as needed.
            this.bLOOD_BANKTableAdapter.Fill(this.blood_Donation_SystemDataSet.BLOOD_BANK);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        /***************************************************************************************************************************************************/
        private void button5_Click(object sender, EventArgs e)      //SHOW DATA
        {
            this.bLOOD_BANKTableAdapter.Fill(this.blood_Donation_SystemDataSet.BLOOD_BANK);
        }
        /**************************************************************************************************************/
        private void button1_Click(object sender, EventArgs e)          //INSERT
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=ZUMA;Initial Catalog=Blood_Donation_System;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "INSERT INTO BLOOD_BANK  VALUES ('" + textBox1.Text + "','" + textBox2.Text + "'," + textBox3.Text + ")";
            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Insertion successfully completed.");
            sqlConnection.Close();
        }
        /************************************************************************************************************************/
        private void button2_Click(object sender, EventArgs e)      //UPDATE
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=ZUMA;Initial Catalog=Blood_Donation_System;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "UPDATE BLOOD_BANK SET BANK_NAME= '" + textBox1.Text + "',BANK_ADDRESS='" + textBox2.Text + "',BANK_CONTACTNO = " + textBox3.Text + " WHERE BANK_ID = " + textBox4.Text + "";

            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Update successfully completed.");
            sqlConnection.Close();
        }
        /***********************************************************************************************************************/
        private void button3_Click(object sender, EventArgs e)      //SEARCH
        {
            string searchValue = textBox1.Text;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[1].Value.ToString().Equals(searchValue))
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.SelectedRows[0].Index;
        }
        
        
        /************************************************************************************************************************************************/
    }
}
