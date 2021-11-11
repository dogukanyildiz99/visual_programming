using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopSektirme
{
    public partial class Form1 : Form
    {
        //Picture Box kullanarak yuvarlak şekilleri oluşturacağız
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

        //Şekil oluşturmada kullanılacak fonksiyon
        private void MakePictureBox()
        {

            if (picBoxCount < 5)
            {
                Random rnd = new Random();
                int num = rnd.Next(0, 1000);

                //Kare şeklinde PictureBox çizdirme
                PictureBox newPic = new PictureBox();
                newPic.Height = 40;
                newPic.Width = 40;

                //PictureBoxtan Daire çizdirme
                System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
                gp.AddEllipse(0, 0, newPic.Width - 3, newPic.Height - 3);
                Region rg = new Region(gp);
                newPic.Region = rg;

                //Dairenin çizdireleceği aralıklar
                int x = rand.Next(30, 758);
                int y = rand.Next(30, 510);
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

                /*
                int eksenx = newPic.Location.X;
                int ekseny = newPic.Location.Y;
                if (num % 3 == 0)
                {
                    eksenx += 5;
                }
                else if (num % 5 == 0)
                {
                    eksenx -= 5;
                }
                else if (num % 7 == 0)
                {
                    ekseny += 5;
                }
                else if (num % 11 == 0)
                {
                    ekseny -= 5;
                }
                */

            }

        }
        //Her 10 saniyede bir fonksiyon çağırılacak ve şekil oluşturulacak
        private void TimerEvent(object sender, EventArgs e)
        {
            MakePictureBox();
        }

        //Çubuğun sağa sola hareketi
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;

            if (x > 30 && x < 505)
            {
                if (e.KeyCode == Keys.D)
                {
                    x += 10;
                }
                else if (e.KeyCode == Keys.A)
                {
                    x -= 10;
                }
                else if (e.KeyCode == Keys.Right)
                {
                    x += 10;
                }
                else if (e.KeyCode == Keys.Left)
                {
                    x -= 10;
                }


            }
            //Duvarlardan geçmemesi için
            else if (x == 30)
            {
                if (e.KeyCode == Keys.D)
                {
                    x += 10;
                }
                else if (e.KeyCode == Keys.Right)
                {
                    x += 10;
                }
            }
            else if(x > 500)
            {
                if (e.KeyCode == Keys.A)
                {
                    x -= 10;
                }
                else if (e.KeyCode == Keys.Left)
                {
                    x -= 10;
                }
            }

            pictureBox1.Location = new Point(x, y);
        }
    }
}
