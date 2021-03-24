using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Jual_Pulsa.Properties;

namespace Jual_Pulsa
{
    public partial class TransaksiKhusus : Form
    {
        Utama Maim;
        bool TDel = false;
        bool ChDate = true;
        DateTimePicker DTP = new DateTimePicker();
        //bool SwapUse = false;


        List<INT> Bonuss = new List<INT>();
        List<INT> Rugiii = new List<INT>();
        List<INT> PakePLain = new List<INT>();
        int TotBonus = 0;
        int TotMin = 0;
        int TotPulse = 0;
        TransKhususBaru Trk = new TransKhususBaru();
        int p;
        //bool derubon = false;
        bool deru = false;

        bool extra = true;

        string bName = "BTransKhususBaru.jpg";


        public bool Rebound = false;
        public TransaksiKhusus()
        {
            InitializeComponent();
        }

        private void Transaksi_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            ITransaksi ITR = (ITransaksi)this.Owner;

            Maim = (Utama)this.Owner.Owner;
            ////cmbKode.Focus();
            cmbKode.DataSource = Maim.listPulsa;
            cmbKode.DisplayMember = "Kode";

            btnUse.Checked = true;
            //SwapUse = false;

            //dtTgl_ValueChanged(sender, e);
            cmbKode.SelectedIndex = 0;
            dtTgl.Value = new DateTime(dtTgl.Value.Year, dtTgl.Value.Month, 1);
            DTP.Value = dtTgl.Value;

            Maim.ChangeBack(bName, this);
            //Maim.SizeManage(dtTransaksi);
            //Maim.SizeManage(dtBon);
            //Maim.SizeManage(dtMin);
            tabKirimPake.BackgroundImage = BackgroundImage;
            tabRugiBon.BackgroundImage = BackgroundImage;
        }
        #region Tab1
        private void FillDataGrid(DataGridView DGrid, List<SubTransaction> lSub)
        {
            for (int i = 0; i < lSub.Count; i++)
            {
                string[] bla = new string[] { lSub[i].Pulse.Kode, lSub[i].Pulse.Modal.ToString(), lSub[i].Unit.ToString(), lSub[i].SubUntung.ToString() };
                DGrid.Rows.Add(bla);
                DGrid.Rows[DGrid.RowCount - 1].DefaultCellStyle.BackColor = lSub[i].Pulse.Operand.Warna;

            }
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
            lblModal.Text = pulse.Modal.ToString();
        //    lblUntung.Text = pulse.Untung.ToString();
            lblTotalUntung.Text = pulse.Untung.ToString();
            numJumlah.Value = 1;

        }

        private void numJumlah_ValueChanged(object sender, EventArgs e)
        {
            int jum = (int)numJumlah.Value;
            int TotUntung = jum * int.Parse(lblModal.Text);
            lblTotalUntung.Text = TotUntung.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Restar();
        }

        private void AddTotal(DataGridView DGrid)
        {
            DGrid.Rows.Add();
            DGrid.Rows[DGrid.Rows.Count - 1].Cells[0].Value = "Total";
            DGrid.Rows[DGrid.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Black;
            DGrid.Rows[DGrid.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.White;
            DGrid.Rows[DGrid.Rows.Count - 1].Cells[3].Value = FindNomi(3, DGrid);
            DGrid.Rows[DGrid.Rows.Count - 1].Cells[2].Value = FindNomi(2, DGrid);
            //dtTransaksi.Rows[dtTransaksi.Rows.Count - 1].Cells[5].Value = FindNomi(5);

        }

        private int FindNomi(int idex, DataGridView DGrid)
        {
            int Total = 0;
            for (int i = 0; i < DGrid.Rows.Count - 1; i++)
            {
                Total += int.Parse(DGrid.Rows[i].Cells[idex].Value.ToString());
            }
            return Total;
        }

        private void SaveTo(DataGridView DGRid)
        {
            int TModal = int.Parse(lblModal.Text) * (int)numJumlah.Value;
            Pulsa pulse = (Pulsa)cmbKode.SelectedValue;
            string[] dataa = new string[] { cmbKode.Text, lblModal.Text, numJumlah.Value.ToString(), TModal.ToString() };
            bool avaib = true;
            if (DGRid.RowCount > 0)
            {
                DGRid.Rows.RemoveAt(DGRid.RowCount - 1);
            }
            for (int i = 0; i < DGRid.Rows.Count; i++)
            {
                if (cmbKode.Text == DGRid.Rows[i].Cells[0].Value.ToString())
                {
                    avaib = false;
                    DGRid.Rows[i].Cells[2].Value = (int)numJumlah.Value + int.Parse(DGRid.Rows[i].Cells[2].Value.ToString());
                    DGRid.Rows[i].Cells[3].Value = TModal + int.Parse(DGRid.Rows[i].Cells[3].Value.ToString());
                    DGRid.Rows[i].DefaultCellStyle.BackColor = pulse.Operand.Warna;

                    MessageBox.Show("data telah ditambahkan", "Notification");
                }
            }
            if (avaib == true)
            {
                DGRid.Rows.Add(dataa);
                DGRid.Rows[DGRid.RowCount - 1].DefaultCellStyle.BackColor = pulse.Operand.Warna;

            }
            AddTotal(DGRid);
            Maim.SizeManage(DGRid);
            DGRid.ScrollBars = ScrollBars.None;
            pulse.AddUnit((int)numJumlah.Value);

            ChDate = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Pulsa pulse = (Pulsa)cmbKode.SelectedValue;
            if (pulse.CheckStok((int)numJumlah.Value))
            {
                if (btnUse.Checked)
                {
                    SaveTo(dtTrPake);
                }
                else if (btnWrong.Checked)
                {
                    SaveTo(dtTrSalah);
                }
            }
            else
            {
                MessageBox.Show("Jumlah Stok yang tersedia tidak sesuai dengan unit yang ada");
            }
            Restar();
        }

        private void dtTransaksi_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //if (dttrpakekks.Rows[e.RowIndex].Cells[0].Value != null)
            //{
            //    string Bzzzza = dttrpakekks.Rows[e.RowIndex].Cells[0].Value.ToString();
            //    if (Bzzzza != "Total")
            //    {
            //        if (TDel == true)
            //        {
            //            DialogResult usea = MessageBox.Show("Are you sure want to delete this one?", "Notification", MessageBoxButtons.YesNo);
            //            if (usea == System.Windows.Forms.DialogResult.Yes)
            //            {
            //                ChDate = false;
            //                if (dttrpakekks.RowCount > 0)
            //                {
            //                    dttrpakekks.Rows.RemoveAt(dttrpakekks.RowCount - 1);
            //                }
            //                for (int i = 0; i < Maim.listPulsa.Count; i++)
            //                {
            //                    if (Maim.listPulsa[i].Kode == Bzzzza)
            //                    {
            //                        Maim.listPulsa[i].AddUnit(-int.Parse(dttrpakekks.Rows[e.RowIndex].Cells[3].Value.ToString()));
            //                        Restar();
            //                        dttrpakekks.Rows.RemoveAt(e.RowIndex);
            //                    }
            //                }
            //                AddTotal();
            //            }
            //        }
            //    }
            //}
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (TDel == true)
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
                TransKhususBaru Trust = new TransKhususBaru();
                List<SubTransaction> lPake = MakeIt(dtTrPake);
                List<SubTransaction> lSalah = MakeIt(dtTrSalah);

                int avaib = 0;
                for (int i = 0; i < Maim.listKhusus.Count; i++)
                {
                    if (Maim.listKhusus[i].Tanggal.Date == DTP.Value.Date)
                    {
                        avaib = 1;
                        Maim.listKhusus[i].Pakai = lPake;
                        Maim.listKhusus[i].Salah = lSalah;
                        //if (SwapUse == true)
                        //{
                        //    Maim.listKhusus[i].Pakai = lSubs;
                        //}
                        //else
                        //{
                        //    Maim.listKhusus[i].Salah = lSubs;
                        //}
                    }
                }

                if (avaib == 0)
                {
                    Trust.Tanggal = DTP.Value;
                    //if (SwapUse == true)
                    //{
                    //    Trust.Pakai = lSubs;
                    //}
                    //else
                    //{
                    //    Trust.Salah = lSubs;
                    //}

                    Trust.Pakai = lPake;
                    Trust.Salah = lSalah;

                    Maim.listKhusus.Add(Trust);
                }
                MessageBox.Show("Saved");
                ChDate = true;
            }
            catch (Exception Exc)
            {
                MessageBox.Show("You'r doing error!!!, Please check again \n Err Message: " + Exc.Message, "Message");
            }
        }

        private List<SubTransaction> MakeIt(DataGridView DGrid)
        {
            List<SubTransaction> lSub = new List<SubTransaction>();
            for (int i = 0; i < DGrid.RowCount - 1; i++)
            {
                SubTransaction Sub = new SubTransaction();
                foreach (Pulsa Pulse in Maim.listPulsa)
                {
                    if (Pulse.Kode == DGrid.Rows[i].Cells[0].Value.ToString())
                    {
                        Sub.Pulse = Pulse;
                        break;
                    }
                }
                Sub.Unit = int.Parse(DGrid.Rows[i].Cells[2].Value.ToString());
                Sub.SubUntung = int.Parse(DGrid.Rows[i].Cells[3].Value.ToString());
                lSub.Add(Sub);
            }
            return lSub;
        }

        private TransKhususBaru MakeIt2(DataGridView DGrid)
        {

            TransKhususBaru Trans = new TransKhususBaru();
            List<SubTransaction> lSub = new List<SubTransaction>();
            for (int i = 0; i < DGrid.RowCount - 1; i++)
            {
                SubTransaction Sub = new SubTransaction();
                foreach (Pulsa Pulse in Maim.listPulsa)
                {
                    if (Pulse.Kode == DGrid.Rows[i].Cells[0].Value.ToString())
                    {
                        Sub.Pulse = Pulse;
                        break;
                    }
                }
                Sub.Unit = int.Parse(DGrid.Rows[i].Cells[2].Value.ToString());
                Sub.SubUntung = int.Parse(DGrid.Rows[i].Cells[3].Value.ToString());
                lSub.Add(Sub);
            }
            //if (SwapUse == true)
            //{
            //    Trans.Pakai = lSub;
            //}
            //else
            //{
            //    Trans.Salah = lSub;
            //}
            return Trans;
        }

        public void Checkit(DataGridView DGrid)
        {
            TransKhususBaru Trunks = new TransKhususBaru(); // Lama
            for (int i = 0; i < Maim.listKhusus.Count; i++)
            {
                if (Maim.listKhusus[i].Tanggal == DTP.Value)
                {
                    Trunks = Maim.listKhusus[i];
                }
            }

            TransKhususBaru Trans12 = new TransKhususBaru(); //baru
            Trans12 = MakeIt2(DGrid);

            //if (SwapUse == true)
            //{
            //    for (int i = 0; i < Trans12.Salah.Count; i++)
            //    {
            //        int Av = 0;
            //        for (int j = 0; j < Trunks.Salah.Count; j++)
            //        {
            //            if (Trans12.Salah[i].Pulse.Kode == Trunks.Salah[j].Pulse.Kode)
            //            {
            //                Av++;
            //                for (int k = 0; k < Maim.listPulsa.Count; k++)
            //                {
            //                    if (Maim.listPulsa[k].Kode == Trans12.Salah[i].Pulse.Kode)
            //                    {
            //                        Maim.listPulsa[k].AddUnit(-Trans12.Salah[i].Unit + Trunks.Salah[j].Unit);
            //                    }
            //                }
            //            }
            //        }
            //        if (Av == 0)
            //        {
            //            for (int k = 0; k < Maim.listPulsa.Count; k++)
            //            {
            //                if (Maim.listPulsa[k].Kode == Trans12.Salah[i].Pulse.Kode)
            //                {
            //                    Maim.listPulsa[k].AddUnit(-Trans12.Salah[i].Unit);
            //                }
            //            }
            //        }
            //    }

            //    for (int i = 0; i < Trunks.Salah.Count; i++)
            //    {
            //        int Av = 0;
            //        for (int j = 0; j < Trans12.Salah.Count; j++)
            //        {
            //            if (Trans12.Salah[j].Pulse.Kode == Trunks.Salah[i].Pulse.Kode)
            //            {
            //                Av++;
            //            }
            //        }
            //        if (Av == 0)
            //        {
            //            for (int k = 0; k < Maim.listPulsa.Count; k++)
            //            {
            //                if (Maim.listPulsa[k].Kode == Trunks.Salah[i].Pulse.Kode)
            //                {
            //                    Maim.listPulsa[k].AddUnit(Trunks.Salah[i].Unit);
            //                }
            //            }
            //        }
            //    }
            //}
            //else
            //{
            for (int i = 0; i < Trans12.Pakai.Count; i++)
            {
                int Av = 0;
                for (int j = 0; j < Trunks.Pakai.Count; j++)
                {
                    if (Trans12.Pakai[i].Pulse.Kode == Trunks.Pakai[j].Pulse.Kode)
                    {
                        Av++;
                        for (int k = 0; k < Maim.listPulsa.Count; k++)
                        {
                            if (Maim.listPulsa[k].Kode == Trans12.Pakai[i].Pulse.Kode)
                            {
                                Maim.listPulsa[k].AddUnit(-Trans12.Pakai[i].Unit + Trunks.Pakai[j].Unit);
                            }
                        }
                    }
                }
                if (Av == 0)
                {
                    for (int k = 0; k < Maim.listPulsa.Count; k++)
                    {
                        if (Maim.listPulsa[k].Kode == Trans12.Pakai[i].Pulse.Kode)
                        {
                            Maim.listPulsa[k].AddUnit(-Trans12.Pakai[i].Unit);
                        }
                    }
                }
            }

            for (int i = 0; i < Trunks.Pakai.Count; i++)
            {
                int Av = 0;
                for (int j = 0; j < Trans12.Pakai.Count; j++)
                {
                    if (Trans12.Pakai[j].Pulse.Kode == Trunks.Pakai[i].Pulse.Kode)
                    {
                        Av++;
                    }
                }
                if (Av == 0)
                {
                    for (int k = 0; k < Maim.listPulsa.Count; k++)
                    {
                        if (Maim.listPulsa[k].Kode == Trunks.Pakai[i].Pulse.Kode)
                        {
                            Maim.listPulsa[k].AddUnit(Trunks.Pakai[i].Unit);
                        }
                    }
                }
            }
            //}
        }

        private void dtTgl_CloseUp(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void tabpakeKirim_Click(object sender, EventArgs e)
        {

        }

        private void btnWrong_CheckedChanged(object sender, EventArgs e)
        {
            //dtTgl_ValueChanged(sender, e);
            //if (btnWrong.Checked)
            //{
            //    SwapUse = false;
            //}
        }

        private void btnUse_CheckedChanged(object sender, EventArgs e)
        {
            //dtTgl_ValueChanged(sender, e);
            //if (btnUse.Checked)
            //{
            //    SwapUse = true;
            //}
        }

        private void dtTransaksi_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView DGrid = (DataGridView)sender;
            ChDate = false;
            int angka = 0;
            if (e.ColumnIndex == 2 && int.TryParse(DGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out angka))
            {
                DataGridViewRow DRow = DGrid.Rows[e.RowIndex];
                int total = int.Parse(DRow.Cells[1].Value.ToString()) * angka;
                //int Untung = int.Parse(DRow.Cells[2].Value.ToString()) * angka;
                DRow.Cells[3].Value = total;
                //DRow.Cells[5].Value = Untung;
                DGrid.Rows[DGrid.Rows.Count - 1].Cells[3].Value = FindNomi(3, DGrid);
                DGrid.Rows[DGrid.Rows.Count - 1].Cells[2].Value = FindNomi(4, DGrid);
                DGrid.Rows[DGrid.Rows.Count - 1].Cells[1].Value = FindNomi(5, DGrid);
            }
            else
            {
                btnRef_Click(sender, e);
            }
        }

        private void dtTransaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    if (dtTransaksi.Rows[e.RowIndex].Cells[0].Value != null)
            //    {
            //        string Bzzzza = dtTransaksi.Rows[e.RowIndex].Cells[0].Value.ToString();
            //        if (Bzzzza != "Total")
            //        {
            //            if (TDel == true)
            //            {
            //                DialogResult usea = MessageBox.Show("Are you sure want to delete this one?", "Notification", MessageBoxButtons.YesNo);
            //                if (usea == System.Windows.Forms.DialogResult.Yes)
            //                {
            //                    ChDate = false;
            //                    if (dtTransaksi.RowCount > 0)
            //                    {
            //                        dtTransaksi.Rows.RemoveAt(dtTransaksi.RowCount - 1);
            //                    }
            //                    for (int i = 0; i < Maim.listPulsa.Count; i++)
            //                    {
            //                        if (Maim.listPulsa[i].Kode == Bzzzza)
            //                        {
            //                            Maim.listPulsa[i].AddUnit(-int.Parse(dtTransaksi.Rows[e.RowIndex].Cells[3].Value.ToString()));
            //                            Restar();
            //                            dtTransaksi.Rows.RemoveAt(e.RowIndex);
            //                        }
            //                    }
            //                    AddTotal();
            //                }
            //            }
            //        }
            //    }
            //}
        }

        private void dtTransaksi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView DGrid = (DataGridView)sender;
            if (e.RowIndex >= 0)
            {
                if (DGrid.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    string Bzzzza = DGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                    if (Bzzzza != "Total")
                    {
                        if (TDel == true)
                        {
                            DialogResult usea = MessageBox.Show("Are you sure want to delete this one?", "Notification", MessageBoxButtons.YesNo);
                            if (usea == System.Windows.Forms.DialogResult.Yes)
                            {
                                ChDate = false;
                                if (DGrid.RowCount > 0)
                                {
                                    DGrid.Rows.RemoveAt(DGrid.RowCount - 1);
                                }
                                for (int i = 0; i < Maim.listPulsa.Count; i++)
                                {
                                    if (Maim.listPulsa[i].Kode == Bzzzza)
                                    {
                                        Maim.listPulsa[i].AddUnit(-int.Parse(DGrid.Rows[e.RowIndex].Cells[3].Value.ToString()));
                                        Restar();
                                        DGrid.Rows.RemoveAt(e.RowIndex);
                                    }
                                }
                                AddTotal(DGrid);
                                Maim.SizeManage(DGrid);
                            }
                        }
                    }
                }
            }
        }
        #endregion


        #region Tab2
        private void dtTgl_ValueChanged(object sender, EventArgs e)
        {
            int Chosse = PakeKirim.SelectedIndex;
            #region Tab1
            if (ChDate == true)
            {

            }
            else
            {
                DialogResult Msg = MessageBox.Show("Data in Belum disimpan, APakah ingin disimpan?", "Message", MessageBoxButtons.YesNo);
                if (Msg == System.Windows.Forms.DialogResult.Yes)
                {
                    btnRSave_Click(sender, e);
                }
                else if (Msg == System.Windows.Forms.DialogResult.No)
                {
                    Checkit(dtTrPake);
                    Checkit(dtTrSalah);
                }
            }
            dtTrPake.Rows.Clear();
            dtTrSalah.Rows.Clear();
            TransKhususBaru Trans = new TransKhususBaru();
            for (int i = 0; i < Maim.listKhusus.Count; i++)
            {
                if (Maim.listKhusus[i].Tanggal.Date == dtTgl.Value.Date)
                {
                    Trans = Maim.listKhusus[i];
                }
            }

            FillDataGrid(dtTrSalah, Trans.Salah);
            FillDataGrid(dtTrPake, Trans.Pakai);
            //if (btnUse.Checked == true)
            //{
            //    for (int i = 0; i < Trans.Pakai.Count; i++)
            //    {
            //        string[] bla = new string[] { Trans.Pakai[i].Pulse.Kode, Trans.Pakai[i].Pulse.Untung.ToString(), Trans.Pakai[i].Unit.ToString(), Trans.Pakai[i].SubHarga.ToString() };
            //        dttrpakekks.Rows.Add(bla);
            //        dttrpakekks.Rows[dttrpakekks.RowCount - 1].DefaultCellStyle.BackColor = Trans.Pakai[i].Pulse.Operand.Warna;

            //    }
            //}
            //else if (btnWrong.Checked == true)
            //{
            //    for (int i = 0; i < Trans.Salah.Count; i++)
            //    {
            //        string[] bla = new string[] { Trans.Salah[i].Pulse.Kode, Trans.Salah[i].Pulse.Untung.ToString(), Trans.Salah[i].Unit.ToString(), Trans.Salah[i].SubHarga.ToString() };
            //        dttrpakekks.Rows.Add(bla);
            //        dttrpakekks.Rows[dttrpakekks.RowCount - 1].DefaultCellStyle.BackColor = Trans.Salah[i].Pulse.Operand.Warna;
            //    }
            //}
            AddTotal(dtTrPake);
            AddTotal(dtTrSalah);
            DTP.Value = dtTgl.Value;
            ChDate = true;
            Restar();
            Maim.SizeManage(dtTrPake);
            Maim.SizeManage(dtTrSalah);
            //dtTransaksi.Width -= 75;

            #endregion

            #region Tab2
            if (extra == false)
            {
                DialogResult Msg = MessageBox.Show("Data in Belum disimpan, APakah ingin disimpan?", "Message", MessageBoxButtons.YesNo);
                if (Msg == System.Windows.Forms.DialogResult.Yes)
                {
                    btnSimpan_Click(sender, e);
                }
            }
            Trk = new TransKhususBaru();
            int ava = 0;
            TotBonus = 0; TotMin = 0; TotPulse = 0;
            Bonuss.Clear(); Rugiii.Clear(); PakePLain.Clear();
            #region listKhusus
            for (int i = 0; i < Maim.listKhusus.Count; i++)
            {
                if (Maim.listKhusus[i].Tanggal.Date == dtTgl.Value.Date)
                {
                    ava++;
                    Trk = Maim.listKhusus[i];
                    p = i;
                    Bonuss = new List<INT>(Trk.Bonus);
                    Rugiii = new List<INT>(Trk.Rugi);
                    PakePLain = new List<INT>(Trk.PakeLain);
                    foreach (INT angka in Rugiii)
                    {
                        TotMin += angka.Number;
                    }
                    foreach (INT angka in Bonuss)
                    {
                        TotBonus += angka.Number;
                    }
                    foreach (INT angka in PakePLain)
                    {
                        TotPulse += angka.Number;
                    }
                }
            }
            if (ava == 0)
            {
                p = Maim.listKhusus.Count;
                Maim.listKhusus.Add(Trk);
                Trk.Tanggal = dtTgl.Value;
            }
            #endregion

            lblTotBonus.Text = TotBonus.ToString();
            lblTotMin.Text = TotMin.ToString();
            lblTotPakeLain.Text = TotPulse.ToString();


            dtBon.Columns.Clear();
            dtMin.Columns.Clear();
            dtPLain.Columns.Clear();
            dtBon.DataSource = null;
            dtMin.DataSource = null;
            dtPLain.DataSource = null;
            dtBon.DataSource = Trk.Bonus;
            dtMin.DataSource = Trk.Rugi;
            dtPLain.DataSource = Trk.PakeLain;
            dtBon.Columns[0].HeaderText = "Nama";
            dtBon.Columns[1].HeaderText = "Bonus";
            dtMin.Columns[1].HeaderText = "Rugi";
            dtMin.Columns[0].HeaderText = "Nama";
            dtPLain.Columns[1].HeaderText = "Jumlah";
            dtPLain.Columns[0].HeaderText = "Nama (Kode)";
            extra = true;
            #endregion
            //Maim.SizeManage(dtBon);
            //Maim.SizeManage(dtMin);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string[] hah = new string[] { numBonus.Value.ToString() };
            //dtBon.Rows.Add(hah);
            if (numBonus.Value > 0)
            {
                dtBon.DataSource = null;
                INT What = new INT((int)numBonus.Value, txtNameBon.Text);
                Bonuss.Add(What);
                TotBonus += (int)numBonus.Value;
                dtBon.DataSource = Bonuss;
                lblTotBonus.Text = TotBonus.ToString();
                numBonus.Value = 0;
                extra = false;
                dtBon.Columns[0].HeaderText = "Nama";
                dtBon.Columns[1].HeaderText = "Bonus";
                txtNameBon.Text = "";
            }
        }

        private void btnRugi_Click(object sender, EventArgs e)
        {
            if (numRugi.Value > 0)
            {
                dtMin.DataSource = null;
                INT Whuts = new INT((int)numRugi.Value, txtNameMin.Text);
                Rugiii.Add(Whuts);
                dtMin.DataSource = Rugiii;
                TotMin += (int)numRugi.Value;
                lblTotMin.Text = TotMin.ToString();
                numRugi.Value = 0;
                extra = false;
                txtNameMin.Text = "";
                dtMin.Columns[1].HeaderText = "Rugi";
                dtMin.Columns[0].HeaderText = "Nama";

            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            Maim.listKhusus[p].Rugi = new List<INT>(Rugiii);
            Maim.listKhusus[p].Bonus = new List<INT>(Bonuss);
            Maim.listKhusus[p].PakeLain = new List<INT>(PakePLain);
            extra = true;
            MessageBox.Show("Saved");
        }

        private void PakeKirim_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            dtTgl_ValueChanged(sender, e);
            if (PakeKirim.SelectedIndex == 0)
            {
                PakeKirim.Height = 600;
                
            }
            else
            {
                PakeKirim.Height = 475;
               
            }
        }

        private void dtBon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (deru == true && e.RowIndex >= 0)
            {
                TotBonus -= int.Parse(dtBon.Rows[e.RowIndex].Cells[1].Value.ToString());
                Bonuss.RemoveAt(e.RowIndex);
                dtBon.DataSource = null;
                dtBon.DataSource = Bonuss;
                lblTotBonus.Text = TotBonus.ToString();
                dtBon.Columns[0].HeaderText = "Bonus";

            }
        }

        //private void Delbon_Click(object sender, EventArgs e)
        //{
        //    if (derubon == false)
        //    {
        //        derubon = true;
        //        //Delbon.BackgroundImage = Properties.Resources.DataDelAk;
        //    }
        //    else
        //    {
        //        derubon = false;
        //        //Delbon.BackgroundImage = Properties.Resources.DataDel;
        //    }
        //}

        private void delMin_Click(object sender, EventArgs e)
        {
            if (deru == false)
            {
                deru = true;
                delMin.BackgroundImage = Properties.Resources.DataDelAk;
            }
            else
            {
                deru = false;
                delMin.BackgroundImage = Properties.Resources.DataDel;
            }
        }

        private void dtMin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (deru == true && e.RowIndex >= 0)
            {
                TotMin -= int.Parse(dtMin.Rows[e.RowIndex].Cells[1].Value.ToString());
                Rugiii.RemoveAt(e.RowIndex);
                dtMin.DataSource = null;
                dtMin.DataSource = Rugiii;
                lblTotMin.Text = TotMin.ToString();

                dtMin.Columns[0].HeaderText = "Rugi";
            }
        }

        #endregion
        private void TransaksiKhusus_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == Maim.MsBtn)
            {
                Maim.Warna(bName, this);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            dtTgl_ValueChanged(sender, e);
            this.Close();
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            Checkit(dtTrSalah);
            Checkit(dtTrPake);
            ChDate = true; extra = true;
            dtTgl_ValueChanged(sender, e);
        }

        private void dtTransaksi_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            //ChDate = false;
        }

        private void txtNameMin_TextChanged(object sender, EventArgs e)
        {

        }

        private void TrPulse_Click(object sender, EventArgs e)
        {
            Rebound = true;
            this.Close();
        }

        private void dtPLain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (deru == true && e.RowIndex >= 0)
            {
                TotPulse -= int.Parse(dtPLain.Rows[e.RowIndex].Cells[1].Value.ToString());
                PakePLain.RemoveAt(e.RowIndex);
                dtPLain.DataSource = null;
                dtPLain.DataSource = PakePLain;
                lblTotPakeLain.Text = TotPulse.ToString();

                dtPLain.Columns[0].HeaderText = "Nama (Kode)";
                dtPLain.Columns[1].HeaderText = "Jumlah";
            }
        }

        private void btnPakeLain_Click(object sender, EventArgs e)
        {
            if (numKPulse.Value > 0)
            {
                dtPLain.DataSource = null;
                INT What = new INT((int)numKPulse.Value, txtKPulse.Text+ " (" + txtKode.Text+ ")");
                PakePLain.Add(What);
                TotPulse += (int)numKPulse.Value;
                dtPLain.DataSource = PakePLain;
                lblTotPakeLain.Text = TotPulse.ToString();
                numKPulse.Value = 0;
                extra = false;
                dtPLain.Columns[0].HeaderText = "Nama (Kode)";
                dtPLain.Columns[1].HeaderText = "Jumlah";
                txtKPulse.Text = "";
                txtKode.Text = "";
            }
        }

        private void gbxOtPulse_Enter(object sender, EventArgs e)
        {

        }

     
    }
    
}
