using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace shoppingManagement
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connstr = "Data Source=(DESCRIPTION=" +
         "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-2V34OVD)(PORT = 1521))" +
          "(CONNECT_DATA =" +
             "(SERVER = DEDICATED)" +
             "(SERVICE_NAME = XE)" +
     ")" +
     "); User Id=HR; Password=hr";
            OracleConnection con = new OracleConnection(connstr);

            try
            {


                string sql = "Select * from addstuff";

                OracleDataAdapter adapter = new OracleDataAdapter(sql, con);


                DataTable dt = new DataTable();
                adapter.Fill(dt);
                //dataGridView1.DataSource = dt;
                dataGridView1.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();

                    //dataGridView1.Rows[n].Cells[0].Value = false;
                    dataGridView1.Rows[n].Cells[0].Value = item["name"].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item["id"].ToString();

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if ((bool)dataGridView1.SelectedRows[0].Cells[0].Value == false)
            {
                dataGridView1.SelectedRows[0].Cells[0].Value = true;
            }
            else
            {
                dataGridView1.SelectedRows[0].Cells[0].Value = false;
            }
        }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }
    }
}
    
