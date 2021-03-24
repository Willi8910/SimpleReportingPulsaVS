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
    public partial class FBuatOperator : Form
    {
        Utama Maim;
        public FBuatOperator()
        {
            InitializeComponent();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog clgBac = new ColorDialog();
            clgBac.FullOpen = false;
            DialogResult PilihWarna = clgBac.ShowDialog();
            if (PilihWarna == System.Windows.Forms.DialogResult.OK)
            {
                btnColor.BackColor = clgBac.Color;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtOpName.Text = "";
            txtAlias.Text = "";
            btnColor.BackColor = SystemColors.Control;
            rbtAll.Select();
        }

        private void btnPSave_Click(object sender, EventArgs e)
        {
            bool avaib = true;
            foreach (Operator Op in Maim.listOperator)
            {
                if (Op.Alias == txtAlias.Text)
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


                btnReset_Click(sender, e);
                
            }
        }

        private void FBuatOperator_Load(object sender, EventArgs e)
        {
            DisplayOperator DiOp = (DisplayOperator)this.Owner;
            Maim = (Utama)this.Owner.Owner;
        }

        private void btnPBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
