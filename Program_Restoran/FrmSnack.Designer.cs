namespace Program_Restoran
{
    partial class FrmSnack
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSnack));
            this.Button2 = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.DG = new System.Windows.Forms.DataGridView();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.btsearch = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.btsave = new System.Windows.Forms.Button();
            this.btnew = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtharga = new System.Windows.Forms.TextBox();
            this.txtdes = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).BeginInit();
            this.Panel1.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button2
            // 
            this.Button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button2.Location = new System.Drawing.Point(200, 0);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(51, 50);
            this.Button2.TabIndex = 6;
            this.Button2.Text = "Show All";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(157, 29);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(197, 29);
            this.txtid.TabIndex = 2;
            this.txtid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtid_KeyPress);
            // 
            // DG
            // 
            this.DG.AllowUserToAddRows = false;
            this.DG.AllowUserToDeleteRows = false;
            this.DG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DG.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG.DefaultCellStyle = dataGridViewCellStyle1;
            this.DG.Location = new System.Drawing.Point(12, 229);
            this.DG.Name = "DG";
            this.DG.ReadOnly = true;
            this.DG.RowHeadersVisible = false;
            this.DG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG.Size = new System.Drawing.Size(504, 273);
            this.DG.TabIndex = 18;
            this.DG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_CellContentClick);
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.Button2);
            this.Panel1.Controls.Add(this.btsearch);
            this.Panel1.Controls.Add(this.btdelete);
            this.Panel1.Controls.Add(this.btsave);
            this.Panel1.Controls.Add(this.btnew);
            this.Panel1.Location = new System.Drawing.Point(12, 14);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(251, 50);
            this.Panel1.TabIndex = 17;
            // 
            // btsearch
            // 
            this.btsearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.btsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsearch.Image = ((System.Drawing.Image)(resources.GetObject("btsearch.Image")));
            this.btsearch.Location = new System.Drawing.Point(150, 0);
            this.btsearch.Name = "btsearch";
            this.btsearch.Size = new System.Drawing.Size(50, 50);
            this.btsearch.TabIndex = 5;
            this.btsearch.UseVisualStyleBackColor = true;
            this.btsearch.Click += new System.EventHandler(this.btsearch_Click);
            // 
            // btdelete
            // 
            this.btdelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btdelete.Image = ((System.Drawing.Image)(resources.GetObject("btdelete.Image")));
            this.btdelete.Location = new System.Drawing.Point(100, 0);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(50, 50);
            this.btdelete.TabIndex = 4;
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // btsave
            // 
            this.btsave.Dock = System.Windows.Forms.DockStyle.Left;
            this.btsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsave.Image = ((System.Drawing.Image)(resources.GetObject("btsave.Image")));
            this.btsave.Location = new System.Drawing.Point(50, 0);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(50, 50);
            this.btsave.TabIndex = 3;
            this.btsave.UseVisualStyleBackColor = true;
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // btnew
            // 
            this.btnew.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnew.Image = ((System.Drawing.Image)(resources.GetObject("btnew.Image")));
            this.btnew.Location = new System.Drawing.Point(0, 0);
            this.btnew.Name = "btnew";
            this.btnew.Size = new System.Drawing.Size(50, 50);
            this.btnew.TabIndex = 2;
            this.btnew.UseVisualStyleBackColor = true;
            this.btnew.Click += new System.EventHandler(this.btnew_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtharga);
            this.GroupBox1.Controls.Add(this.txtdes);
            this.GroupBox1.Controls.Add(this.txtid);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(12, 83);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(504, 139);
            this.GroupBox1.TabIndex = 16;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Detail";
            // 
            // txtharga
            // 
            this.txtharga.Location = new System.Drawing.Point(157, 99);
            this.txtharga.Name = "txtharga";
            this.txtharga.Size = new System.Drawing.Size(241, 29);
            this.txtharga.TabIndex = 3;
            // 
            // txtdes
            // 
            this.txtdes.Location = new System.Drawing.Point(157, 64);
            this.txtdes.Name = "txtdes";
            this.txtdes.Size = new System.Drawing.Size(241, 29);
            this.txtdes.TabIndex = 4;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(6, 102);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(61, 24);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Harga";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(6, 67);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(86, 24);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Deskripsi";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(6, 32);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(27, 24);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "ID";
            // 
            // FrmSnack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 513);
            this.Controls.Add(this.DG);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.GroupBox1);
            this.Name = "FrmSnack";
            this.Text = "FrmSnack";
            this.Load += new System.EventHandler(this.FrmSnack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.TextBox txtid;
        internal System.Windows.Forms.DataGridView DG;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Button btsearch;
        internal System.Windows.Forms.Button btdelete;
        internal System.Windows.Forms.Button btsave;
        internal System.Windows.Forms.Button btnew;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox txtharga;
        internal System.Windows.Forms.TextBox txtdes;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}