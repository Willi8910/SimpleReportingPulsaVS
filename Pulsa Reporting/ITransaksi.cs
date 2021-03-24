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
    public partial class ITransaksi : Form
    {
        Utama Maim;
        string bName = "BITrans.jpg";
        public ITransaksi()
        {
            InitializeComponent();
        }

        private void ITransaksi_Load(object sender, EventArgs e)
        {
            Maim = (Utama)this.Owner;
            Maim.ChangeBack(bName, this);
        }

        private void TrPulse_Click(object sender, EventArgs e)
        {
            Transaksi Tr = new Transaksi();
            Tr.Owner = this;
            Tr.ShowDialog();
            if (Tr.Rebound == true)
            {
                btnTrKhusus_Click(sender, e);
            }

            //Maim.ChangeBack(bName, this);

        }

        private void btnTrKhusus_Click(object sender, EventArgs e)
        {
            TransaksiKhusus TrKhu = new TransaksiKhusus();
            TrKhu.Owner = this;
            TrKhu.ShowDialog();
            if (TrKhu.Rebound == true)
            {
                TrPulse_Click(sender, e);
            }
        }

        private void ITransaksi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == Maim.MsBtn)
            {
                Maim.Warna(bName, this);
            }
        }
    }
}
