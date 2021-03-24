namespace Jual_Pulsa
{
    partial class DisplayOperator
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.dtTransaksi = new System.Windows.Forms.DataGridView();
            this.dtcKode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcHarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcUntung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtctotHarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtctotUntung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.PanOp = new System.Windows.Forms.Panel();
            this.lblContoh = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtTransaksi)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Jual_Pulsa.Properties.Resources.Refresh;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(1044, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtTransaksi
            // 
            this.dtTransaksi.AllowUserToAddRows = false;
            this.dtTransaksi.AllowUserToDeleteRows = false;
            this.dtTransaksi.AllowUserToOrderColumns = true;
            this.dtTransaksi.AllowUserToResizeColumns = false;
            this.dtTransaksi.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtTransaksi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtTransaksi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtcKode,
            this.dtcHarga,
            this.dtcUntung,
            this.dtcUnit,
            this.dtctotHarga,
            this.dtctotUntung});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtTransaksi.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtTransaksi.Location = new System.Drawing.Point(740, 110);
            this.dtTransaksi.Name = "dtTransaksi";
            this.dtTransaksi.ReadOnly = true;
            this.dtTransaksi.RowHeadersVisible = false;
            this.dtTransaksi.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtTransaksi.RowTemplate.Height = 25;
            this.dtTransaksi.Size = new System.Drawing.Size(511, 200);
            this.dtTransaksi.TabIndex = 22;
            this.dtTransaksi.Visible = false;
            // 
            // dtcKode
            // 
            this.dtcKode.HeaderText = "Kode";
            this.dtcKode.Name = "dtcKode";
            this.dtcKode.ReadOnly = true;
            this.dtcKode.Width = 80;
            // 
            // dtcHarga
            // 
            this.dtcHarga.HeaderText = "Harga";
            this.dtcHarga.Name = "dtcHarga";
            this.dtcHarga.ReadOnly = true;
            this.dtcHarga.Width = 85;
            // 
            // dtcUntung
            // 
            this.dtcUntung.HeaderText = "Untung";
            this.dtcUntung.Name = "dtcUntung";
            this.dtcUntung.ReadOnly = true;
            this.dtcUntung.Width = 85;
            // 
            // dtcUnit
            // 
            this.dtcUnit.HeaderText = "Unit";
            this.dtcUnit.Name = "dtcUnit";
            this.dtcUnit.ReadOnly = true;
            this.dtcUnit.Width = 40;
            // 
            // dtctotHarga
            // 
            this.dtctotHarga.HeaderText = "Total Harga";
            this.dtctotHarga.Name = "dtctotHarga";
            this.dtctotHarga.ReadOnly = true;
            this.dtctotHarga.Width = 105;
            // 
            // dtctotUntung
            // 
            this.dtctotUntung.HeaderText = "Total Untung";
            this.dtctotUntung.Name = "dtctotUntung";
            this.dtctotUntung.ReadOnly = true;
            this.dtctotUntung.Width = 110;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(588, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 68);
            this.label1.TabIndex = 23;
            this.label1.Text = "Operator";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.BackgroundImage = global::Jual_Pulsa.Properties.Resources.Add;
            this.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Location = new System.Drawing.Point(1135, 48);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(50, 50);
            this.btnNew.TabIndex = 24;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::Jual_Pulsa.Properties.Resources.Exit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(1233, 48);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 50);
            this.btnExit.TabIndex = 25;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // PanOp
            // 
            this.PanOp.AutoScroll = true;
            this.PanOp.AutoSize = true;
            this.PanOp.BackColor = System.Drawing.Color.Transparent;
            this.PanOp.Location = new System.Drawing.Point(97, 207);
            this.PanOp.Name = "PanOp";
            this.PanOp.Size = new System.Drawing.Size(1256, 482);
            this.PanOp.TabIndex = 0;
            this.PanOp.Paint += new System.Windows.Forms.PaintEventHandler(this.PanOp_Paint);
            // 
            // lblContoh
            // 
            this.lblContoh.AutoSize = true;
            this.lblContoh.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContoh.Location = new System.Drawing.Point(32, 48);
            this.lblContoh.Name = "lblContoh";
            this.lblContoh.Size = new System.Drawing.Size(87, 23);
            this.lblContoh.TabIndex = 26;
            this.lblContoh.Text = "Intersisial";
            this.lblContoh.Visible = false;
            // 
            // DisplayOperator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.lblContoh);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PanOp);
            this.Controls.Add(this.dtTransaksi);
            this.Name = "DisplayOperator";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisplayOperator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DisplayOperator_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DisplayOperator_MouseDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.dtTransaksi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dtTransaksi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel PanOp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcKode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcHarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcUntung;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtctotHarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtctotUntung;
        private System.Windows.Forms.Label lblContoh;
    }
}