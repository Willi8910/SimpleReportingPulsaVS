namespace Jual_Pulsa
{
    partial class DetailPulsa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailPulsa));
            this.dtMkios = new System.Windows.Forms.DataGridView();
            this.dtcKode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcHarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcModal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbMUntung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtAllOp = new System.Windows.Forms.DataGridView();
            this.dtaKode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtaHarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtaModal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbAUntung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panAllOp = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRefffesh = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtMkios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAllOp)).BeginInit();
            this.panel1.SuspendLayout();
            this.panAllOp.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtMkios
            // 
            this.dtMkios.AllowUserToAddRows = false;
            this.dtMkios.AllowUserToDeleteRows = false;
            this.dtMkios.AllowUserToOrderColumns = true;
            this.dtMkios.AllowUserToResizeColumns = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtMkios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtMkios.ColumnHeadersHeight = 30;
            this.dtMkios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtMkios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtcKode,
            this.dtcHarga,
            this.dtcModal,
            this.tbMUntung});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtMkios.DefaultCellStyle = dataGridViewCellStyle11;
            this.dtMkios.Location = new System.Drawing.Point(3, 3);
            this.dtMkios.Name = "dtMkios";
            this.dtMkios.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtMkios.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dtMkios.RowHeadersVisible = false;
            this.dtMkios.RowHeadersWidth = 50;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtMkios.RowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dtMkios.RowTemplate.Height = 25;
            this.dtMkios.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtMkios.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dtMkios.Size = new System.Drawing.Size(409, 150);
            this.dtMkios.TabIndex = 0;
            this.dtMkios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtMkios_CellClick);
            this.dtMkios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtMkios_CellContentClick);
            this.dtMkios.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtMkios_ColumnHeaderMouseClick);
            this.dtMkios.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtMkios_RowHeaderMouseClick);
            // 
            // dtcKode
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.dtcKode.DefaultCellStyle = dataGridViewCellStyle10;
            this.dtcKode.HeaderText = "Kode";
            this.dtcKode.Name = "dtcKode";
            this.dtcKode.ReadOnly = true;
            // 
            // dtcHarga
            // 
            this.dtcHarga.HeaderText = "Harga";
            this.dtcHarga.Name = "dtcHarga";
            this.dtcHarga.ReadOnly = true;
            // 
            // dtcModal
            // 
            this.dtcModal.HeaderText = "Modal";
            this.dtcModal.Name = "dtcModal";
            this.dtcModal.ReadOnly = true;
            // 
            // tbMUntung
            // 
            this.tbMUntung.HeaderText = "Untung";
            this.tbMUntung.Name = "tbMUntung";
            this.tbMUntung.ReadOnly = true;
            // 
            // dtAllOp
            // 
            this.dtAllOp.AllowUserToAddRows = false;
            this.dtAllOp.AllowUserToDeleteRows = false;
            this.dtAllOp.AllowUserToOrderColumns = true;
            this.dtAllOp.AllowUserToResizeColumns = false;
            this.dtAllOp.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtAllOp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dtAllOp.ColumnHeadersHeight = 30;
            this.dtAllOp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtaKode,
            this.dtaHarga,
            this.dtaModal,
            this.tbAUntung});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtAllOp.DefaultCellStyle = dataGridViewCellStyle15;
            this.dtAllOp.Location = new System.Drawing.Point(57, 54);
            this.dtAllOp.Name = "dtAllOp";
            this.dtAllOp.ReadOnly = true;
            this.dtAllOp.RowHeadersVisible = false;
            this.dtAllOp.RowHeadersWidth = 50;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtAllOp.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dtAllOp.RowTemplate.Height = 25;
            this.dtAllOp.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtAllOp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dtAllOp.Size = new System.Drawing.Size(406, 150);
            this.dtAllOp.TabIndex = 1;
            this.dtAllOp.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtAllOp_RowHeaderMouseClick);
            // 
            // dtaKode
            // 
            this.dtaKode.HeaderText = "Kode";
            this.dtaKode.Name = "dtaKode";
            this.dtaKode.ReadOnly = true;
            // 
            // dtaHarga
            // 
            this.dtaHarga.HeaderText = "Harga";
            this.dtaHarga.Name = "dtaHarga";
            this.dtaHarga.ReadOnly = true;
            // 
            // dtaModal
            // 
            this.dtaModal.HeaderText = "Modal";
            this.dtaModal.Name = "dtaModal";
            this.dtaModal.ReadOnly = true;
            // 
            // tbAUntung
            // 
            this.tbAUntung.HeaderText = "Untung";
            this.tbAUntung.Name = "tbAUntung";
            this.tbAUntung.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.dtMkios);
            this.panel1.Location = new System.Drawing.Point(467, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 258);
            this.panel1.TabIndex = 4;
            // 
            // panAllOp
            // 
            this.panAllOp.AutoScroll = true;
            this.panAllOp.BackColor = System.Drawing.Color.Transparent;
            this.panAllOp.Controls.Add(this.dtAllOp);
            this.panAllOp.Location = new System.Drawing.Point(165, 480);
            this.panAllOp.Name = "panAllOp";
            this.panAllOp.Size = new System.Drawing.Size(1024, 463);
            this.panAllOp.TabIndex = 5;
            this.panAllOp.Scroll += new System.Windows.Forms.ScrollEventHandler(this.panel2_Scroll);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(551, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mkios / Voucher";
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(586, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "All Operator";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(1248, 33);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 50);
            this.btnExit.TabIndex = 26;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRefffesh
            // 
            this.btnRefffesh.BackgroundImage = global::Jual_Pulsa.Properties.Resources.Refresh;
            this.btnRefffesh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefffesh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefffesh.Location = new System.Drawing.Point(1082, 33);
            this.btnRefffesh.Name = "btnRefffesh";
            this.btnRefffesh.Size = new System.Drawing.Size(50, 50);
            this.btnRefffesh.TabIndex = 3;
            this.btnRefffesh.UseVisualStyleBackColor = true;
            this.btnRefffesh.Click += new System.EventHandler(this.btnRefffesh_Click);
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
            this.btnNew.Location = new System.Drawing.Point(1167, 33);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(50, 50);
            this.btnNew.TabIndex = 2;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // DetailPulsa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRefffesh);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panAllOp);
            this.DoubleBuffered = true;
            this.Name = "DetailPulsa";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pulsa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Pulsa_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DetailPulsa_MouseDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.dtMkios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAllOp)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panAllOp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtMkios;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnRefffesh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtaKode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtaHarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtaModal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panAllOp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcKode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcHarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcModal;
        public System.Windows.Forms.DataGridView dtAllOp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbMUntung;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbAUntung;
    }
}