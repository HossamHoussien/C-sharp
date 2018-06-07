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
    public partial class DONOR : Form
    {
        public DONOR()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /*****************************************************************************************************/
        private void DONOR_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'blood_Donation_SystemDataSet.BLOOD_BANK' table. You can move, or remove it, as needed.
            this.bLOOD_BANKTableAdapter.Fill(this.blood_Donation_SystemDataSet.BLOOD_BANK);
            // TODO: This line of code loads data into the 'blood_Donation_SystemDataSet.DONOR' table. You can move, or remove it, as needed.
            this.dONORTableAdapter.Fill(this.blood_Donation_SystemDataSet.DONOR);

        }

        /***********************************************************************************************************************/
        public string table;

        private void button1_Click(object sender, EventArgs e)          //INSERT
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=ZUMA;Initial Catalog=Blood_Donation_System;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "INSERT INTO " + table + " VALUES ('"  +Convert.ToInt32(comboBox1.SelectedValue .ToString())+ "','" + textBox3.Text + "','" + comboBox2.SelectedItem.ToString() + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
            
            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Insertion successfully completed.");
            sqlConnection.Close();
        }
        /************************************************************************************************************************/
        private void button4_Click(object sender, EventArgs e)      //SHOW DATA
        {
            this.dONORTableAdapter.Fill(this.blood_Donation_SystemDataSet.DONOR);
        }
        /******************************************************************************************************************************/
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /********************************************************************************************************************/
        
        /********************************************************************************************************************************/
        private void button2_Click(object sender, EventArgs e)      //UPDATE
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=ZUMA;Initial Catalog=Blood_Donation_System;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "UPDATE " + table + " SET BANK_ID = "+comboBox1.SelectedValue+", DONOR_NAME= '" + textBox3.Text + "',DONOR_BLOODTYPE='" + comboBox2.SelectedItem +"',DONOR_MEDICALREPORT = '"+textBox5.Text+ "', DONOR_ADDRESS = '"+textBox6.Text+"',DONOR_CONTACTNO = " + textBox7.Text + " WHERE DONOR_ID = " + textBox1.Text + "";

            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Update successfully completed.");

            sqlConnection.Close();
        }
        /*************************************************************************************************************************/
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        /******************************************************************************************/
        private void button5_Click(object sender, EventArgs e)          //SEARCH
        {
            string searchValue = textBox3.Text;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[2].Value.ToString().Equals(searchValue))
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
        /*************************************************************************************************************/
        private void button3_Click(object sender, EventArgs e)              //DELETE
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=ZUMA;Initial Catalog=Blood_Donation_System;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "DELETE FROM " + table + " WHERE DONOR_ID = " + textBox1.Text + "";
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Deletion successfully completed.");

            sqlConnection.Close();
        }
    }
}
