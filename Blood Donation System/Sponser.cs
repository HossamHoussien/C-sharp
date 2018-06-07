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
    public partial class Sponser : Form
    {
        public Sponser()
        {
            InitializeComponent();
        }
        public string table;
        private void Sponser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'blood_Donation_SystemDataSet.SPONSOR' table. You can move, or remove it, as needed.
            this.sPONSORTableAdapter.Fill(this.blood_Donation_SystemDataSet.SPONSOR);

        }

        private void button1_Click(object sender, EventArgs e)          //INSERT
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=ZUMA;Initial Catalog=Blood_Donation_System;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "INSERT INTO " + table + " VALUES ('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text +"')";
            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Insertion successfully completed.");
            sqlConnection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /********************************************************************************************************************/
        private void button2_Click(object sender, EventArgs e)      //UPDATE
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=ZUMA;Initial Catalog=Blood_Donation_System;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "UPDATE " + table + " SET SPONSOR_NAME= '" + textBox2.Text + "',SPONSOR_ORIGIN='" + textBox3.Text + "',SPONSORSHIP_AMOUNT = '" + textBox4.Text + "' WHERE SPONSOR_ID = " + textBox1.Text + "";

            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Update successfully completed.");
            sqlConnection.Close();


        }
        /************************************************************************************************************/
        private void button3_Click(object sender, EventArgs e)          //DELETE
        {
                   SqlConnection sqlConnection = new SqlConnection("Data Source=ZUMA;Initial Catalog=Blood_Donation_System;Integrated Security=True");
                   SqlCommand sqlCommand = new SqlCommand();
                   sqlCommand.Connection = sqlConnection;
                   sqlConnection.Open();
                   sqlCommand.CommandText = "DELETE FROM " + table + " WHERE SPONSOR_ID = " + textBox1.Text + "";
                    sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Deletion successfully completed.");
            sqlConnection.Close();
              
           /* foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }*/
        }
        /****************************************************************************************************************/
        private void button4_Click(object sender, EventArgs e)          //SHOW DATA
        {
            this.sPONSORTableAdapter.Fill(this.blood_Donation_SystemDataSet.SPONSOR);
        }
        /******************************************************************************************************************/
        private void button5_Click(object sender, EventArgs e)      //SEARCH
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
        /****************************************************************************************************************/
    }
}
