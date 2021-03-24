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

    public partial class DetailPulsa : Form
    {
        Utama Maim;
        public string dexPulseCode;
        //string bbNam = "BDetPulsa";
        string bName = "BDetPulsa.jpg";
        public DetailPulsa()
        {
            InitializeComponent();
        }

        public void Pulsa_Load(object sender, EventArgs e)
        {
            Maim = (Utama) this.Owner;
            Refreshh();
            Maim.ChangeBack(bName, this);
            
        }

        public void Refreshh()
        {
            panAllOp.Controls.Clear();
            if (Maim.listPulsa != null)
            {

                //Maim.listPulsa.Sort();
                dtMkios.DataSource = null;
                dtAllOp.DataSource = null;
                dtMkios.Rows.Clear();
                dtAllOp.Rows.Clear();

                foreach (Pulsa pul in Maim.listPulsa)
                {
                    if (pul.Operand.TipePulsa == PulsaType.Mkios)
                    {
                        PulsaMkios PKios = (PulsaMkios)pul;
                        string[] dtRow = new string[] { PKios.Kode, PKios.Harga.ToString(), PKios.Modal.ToString(), PKios.Untung.ToString() };
                        dtMkios.Rows.Add(dtRow);
                        dtMkios.Rows[dtMkios.Rows.Count -1 ].DefaultCellStyle.BackColor = pul.Operand.Warna;
                    }
                }

                List<DataGridView> lGrid = new List<DataGridView>();
                foreach (Operator Operan in Maim.listOperator)
                {
                    if (Operan.TipePulsa == PulsaType.AllOperator)
                    {
                        DetailPulsa Pls = new DetailPulsa();
                        Pls.dtaKode.HeaderText = Operan.Nama;
                        DataGridView dtOOp = Pls.dtAllOp;

                        foreach (Pulsa pul in Maim.listPulsa)
                        {
                            if (pul.Operand.Nama == Operan.Nama)
                            {

                                string[] dtRow = new string[] { pul.Kode, pul.Harga.ToString(), pul.Modal.ToString(), pul.Untung.ToString() };
                                dtOOp.Rows.Add(dtRow);
                                dtOOp.Rows[dtOOp.Rows.Count - 1].DefaultCellStyle.BackColor = pul.Operand.Warna;

                            }
                        }

                        dtOOp.Left = panAllOp.Controls.Count % 2 * 440 + 50;
                        dtOOp.Top = 30;
                        SizeManage(dtOOp);
                        if (panAllOp.Controls.Count >= 2)
                        {
                            dtOOp.Top = lGrid[panAllOp.Controls.Count - 2].Bottom + 50;
                        }
                        lGrid.Add(dtOOp);
                        panAllOp.Controls.Add(dtOOp);
                        dtOOp.BringToFront();
                        dtOOp.CellClick += dtAllOp_CellClick;
                        //MessageBox.Show(dtOOp.Left + " " + dtOOp.Top);

                        if (panAllOp.Height < dtOOp.Bottom + 100)
                        {
                            panAllOp.Height = dtOOp.Bottom + 100;
                        }
                    }
                }
                SizeManage(dtMkios);
                
                //dtAllOp.Sort(dtAllOp.Columns[0], ListSortDirection.Ascending);
                //dtMkios.Sort(dtMkios.Columns[0], ListSortDirection.Ascending);
            }
        }

        public void SizeManage(DataGridView Datagr)
        {
            //Datagr.AutoResizeColumns();
            //Datagr.AutoResizeRows();
            //Datagr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //Datagr.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            //Datagr.AutoSize = true;
            if (Datagr.RowCount > 0)
            {
                Datagr.Width = (Datagr.Columns.Count) * Datagr.Columns[Datagr.Columns.Count - 1].Width;// -Datagr.Columns[Datagr.Columns.Count - 1].Width / 2 + 8;
                Datagr.Height = (Datagr.Rows.Count + 2) * Datagr.Rows[Datagr.Rows.Count - 1].Height - 20;
            }
        }

        private void dtMkios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FBuatPulsa buat = new FBuatPulsa();
            buat.Owner = this.Owner;
            buat.ShowDialog();
            Refreshh();
        }

        private void btnRefffesh_Click(object sender, EventArgs e)
        {
            Refreshh();
        }

        private void dtMkios_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            //MessageBox.Show(e.RowIndex.ToString() + dtMkios.Rows.Count);
            //if(dtMkios.Rows[e.RowIndex].Cells[0].ToString() != "")
            //{
            //    FOnePulsa Display = new FOnePulsa();
            //    Display.Owner = this;
            //    dexPulseCode = dtMkios.Rows[e.RowIndex].Cells[0].Value.ToString();
            //    Display.Show();
            //}
        }

        private void dtMkios_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //MessageBox.Show(e.ColumnIndex.ToString());
        }

        private void dtMkios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dtMkios.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    FOnePulsa Display = new FOnePulsa();
                    Display.Owner = this;
                    dexPulseCode = dtMkios.Rows[e.RowIndex].Cells[0].Value.ToString();
                    Display.ShowDialog();
                    Refreshh();
                }
            }
        }

        private void dtAllOp_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void dtAllOp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridView DGrid = (DataGridView)sender;
                if (DGrid.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    FOnePulsa Display = new FOnePulsa();
                    Display.Owner = this;
                    dexPulseCode = DGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                    Display.ShowDialog();
                    Refreshh();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Maim.Warna(bName, this);
        }

        private void panel2_Scroll(object sender, ScrollEventArgs e)
        {
        }

        private void DetailPulsa_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == Maim.MsBtn)
            {
                Maim.Warna(bName, this);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
