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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string table;
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'blood_Donation_SystemDataSet.DOCTOR' table. You can move, or remove it, as needed.
            this.dOCTORTableAdapter.Fill(this.blood_Donation_SystemDataSet.DOCTOR);

        }
        /******************************************************************************************************************/
        private void button1_Click(object sender, EventArgs e)      //INSERT BUTTON
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=ZUMA;Initial Catalog=Blood_Donation_System;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "INSERT INTO " + table + " VALUES ('"  + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Insertion successfully completed.");
            sqlConnection.Close();
        }
        /***************************************************************************************************************/
        private void button2_Click(object sender, EventArgs e)          //UPDATE BUTTON
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=ZUMA;Initial Catalog=Blood_Donation_System;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "UPDATE " + table + " SET DOCTOR_NAME= '" + textBox2.Text + "',DOCTOR_ADDRESS='" + textBox3.Text + "',DOCTOR_CONTACTNO = '" + textBox4.Text + "' WHERE DOCTOR_ID = " + textBox1.Text + "";
            MessageBox.Show("Update successfully completed.");
            sqlCommand.ExecuteNonQuery();

            
            sqlConnection.Close();
            
        }
        /*****************************************************************************************************************/
        private void button3_Click(object sender, EventArgs e)      //DELETE 
        {
             SqlConnection sqlConnection = new SqlConnection("Data Source=ZUMA;Initial Catalog=Blood_Donation_System;Integrated Security=True");
             SqlCommand sqlCommand = new SqlCommand();
             sqlCommand.Connection = sqlConnection;
             sqlConnection.Open();
             sqlCommand.CommandText = "DELETE FROM " + table + " WHERE DOCTOR_ID = "+textBox1.Text+ "";
             sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Deletion successfully completed.");
            sqlConnection.Close();

            

        }
        /******************************************************************************************************************/
        private void button4_Click(object sender, EventArgs e)          //SHOW DATA
        {
            
            this.dOCTORTableAdapter.Fill(this.blood_Donation_SystemDataSet.DOCTOR);
        }
        /*******************************************************************************************************************/
        private void label1_Click(object sender, EventArgs e)
        {

        }
        /*******************************************************************************************************************/
    
        private void button5_Click_1(object sender, EventArgs e)        //SEARCH
        {
          
            string searchValue = textBox2.Text;

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
    