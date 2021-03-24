using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Resources;
using Jual_Pulsa.Properties;

namespace Jual_Pulsa
{
    [Serializable]
    public enum PulsaType { AllOperator, Mkios}
    public partial class Utama : Form
    {
        public List<Operator> listOperator = new List<Operator>();
        public List<Pulsa> listPulsa = new List<Pulsa>();
        public List<Transaction> listTransaction = new List<Transaction>();
        public List<CheckPoint> listCheckPoint = new List<CheckPoint>();
        public List<TransKhusus> listKhusus2 = new List<TransKhusus>();
        public List<TransKhususBaru> listKhusus = new List<TransKhususBaru>();


        bool Convert = false;

        string pathers = "Pulsa.datasave";

        FOnePulsa Fone = new FOnePulsa();
        FCheckPointDisplay FChec = new FCheckPointDisplay();

        //string bbNam = "BUtama.jpg";
        string bName = "BUtama.jpg";

        public MouseButtons MsBtn = MouseButtons.Right;
        public Utama()
        {
            InitializeComponent();
        }

        private void Reload()
        {
            string path = Application.StartupPath + "\\" + pathers;
            FileStream fls = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
            if (fls.Length > 0)
            {
                BinaryFormatter bin = new BinaryFormatter();
                listOperator = (List<Operator>)bin.Deserialize(fls);
                listPulsa = (List<Pulsa>)bin.Deserialize(fls);
                listTransaction = (List<Transaction>)bin.Deserialize(fls);
                listCheckPoint = (List<CheckPoint>)bin.Deserialize(fls);

                if (Convert == true)
                {
                    listKhusus2 = (List<TransKhusus>)bin.Deserialize(fls);
                    foreach (TransKhusus Trb in listKhusus2)
                    {
                        listKhusus.Add(TransKhususBaru.Change(Trb));
                        listKhusus[listKhusus.Count - 1].PakeLain = new List<INT>();
                    }
                    Convert = false;
                }
                else
                {
                    try
                    {
                        listKhusus = (List<TransKhususBaru>)bin.Deserialize(fls);
                    }
                    catch (Exception ex) {
                        fls.Close();
                        Convert = true;
                        Reload();
                    }
                 
                }
            }
            fls.Close();
        }

        private void Utama_Load(object sender, EventArgs e)
        {

            Reload();
           // listKhusus.Clear();
           
            

            ChangeBack(bName, this);
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
                //Datagr.Width = (Datagr.Columns.Count) * Datagr.Columns[Datagr.Columns.Count - 1].Width;// -Datagr.Columns[Datagr.Columns.Count - 1].Width / 2 + 8;
                int WI = 0;
                for (int i = 0; i < Datagr.ColumnCount; i++)
                {
                    WI += Datagr.Columns[i].Width;
                }
                Datagr.Width = WI;
                    Datagr.Height = (Datagr.Rows.Count + 2) * Datagr.Rows[Datagr.Rows.Count - 1].Height - 15;
            }
        }

        public void ChangeBack(string Name, Form Widow)
        {
            try
            {
                byte[] bytes = System.IO.File.ReadAllBytes(Application.StartupPath + "\\Resources\\" + Name);
                System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
                //pictureBox1.Image = Image.FromStream(ms);
                //Image Gbr = new Bitmap(Image.FromFile( Application.StartupPath + "\\Resources\\" + Name));
                Widow.BackgroundImage = Image.FromStream(ms);
                Widow.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch (Exception ex)
            { }
        }
        public void Warna(string Name, Form Widow)
        {
           
            OpenFileDialog fl = new OpenFileDialog();
            //Example: "Text files (*.txt)|*.txt|All files (*.*)|*.*"
            fl.Filter = "Image files (*.jpg, *.png, *jpeg)|*.jpg;*.png;*.jpeg";

            fl.InitialDirectory = "d:\\";
            DialogResult bla = fl.ShowDialog();
            if (bla == System.Windows.Forms.DialogResult.OK)
            {
                string nama = fl.SafeFileName;
                string asal = Path.GetDirectoryName(fl.FileName);
                string usul = Application.StartupPath + "\\" + "Resources";

                if (!System.IO.Directory.Exists(usul))
                {
                    System.IO.Directory.CreateDirectory(usul);
                }

                Widow.BackgroundImage = null;
                //File.Delete(usul + @"/" + Name);

                //Bitmap biea = new Bitmap(fl.FileName);
               Image png = Image.FromFile(fl.FileName);
                png.Save(usul + @"/" + Name, System.Drawing.Imaging.ImageFormat.Jpeg);
                png.Dispose();
            }
            else if (bla == System.Windows.Forms.DialogResult.Cancel)
            {
                if (MessageBox.Show("Ko Mau Kasi hilang gambar background nya ka?", "Message", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    File.Delete(Application.StartupPath + "\\Resources\\" + Name);
                    Widow.BackgroundImage = null;
                }
            }
            ChangeBack(Name, Widow);
        }

        public void CopyFIle()
        {
            OpenFileDialog fl = new OpenFileDialog();
            //Example: "Text files (*.txt)|*.txt|All files (*.*)|*.*"
            fl.Filter = "Image files (*.jpg, *.png, *jpeg)|*.jpg;*.png;*.jpeg";

            fl.InitialDirectory = "d:\\";
            DialogResult bla = fl.ShowDialog();
            if (bla == System.Windows.Forms.DialogResult.OK)
            {
                string nama2 = "Tkhuus" + Path.GetExtension(fl.FileName);
                string nama = fl.SafeFileName;
                string asal = Path.GetDirectoryName(fl.FileName);
                string usul = Application.StartupPath + "\\" + "Resources";

                string basal = Path.Combine(asal, nama);
                string busul = Path.Combine(usul, nama2);

                if (!System.IO.Directory.Exists(usul))
                {
                    System.IO.Directory.CreateDirectory(usul);
                }


                //Image png = Image.FromFile(fl.FileName);
                //png.Save(usul + @"/" + "Ykus" + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                //png.Dispose();

                System.IO.File.Copy(basal, busul, true);
                //ResourceManager rm = Resources.ResourceManager;
                //Image myImage = (Image)rm.GetObject("Tkhuus");
                //BackgroundImage = Image.FromFile(Application.StartupPath + "\\" + "Resources\\" + "Tkhusus.jpg");
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            DetailPulsa Pls = new DetailPulsa();
            Pls.Owner = this;
            Pls.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisplayOperator DsP = new DisplayOperator();
            DsP.Owner = this;
            DsP.Show();

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ITransaksi Trans = new ITransaksi();
            Trans.Owner = this;
            Trans.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            History hst = new History();
            hst.Owner = this;
            hst.Show();
        }

        private void Utama_FormClosing(object sender, FormClosingEventArgs e)
        {
            string path = Application.StartupPath + "\\" + pathers;
            FileStream fls = new FileStream(path, FileMode.Create, FileAccess.Write);
            BinaryFormatter bin = new BinaryFormatter();
            bin.Serialize(fls, listOperator);
            bin.Serialize(fls, listPulsa);
            bin.Serialize(fls, listTransaction);
            bin.Serialize(fls, listCheckPoint);
            bin.Serialize(fls, listKhusus);
            fls.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Warna(bName, this);
        }

        private void Utama_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MsBtn)
            {
                Warna(bName, this);
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            DialogResult ds = MessageBox.Show("Mau Hapus listKhusus?", "", MessageBoxButtons.YesNo);
            if(ds == System.Windows.Forms.DialogResult.Yes)
            {
                listKhusus.Clear();
            }
        }
    }
}
