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
    public partial class Tables_Viewer : Form
    {
        public Tables_Viewer()
        {
            InitializeComponent();
        }

        private void Tables_Viewer_Load(object sender, EventArgs e)
        {
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dOCTORTableAdapter.Fill(this.blood_Donation_SystemDataSet.DOCTOR);
           // this.pATIENTTableAdapter.Fill(this.blood_Donation_SystemDataSet.PATIENT);
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {
            this.dOCTORTableAdapter.Fill(this.blood_Donation_SystemDataSet.DOCTOR);
        }
    }
}
