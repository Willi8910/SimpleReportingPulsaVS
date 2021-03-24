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
    public partial class FOnePulsa : Form
    {
        Utama Maim;
        DetailPulsa DetPul;
        public FOnePulsa()
        {
            InitializeComponent();
        }

        private void PanEdit_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FOnePulsa_Load(object sender, EventArgs e)
        {
            PanEdit.Left = 0;
            DetPul = (DetailPulsa)this.Owner;
            string Cood = DetPul.dexPulseCode;
            //this.Owner = null;
            Maim = (Utama)this.Owner.Owner;
            

           
            foreach(Pulsa Puls in Maim.listPulsa)
            {
                if(Puls.Kode == Cood)
                {
                    lblOp.Text = Puls.Operand.Nama;
                    lblPop.Text = lblOp.Text;
                    //cmbOperator.DataSource = Maim.listOperator;
                    //cmbOperator.DisplayMember = "Nama";
                    //cmbOperator.SelectedItem = Puls.Operand;

                    lblKode.Text = Puls.Kode;
                    txtKode.Text = Puls.Kode;

                    lblModal.Text = Puls.Modal.ToString();
                    numModal.Value = Puls.Modal;

                    lblHarga.Text = Puls.Harga.ToString();
                    numHarga.Value = Puls.Harga;
                    Text = txtKode.Text;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            PanDis.SendToBack();
        }

        //private void cmbOperator_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    Operator Oper = (Operator)cmbOperator.SelectedValue;
        //    if(Oper.TipePulsa == PulsaType.Mkios)
        //    {
        //        PanKios1.Visible = true;
        //        PanKios2.Visible = true;
        //    }
        //    else if(Oper.TipePulsa == PulsaType.AllOperator)
        //    {
        //        PanKios1.Visible = false;
        //        PanKios2.Visible = false;
        //    }
        //}

        private void btnBack_Click(object sender, EventArgs e)
        {
            PanEdit.SendToBack();
            Resetter();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Resetter();
        }

        private void Resetter()
        {
            //for (int i = 0; i < cmbOperator.Items.Count; i++)
            //{
            //    if (cmbOperator.Items[i].ToString() == lblOp.Text)
            //    {
            //        cmbOperator.SelectedIndex = i;
            //    }
            //}
            txtKode.Text = lblKode.Text;
            numModal.Value = int.Parse(lblModal.Text);
            numHarga.Value = int.Parse(lblHarga.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool check = true;
            foreach (Pulsa pulse in Maim.listPulsa)
            {
                if (pulse.Kode == txtKode.Text)
                {
                    if(txtKode.Text == lblKode.Text)
                    {

                    }
                    else
                    {
                        check = false;
                        MessageBox.Show("Kode ini sudah ada, silahkan cari yang lain");
                        break;
                    }
                }
            }
            if (check == true)
            {
                foreach (Pulsa pulse in Maim.listPulsa)
                {
                    if (pulse.Kode == lblKode.Text)
                    {
                        //Operator opera = (Operator)cmbOperator.SelectedValue;
                        //pulse.Operand = opera;
                        pulse.Kode = txtKode.Text;


                        pulse.Harga = (int)numHarga.Value;
                        pulse.Modal = (int)numModal.Value;
                        pulse.getUntung();


                        foreach (Transaction Trans in Maim.listTransaction)
                        {
                            foreach (SubTransaction STr in Trans.ListSTrans)
                            {
                                if (STr.Pulse.Kode == lblKode.Text)
                                {
                                    STr.Pulse.Kode = txtKode.Text;
                                }
                            }
                        }
                        foreach (TransKhususBaru TrKhusus in Maim.listKhusus)
                        {
                            foreach (SubTransaction STr in TrKhusus.Pakai)
                            {
                                if (STr.Pulse.Kode == lblKode.Text)
                                {
                                    STr.Pulse.Kode = txtKode.Text;

                                }
                            }
                            foreach (SubTransaction STr in TrKhusus.Salah)
                            {
                                if (STr.Pulse.Kode == lblKode.Text)
                                {
                                    STr.Pulse.Kode = txtKode.Text;
                                }
                            }
                        }
                                                //lblOp.Text = opera.Nama;
                        lblKode.Text = txtKode.Text;
                        lblHarga.Text = numHarga.Value.ToString();
                        lblModal.Text = numModal.Value.ToString();
                        MessageBox.Show("data sudah Tersimpan");

                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult Ans = MessageBox.Show("Apakah anda yakin ingin menghapus Pulsa ini?", "Pesan", MessageBoxButtons.YesNo);
            if(Ans == System.Windows.Forms.DialogResult.Yes)
            {
                foreach(Pulsa puls in Maim.listPulsa)
                {
                    if(puls.Kode == lblKode.Text)
                    {
                        Maim.listPulsa.Remove(puls);
                        MessageBox.Show("Pulsa telah dihapus!!!");
                        break;
                    }
                }
                this.Close();
            }
        }
    }
}
