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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=ZUMA;Initial Catalog=Blood_Donation_System;Integrated Security=True");

        }

        public string choice;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            choice = comboBox1.SelectedItem.ToString();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if(choice=="Doctor")
            {
                Form2 frm2 = new Form2();
                frm2.table = choice;
                frm2.Show();
                this.Hide();
            }
            else if (choice=="Donor")
                
             {
                DONOR frm2 = new DONOR();
                frm2.table = choice;
                frm2.Show();
                this.Hide();
            }
            else if (choice == "Patient")

            {
                Patient frm2 = new Patient();
                frm2.table = choice;
                frm2.Show();
                this.Hide();
            }
            else if (choice == "Sponsor")

            {
                Sponser frm2 = new Sponser();
                frm2.table = choice;
                frm2.Show();
                this.Hide();
            }
            else if (choice == "Blood Bank")

            {
                Blood_bank frm2 = new Blood_bank();
                frm2.table = choice;
                frm2.Show();
                this.Hide();
            }




        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tables_Viewer frm2 = new Tables_Viewer();
          //  frm2.table = choice;
            frm2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Report frm2 = new Report();
            //  frm2.table = choice;
            frm2.Show();
            this.Hide();
        }
    }
}
