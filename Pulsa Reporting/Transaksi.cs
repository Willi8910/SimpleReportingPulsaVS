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
    public partial class Transaksi : Form
    {
        Utama Maim;
        bool TDel = false;
        bool ChDate = true;
        DateTimePicker DTP = new DateTimePicker();
        string bName = "BTrans.jpg";

        public bool Rebound = false;
        public Transaksi()
        {
            InitializeComponent();
        }

        private void Transaksi_Load(object sender, EventArgs e)
        {
            ITransaksi ITR = (ITransaksi)this.Owner;
            Maim = (Utama)this.Owner.Owner;
            cmbKode.Focus();
            cmbKode.DataSource = Maim.listPulsa;
            cmbKode.DisplayMember = "Kode";
            cmbKode.SelectedIndex = 0;
            DTP.Value = dtTgl.Value;

            dtTgl_ValueChanged(sender, e);
            Maim.ChangeBack(bName, this);
            Maim.SizeManage(dtTransaksi);
        }

        private void cmbKode_SelectedIndexChanged(object sender, EventArgs e)
        {
            Restar();
        }

        private void Restar()
        {
            Pulsa pulse = (Pulsa)cmbKode.SelectedValue;
            lblOperator.Text = pulse.Operand.Nama + "(" + pulse.Operand.TipePulsa.ToString() + ")";
            lblJual.Text = pulse.Harga.ToString();
            lblTotalHarga.Text = lblJual.Text;
            lblModal.Text =pulse.Modal.ToString();
            lblUntung.Text = pulse.Untung.ToString();
            lblTotalUntung.Text = pulse.Untung.ToString();
            numJumlah.Value = 1;
           
        }

        private void numJumlah_ValueChanged(object sender, EventArgs e)
        {
            int jum = (int)numJumlah.Value;
            int TotHarga = jum * int.Parse(lblJual.Text);
            int TotUntung = jum * int.Parse(lblUntung.Text);
            lblTotalUntung.Text = TotUntung.ToString();
            lblTotalHarga.Text = TotHarga.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Restar();
        }

        private void AddTotal()
        {
            dtTransaksi.Rows.Add();
            dtTransaksi.Rows[dtTransaksi.Rows.Count - 1].Cells[0].Value = "Total";
            dtTransaksi.Rows[dtTransaksi.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Black;
            dtTransaksi.Rows[dtTransaksi.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.White;
            dtTransaksi.Rows[dtTransaksi.Rows.Count - 1].Cells[3].Value = FindNomi(3);
            dtTransaksi.Rows[dtTransaksi.Rows.Count - 1].Cells[4].Value = FindNomi(4);
            dtTransaksi.Rows[dtTransaksi.Rows.Count - 1].Cells[5].Value = FindNomi(5);

        }

        private int FindNomi(int idex)
        {
            int Total = 0;
            for (int i = 0; i < dtTransaksi.Rows.Count - 1; i++) 
            {
                Total += int.Parse(dtTransaksi.Rows[i].Cells[idex].Value.ToString());
            }
            return Total;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Pulsa pulse = (Pulsa)cmbKode.SelectedValue;
            string[] dataa = new string[]{cmbKode.Text, lblJual.Text, lblUntung.Text, numJumlah.Value.ToString(), lblTotalHarga.Text, lblTotalUntung.Text};
            if (pulse.CheckStok((int)numJumlah.Value))
            {
                bool avaib = true;
                if (dtTransaksi.RowCount > 0)
                {
                    dtTransaksi.Rows.RemoveAt(dtTransaksi.RowCount - 1);
                }
                for (int i = 0; i < dtTransaksi.Rows.Count; i++)
                {
                    if (cmbKode.Text == dtTransaksi.Rows[i].Cells[0].Value.ToString())
                    {
                        avaib = false;
                        dtTransaksi.Rows[i].Cells[3].Value = (int)numJumlah.Value + int.Parse(dtTransaksi.Rows[i].Cells[3].Value.ToString());
                        dtTransaksi.Rows[i].Cells[4].Value = int.Parse(lblTotalHarga.Text) + int.Parse(dtTransaksi.Rows[i].Cells[4].Value.ToString());
                        dtTransaksi.Rows[i].Cells[5].Value = int.Parse(lblTotalUntung.Text) + int.Parse(dtTransaksi.Rows[i].Cells[5].Value.ToString());
                        //MessageBox.Show("data telah ditambahkan", "Notification");
                        dtTransaksi.Rows[i].DefaultCellStyle.BackColor = pulse.Operand.Warna;

                    }
                }
                if (avaib == true)
                {
                    
                    dtTransaksi.Rows.Add(dataa);
                    dtTransaksi.Rows[dtTransaksi.RowCount-1].DefaultCellStyle.BackColor = pulse.Operand.Warna;

                }
                AddTotal();
                Maim.SizeManage(dtTransaksi);
                //dtTransaksi.ScrollBars = ScrollBars.None;
                pulse.AddUnit((int)numJumlah.Value);
                
                ChDate = false;
            }
            else
            {
                MessageBox.Show("Jumlah Stok yang tersedia tidak sesuai dengan unit yang ada");
            }
            Restar();
        }

        private void dtTransaksi_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dtTransaksi.Rows[e.RowIndex].Cells[0].Value != null)
            {
                string Bzzzza = dtTransaksi.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (Bzzzza != "Total")
                {
                    if (TDel == true)
                    {
                        DialogResult usea = MessageBox.Show("Are you sure want to delete this one?", "Notification", MessageBoxButtons.YesNo);
                        if (usea == System.Windows.Forms.DialogResult.Yes)
                        {
                            ChDate = false;
                            if (dtTransaksi.RowCount > 0)
                            {
                                dtTransaksi.Rows.RemoveAt(dtTransaksi.RowCount - 1);
                            }
                            for (int i = 0; i < Maim.listPulsa.Count; i++)
                            {
                                if (Maim.listPulsa[i].Kode == Bzzzza)
                                {
                                    Maim.listPulsa[i].AddUnit(-int.Parse(dtTransaksi.Rows[e.RowIndex].Cells[3].Value.ToString()));
                                    Restar();
                                    dtTransaksi.Rows.RemoveAt(e.RowIndex);
                                }
                            }
                            AddTotal();
                        }
                    }
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(TDel == true)
            {
                TDel = false;
                btnDel.BackgroundImage = Properties.Resources.DataDel;
            }
            else
            {
                TDel = true;
                btnDel.BackgroundImage = Properties.Resources.DataDelAk;
            }
        }

        private void btnRSave_Click(object sender, EventArgs e)
        {
            try
            {
                Transaction Trans = new Transaction();
                Trans = MakeIt();

                for (int i = 0; i < Maim.listTransaction.Count; i++)
                {
                    if (Maim.listTransaction[i].Tanggal.Date == DTP.Value.Date)
                    {
                        //Maim.listTransaction[i] = Trans;
                        Maim.listTransaction.RemoveAt(i);
                    }
                }
                Maim.listTransaction.Add(Trans);
                MessageBox.Show("Saved");
                
            }
            catch(Exception Exc)
            {
                MessageBox.Show("You'r doing error!!!, Please check again \n Err Message: " + Exc.Message, "Message");
            }
            ChDate = true;
            dtTgl_ValueChanged(sender,e);
        }

        private Transaction MakeIt()
        {
            
            Transaction Trans = new Transaction();
            List<SubTransaction> lSub = new List<SubTransaction>();
            for (int i = 0; i < dtTransaksi.RowCount - 1; i++)
            {
                SubTransaction Sub = new SubTransaction();
                foreach (Pulsa Pulse in Maim.listPulsa)
                {
                    if (Pulse.Kode == dtTransaksi.Rows[i].Cells[0].Value.ToString())
                    {
                        Sub.Pulse = Pulse;
                        break;
                    }
                }
                Sub.Unit = int.Parse(dtTransaksi.Rows[i].Cells[3].Value.ToString());
                Sub.SubHarga = int.Parse(dtTransaksi.Rows[i].Cells[4].Value.ToString());
                Sub.SubUntung = int.Parse(dtTransaksi.Rows[i].Cells[5].Value.ToString());
                lSub.Add(Sub);
            }
            Trans.ListSTrans = lSub;
            Trans.Tanggal = DTP.Value;
            Trans.TotalUnit = int.Parse(dtTransaksi.Rows[dtTransaksi.RowCount - 1].Cells[3].Value.ToString());
            Trans.TotalHarga = int.Parse(dtTransaksi.Rows[dtTransaksi.RowCount - 1].Cells[4].Value.ToString());
            Trans.TotalUntung = int.Parse(dtTransaksi.Rows[dtTransaksi.RowCount - 1].Cells[5].Value.ToString());

            return Trans;
        }

        public void Checkit()
        {
            Transaction Trunks = new Transaction(); // Lama
            for (int i = 0; i < Maim.listTransaction.Count; i++)
            {
                if (Maim.listTransaction[i].Tanggal.Date == DTP.Value.Date)
                {
                    Trunks = Maim.listTransaction[i];
                }
            }

            Transaction Trans12 = new Transaction(); //baru
            Trans12 = MakeIt();

            for (int i = 0; i < Trans12.ListSTrans.Count; i++) 
            {
                int Av =0;
                for (int j = 0; j < Trunks.ListSTrans.Count; j++)
                {
                    if(Trans12.ListSTrans[i].Pulse.Kode == Trunks.ListSTrans[j].Pulse.Kode)
                    {
                        Av++;
                        for (int k = 0; k < Maim.listPulsa.Count; k++)
                        {
                            if(Maim.listPulsa[k].Kode == Trans12.ListSTrans[i].Pulse.Kode)
                            {
                                Maim.listPulsa[k].AddUnit(-Trans12.ListSTrans[i].Unit + Trunks.ListSTrans[j].Unit);
                            }
                        }
                    }
                }
                if (Av == 0)
                {
                    for (int k = 0; k < Maim.listPulsa.Count; k++)
                    {
                        if (Maim.listPulsa[k].Kode == Trans12.ListSTrans[i].Pulse.Kode)
                        {
                            Maim.listPulsa[k].AddUnit(-Trans12.ListSTrans[i].Unit);
                        }
                    }
                }
            }

            for (int i = 0; i < Trunks.ListSTrans.Count; i++)
            {
                int Av = 0;
                for (int j = 0; j < Trans12.ListSTrans.Count; j++)
                {
                    if (Trans12.ListSTrans[j].Pulse.Kode == Trunks.ListSTrans[i].Pulse.Kode)
                    {
                        Av++;
                    }
                }
                if (Av == 0)
                {
                    for (int k = 0; k < Maim.listPulsa.Count; k++)
                    {
                        if (Maim.listPulsa[k].Kode == Trunks.ListSTrans[i].Pulse.Kode)
                        {
                            Maim.listPulsa[k].AddUnit(Trunks.ListSTrans[i].Unit);
                        }
                    }
                }
            }
        }
        private void dtTgl_ValueChanged(object sender, EventArgs e)
        {
            if (ChDate == true)
            {
                
            }
            else
            {
                DialogResult Msg = MessageBox.Show("Data in Belum disimpan, APakah ingin disimpan?","Message", MessageBoxButtons.YesNo);
                if (Msg == System.Windows.Forms.DialogResult.Yes)
                {
                    //btnRSave_Click(sender, e);            
                    Transaction Traans = new Transaction();
                    Traans = MakeIt();

                    for (int i = 0; i < Maim.listTransaction.Count; i++)
                    {
                        if (Maim.listTransaction[i].Tanggal.Date == DTP.Value.Date)
                        {
                            //Maim.listTransaction[i] = Trans;
                            Maim.listTransaction.RemoveAt(i);
                        }
                    }
                    Maim.listTransaction.Add(Traans);
                    MessageBox.Show("Saved");
                    ChDate = true;
                }
                else if (Msg == System.Windows.Forms.DialogResult.No)
                {
                    Checkit();
                }
            }
            dtTransaksi.Rows.Clear();
            Transaction Trans = new Transaction();
            for (int i = 0; i < Maim.listTransaction.Count; i++)
            {
                if (Maim.listTransaction[i].Tanggal.Date == dtTgl.Value.Date)
                {
                    Trans = Maim.listTransaction[i];
                }
            }

            for (int i = 0; i < Trans.ListSTrans.Count; i++)
            {
                string[] bla = new string[] { Trans.ListSTrans[i].Pulse.Kode, Trans.ListSTrans[i].Pulse.Harga.ToString(), Trans.ListSTrans[i].Pulse.Untung.ToString(), Trans.ListSTrans[i].Unit.ToString(), Trans.ListSTrans[i].SubHarga.ToString(), Trans.ListSTrans[i].SubUntung.ToString() };
                dtTransaksi.Rows.Add(bla);
                dtTransaksi.Rows[dtTransaksi.RowCount - 1].DefaultCellStyle.BackColor = Trans.ListSTrans[i].Pulse.Operand.Warna;
            }
            AddTotal();
            DTP.Value = dtTgl.Value;
            ChDate = true;
            Restar();
            Maim.SizeManage(dtTransaksi);
            //dtTransaksi.Width -= 75;
        }

        private void dtTgl_CloseUp(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void Transaksi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == Maim.MsBtn)
            {
                Maim.Warna(bName, this);
            }
        }

        private void gbxTransaksi_Enter(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            dtTgl_ValueChanged(sender, e);
            this.Close();
        }

        private void dtTransaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dtTransaksi.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    string Bzzzza = dtTransaksi.Rows[e.RowIndex].Cells[0].Value.ToString();
                    if (Bzzzza != "Total")
                    {
                        if (TDel == true)
                        {
                            DialogResult usea = MessageBox.Show("Are you sure want to delete this one?", "Notification", MessageBoxButtons.YesNo);
                            if (usea == System.Windows.Forms.DialogResult.Yes)
                            {
                                ChDate = false;
                                if (dtTransaksi.RowCount > 0)
                                {
                                    dtTransaksi.Rows.RemoveAt(dtTransaksi.RowCount - 1);
                                }
                                for (int i = 0; i < Maim.listPulsa.Count; i++)
                                {
                                    if (Maim.listPulsa[i].Kode == Bzzzza)
                                    {
                                        Maim.listPulsa[i].AddUnit(-int.Parse(dtTransaksi.Rows[e.RowIndex].Cells[3].Value.ToString()));
                                        Restar();
                                        dtTransaksi.Rows.RemoveAt(e.RowIndex);
                                    }
                                }
                                AddTotal();
                            }
                        }
                    }
                }
            }
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            Checkit();
            ChDate = true;
            dtTgl_ValueChanged(sender, e);
        }

        private void dtTransaksi_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            
        }

        private void dtTransaksi_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dtTransaksi_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ChDate = false;
            int angka = 0;
            if (e.ColumnIndex == 3 && int.TryParse(dtTransaksi.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out angka))
            {
                DataGridViewRow DRow = dtTransaksi.Rows[e.RowIndex];
                int total = int.Parse(DRow.Cells[1].Value.ToString()) * angka;
                int Untung = int.Parse(DRow.Cells[2].Value.ToString()) * angka;
                DRow.Cells[4].Value = total;
                DRow.Cells[5].Value = Untung;
                dtTransaksi.Rows[dtTransaksi.Rows.Count - 1].Cells[3].Value = FindNomi(3);
                dtTransaksi.Rows[dtTransaksi.Rows.Count - 1].Cells[4].Value = FindNomi(4);
                dtTransaksi.Rows[dtTransaksi.Rows.Count - 1].Cells[5].Value = FindNomi(5);
            }
            else
            {
                btnRef_Click(sender, e);
            }
        }

        private void btnTrKhusus_Click(object sender, EventArgs e)
        {
            Rebound = true;
            this.Close();
        }
    }
    
}
