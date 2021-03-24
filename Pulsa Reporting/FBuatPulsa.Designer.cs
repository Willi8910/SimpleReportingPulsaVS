namespace Jual_Pulsa
{
    partial class FBuatPulsa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbOperator = new System.Windows.Forms.ComboBox();
            this.NewOp = new System.Windows.Forms.Panel();
            this.btnPSave = new System.Windows.Forms.Button();
            this.btnPReset = new System.Windows.Forms.Button();
            this.btnPBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtAll = new System.Windows.Forms.RadioButton();
            this.rbtMkios = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAlias = new System.Windows.Forms.TextBox();
            this.txtOpName = new System.Windows.Forms.TextBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numNominal = new System.Windows.Forms.NumericUpDown();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.numModal = new System.Windows.Forms.NumericUpDown();
            this.numHarga = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.NewOp.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNominal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numModal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHarga)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operator : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nominal Pulsa : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kode : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Modal : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Harga Jual :";
            // 
            // cmbOperator
            // 
            this.cmbOperator.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOperator.FormattingEnabled = true;
            this.cmbOperator.Location = new System.Drawing.Point(141, 45);
            this.cmbOperator.Name = "cmbOperator";
            this.cmbOperator.Size = new System.Drawing.Size(121, 26);
            this.cmbOperator.TabIndex = 8;
            this.cmbOperator.SelectedIndexChanged += new System.EventHandler(this.cmbOperator_SelectedIndexChanged);
            // 
            // NewOp
            // 
            this.NewOp.Controls.Add(this.btnPSave);
            this.NewOp.Controls.Add(this.btnPReset);
            this.NewOp.Controls.Add(this.btnPBack);
            this.NewOp.Controls.Add(this.panel1);
            this.NewOp.Controls.Add(this.txtAlias);
            this.NewOp.Controls.Add(this.txtOpName);
            this.NewOp.Controls.Add(this.btnColor);
            this.NewOp.Controls.Add(this.label11);
            this.NewOp.Controls.Add(this.label10);
            this.NewOp.Controls.Add(this.label9);
            this.NewOp.Enabled = false;
            this.NewOp.Location = new System.Drawing.Point(397, 13);
            this.NewOp.Name = "NewOp";
            this.NewOp.Size = new System.Drawing.Size(377, 349);
            this.NewOp.TabIndex = 9;
            this.NewOp.Paint += new System.Windows.Forms.PaintEventHandler(this.NewOp_Paint);
            // 
            // btnPSave
            // 
            this.btnPSave.BackgroundImage = global::Jual_Pulsa.Properties.Resources.Save2;
            this.btnPSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPSave.FlatAppearance.BorderSize = 0;
            this.btnPSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPSave.Location = new System.Drawing.Point(247, 238);
            this.btnPSave.Name = "btnPSave";
            this.btnPSave.Size = new System.Drawing.Size(73, 35);
            this.btnPSave.TabIndex = 45;
            this.btnPSave.UseVisualStyleBackColor = true;
            this.btnPSave.Click += new System.EventHandler(this.btnPSave_Click);
            // 
            // btnPReset
            // 
            this.btnPReset.BackColor = System.Drawing.Color.Transparent;
            this.btnPReset.BackgroundImage = global::Jual_Pulsa.Properties.Resources.Reset;
            this.btnPReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPReset.FlatAppearance.BorderSize = 0;
            this.btnPReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPReset.Location = new System.Drawing.Point(195, 237);
            this.btnPReset.Name = "btnPReset";
            this.btnPReset.Size = new System.Drawing.Size(35, 35);
            this.btnPReset.TabIndex = 44;
            this.btnPReset.UseVisualStyleBackColor = false;
            this.btnPReset.Click += new System.EventHandler(this.btnPReset_Click);
            // 
            // btnPBack
            // 
            this.btnPBack.BackColor = System.Drawing.Color.Transparent;
            this.btnPBack.BackgroundImage = global::Jual_Pulsa.Properties.Resources.Back;
            this.btnPBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPBack.FlatAppearance.BorderSize = 0;
            this.btnPBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPBack.Location = new System.Drawing.Point(31, 238);
            this.btnPBack.Name = "btnPBack";
            this.btnPBack.Size = new System.Drawing.Size(35, 35);
            this.btnPBack.TabIndex = 43;
            this.btnPBack.UseVisualStyleBackColor = false;
            this.btnPBack.Click += new System.EventHandler(this.btnPBack_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtAll);
            this.panel1.Controls.Add(this.rbtMkios);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(69, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 65);
            this.panel1.TabIndex = 22;
            // 
            // rbtAll
            // 
            this.rbtAll.AutoSize = true;
            this.rbtAll.Location = new System.Drawing.Point(107, 14);
            this.rbtAll.Name = "rbtAll";
            this.rbtAll.Size = new System.Drawing.Size(102, 22);
            this.rbtAll.TabIndex = 21;
            this.rbtAll.TabStop = true;
            this.rbtAll.Text = "All Operator";
            this.rbtAll.UseVisualStyleBackColor = true;
            // 
            // rbtMkios
            // 
            this.rbtMkios.AutoSize = true;
            this.rbtMkios.Location = new System.Drawing.Point(107, 37);
            this.rbtMkios.Name = "rbtMkios";
            this.rbtMkios.Size = new System.Drawing.Size(62, 22);
            this.rbtMkios.TabIndex = 20;
            this.rbtMkios.TabStop = true;
            this.rbtMkios.Text = "MKios";
            this.rbtMkios.UseVisualStyleBackColor = true;
            this.rbtMkios.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(55, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 18);
            this.label12.TabIndex = 19;
            this.label12.Text = "Tipe :";
            // 
            // txtAlias
            // 
            this.txtAlias.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlias.Location = new System.Drawing.Point(176, 133);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(100, 26);
            this.txtAlias.TabIndex = 15;
            this.txtAlias.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FBuatPulsa_KeyDown);
            // 
            // txtOpName
            // 
            this.txtOpName.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpName.Location = new System.Drawing.Point(176, 89);
            this.txtOpName.Name = "txtOpName";
            this.txtOpName.Size = new System.Drawing.Size(100, 26);
            this.txtOpName.TabIndex = 14;
            this.txtOpName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FBuatPulsa_KeyDown);
            // 
            // btnColor
            // 
            this.btnColor.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColor.Location = new System.Drawing.Point(176, 177);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(36, 23);
            this.btnColor.TabIndex = 13;
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(53, 182);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 18);
            this.label11.TabIndex = 12;
            this.label11.Text = "Warna Operator : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(117, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 18);
            this.label10.TabIndex = 11;
            this.label10.Text = "Kode : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(57, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 18);
            this.label9.TabIndex = 10;
            this.label9.Text = "Nama Operator : ";
            // 
            // numNominal
            // 
            this.numNominal.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNominal.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numNominal.Location = new System.Drawing.Point(141, 89);
            this.numNominal.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numNominal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNominal.Name = "numNominal";
            this.numNominal.Size = new System.Drawing.Size(70, 26);
            this.numNominal.TabIndex = 10;
            this.numNominal.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numNominal.ValueChanged += new System.EventHandler(this.cmbOperator_SelectedIndexChanged);
            // 
            // txtKode
            // 
            this.txtKode.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKode.Location = new System.Drawing.Point(141, 136);
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(100, 26);
            this.txtKode.TabIndex = 19;
            // 
            // numModal
            // 
            this.numModal.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numModal.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numModal.Location = new System.Drawing.Point(141, 182);
            this.numModal.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numModal.Name = "numModal";
            this.numModal.Size = new System.Drawing.Size(121, 26);
            this.numModal.TabIndex = 20;
            // 
            // numHarga
            // 
            this.numHarga.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numHarga.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numHarga.Location = new System.Drawing.Point(141, 225);
            this.numHarga.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numHarga.Name = "numHarga";
            this.numHarga.Size = new System.Drawing.Size(121, 26);
            this.numHarga.TabIndex = 21;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::Jual_Pulsa.Properties.Resources.Save;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(304, 297);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(35, 35);
            this.btnSave.TabIndex = 42;
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
            this.btnReset.Location = new System.Drawing.Point(225, 297);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(35, 35);
            this.btnReset.TabIndex = 41;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::Jual_Pulsa.Properties.Resources.Back;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(25, 297);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(35, 35);
            this.btnBack.TabIndex = 26;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            this.btnNew.Location = new System.Drawing.Point(285, 43);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(25, 25);
            this.btnNew.TabIndex = 25;
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FBuatPulsa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 367);
            this.Controls.Add(this.NewOp);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.numHarga);
            this.Controls.Add(this.numModal);
            this.Controls.Add(this.txtKode);
            this.Controls.Add(this.numNominal);
            this.Controls.Add(this.cmbOperator);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FBuatPulsa";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buat Pulsa Baru";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BuatPulsa_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FBuatPulsa_FormClosed);
            this.Load += new System.EventHandler(this.BuatPulsa_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FBuatPulsa_KeyDown);
            this.NewOp.ResumeLayout(false);
            this.NewOp.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNominal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numModal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHarga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbOperator;
        private System.Windows.Forms.Panel NewOp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAlias;
        private System.Windows.Forms.TextBox txtOpName;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.NumericUpDown numNominal;
        private System.Windows.Forms.TextBox txtKode;
        private System.Windows.Forms.NumericUpDown numModal;
        private System.Windows.Forms.NumericUpDown numHarga;
        private System.Windows.Forms.RadioButton rbtAll;
        private System.Windows.Forms.RadioButton rbtMkios;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPReset;
        private System.Windows.Forms.Button btnPBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPSave;
    }
}