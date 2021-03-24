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
    //class Ellipse
    //{
    //    public int PenWidth;
    //    public Color Color;
    //    public Rectangle Rectangle;

    //    // Paint ourselves with the specified Graphics object
    //    public void Draw(Graphics graphics)
    //    {
    //        using (Pen pen = new Pen(Color, PenWidth))
    //            graphics.DrawEllipse(pen, Rectangle);
    //    }
    //}
    public partial class DisplayOperator : Form
    {
        Utama Maim;
        public int dexOpe;
        string bName = "BDisOp.jpg";
        Color Warnain = new Color();
        Point Po;

        public DisplayOperator()
        {
            InitializeComponent();
        }

        public void Refresssh()
        {
            PanOp.Controls.Clear();
            for (int i = 0; i < Maim.listOperator.Count; i++)
            {
               

                Panel Ope = new Panel();
                Ope.Width = 200;
                Ope.Height = Ope.Width;
                Ope.Left = (i % 4) * (Ope.Width + 50) + 100;
                Ope.Top = (i / 4) * (Ope.Height + 50);
                Warnain = Maim.listOperator[i].Warna;
                Po = Ope.Location;
                PanOp.Controls.Add(Ope);
                Ope.BackColor = Warnain;
                //Ope.Paint += Ope_Paint;
                Rectangle Rc = new Rectangle(new Point(0, 0), new Size(200, 200));
                Graphics Grat = Ope.CreateGraphics();
                Grat.DrawEllipse(new Pen(Color.Black), Rc);

                Label Name = new Label();
                Label Opera = new Label();
                
                Name.Text = Maim.listOperator[i].Nama + " (" + Maim.listOperator[i].Alias + ")";
                Opera.Text = Maim.listOperator[i].TipePulsa.ToString();
                Name.AutoSize = true;
                Opera.AutoSize = true;
                Name.BorderStyle = BorderStyle.Fixed3D;


                Ope.Controls.Add(Name);
                Ope.Controls.Add(Opera);
                Opera.ForeColor = Color.Black;
                Name.ForeColor = Color.White;
                Name.BackColor = Color.Black;
                //FontFamily fam = new FontFamily("Comic Sans MS");
                //Font tulis = new System.Drawing.Font(fam, 12);
                Name.Font = lblContoh.Font;
                //fam = new FontFamily("Times New Roman");
                //tulis = new System.Drawing.Font(fam, 12);
                Opera.Font = lblContoh.Font;
                Name.Location = new Point((Ope.Width - Name.Width) / 2, Ope.Height / 4);
                Opera.Location = new Point((Ope.Width - Opera.Width) / 2, (int)(Ope.Height / 2));
                Ope.Click += Ope_Click;

                //PanOp.Invalidate();
                ////Ope.Paint += new PaintEventHandler(Opesc);
                
            }
        }

        void Opesc(object sender, PaintEventArgs e)
        {

        }
        void Ope_Paint(object sender, PaintEventArgs e)
        {
             //Graphics Gr;
             //   using (Pen pen = new Pen(Maim.listOperator[i].Warna, Ope.Width)) 
             //   //Gr.DrawEllipse(pen, )

            //e.Graphics.FillEllipse(new SolidBrush(BallColor), RectBall);
            //e.Graphics.DrawEllipse(Pens.Black, RectBall);

            Rectangle Rc = new Rectangle(new Point(0, 0), new Size(200, 200));
            //Graphics Gr = Ope.CreateGraphics();
            e.Graphics.FillEllipse(new SolidBrush(Warnain), Rc);
            //Gr.DrawEllipse(Pens.Black, Rc);
            
        }
        private void DisplayOperator_Load(object sender, EventArgs e)
        {
            Maim = (Utama)this.Owner;
            Refresssh();
            Maim.ChangeBack(bName, this);
            
        }

        void Ope_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(sender.Equals(this.PanOp.Controls[1]) + " " + e.Equals(this.PanOp.Controls[1]));
            for (int i = 0; i < this.PanOp.Controls.Count; i++)
            {
                if(sender.Equals(this.PanOp.Controls[i]) == true)
                {
                    dexOpe = i;
                    FDetailOperator FDOp = new FDetailOperator();
                    FDOp.Owner = this;
                    FDOp.ShowDialog();
                    Refresssh();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Refresssh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FBuatOperator FBOp = new FBuatOperator();
            FBOp.Owner = this;
            FBOp.ShowDialog();
        }

        private void DisplayOperator_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == Maim.MsBtn)
            {
                Maim.Warna(bName, this);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PanOp_Paint(object sender, PaintEventArgs e)
        {
            //Rectangle Rc = new Rectangle(Po, new Size(200, 200));
            ////Graphics Gr = Ope.CreateGraphics();
            //e.Graphics.FillEllipse(new SolidBrush(Warnain), Rc);
            ////Gr.DrawEllipse(Pens.Black, Rc);
        }
    }
}
