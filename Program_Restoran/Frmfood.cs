﻿using System;
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

    public partial class Frmfood : Form
    {
        string koneksi = "Provider = Microsoft.jet.oledb.4.0;Data source=" + Application.StartupPath + "/Restoran.mdb";
        DataSet ds = new DataSet();
        public Frmfood()
        {
            InitializeComponent();
        }

        private void tampil()
        {
            string sql = "select * from TB_Food";
            OleDbConnection con = new OleDbConnection(koneksi);
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "TB_Food");
            con.Close();
            DG.DataSource = ds.Tables["TB_Food"].DefaultView;
        }

        private void search()
        {
            string sql = "select * from TB_Food where id='" + txtid.Text + "'";
            OleDbConnection con = new OleDbConnection(koneksi);
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(sql, con);
         
            da.Fill(ds, "TB_Food");
            con.Close();
            DG.DataSource = ds.Tables["TB_Food"].DefaultView;
        }

        private void Frmfood_Load(object sender, EventArgs e)
        {
            tampil();
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtharga.Text == "" || txtdes.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdes.Clear();
                txtharga.Clear();
                txtid.Clear();
                return;
            }

            try
            {
                string sql = string.Format("Update TB_Food  set Nama_Item ='" + txtdes.Text + "',Harga='" + txtharga.Text + "' where id='" + txtid.Text + "'");
                OleDbConnection con = new OleDbConnection(koneksi);
                con.Open();
                OleDbCommand cmd = new OleDbCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Perubahan Data Tersimpan", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ds.Clear();
                tampil();
            }
            catch (OleDbException salah)
            {
                MessageBox.Show(salah.ToString());
            }
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Yakin Hapus?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string sql = string.Format("delete * from TB_Food where id='" + txtid.Text + "'");
                    OleDbConnection con = new OleDbConnection(koneksi);
                    con.Open();
                    OleDbCommand cmd = new OleDbCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    tampil();
                }
            }

            catch (OleDbException salah)
            {
                MessageBox.Show(salah.ToString());
            }
        }

        private void btsearch_Click(object sender, EventArgs e)
        {
            search();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            tampil();
        }

        private void btnew_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtharga.Text == "" || txtdes.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdes.Clear();
                txtharga.Clear();
                txtid.Clear();
            }
            try
            {
                string sql = string.Format("Insert into TB_Food (ID,Nama_Item,Harga) Values('{0}','{1}','{2}')", txtid.Text, txtdes.Text, txtharga.Text);
                OleDbConnection con = new OleDbConnection(koneksi);
                con.Open();
                OleDbCommand cmd = new OleDbCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Tersimpan", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tampil();
            }
            catch (OleDbException salah)
            {
                MessageBox.Show(salah.ToString());
            }
        }

        private void DG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DG.Rows[e.RowIndex];

                txtid.Text = row.Cells["ID"].Value.ToString();
                txtdes.Text = row.Cells["Nama_Item"].Value.ToString();
                txtharga.Text = row.Cells["Harga"].Value.ToString();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtdes.Enabled = true;
            txtharga.Enabled = true;
            txtid.Enabled = true;
        }
    }
}
