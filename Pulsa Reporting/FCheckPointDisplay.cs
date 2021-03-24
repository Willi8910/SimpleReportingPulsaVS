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
    public partial class FCheckPointDisplay : Form
    {
        int indexeeer;
        Utama Maim;

        bool Edit = false;
        bool Addd = false;

        int gbdex;

        List<Label> listFr = new List<Label>();
        List<Label> listCt = new List<Label>();
        List<Button> listDel = new List<Button>();
        List<Button> listbt = new List<Button>();

        public string bName = "FCheck.jpg";
        DateTime Maxer = new DateTime(12 / 31 / 9998);
        public FCheckPointDisplay()
        {
            InitializeComponent();
        }

        private void FCheckPointDisplay_Load(object sender, EventArgs e)
        {
            //PanCheck.Controls.Clear();
            listFr.Add(lblMark);
            listCt.Add(lblCheck);
            listDel.Add(btnDel);
            listbt.Add(btnDit);

            int v = lblCheck.Left;
            History hst = (History)this.Owner;
            indexeeer = hst.idex;

            Maim = (Utama)this.Owner.Owner;

            lblDate.Text = Maim.listCheckPoint[indexeeer].Bulan.ToString() + " - " + Maim.listCheckPoint[indexeeer].Tahun.ToString();

            for (int i = 0; i < Maim.listCheckPoint[indexeeer].ListCheck.Count; i++)
            {
                CheckDate cd = new CheckDate ();
                cd = Maim.listCheckPoint[indexeeer].ListCheck[i];
                if (i == 0)
                {
                    listFr[i].Text = "CheckPoint" + 1;
                    listCt[i].Text = Maim.listCheckPoint[indexeeer].ListCheck[i].Starting.Day + " - " + Maim.listCheckPoint[indexeeer].ListCheck[i].Ending.Day;
                }
                else
                {
                    AddCheck(i);
                }
                
            }
            Maim.ChangeBack(bName, this);
        }

        private void btnDit_Click(object sender, EventArgs e)
        {
            Edit = true;
            gbxTgl.Visible = true;
            Addd = false;

            for (int i = 0; i < listbt.Count; i++)
            {
                if (listbt[i] == sender)
                {
                    gbxTgl.Text = "CheckPoint" + (i + 1); 
                    History hst = new History();
                    hst.EditTwoDate(dtStart, dtEnd, Maim.listCheckPoint[indexeeer].ListCheck[i].Starting, Maim.listCheckPoint[indexeeer].ListCheck[i].Ending);
                    //dtStart.Value = Maim.listCheckPoint[indexeeer].ListCheck[i].Starting;
                    //dtEnd.Value = Maim.listCheckPoint[indexeeer].ListCheck[i].Ending;

                    if (i == 0 && i == Maim.listCheckPoint[indexeeer].ListCheck.Count -1)
                    {
                        dtStart.MinDate = DateTime.Parse(dtStart.Value.Month + " / " + 1 + " / " + dtStart.Value.Year);
                        dtEnd.MaxDate = DateTime.Parse(dtStart.Value.Month + " / " + DateTime.DaysInMonth(dtStart.Value.Year, dtStart.Value.Month) + " / " + dtStart.Value.Year);

                    }
                    else if (i > 0 && i < Maim.listCheckPoint[indexeeer].ListCheck.Count-1)
                    {
                        dtEnd.MaxDate = Maim.listCheckPoint[indexeeer].ListCheck[i + 1].Starting.Subtract(TimeSpan.FromDays(1));
                        dtStart.MinDate = Maim.listCheckPoint[indexeeer].ListCheck[i - 1].Ending.Add(TimeSpan.FromDays(1)); ;

                    }
                    
                    else if (i == 0)
                    {
                        dtEnd.MaxDate = Maim.listCheckPoint[indexeeer].ListCheck[i + 1].Starting.Subtract(TimeSpan.FromDays(1));
                        dtStart.MinDate = DateTime.Parse(dtStart.Value.Month + " / " + 1 + " / " + dtStart.Value.Year);
                    }
                    else if (i == Maim.listCheckPoint[indexeeer].ListCheck.Count - 1)
                    {
                        dtEnd.MaxDate = DateTime.Parse(dtStart.Value.Month + " / " + DateTime.DaysInMonth(dtStart.Value.Year, dtStart.Value.Month) + " / " + dtStart.Value.Year);
                        dtStart.MinDate = Maim.listCheckPoint[indexeeer].ListCheck[i - 1].Ending.Add(TimeSpan.FromDays(1)); ;
                    }
                    gbdex = i;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            int num = Maim.listCheckPoint[indexeeer].ListCheck.Count-1;
            int mxdate = DateTime.DaysInMonth(Maim.listCheckPoint[indexeeer].ListCheck[num].Ending.Year, Maim.listCheckPoint[indexeeer].ListCheck[num].Ending.Month);
            if(Maim.listCheckPoint[indexeeer].ListCheck[num].Ending.Day == mxdate)
            {

                MessageBox.Show("Jumlah tanggal sudah mencapai maximum, Ubah dulu!!!");
            }
            else
            {
                Addd = true;
                Edit = false;
                gbxTgl.Visible = true;
                gbxTgl.Text = "CheckPoint" + (num + 2);

                History hst = new History();
                hst.EditTwoDate(dtStart, dtEnd, Maim.listCheckPoint[indexeeer].ListCheck[num].Ending.Add(TimeSpan.FromDays(1)), dtEnd.Value.Add(TimeSpan.FromDays(mxdate - dtEnd.Value.Day)));

                int i = num;
                //dtStart.Value = Maim.listCheckPoint[indexeeer].ListCheck[num].Ending.Add(TimeSpan.FromDays(1));
                //dtEnd.Value = dtEnd.Value.Add(TimeSpan.FromDays(mxdate - dtEnd.Value.Day));
                dtEnd.MaxDate = dtEnd.Value;
                dtStart.MinDate = Maim.listCheckPoint[indexeeer].ListCheck[i].Ending.Add(TimeSpan.FromDays(1)); ;       
            }
        }

        private void btngbxSave_Click(object sender, EventArgs e)
        {
            CheckDate ckd = new CheckDate(dtStart.Value, dtEnd.Value);
            if(Addd == true)
            {
                Maim.listCheckPoint[indexeeer].ListCheck.Add(ckd);
                AddCheck(listbt.Count);
               
            }
            if(Edit == true)
            {
                listCt[gbdex].Text = dtStart.Value.Day + " - " + dtEnd.Value.Day;            
                Maim.listCheckPoint[indexeeer].ListCheck[gbdex] = ckd;
            }
            Edit = false;
            Addd = false;
            gbxTgl.Visible = false;
        }

        private void AddCheck(int i)
        {
            Label Chk = new Label();
            Label Conten = new Label();
            Chk.Font = lblMark.Font;
            Conten.Font = lblMark.Font;
            FCheckPointDisplay fCheck = new FCheckPointDisplay();
            Button Del = new Button();
            Del = fCheck.btnDel;
            Button btn = new Button();
            btn = fCheck.btnDit;
            listFr.Add(Chk);
            listCt.Add(Conten);
            listDel.Add(Del);
            listbt.Add(btn);
            Chk.AutoSize = true;
            listFr[i].Location = listFr[i - 1].Location;
            listFr[i].Top += 30;
            listCt[i].Location = listCt[i - 1].Location;
            listCt[i].Top += 30;
            listDel[i].Location = listDel[i - 1].Location;
            listDel[i].Top += 30;
            //listDel[i].Text = "Del";
            listDel[i].Size = listDel[i - 1].Size;
            listbt[i].Location = listbt[i - 1].Location;
            listbt[i].Top += 30;
            //listbt[i].Text = "Edit";
            listbt[i].Size = listbt[i - 1].Size;

            PanCheck.Controls.Add(Chk);
            PanCheck.Controls.Add(Conten);
            PanCheck.Controls.Add(Del);
            PanCheck.Controls.Add(btn);
            btn.Click += btnDit_Click;
            Del.Click += btnDel_Click;
            listFr[i].Text = "CheckPoint" + (i+1);
            listCt[i].Text = Maim.listCheckPoint[indexeeer].ListCheck[i].Wordy;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtEnd_ValueChanged(object sender, EventArgs e)
        {
            dtStart.MaxDate = dtEnd.Value;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listDel.Count; i++)
            {
                if (listDel[i] == sender)
                {
                    if (i == 0 && listDel.Count == 1)
                    {
                        DateTime dist = DateTime.Parse(dtStart.Value.Month + " / " + 1 + " / " + dtStart.Value.Year);
                       DateTime dest = DateTime.Parse(dtStart.Value.Month + " / " + DateTime.DaysInMonth(dtStart.Value.Year, dtStart.Value.Month) + " / " + dtStart.Value.Year);

                       CheckDate ckd = new CheckDate(dist, dest);
                        listCt[0].Text = ckd.Wordy;
                        Maim.listCheckPoint[indexeeer].ListCheck[0] = ckd;
                    }
                    else
                    {
                        PanCheck.Controls.Remove(listbt[i]);
                        PanCheck.Controls.Remove(listFr[i]);
                        PanCheck.Controls.Remove(listDel[i]);
                        PanCheck.Controls.Remove(listCt[i]);
                        listFr.RemoveAt(i);
                        listDel.RemoveAt(i);
                        listCt.RemoveAt(i);
                        listbt.RemoveAt(i);
                        Maim.listCheckPoint[indexeeer].ListCheck.RemoveAt(i);
                        Ressetto(indexeeer);
                    }
                }
            }
        }

        private void Ressetto(int l)
        {
            Edit = false;
            gbxTgl.Visible = false;
            Addd = false;
            PanCheck.Controls.Clear();

            for (int i = 0; i < Maim.listCheckPoint[l].ListCheck.Count; i++)
            {
                CheckDate cd = new CheckDate();
                cd = Maim.listCheckPoint[indexeeer].ListCheck[i];
                if (i == 0)
                {
                    listFr[i].Text = "CheckPoint" + 1;
                    listCt[i].Text = cd.Wordy;

                    listFr[i].AutoSize = true;
                    listFr[i].Location = lblMark.Location;
                    listCt[i].Location = lblCheck.Location;
                    listDel[i].Location = btnDel.Location;
                    //listDel[i].Text = "Del";
                    listDel[i].Size = btnDel.Size;
                    listbt[i].Location = btnDit.Location;
                    //listbt[i].Text = "Edit";
                    listbt[i].Size = btnDit.Size;

                   
                }
                else
                {
                    listFr[i].Location = listFr[i - 1].Location;
                    listFr[i].Top += 30;
                    listCt[i].Location = listCt[i - 1].Location;
                    listCt[i].Top += 30;
                    listDel[i].Location = listDel[i - 1].Location;
                    listDel[i].Top += 30;
                    //listDel[i].Text = "Del";
                    listDel[i].Size = listDel[i - 1].Size;
                    listbt[i].Location = listbt[i - 1].Location;
                    listbt[i].Top += 30;
                    //listbt[i].Text = "Edit";
                    listbt[i].Size = listbt[i - 1].Size;

                   
                    listFr[i].Text = "CheckPoint" + (i + 1);
                    listFr[i].Font = lblMark.Font;
                    listCt[i].Font = lblMark.Font;
                    listCt[i].Text = Maim.listCheckPoint[indexeeer].ListCheck[i].Wordy;
                }
                PanCheck.Controls.Add(listFr[i]);
                PanCheck.Controls.Add(listCt[i]);
                PanCheck.Controls.Add(listDel[i]);
                PanCheck.Controls.Add(listbt[i]);
                listbt[i].Click += btnDit_Click;
                listDel[i].Click += btnDel_Click;
            }
        }

        private void dtStart_ValueChanged(object sender, EventArgs e)
        {
            dtEnd.MinDate = dtStart.Value;
        }

        private void FCheckPointDisplay_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == Maim.MsBtn)
            {
                Maim.Warna(bName, this);
            }
        }
    }
}
