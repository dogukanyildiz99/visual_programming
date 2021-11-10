using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarpisanToplar
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        List<PictureBox> items = new List<PictureBox>();
        int picBoxCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MakePictureBox();
        }
        

        private void MakePictureBox()
        {

            if (picBoxCount <= 5)
            {
                Random rnd = new Random();
                int num = rnd.Next(0, 100);

                //Kare şeklinde PictureBox çizdirme
                PictureBox newPic = new PictureBox();
                newPic.Height = 40;
                newPic.Width = 40;

                //PictureBoxtan Daire çizdirme
                System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
                gp.AddEllipse(0, 0, newPic.Width - 3, newPic.Height - 3);
                Region rg = new Region(gp);
                newPic.Region = rg;

                int x = rand.Next(20, this.ClientSize.Width - newPic.Width);
                int y = rand.Next(20, this.ClientSize.Height - newPic.Height);
                newPic.Location = new Point(x, y);

                items.Add(newPic);
                this.Controls.Add(newPic);

                //Renkleri rastgele belirlemek için
                if (num % 3 == 0)
                {
                    newPic.BackColor = Color.Red;
                }
                else if (num % 5 == 0)
                {
                    newPic.BackColor = Color.Yellow;
                }
                else if (num % 7 == 0)
                {
                    newPic.BackColor = Color.Blue;
                }
                else if (num % 11 == 0)
                {
                    newPic.BackColor = Color.Green;
                }

                picBoxCount++;

            }

        }

        // Timer Spawn olarak adlandırılmış ve Interval değeri 10000 olarak ayarlanmıştır
        private void TimerEvent(object sender, EventArgs e)
        {
            MakePictureBox();
        }
    }
}
