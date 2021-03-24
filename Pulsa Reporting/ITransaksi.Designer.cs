namespace Jual_Pulsa
{
    partial class ITransaksi
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
            this.TrPulse = new System.Windows.Forms.Button();
            this.btnTrKhusus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TrPulse
            // 
            this.TrPulse.BackColor = System.Drawing.Color.Transparent;
            this.TrPulse.BackgroundImage = global::Jual_Pulsa.Properties.Resources.Transaksi_Pulsa;
            this.TrPulse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TrPulse.FlatAppearance.BorderSize = 0;
            this.TrPulse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TrPulse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TrPulse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TrPulse.Location = new System.Drawing.Point(69, 119);
            this.TrPulse.Name = "TrPulse";
            this.TrPulse.Size = new System.Drawing.Size(100, 100);
            this.TrPulse.TabIndex = 0;
            this.TrPulse.UseVisualStyleBackColor = false;
            this.TrPulse.Click += new System.EventHandler(this.TrPulse_Click);
            // 
            // btnTrKhusus
            // 
            this.btnTrKhusus.BackColor = System.Drawing.Color.Transparent;
            this.btnTrKhusus.BackgroundImage = global::Jual_Pulsa.Properties.Resources.Transaksi_Khusus;
            this.btnTrKhusus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTrKhusus.FlatAppearance.BorderSize = 0;
            this.btnTrKhusus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTrKhusus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTrKhusus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrKhusus.Location = new System.Drawing.Point(283, 119);
            this.btnTrKhusus.Name = "btnTrKhusus";
            this.btnTrKhusus.Size = new System.Drawing.Size(100, 100);
            this.btnTrKhusus.TabIndex = 1;
            this.btnTrKhusus.UseVisualStyleBackColor = false;
            this.btnTrKhusus.Click += new System.EventHandler(this.btnTrKhusus_Click);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Transaksi Pulsa";
            this.label1.Click += new System.EventHandler(this.TrPulse_Click);
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Transaksi Khusus";
            this.label2.Click += new System.EventHandler(this.btnTrKhusus_Click);
            // 
            // ITransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 310);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTrKhusus);
            this.Controls.Add(this.TrPulse);
            this.Name = "ITransaksi";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ITransaksi";
            this.Load += new System.EventHandler(this.ITransaksi_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ITransaksi_MouseDoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TrPulse;
        private System.Windows.Forms.Button btnTrKhusus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}