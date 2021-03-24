namespace Jual_Pulsa
{
    partial class Transaksi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaksi));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbKode = new System.Windows.Forms.ComboBox();
            this.lblOperator = new System.Windows.Forms.Label();
            this.lblTotalHarga = new System.Windows.Forms.Label();
            this.lblUntung = new System.Windows.Forms.Label();
            this.lblJual = new System.Windows.Forms.Label();
            this.numJumlah = new System.Windows.Forms.NumericUpDown();
            this.dtTgl = new System.Windows.Forms.DateTimePicker();
            this.lblTotalUntung = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbxTransaksi = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblModal = new System.Windows.Forms.Label();
            this.dtTransaksi = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRSave = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnRef = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTrKhusus = new System.Windows.Forms.Button();
            this.dtcKode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcHarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcUntung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtctotHarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtctotUntung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numJumlah)).BeginInit();
            this.gbxTransaksi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTransaksi)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Operator :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Harga Jual :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Untung :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Penjualan :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total Harga :";
            // 
            // cmbKode
            // 
            this.cmbKode.AutoCompleteCustomSource.AddRange(new string[] {
            "clash",
            "Blast"});
            this.cmbKode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbKode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbKode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbKode.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKode.FormattingEnabled = true;
            this.cmbKode.Items.AddRange(new object[] {
            "as",
            "bas",
            "clash",
            "bis"});
            this.cmbKode.Location = new System.Drawing.Point(126, 37);
            this.cmbKode.Name = "cmbKode";
            this.cmbKode.Size = new System.Drawing.Size(121, 31);
            this.cmbKode.TabIndex = 7;
            this.cmbKode.SelectedIndexChanged += new System.EventHandler(this.cmbKode_SelectedIndexChanged);
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperator.Location = new System.Drawing.Point(125, 73);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(56, 23);
            this.lblOperator.TabIndex = 8;
            this.lblOperator.Text = "label8";
            // 
            // lblTotalHarga
            // 
            this.lblTotalHarga.AutoSize = true;
            this.lblTotalHarga.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHarga.Location = new System.Drawing.Point(124, 227);
            this.lblTotalHarga.Name = "lblTotalHarga";
            this.lblTotalHarga.Size = new System.Drawing.Size(63, 23);
            this.lblTotalHarga.TabIndex = 10;
            this.lblTotalHarga.Text = "label10";
            // 
            // lblUntung
            // 
            this.lblUntung.AutoSize = true;
            this.lblUntung.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUntung.Location = new System.Drawing.Point(125, 164);
            this.lblUntung.Name = "lblUntung";
            this.lblUntung.Size = new System.Drawing.Size(63, 23);
            this.lblUntung.TabIndex = 12;
            this.lblUntung.Text = "label12";
            // 
            // lblJual
            // 
            this.lblJual.AutoSize = true;
            this.lblJual.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJual.Location = new System.Drawing.Point(125, 104);
            this.lblJual.Name = "lblJual";
            this.lblJual.Size = new System.Drawing.Size(63, 23);
            this.lblJual.TabIndex = 13;
            this.lblJual.Text = "label13";
            // 
            // numJumlah
            // 
            this.numJumlah.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numJumlah.Location = new System.Drawing.Point(125, 192);
            this.numJumlah.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numJumlah.Name = "numJumlah";
            this.numJumlah.Size = new System.Drawing.Size(58, 30);
            this.numJumlah.TabIndex = 14;
            this.numJumlah.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numJumlah.ValueChanged += new System.EventHandler(this.numJumlah_ValueChanged);
            // 
            // dtTgl
            // 
            this.dtTgl.Dock = System.Windows.Forms.DockStyle.Right;
            this.dtTgl.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTgl.Location = new System.Drawing.Point(1060, 0);
            this.dtTgl.Name = "dtTgl";
            this.dtTgl.ShowUpDown = true;
            this.dtTgl.Size = new System.Drawing.Size(294, 31);
            this.dtTgl.TabIndex = 20;
            this.dtTgl.ValueChanged += new System.EventHandler(this.dtTgl_ValueChanged);
            // 
            // lblTotalUntung
            // 
            this.lblTotalUntung.AutoSize = true;
            this.lblTotalUntung.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalUntung.Location = new System.Drawing.Point(124, 257);
            this.lblTotalUntung.Name = "lblTotalUntung";
            this.lblTotalUntung.Size = new System.Drawing.Size(63, 23);
            this.lblTotalUntung.TabIndex = 17;
            this.lblTotalUntung.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 23);
            this.label9.TabIndex = 16;
            this.label9.Text = "Total Untung :";
            // 
            // gbxTransaksi
            // 
            this.gbxTransaksi.Controls.Add(this.btnSave);
            this.gbxTransaksi.Controls.Add(this.btnReset);
            this.gbxTransaksi.Controls.Add(this.label5);
            this.gbxTransaksi.Controls.Add(this.lblModal);
            this.gbxTransaksi.Controls.Add(this.cmbKode);
            this.gbxTransaksi.Controls.Add(this.lblTotalUntung);
            this.gbxTransaksi.Controls.Add(this.label1);
            this.gbxTransaksi.Controls.Add(this.label9);
            this.gbxTransaksi.Controls.Add(this.label2);
            this.gbxTransaksi.Controls.Add(this.label3);
            this.gbxTransaksi.Controls.Add(this.numJumlah);
            this.gbxTransaksi.Controls.Add(this.label4);
            this.gbxTransaksi.Controls.Add(this.lblJual);
            this.gbxTransaksi.Controls.Add(this.lblUntung);
            this.gbxTransaksi.Controls.Add(this.label6);
            this.gbxTransaksi.Controls.Add(this.label7);
            this.gbxTransaksi.Controls.Add(this.lblTotalHarga);
            this.gbxTransaksi.Controls.Add(this.lblOperator);
            this.gbxTransaksi.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTransaksi.Location = new System.Drawing.Point(172, 163);
            this.gbxTransaksi.Name = "gbxTransaksi";
            this.gbxTransaksi.Size = new System.Drawing.Size(340, 304);
            this.gbxTransaksi.TabIndex = 18;
            this.gbxTransaksi.TabStop = false;
            this.gbxTransaksi.Text = "Isi Transaksi";
            this.gbxTransaksi.Enter += new System.EventHandler(this.gbxTransaksi_Enter);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::Jual_Pulsa.Properties.Resources.Save2;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(259, 32);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(72, 39);
            this.btnSave.TabIndex = 41;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.BackgroundImage = global::Jual_Pulsa.Properties.Resources.Reset;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(273, 226);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(50, 48);
            this.btnReset.TabIndex = 42;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "Modal :";
            // 
            // lblModal
            // 
            this.lblModal.AutoSize = true;
            this.lblModal.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModal.Location = new System.Drawing.Point(125, 134);
            this.lblModal.Name = "lblModal";
            this.lblModal.Size = new System.Drawing.Size(50, 23);
            this.lblModal.TabIndex = 21;
            this.lblModal.Text = "lblMl";
            // 
            // dtTransaksi
            // 
            this.dtTransaksi.AllowUserToAddRows = false;
            this.dtTransaksi.AllowUserToOrderColumns = true;
            this.dtTransaksi.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtTransaksi.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtTransaksi.Location = new System.Drawing.Point(14, 16);
            this.dtTransaksi.Name = "dtTransaksi";
            this.dtTransaksi.RowHeadersVisible = false;
            this.dtTransaksi.RowTemplate.Height = 25;
            this.dtTransaksi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dtTransaksi.Size = new System.Drawing.Size(618, 233);
            this.dtTransaksi.TabIndex = 19;
            this.dtTransaksi.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dtTransaksi_CellBeginEdit);
            this.dtTransaksi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtTransaksi_CellClick);
            this.dtTransaksi.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtTransaksi_CellEndEdit);
            this.dtTransaksi.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtTransaksi_CellValueChanged);
            this.dtTransaksi.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtTransaksi_RowHeaderMouseClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(460, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(251, 47);
            this.label8.TabIndex = 45;
            this.label8.Text = "Transaksi Pulsa";
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
            this.btnExit.Location = new System.Drawing.Point(1277, 58);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 50);
            this.btnExit.TabIndex = 44;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRSave
            // 
            this.btnRSave.BackColor = System.Drawing.Color.Transparent;
            this.btnRSave.BackgroundImage = global::Jual_Pulsa.Properties.Resources.Save;
            this.btnRSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRSave.FlatAppearance.BorderSize = 0;
            this.btnRSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRSave.Location = new System.Drawing.Point(462, 490);
            this.btnRSave.Name = "btnRSave";
            this.btnRSave.Size = new System.Drawing.Size(50, 50);
            this.btnRSave.TabIndex = 43;
            this.btnRSave.UseVisualStyleBackColor = false;
            this.btnRSave.Click += new System.EventHandler(this.btnRSave_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Transparent;
            this.btnDel.BackgroundImage = global::Jual_Pulsa.Properties.Resources.DataDel;
            this.btnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Location = new System.Drawing.Point(365, 485);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(65, 61);
            this.btnDel.TabIndex = 20;
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnRef
            // 
            this.btnRef.BackColor = System.Drawing.Color.Transparent;
            this.btnRef.BackgroundImage = global::Jual_Pulsa.Properties.Resources.Refresh;
            this.btnRef.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRef.FlatAppearance.BorderSize = 0;
            this.btnRef.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRef.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRef.Location = new System.Drawing.Point(1190, 58);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(50, 50);
            this.btnRef.TabIndex = 46;
            this.btnRef.UseVisualStyleBackColor = false;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.dtTransaksi);
            this.panel1.Location = new System.Drawing.Point(566, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 487);
            this.panel1.TabIndex = 47;
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
            this.btnTrKhusus.Location = new System.Drawing.Point(276, 490);
            this.btnTrKhusus.Name = "btnTrKhusus";
            this.btnTrKhusus.Size = new System.Drawing.Size(61, 50);
            this.btnTrKhusus.TabIndex = 48;
            this.btnTrKhusus.UseVisualStyleBackColor = false;
            this.btnTrKhusus.Click += new System.EventHandler(this.btnTrKhusus_Click);
            // 
            // dtcKode
            // 
            this.dtcKode.HeaderText = "Kode";
            this.dtcKode.Name = "dtcKode";
            // 
            // dtcHarga
            // 
            this.dtcHarga.HeaderText = "Harga";
            this.dtcHarga.Name = "dtcHarga";
            // 
            // dtcUntung
            // 
            this.dtcUntung.HeaderText = "Untung";
            this.dtcUntung.Name = "dtcUntung";
            // 
            // dtcUnit
            // 
            this.dtcUnit.HeaderText = "Unit";
            this.dtcUnit.Name = "dtcUnit";
            this.dtcUnit.Width = 40;
            // 
            // dtctotHarga
            // 
            this.dtctotHarga.HeaderText = "Total Harga";
            this.dtctotHarga.Name = "dtctotHarga";
            this.dtctotHarga.Width = 133;
            // 
            // dtctotUntung
            // 
            this.dtctotUntung.HeaderText = "Total Untung";
            this.dtctotUntung.Name = "dtctotUntung";
            this.dtctotUntung.Width = 140;
            // 
            // Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.ControlBox = false;
            this.Controls.Add(this.btnTrKhusus);
            this.Controls.Add(this.btnRef);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRSave);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.gbxTransaksi);
            this.Controls.Add(this.dtTgl);
            this.Controls.Add(this.panel1);
            this.Name = "Transaksi";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaksi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Transaksi_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Transaksi_MouseDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.numJumlah)).EndInit();
            this.gbxTransaksi.ResumeLayout(false);
            this.gbxTransaksi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTransaksi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbKode;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Label lblTotalHarga;
        private System.Windows.Forms.Label lblUntung;
        private System.Windows.Forms.Label lblJual;
        private System.Windows.Forms.NumericUpDown numJumlah;
        public System.Windows.Forms.DateTimePicker dtTgl;
        private System.Windows.Forms.Label lblTotalUntung;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbxTransaksi;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblModal;
        public System.Windows.Forms.DataGridView dtTransaksi;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRef;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTrKhusus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcKode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcHarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcUntung;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtctotHarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtctotUntung;
    }
}