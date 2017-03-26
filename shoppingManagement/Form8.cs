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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connstr = "Data Source= (DESCRIPTION =" +
        "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-2V34OVD)(PORT = 1521))" +
         "(CONNECT_DATA =" +
            "(SERVER = DEDICATED)" +
            "(SERVICE_NAME = XE)" +
    ")" +
    "); User Id=HR; Password=hr";
            OracleConnection con = new OracleConnection(connstr);

            try
            {
                string sql = "create or replace trigger insert_into_stuffinfo after insert on addstuff for each row begin insert into stuffinfo values ('" + txtId.Text + "','" + txtUsername.Text + "','" + txtPassword.Text + "' ); end;";
                OracleCommand cmd = new OracleCommand(sql, con);
                //OracleDataAdapter adapter = new OracleDataAdapter("select * from product", con);

                con.Open();

                cmd.ExecuteNonQuery();
           
                string sqlr = "INSERT INTO addstuff (name, id) values ('" + txtName.Text + "', '" + txtId.Text + "' )";
                OracleCommand cmd1 = new OracleCommand(sqlr, con);
               // con.Open();

                cmd1.ExecuteNonQuery();
                MessageBox.Show("Add new record done !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //OracleDataAdapter adapter = new OracleDataAdapter();
                //OracleDataAdapter adapter = new OracleDataAdapter("select * from addstuff", con);
                //DataTable dt = new DataTable();

                //adapter.Fill(dt);


                //dataGridView1.DataSource = dt;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                con.Close();
            }
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form13 f13 = new Form13();
            f13.ShowDialog();
        }
    }
}
