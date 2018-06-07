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
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }
        public string table;
        private void Patient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'blood_Donation_SystemDataSet.DOCTOR' table. You can move, or remove it, as needed.
            this.dOCTORTableAdapter.Fill(this.blood_Donation_SystemDataSet.DOCTOR);
            // TODO: This line of code loads data into the 'blood_Donation_SystemDataSet.PATIENT' table. You can move, or remove it, as needed.
            this.pATIENTTableAdapter.Fill(this.blood_Donation_SystemDataSet.PATIENT);

        }

        private void button1_Click(object sender, EventArgs e)      //INSERT
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=ZUMA;Initial Catalog=Blood_Donation_System;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "INSERT INTO " + table + " VALUES ('" + Convert.ToInt32(comboBox1.SelectedValue.ToString()) + "','" +textBox1.Text + "','" + comboBox2.SelectedItem + "','" + textBox3.Text + "','" + textBox4.Text +  "')";
            //
            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Insertion successfully completed.");
            sqlConnection.Close();
        }
        /******************************************************************************************************************/
        private void button5_Click(object sender, EventArgs e)      //SHOW
        {
            this.pATIENTTableAdapter.Fill(this.blood_Donation_SystemDataSet.PATIENT);
        }
        /************************************************************************************************************/
        private void button2_Click(object sender, EventArgs e)      //UPDATE
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=ZUMA;Initial Catalog=Blood_Donation_System;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "UPDATE " + table + " SET PATIENT_NAME = '" + textBox1.Text+ "', PATIENT_BLOODTYPE = '" + comboBox2.Text + "',PATIENT_DISEASE= '" +textBox3.Text + "',PATIENT_CONTACTNO = " + textBox4.Text + ", DOCTOR_ID = " + comboBox1.SelectedValue +  " WHERE PATIENT_ID = " + textBox6.Text + "";

            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Update successfully completed.");
            sqlConnection.Close();
         }
        /******************************************************************************************************************/
        private void button3_Click(object sender, EventArgs e)      //SEARCH
        {
            string searchValue = textBox1.Text;

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
        private void button4_Click(object sender, EventArgs e)          //DELETE
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=ZUMA;Initial Catalog=Blood_Donation_System;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "DELETE FROM " + table + " WHERE PATIENT_ID = " + textBox6.Text + "";
            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Deletion successfully completed.");
            sqlConnection.Close();
        }
    }
}
