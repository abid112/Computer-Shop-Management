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
    public partial class Form6 : Form
    {
        private double grandTotal=0;
        public Form6(string user,string pass ) 
        {
            InitializeComponent();
            lblUser.Text = user;
            lblPass.Text = pass;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f7 = new Form7();
            f7.ShowDialog();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
{
    
}

        private void Form6_Load(object sender, EventArgs e)
        {
           /* string connstr = "Data Source=(DESCRIPTION=" +
         "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-2V34OVD)(PORT = 1521))" +
          "(CONNECT_DATA =" +
             "(SERVER = DEDICATED)" +
             "(SERVICE_NAME = XE)" +
     ")" +
     "); User Id=HR; Password=hr";
            OracleConnection con = new OracleConnection(connstr);
            try
            {


                string sql = "Select * from product";

                OracleDataAdapter adapter = new OracleDataAdapter(sql, con);


                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String id = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

            String type = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

            String Model = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

            String memory = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            String price = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            String quantity = textBox2.Text;
            double total = (Double.Parse(price)* Double.Parse(textBox2.Text));

            grandTotal = grandTotal + total;

            dataGridView2.Rows.Add(id, type, Model, memory, price,quantity,total.ToString());

            label4.Text = grandTotal.ToString();

            //dataGridView2.Rows.Clear();
            //foreach (DataGridViewRow item in dataGridView1.Rows)
            //{
            //    if ((bool)item.Cells[0].Value == true)
            //    {
            //        int n = dataGridView2.Rows.Add();
            //        dataGridView2.Rows[n].Cells[0].Value = item.Cells[1].Value.ToString();
            //        dataGridView2.Rows[n].Cells[1].Value = item.Cells[2].Value.ToString();
            //        dataGridView2.Rows[n].Cells[2].Value = item.Cells[3].Value.ToString();
            //        dataGridView2.Rows[n].Cells[3].Value = item.Cells[4].Value.ToString();
            //        dataGridView2.Rows[n].Cells[4].Value = item.Cells[5].Value.ToString();
            //        dataGridView2.Rows[n].Cells[5].Value = textBox2.Text;
                    
            //        dataGridView2.Rows[n].Cells[6].Value =
            //            (Double.Parse(dataGridView2.Rows[n].Cells[4].Value.ToString())*
            //            Double.Parse(textBox2.Text)).ToString();


            //    }
            //}
        }


        private void button3_Click(object sender, EventArgs e)
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


                string sql = "Select * from product";

                OracleDataAdapter adapter = new OracleDataAdapter(sql, con);


                DataTable dt = new DataTable();
                adapter.Fill(dt);
                //dataGridView1.DataSource = dt;
                dataGridView1.Rows.Clear();
                foreach(DataRow item in dt.Rows)
                { 
                  int n=dataGridView1.Rows.Add();

                  dataGridView1.Rows[n].Cells[0].Value = false;
                  dataGridView1.Rows[n].Cells[1].Value = item["id"].ToString();
                  dataGridView1.Rows[n].Cells[2].Value = item["type"].ToString();
                  dataGridView1.Rows[n].Cells[3].Value = item["model"].ToString();
                  dataGridView1.Rows[n].Cells[4].Value = item["memory"].ToString();
                  dataGridView1.Rows[n].Cells[5].Value = item["price"].ToString();
                  dataGridView1.Rows[n].Cells[6].Value = item["quantity"].ToString();
                
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 f9 = new Form9(lblUser.Text,lblPass.Text);
            f9.ShowDialog();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {

                string connstr = "Data Source=(DESCRIPTION=" +
         "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-2V34OVD)(PORT = 1521))" +
          "(CONNECT_DATA =" +
             "(SERVER = DEDICATED)" +
             "(SERVICE_NAME = XE)" +
     ")" +
     "); User Id=HR; Password=hr";
                OracleConnection con = new OracleConnection(connstr);

               /* con.Open();
                OracleDataAdapter sda = new OracleDataAdapter("Select * FROM product Where model like '" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();*/


                try
                {


                    string sql = "Select * FROM product Where model like '" + textBox1.Text + "%'";

                    OracleDataAdapter adapter = new OracleDataAdapter(sql, con);


                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    //dataGridView1.DataSource = dt;
                    dataGridView1.Rows.Clear();
                    foreach (DataRow item in dt.Rows)
                    {
                        int n = dataGridView1.Rows.Add();

                        dataGridView1.Rows[n].Cells[0].Value = false;
                        dataGridView1.Rows[n].Cells[1].Value = item["id"].ToString();
                        dataGridView1.Rows[n].Cells[2].Value = item["type"].ToString();
                        dataGridView1.Rows[n].Cells[3].Value = item["model"].ToString();
                        dataGridView1.Rows[n].Cells[4].Value = item["memory"].ToString();
                        dataGridView1.Rows[n].Cells[5].Value = item["price"].ToString();
                        dataGridView1.Rows[n].Cells[6].Value = item["quantity"].ToString();

                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
           
        }
    }
}
