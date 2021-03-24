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
    public partial class History : Form
    {
        string bName = "BHistory.jpg";
        Utama Maim;
        public int idex = 0;
        List<string> listMonth = new List<string>{"January", "February", "March", "April", "May", "June", "July",
                                "August", "September", "October", "November", "December"};
        public bool tb1Change = false;
        bool asli1 = false;

        public History()
        {
            InitializeComponent();
        }


        private void History_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            PanPer.Visible = false;
            Maim = (Utama)this.Owner;
            Maim.ChangeBack(bName, this);

            cmbMonth.SelectedIndex = DateTime.Now.Month - 1;
            numKwi.Value = DateTime.Now.Year;
            numSell.Value = numKwi.Value;

            //cmbDMBulan.SelectedIndex = DateTime.Now.Month - 1;
            //numKiosk.Value = numSell.Value;
            ckdCheck.Checked = true;

            tb1Change = false;

            //TbDatePeriod();
            //cmbMonth.SelectedIndex = 0;
            //detMkios.SelectedTab = detMkios.TabPages[2];
            numKiosk.Value = DateTime.Now.Year;

            tb1Change = true;

            int bulan = DateTime.Now.Month;
            int tahun = DateTime.Now.Year;

            
            //dtMStart.Value = dtMEnd.Value.Subtract(TimeSpan.FromDays(6));
            dtMStart.Value = new DateTime(tahun, bulan, 1);
            dtMEnd.Value = new DateTime(tahun, bulan, DateTime.DaysInMonth(tahun, bulan));
            ckdCheck.Checked = false;
            //tb3ViewKwitance();
            PanPer.Visible = true;
           
            //DtAw.Value = dtAk.Value.Subtract(TimeSpan.FromDays(6));
            DtAw.Value = new DateTime(tahun, bulan, 1);
            dtAk.Value = new DateTime(tahun, bulan, DateTime.DaysInMonth(tahun, bulan));
            asli1 = true;
            Tb1DatePeriod();
        }

        #region Methods
        private int FindTotal(List<INT> Lister)
        {
            int num = 0;
            for (int i = 0; i < Lister.Count; i++)
            {
                num += Lister[i].ToInt();
            }
            return num;
        }
        private int FindTotal(List<SubTransaction> lSub)
        {
            int num = 0;
            for (int i = 0; i < lSub.Count; i++)
            {
                num += lSub[i].SubUntung;
            }
            return num;
        }

        private DataGridViewCellStyle GetStyle(Color Backwarna)
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style.ForeColor = Color.Black;
            style.BackColor = Backwarna;
            return style;
        }

        private void ChangeBackColumn(DataGridView DGrid,int dex, Color Warna)
        {
            DGrid.Columns[dex].DefaultCellStyle.BackColor = Warna;
            DGrid.Columns[dex].HeaderCell.Style = GetStyle(Warna);
        }

        private void tb4ViewKwitance()
        {
            dtKwitance.Rows.Clear();

            ChangeBackColumn(dtKwitance, 0, Color.PaleTurquoise);
            ChangeBackColumn(dtKwitance, 1, Color.GreenYellow);
            ChangeBackColumn(dtKwitance, 2, Color.GreenYellow);
            ChangeBackColumn(dtKwitance, 3, Color.FromArgb(255,255,128));
            ChangeBackColumn(dtKwitance, 4, Color.GreenYellow);
            ChangeBackColumn(dtKwitance, 5, Color.GreenYellow);
            ChangeBackColumn(dtKwitance, 6, Color.GreenYellow);
            ChangeBackColumn(dtKwitance, 7, Color.GreenYellow);
            ChangeBackColumn(dtKwitance, 8, Color.FromArgb(255,255,128));
            ChangeBackColumn(dtKwitance, 9, Color.FromArgb(255, 192, 192));



            for (int i = 0; i < listMonth.Count; i++)
            {
                TransKhususBaru trKhusus = new TransKhususBaru();
                int avai = 0;

                int Income = 0, salah = 0,
                Bonus = 0, kurang = 0, Beli = 0,
                Pake = 0, total = 0, Sisa = 0, TotIncome = 0;

                for (int k = 0; k < Maim.listTransaction.Count; k++)
                {
                    if (Maim.listTransaction[k].Tanggal.Month == (i + 1) && Maim.listTransaction[k].Tanggal.Year == numKwi.Value)
                    {
                        Income += Maim.listTransaction[k].TotalUntung;
                    }
                }
                for (int j = 0; j < Maim.listKhusus.Count; j++)
                {
                    if(Maim.listKhusus[j].Tanggal.Month == (i+1) && Maim.listKhusus[j].Tanggal.Year == numKwi.Value)
                    {
                        avai++;
                        trKhusus = Maim.listKhusus[j];
                        Bonus += FindTotal(trKhusus.Bonus);
                        kurang += FindTotal(trKhusus.Rugi);
                        Pake += FindTotal(trKhusus.Pakai);
                        salah += FindTotal(trKhusus.Salah);
                        Beli += FindTotal(trKhusus.PakeLain);

                        
                    }
                }
                TotIncome = Income + Bonus;
                total = -( - kurang - Pake - salah - Beli);
                Sisa = TotIncome - total;

                string[] Rowu = new string[] {listMonth[i], Income.ToString(), Bonus.ToString(), TotIncome.ToString() ,Pake.ToString(), Beli.ToString(),
                                    salah.ToString(), kurang.ToString(), total.ToString(), Sisa.ToString()};
                dtKwitance.Rows.Add(Rowu);            
                }
                dtKwitance.Rows.Add();
                int ide = dtKwitance.RowCount-1;
                dtKwitance.Rows[ide].Cells[0].Value = "Total";
         
                //dtKwitance.Rows[dtKwitance.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Aqua;
                dtKwitance.Rows[dtKwitance.Rows.Count - 1].DefaultCellStyle.Font = new System.Drawing.Font(new FontFamily("Comic Sans MS"), 12);
                //for (int i = 1; i < dtKwitance.ColumnCount; i++)
                //{
                //    dtKwitance.Rows[ide].Cells[i].Value = FindNomi(i,dtKwitance);
                //}
                dtKwitance.Rows[ide].Cells[3].Value = FindNomi(3, dtKwitance);
                dtKwitance.Rows[ide].Cells[9].Value = FindNomi(9, dtKwitance);

                dtKwitance.Rows.Add();
                 ide ++;
                dtKwitance.Rows[ide].Cells[0].Value = "Average";
                //dtKwitance.Rows[dtKwitance.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Aqua;
                //dtKwitance.Rows[dtKwitance.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.White;
                //for (int i = 1; i < dtKwitance.ColumnCount; i++)
                //{
                //    dtKwitance.Rows[ide].Cells[i].Value = int.Parse(dtKwitance.Rows[ide-1].Cells[i].Value.ToString())/12;
                //}
                //DetailPulsa DP = new DetailPulsa();
                dtKwitance.Rows[ide].Cells[3].Value = int.Parse(dtKwitance.Rows[ide - 1].Cells[3].Value.ToString()) / 12;
                dtKwitance.Rows[ide].Cells[9].Value = int.Parse(dtKwitance.Rows[ide - 1].Cells[9].Value.ToString()) / 12;
                Maim.SizeManage(dtKwitance);
                dtKwitance.ScrollBars = ScrollBars.None;

                dtKwitance.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                
               // History hst = new History();            
            }              
        private void tb2MonthCheck()
        {
            int Lebar = 0;
            int Avai = 0;
            CheckPoint Chk = new CheckPoint();
            for (int i = 0; i < Maim.listCheckPoint.Count; i++)
            {
                if(Maim.listCheckPoint[i].Bulan == cmbMonth.SelectedIndex + 1 && Maim.listCheckPoint[i].Tahun == numSell.Value)
                {
                    Chk = Maim.listCheckPoint[i];
                    Avai++;
                    idex = i;
                }
            }
            if (Avai == 0)
            {
                Chk = new CheckPoint(cmbMonth.SelectedIndex + 1, (int)numSell.Value);
                DateTime Datee = new DateTime(Chk.Tahun, Chk.Bulan, (int)1);
                DateTime Datea = new DateTime(Chk.Tahun, Chk.Bulan, DateTime.DaysInMonth(Chk.Tahun,Chk.Bulan));
                
                CheckDate Chd = new CheckDate(Datee,Datea);
                Chk.ListCheck.Add(Chd);
                Maim.listCheckPoint.Add(Chk);
                idex = Maim.listCheckPoint.Count - 1;
            }
            
            panCheck.Controls.Clear();
            panCheck.BackgroundImage = BackgroundImage;
            DataGridView DGrid = new DataGridView();
            DGrid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGrid.RowHeadersVisible = false;
            DGrid.AllowUserToAddRows = false;
            DGrid.ReadOnly = true;
            DGrid.Columns.Add("dtKode", "Kode");
            DGrid.Columns.Add("dtUntung", "Untung");
            for (int m = 0; m < Chk.ListCheck.Count; m++)
            {
                DGrid.Columns.Add("dtCheck" + m, Chk.ListCheck[m].Wordy);
                DGrid.Columns[DGrid.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                Lebar += 25;
                //DGrid.Columns[DGrid.ColumnCount - 1].HeaderText += DGrid.Columns[DGrid.ColumnCount - 1].Width.ToString();
            }
            DGrid.Columns.Add("dtJumlah", "T.Unit");
            DGrid.Columns.Add("dtSum", "Total");

            for (int i = 0; i < Maim.listPulsa.Count; i++)
            {
                List<string> bla = new List<string>();
                bla.Add(Maim.listPulsa[i].Kode);
                bla.Add(Maim.listPulsa[i].Untung.ToString());

                int Totjum = 0;
                for (int m = 0; m < Chk.ListCheck.Count; m++)
                {
                    int jum = 0;
                    for (int j = 0; j < Maim.listTransaction.Count; j++)
                    {
                        if (Maim.listTransaction[j].Tanggal.Month == Chk.Bulan && Maim.listTransaction[j].Tanggal.Year == Chk.Tahun
                            && Chk.ListCheck[m].Starting.Day <= Maim.listTransaction[j].Tanggal.Day && Chk.ListCheck[m].Ending.Day >= Maim.listTransaction[j].Tanggal.Day)
                        {
                            for (int k = 0; k < Maim.listTransaction[j].ListSTrans.Count; k++)
                            {
                                SubTransaction STrans = Maim.listTransaction[j].ListSTrans[k];
                                if (STrans.Pulse.Kode == Maim.listPulsa[i].Kode)
                                {
                                    jum += STrans.Unit;
                                }
                            }
                        }
                    }
                    bla.Add(jum.ToString());
                    Totjum += jum;
                }
                bla.Add(Totjum.ToString());
                int Sum = Totjum * Maim.listPulsa[i].Untung;
                bla.Add(Sum.ToString());
               string[] haha = new string[bla.Count];
                haha = bla.ToArray();
                DGrid.Rows.Add(haha);
                DGrid.Rows[DGrid.RowCount - 1].DefaultCellStyle.BackColor = Maim.listPulsa[i].Operand.Warna;
            }
            DGrid.Rows.Add();
            DGrid.Rows[DGrid.Rows.Count - 1].Cells[0].Value = "Total";

            DGrid.Rows[DGrid.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Black;
            DGrid.Rows[DGrid.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.White;
            DetailPulsa DP = new DetailPulsa();
            DP.SizeManage(DGrid);
            DGrid.ScrollBars = ScrollBars.None;
            for (int i = 2; i < DGrid.ColumnCount; i++)
            {
                DGrid.Rows[DGrid.Rows.Count - 1].Cells[i].Value = FindNomi(i, DGrid);
            }

            DGrid.Location = new Point(0, 0);
            panCheck.Controls.Add(DGrid);
            //DetailPulsa Dp = new DetailPulsa();
            Maim.SizeManage(DGrid);
            //DGrid.BackgroundColor = Color.Transparent;
            DGrid.Width -= Lebar;
        }
        private void Tb1DatePeriod()
        {
            if (tb1Change == true && asli1 == true)
            {
                int TotHarga = 0;
                int TotUntung = 0;
                PanPer.Controls.Clear();
                PanPer.BackgroundImage = this.BackgroundImage;
                int Loca = 0;

                DateTime tglAwal = DateTime.Parse(DtAw.Value.ToLongDateString());
                int kecilan = DateTime.Compare(tglAwal, dtAk.Value);
               // for (int i = DtAw.Value.DayOfYear; i <= dtAk.Value.DayOfYear; i++)
                while (DateTime.Compare(tglAwal, dtAk.Value) <= 0)
                {

                    //DateTime Waktu = new DateTime();
                    //Waktu = DtAw.Value.Add(TimeSpan.FromDays(Loca));
                    Panel Pan = new Panel();
                    Label Tgl = new Label();
                    Pan.Left = (Loca % 2) * 535;
                    Pan.Top = (Loca / 2) * 250;
                    Loca++;
                    Tgl.Text = tglAwal.Date.ToLongDateString();
                    Tgl.Dock = DockStyle.Top;
                    Tgl.AutoSize = false;
                    Tgl.TextAlign = ContentAlignment.MiddleCenter;
                    Tgl.Location = new Point(0, 0);
                    Pan.Controls.Add(Tgl);
                    DataGridView dtGrid = new DataGridView();
                    DisplayOperator DSp = new DisplayOperator();
                    dtGrid = DSp.dtTransaksi;
                    dtGrid.Location = new Point(7, 30);
                    dtGrid.Visible = true;
                    Pan.Controls.Add(dtGrid);
                    Pan.Size = new Size(530, 240);
                    Pan.BorderStyle = BorderStyle.Fixed3D;
                    Pan.AutoScroll = true;
                    PanPer.Controls.Add(Pan);

                    Tb1GridView(dtGrid, tglAwal);

                    TotHarga += FindNomi(4, dtGrid);
                    TotUntung += FindNomi(5, dtGrid);

                    tglAwal = tglAwal.AddDays(1);
                }
                lblKas.Text = TotHarga.ToString();
                lblUntung.Text = TotUntung.ToString();
            }
           
        }
        public void Tb1GridView(DataGridView DView, DateTime Timme)
        {
            Transaction Trans = new Transaction();
            for (int i = 0; i < Maim.listTransaction.Count; i++)
            {
                if (Maim.listTransaction[i].Tanggal.Date == Timme.Date)
                {
                    Trans = Maim.listTransaction[i];
                }
            }

            for (int i = 0; i < Trans.ListSTrans.Count; i++)
            {
                string[] bla = new string[] { Trans.ListSTrans[i].Pulse.Kode, Trans.ListSTrans[i].Pulse.Harga.ToString(), Trans.ListSTrans[i].Pulse.Untung.ToString(), Trans.ListSTrans[i].Unit.ToString(), Trans.ListSTrans[i].SubHarga.ToString(), Trans.ListSTrans[i].SubUntung.ToString() };
                DView.Rows.Add(bla);
                DView.Rows[DView.RowCount - 1].DefaultCellStyle.BackColor = Trans.ListSTrans[i].Pulse.Operand.Warna;
            }

            DView.Rows.Add();
            DView.Rows[DView.Rows.Count - 1].Cells[0].Value = "Total";
            DView.Rows[DView.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Black;
            DView.Rows[DView.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.White;
            DView.Rows[DView.Rows.Count - 1].Cells[3].Value = FindNomi(3, DView);
            DView.Rows[DView.Rows.Count - 1].Cells[4].Value = FindNomi(4, DView);
            DView.Rows[DView.Rows.Count - 1].Cells[5].Value = FindNomi(5, DView);
            DView.ScrollBars = ScrollBars.Vertical;
        }
        public void EditTwoDate(DateTimePicker StDate, DateTimePicker EndDate, DateTime stTo, DateTime EndTo)
        {
            if (tb1Change == true)
            {  tb1Change = false;}

            StDate.MaxDate = new DateTime(2222, 12,31);// DateTime.Parse("12/31/9998");
            StDate.MinDate = new DateTime(1990, 1, 1); //DateTime.Parse("1/1/1900");
            EndDate.MinDate = new DateTime(1990, 1, 1);//DateTime.Parse("1/1/1900");
            EndDate.MaxDate = new DateTime(2222,  12,31);//DateTime.Parse("12/31/9998");
            StDate.Value = stTo;
            tb1Change = true;
            EndDate.Value = EndTo;
            StDate.MaxDate = EndTo;
            EndDate.MinDate = stTo;
        }
        private int FindNomi(int inndex, DataGridView DView)
        {
            try
            {
                int Total = 0;
                for (int i = 0; i < DView.Rows.Count - 1; i++)
                {
                    Total += int.Parse(DView.Rows[i].Cells[inndex].Value.ToString());
                }
                return Total;
            }
            catch(Exception ex)
            {

            }
            return 0;
        }
        private void tb3DetKios()
        {
            if (dtMStart.Value.Year >= 2015)
            {
                int Lebar = 0;
                panKios.Controls.Clear();
                panKios.BackgroundImage = this.BackgroundImage;
                CheckDate Chk = new CheckDate(dtMStart.Value, dtMEnd.Value);
                DataGridView DGrid = new DataGridView();
                DGrid.AutoSize = true;
                DGrid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGrid.RowHeadersVisible = false;
                DGrid.AllowUserToAddRows = false;
                DGrid.ReadOnly = true;
                DGrid.ScrollBars = ScrollBars.None;
                DGrid.Columns.Add("dtKode", "Kode");
                DGrid.Columns.Add("dtUntung", "Untung");
                int jum = 0;
                int TTal = 0;

                DateTime tglAwal = DateTime.Parse(Chk.Starting.ToLongDateString());
                 while (DateTime.Compare(tglAwal, Chk.Ending) <= 0)
                //for (int m = Chk.Starting.DayOfYear; m <= Chk.Ending.DayOfYear; m++)
                {
                    DGrid.Columns.Add("tgl" + (jum + 1), tglAwal.Day.ToString());
                    DGrid.Columns[DGrid.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    Lebar += 50;
                    jum++;
                    tglAwal = tglAwal.AddDays(1);
                }
                DGrid.Columns.Add("dtUnit", "Unit");
                DGrid.Columns.Add("dtTotal", "Total");

                for (int i = 0; i < Maim.listPulsa.Count; i++)
                {
                    if (ckdtb3Mkios.Checked)
                    {
                        if (Maim.listPulsa[i].Operand.TipePulsa == PulsaType.Mkios)
                        {
                            List<string> bla = new List<string>();
                            bla.Add(Maim.listPulsa[i].Kode);
                            bla.Add(Maim.listPulsa[i].Untung.ToString());
                            int Totjum = 0;
                            for (int m = Chk.Starting.DayOfYear; m <= Chk.Ending.DayOfYear; m++)
                            {
                                int jumlah = 0;
                                for (int j = 0; j < Maim.listTransaction.Count; j++)
                                {
                                    if (m == Maim.listTransaction[j].Tanggal.DayOfYear)
                                    {
                                        for (int k = 0; k < Maim.listTransaction[j].ListSTrans.Count; k++)
                                        {
                                            SubTransaction STrans = Maim.listTransaction[j].ListSTrans[k];
                                            if (STrans.Pulse.Kode == Maim.listPulsa[i].Kode)
                                            {
                                                jumlah += STrans.Unit;
                                            }
                                        }
                                    }
                                }
                                bla.Add(jumlah.ToString());
                                Totjum += jumlah;
                            }
                            bla.Add(Totjum.ToString());
                            TTal = (Totjum * Maim.listPulsa[i].Untung);
                            bla.Add(TTal.ToString());
                            string[] haha = new string[bla.Count];
                            haha = bla.ToArray();
                            DGrid.Rows.Add(haha);
                            DGrid.Rows[DGrid.RowCount - 1].DefaultCellStyle.BackColor = Maim.listPulsa[i].Operand.Warna;

                        }
                    }
                    else
                    {
                        List<string> bla = new List<string>();
                        bla.Add(Maim.listPulsa[i].Kode);
                        bla.Add(Maim.listPulsa[i].Untung.ToString());
                        int Totjum = 0;
                        tglAwal = DateTime.Parse(Chk.Starting.ToLongDateString());
                        while (DateTime.Compare(tglAwal, Chk.Ending) <= 0)
                       // for (int m = Chk.Starting.DayOfYear; m <= Chk.Ending.DayOfYear; m++)
                        {
                            int jumlah = 0;
                            for (int j = 0; j < Maim.listTransaction.Count; j++)
                            {
                                int bding = DateTime.Compare(tglAwal.Date, Maim.listTransaction[j].Tanggal.Date);
                                if (bding == 0)
                                {
                                    for (int k = 0; k < Maim.listTransaction[j].ListSTrans.Count; k++)
                                    {
                                        SubTransaction STrans = Maim.listTransaction[j].ListSTrans[k];
                                        if (STrans.Pulse.Kode == Maim.listPulsa[i].Kode)
                                        {
                                            jumlah += STrans.Unit;
                                        }
                                    }
                                }
                            }
                            bla.Add(jumlah.ToString());
                            Totjum += jumlah;
                            tglAwal = tglAwal.AddDays(1);
                        }
                        TTal = (Totjum * Maim.listPulsa[i].Untung);
                        bla.Add(Totjum.ToString());
                        bla.Add(TTal.ToString());

                        string[] haha = new string[bla.Count];
                        haha = bla.ToArray();
                        DGrid.Rows.Add(haha);
                        DGrid.Rows[DGrid.RowCount - 1].DefaultCellStyle.BackColor = Maim.listPulsa[i].Operand.Warna;
                        DGrid.AutoSize = true;
                    }
                }
                DGrid.Location = new Point(0, 0);

                DGrid.Rows.Add();
                DGrid.Rows[DGrid.Rows.Count - 1].Cells[0].Value = "Total";
                DGrid.Rows[DGrid.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Black;
                DGrid.Rows[DGrid.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.White;
                lbl3Tharga.Text = FindNomi(DGrid.ColumnCount - 1, DGrid).ToString();
                for (int i = 2; i < DGrid.ColumnCount; i++)
                {
                    DGrid.Rows[DGrid.Rows.Count - 1].Cells[i].Value = FindNomi(i, DGrid);
                }

                panKios.Controls.Add(DGrid);
                // DGrid.ColumnHeadersDefaultCellStyle = dtKwitance.ColumnHeadersDefaultCellStyle;
                DetailPulsa Dp = new DetailPulsa();
                Dp.SizeManage(DGrid);
                DGrid.Width -= Lebar;
            }
        }
        #endregion

        #region EventHandler

        private void DtAw_ValueChanged(object sender, EventArgs e)
        {
           
            //DtAw.MaxDate = dtAk.Value;
            dtAk.MinDate = DtAw.Value;
            Tb1DatePeriod();
            if (ckdCheck.Checked == false)
            {
                if (DtAw.Value != dtMStart.Value)
                {
                    dtMStart.Value = DtAw.Value;
                }
            }
        }

        private void dtAk_ValueChanged(object sender, EventArgs e)
        {
            if (ckdCheck.Checked == false)
            {
                if (dtMEnd.Value != dtAk.Value)
                {
                    dtMEnd.Value = dtAk.Value;
                }
            }
           
            DtAw.MaxDate = dtAk.Value;
            Tb1DatePeriod();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            PanPer.Invalidate();
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb2MonthCheck();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            FCheckPointDisplay fc = new FCheckPointDisplay();
            fc.Owner = this;
            fc.ShowDialog();
            //cmbDMBulan_SelectedIndexChanged(sender, e);
            tb2MonthCheck();
            
        }

        private void dtMStart_ValueChanged(object sender, EventArgs e)
        {

            tb3DetKios();
            dtMEnd.MinDate = dtMStart.Value;
            dtMStart.MaxDate = dtMEnd.Value;
            if (ckdCheck.Checked == false)
            {
                if (DtAw.Value != dtMStart.Value && dtMStart.Value.Year > 2000 && dtMStart.Value.Year < 2050)
                {
                    DtAw.Value = dtMStart.Value;

                }
                if (dtMEnd.Value != dtAk.Value && dtMEnd.Value.Year < 2050 && dtMEnd.Value.Year > 2000)
                {
                    dtAk.Value = dtMEnd.Value;
                }
            }
        }

        private void ckdCheck_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (ckdCheck.Checked)
                {
                    tb1Change = false;
                    dtMEnd.Enabled = false;
                    dtMStart.Enabled = false;
                    panDMckdCheck.Visible = true;

                    cmbDMBulan.SelectedIndex = DateTime.Now.Month - 1;
                    //tb1Change = true;
                    numKiosk.Value = numSell.Value;

                }
                else
                {
                    dtMEnd.Enabled = true;
                    dtMStart.Enabled = true;
                    panDMckdCheck.Visible = false;

                }
            }
            catch(Exception ec)
            {

            }
        }

        private void cmbDMckd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDMckd.SelectedValue != null)
            {
                CheckDate Datee = (CheckDate)cmbDMckd.SelectedValue;
                EditTwoDate(dtMStart, dtMEnd, Datee.Starting, Datee.Ending);
                EditTwoDate(DtAw, dtAk, Datee.Starting, Datee.Ending);
                //dtMEnd.Value = Datee.Ending;
                //dtMStart.Value = Datee.Starting;
            }
            else
            {
                //MessageBox.Show("null");
            }
        }

        private void cmbDMBulan_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDMckd.DataSource = null;
            cmbDMckd.Items.Clear();
            int Avai = 0;
            CheckPoint Chk = new CheckPoint();
            CheckDate Chd;
            for (int i = 0; i < Maim.listCheckPoint.Count; i++)
            {
                if (Maim.listCheckPoint[i].Bulan == cmbDMBulan.SelectedIndex + 1 && Maim.listCheckPoint[i].Tahun == (int)numKiosk.Value)
                {
                    Chk = Maim.listCheckPoint[i];
                    Avai++;
                    cmbDMckd.DataSource = Maim.listCheckPoint[i].ListCheck;
                    cmbDMckd.DisplayMember = "Wordy";
                    cmbDMckd.SelectedIndex = cmbDMckd.Items.Count - 1;
                    idex = i;
                }
            }
            if (Avai == 0)
            {
                Chk = new CheckPoint(cmbDMBulan.SelectedIndex + 1, (int)numKiosk.Value);
                DateTime Datee = new DateTime(Chk.Tahun, Chk.Bulan, (int)1);
                DateTime Datea = new DateTime(Chk.Tahun, Chk.Bulan, DateTime.DaysInMonth(Chk.Tahun, Chk.Bulan));

                Chd = new CheckDate(Datee, Datea);
                Chk.ListCheck.Add(Chd);
                Maim.listCheckPoint.Add(Chk);
                //dtMEnd.Value = Chd.Ending;
                //dtMStart.Value = Chd.Starting;

                cmbDMckd.DataSource = Maim.listCheckPoint[Maim.listCheckPoint.Count - 1].ListCheck;
                cmbDMckd.DisplayMember = "Wordy";
                cmbDMckd.SelectedIndex = cmbDMckd.Items.Count - 1;
                idex = Maim.listCheckPoint.Count - 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FCheckPointDisplay fc = new FCheckPointDisplay();
            fc.Owner = this;
            fc.ShowDialog();
            tb2MonthCheck();
            cmbDMBulan_SelectedIndexChanged(sender, e);
        }
        #endregion

        private void History_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == Maim.MsBtn)
            {
                Maim.Warna(bName, this);
            }
        }

        private void numKwi_ValueChanged(object sender, EventArgs e)
        {
            tb4ViewKwitance();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ckdtb3Mkios_CheckedChanged(object sender, EventArgs e)
        {
            tb3DetKios();
        }

        private void tbKwitance_Click(object sender, EventArgs e)
        {

        }

        private void PanPer_Scroll(object sender, ScrollEventArgs e)
        {
            PanPer.BackgroundImage = null;
            PanPer.BackgroundImage = this.BackgroundImage;
        }
    }
}
