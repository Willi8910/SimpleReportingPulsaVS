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
    public partial class FDetailOperator : Form
    {
        Utama Maim;
        DisplayOperator DisP;
        int dex;
        public FDetailOperator()
        {
            InitializeComponent();
        }

        private void FDetailOperator_Load(object sender, EventArgs e)
        {
            DisP = (DisplayOperator)this.Owner;
             dex = DisP.dexOpe;
            Maim = (Utama)this.Owner.Owner;
            Resetter();
        }

        private void Resetter()
        {
            if (Maim.listOperator[dex].TipePulsa == PulsaType.Mkios)
            {
                rbtMkios.Checked = true;
            }
            else if (Maim.listOperator[dex].TipePulsa == PulsaType.AllOperator)
            {
                rbtAll.Checked = true;
            }
            txtOpName.Text = Maim.listOperator[dex].Nama;
            txtAlias.Text = Maim.listOperator[dex].Alias;
            btnColor.BackColor = Maim.listOperator[dex].Warna;
        }

        private void btnPBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog Corgi = new ColorDialog();
            //Corgi.AllowFullOpen = false;
            DialogResult useeer = Corgi.ShowDialog();
            if (useeer == System.Windows.Forms.DialogResult.OK)
            {
                btnColor.BackColor = Corgi.Color;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int ada = 0;
            foreach (Pulsa Pulse in Maim.listPulsa)
            {
                if (Pulse.Operand.Nama == Maim.listOperator[dex].Nama)
                {
                    ada++;
                }
            }
            if (ada == 0)
            {
                DialogResult usee = MessageBox.Show("Are you sure want to delete this Operator?", "Notification", MessageBoxButtons.YesNo);
                if (usee == System.Windows.Forms.DialogResult.Yes)
                {
                    Maim.listOperator.Remove(Maim.listOperator[dex]);
                    MessageBox.Show("Operator ini telah dihapus");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Nda Bole ko Hapus ini, Hapus ko dulu pulsa yang punya operator ini dulu");
            }
        }

        private void btnPSave_Click(object sender, EventArgs e)
        {
            bool avaib = true;
            foreach (Operator Op in Maim.listOperator)
            {
                if (Op.Alias == txtAlias.Text && txtAlias.Text != Maim.listOperator[dex].Alias)
                {
                    avaib = false;
                    MessageBox.Show("Kode yang kamu gunakan sudah ada, silahkan gunakan kode yang lain", "Notification");
                    break;
                }
            }
            if (avaib == true)
            {
                PulsaType Tytpe = new PulsaType();
                if (rbtAll.Checked)
                {
                    Tytpe = PulsaType.AllOperator;
                }
                else if (rbtMkios.Checked)
                {
                    Tytpe = PulsaType.Mkios;
                }
                Operator Opee = new Operator(Tytpe, txtOpName.Text, txtAlias.Text, btnColor.BackColor);

                foreach (Pulsa Pulse in Maim.listPulsa)
                {
                    if (Pulse.Operand.Nama == Maim.listOperator[dex].Nama) 
                    {
                        Pulse.Operand = Opee;
                    }
                }
                foreach(Transaction Trans in Maim.listTransaction)
                {
                    foreach (SubTransaction STr in Trans.ListSTrans)
                    {
                        if (STr.Pulse.Operand.Nama == Maim.listOperator[dex].Nama)
                        {
                            STr.Pulse.Operand = Opee;
                        }
                    }
                }
                foreach (TransKhususBaru TrKhusus in Maim.listKhusus)
                {
                    foreach (SubTransaction STr in TrKhusus.Pakai)
                    {
                        if (STr.Pulse.Operand.Nama == Maim.listOperator[dex].Nama)
                        {
                            STr.Pulse.Operand = Opee;
                        }
                    }
                    foreach (SubTransaction STr in TrKhusus.Salah)
                    {
                        if (STr.Pulse.Operand.Nama == Maim.listOperator[dex].Nama)
                        {
                            STr.Pulse.Operand = Opee;
                        }
                    }
                }

                Maim.listOperator[dex] = Opee;              
                MessageBox.Show("this pulsa has been changed");
            }
            Resetter(); 
        }
    }
}
