using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Program_Restoran
{
    public partial class Frmlogin : Form
    {
       
        string koneksi = "Provider = Microsoft.jet.oledb.4.0;Data source=" + Application.StartupPath + "/Restoran.mdb";
        OleDbConnection Con;
        OleDbCommand Cmd;
        OleDbDataReader Dr;

        public Frmlogin()
        {
            InitializeComponent();
        }

      


        private void BTlogin_Click(object sender, EventArgs e)
        {
            string Usr = txtname.Text;
            string Pass = txtpassword.Text;
            Con = new OleDbConnection(koneksi);
            Cmd = new OleDbCommand();
            Con.Open();
            Cmd.Connection = Con;
            Cmd.CommandText = "SELECT * From TB_USER Where Username='" + txtname.Text + "'And Password='" + txtpassword.Text + "'";
            Dr = Cmd.ExecuteReader();
            if (Dr.Read())
            {
                Form1 F1 = new Form1();
                F1.Show();
                F1.LabelText = this.txtname.Text;
            }
            else
            {
                MessageBox.Show("Username Or Password Is Incorrect!");
            }
            Con.Close();
           


        }

        private void BtCancel_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtpassword.Clear();
        }
    }
}
