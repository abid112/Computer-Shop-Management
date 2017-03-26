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
    public partial class Form9 : Form
    {
        public Form9(string user, string pass)
        {
            InitializeComponent();
            labelU.Text = user;
            labelP.Text = pass;
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txtOld.Text == "") || (txtNew.Text == "") || (txtConfirm.Text == ""))
            {
                MessageBox.Show("One or more fields are empty!");

            }
            else if (txtNew.Text != txtConfirm.Text)
            {
                MessageBox.Show("password mismatch!");
            }
            else if (labelP.Text != txtOld.Text)
            {
                MessageBox.Show("wrong old password!");
            }
            else
            {
                DialogResult del = MessageBox.Show("Are you sure you want to change the :" + labelU.Text + "password", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (del == DialogResult.Yes)
                {
                    string connstr = "Data Source=(DESCRIPTION=" +
         "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-2V34OVD)(PORT = 1521))" +
          "(CONNECT_DATA =" +
             "(SERVER = DEDICATED)" +
             "(SERVICE_NAME = XE)" +
     ")" +
     "); User Id=HR; Password=hr";
                    OracleConnection con = new OracleConnection(connstr);

                    con.Open();
                    OracleCommand cmd = new OracleCommand("update addstuff set password='" + txtNew.Text + "' where (username='" + labelU.Text + "')", con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("password changed");

                    txtOld.Text = "";
                    txtNew.Text = "";
                    txtConfirm.Text = "";
                    con.Close();
                    this.Refresh();

                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }
    }
}
