namespace Program_Restoran
{
    partial class frmbayar
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
            this.txtpembelian = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbayar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtkembali = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtpembelian
            // 
            this.txtpembelian.Enabled = false;
            this.txtpembelian.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpembelian.Location = new System.Drawing.Point(178, 69);
            this.txtpembelian.Name = "txtpembelian";
            this.txtpembelian.Size = new System.Drawing.Size(178, 29);
            this.txtpembelian.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Jumlah Pembelian";
            // 
            // txttax
            // 
            this.txttax.Enabled = false;
            this.txttax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttax.Location = new System.Drawing.Point(178, 114);
            this.txttax.Name = "txttax";
            this.txttax.Size = new System.Drawing.Size(178, 29);
            this.txttax.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "tax";
            // 
            // txtbayar
            // 
            this.txtbayar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbayar.Location = new System.Drawing.Point(178, 158);
            this.txtbayar.Name = "txtbayar";
            this.txtbayar.Size = new System.Drawing.Size(178, 29);
            this.txtbayar.TabIndex = 22;
            this.txtbayar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbayar_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Jumlah Pembayaran";
            // 
            // txtkembali
            // 
            this.txtkembali.Enabled = false;
            this.txtkembali.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkembali.Location = new System.Drawing.Point(178, 204);
            this.txtkembali.Name = "txtkembali";
            this.txtkembali.Size = new System.Drawing.Size(178, 29);
            this.txtkembali.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Kembalian";
            // 
            // frmbayar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(384, 254);
            this.Controls.Add(this.txtkembali);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbayar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpembelian);
            this.Controls.Add(this.label5);
            this.Name = "frmbayar";
            this.Text = "frmbayar";
            this.Load += new System.EventHandler(this.frmbayar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtpembelian;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txttax;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtbayar;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtkembali;
        internal System.Windows.Forms.Label label3;
    }
}