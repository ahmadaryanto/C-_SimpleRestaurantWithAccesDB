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
    public partial class frmregis : Form
    {
        public frmregis()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string koneksi = "Provider = Microsoft.jet.oledb.4.0;Data source=" + Application.StartupPath + "/Restoran.mdb";
            if (txtuser.Text == "" || txtpass.Text == "" || cmbtipe.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpass.Clear();
                txtuser.Clear();
                cmbtipe.Text = "";
            }


            try
            {
                string sql = string.Format("Insert into TB_User (Username,Password,Tipe) Values('{0}','{1}','{2}')", txtuser.Text, txtpass.Text, cmbtipe.Text);
                OleDbConnection con = new OleDbConnection(koneksi);
                con.Open();
                OleDbCommand cmd = new OleDbCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Tersimpan", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (OleDbException salah)
            {
                MessageBox.Show(salah.ToString());
            }
        }
    }
}
