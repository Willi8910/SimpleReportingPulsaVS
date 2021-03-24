using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jual_Pulsa
{
    public partial class FBuatPulsa : Form
    {
        Utama Maim;
        public FBuatPulsa()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog clgBac = new ColorDialog();
            clgBac.FullOpen = false;
            DialogResult PilihWarna = clgBac.ShowDialog();
            if(PilihWarna == System.Windows.Forms.DialogResult.OK)
            {
                btnColor.BackColor = clgBac.Color;
            }
        }

        private void btnPSave_Click(object sender, EventArgs e)
        {
            bool avaib = true;
            foreach(Operator Op in Maim.listOperator)
            {
                if(Op.Alias == txtAlias.Text)
                {
                    avaib = false;
                    MessageBox.Show("Kode yang kamu gunakan sudah ada, silahkan gunakan kode yang lain", "Notification");
                    break;
                }
            }
            if (avaib == true)
            {

                MessageBox.Show("Input Operator telah berhasil!!!", "Pemberitahuan");
                if (rbtMkios.Checked == true)
                {
                    Operator Op = new Operator(PulsaType.Mkios, txtOpName.Text, txtAlias.Text, btnColor.BackColor);
                    Maim.listOperator.Add(Op);
                }
                else if (rbtAll.Checked == true)
                {
                    Operator Op = new Operator(PulsaType.AllOperator, txtOpName.Text, txtAlias.Text, btnColor.BackColor);
                    Maim.listOperator.Add(Op);
                }
                Maim = (Utama)this.Owner;
                cmbOperator.DataSource = null;
                cmbOperator.DataSource = Maim.listOperator;
                cmbOperator.DisplayMember = "Nama";
                cmbOperator.SelectedIndex = cmbOperator.Items.Count - 1;
                btnPReset_Click(sender, e);
                
            }
        }

        private void btnPReset_Click(object sender, EventArgs e)
        {
            txtOpName.Text = "";
            txtAlias.Text = "";
            btnColor.BackColor = SystemColors.Control;
            rbtAll.Select();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NewOp.Enabled = true;
            NewOp.Visible = true;
            NewOp.Left = 0;
            txtOpName.Focus();
        }

        private void btnPBack_Click(object sender, EventArgs e)
        {
            NewOp.Enabled = false;
            NewOp.Visible = false;
            btnPReset_Click(sender, e);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuatPulsa_Load(object sender, EventArgs e)
        {
            Maim = (Utama)this.Owner;
            rbtMkios.Select();
            cmbOperator.DataSource = Maim.listOperator;
            cmbOperator.DisplayMember = "Nama";
            NewOp.Left = 0;
            NewOp.Visible = false;
        }

        private void cmbOperator_SelectedIndexChanged(object sender, EventArgs e)
        {
            Operator Oper = (Operator)cmbOperator.SelectedValue;
            if (Oper != null)
            {
                txtKode.Text = Oper.Alias + " " + numNominal.Value.ToString();
                numModal.Value = numNominal.Value * 1000;
                numHarga.Value = numModal.Value + 1000;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbOperator.SelectedIndex = 0;
            numNominal.Value = 5;
            numHarga.Value = 0;
            numModal.Value = 0;
            txtKode.Text = "";
            rbtMkios.Checked =true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool avaib = true;
            foreach (Pulsa Op in Maim.listPulsa)
            {
                if (Op.Kode == txtKode.Text)
                {
                    avaib = false;
                    MessageBox.Show("Kode yang kamu gunakan sudah ada, silahkan gunakan kode yang lain", "Notification");
                    break;
                }
            }
            if (avaib == true)
            {
                Operator Pulse = (Operator)cmbOperator.SelectedValue;
                if (Pulse.TipePulsa == PulsaType.AllOperator)
                {
                    Pulsa Pull = new Pulsa(Pulse, txtKode.Text, (int)(numModal.Value), (int)(numHarga.Value));
                    Maim.listPulsa.Add(Pull);
                }
                else if (Pulse.TipePulsa == PulsaType.Mkios)
                {
                    PulsaMkios Pulss = new PulsaMkios(Pulse, txtKode.Text, (int)(numModal.Value), (int)(numHarga.Value), 1000000, 0);
                    Maim.listPulsa.Add(Pulss);
                }
                //btnReset_Click(sender, e);
                MessageBox.Show("This Pulsa has been added");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void NewOp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BuatPulsa_FormClosing(object sender, FormClosingEventArgs e)
        {
         
        }

        private void FBuatPulsa_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down && txtOpName.Focus())
            {
                txtAlias.Focus();
            }
            if (e.KeyCode == Keys.Up && txtAlias.Focus())
            {
                txtOpName.Focus();
            }
        }

        private void FBuatPulsa_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
