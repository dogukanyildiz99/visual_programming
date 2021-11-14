using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopSektirmeSkorlu
{
    public partial class Form1 : Form
    {

        int SagUstSinir = 30;
        int SolUstSinir = 30;
        int SagSinir = 758;
        int SolSinir = 30;

        int hizx = 5;
        int hizy = 5;

        int gamescore = 0;
        Random rand = new Random();
        List<PictureBox> items = new List<PictureBox>();
        int picBoxCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Form açılınca ekranda daire olması için
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
            int x = rand.Next(30, 700);
            int y = rand.Next(30, 520);
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

            //Gamescore değişimine göre textin değişmesi !TAMAMLANMADI!
            if (gamescore == 1)
            {
                skor.Text = (1 + Double.Parse(skor.Text)).ToString();
            }
            else if (gamescore == 10)
            {
                skor.Text = (10 + Double.Parse(skor.Text)).ToString();
            }
            else if (gamescore == -20)
            {
                skor.Text = (-20 + Double.Parse(skor.Text)).ToString();
            }
        }
        
        //Oyuna devam et
        private void play_Click(object sender, EventArgs e)
        {
            Spawn.Start();
            Movement.Start();
        }

        //Oyunu durdur
        private void pause_Click(object sender, EventArgs e)
        {
            Spawn.Stop();
            Movement.Stop();
        }

        //Verilen interval değere göre ekrana daire çizilmesi
        private void TimerEvent(object sender, EventArgs e)
        {
            if(picBoxCount < 11)
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
                int x = rand.Next(30, 700);
                int y = rand.Next(30, 520);
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
            else if(picBoxCount == 0)
            {
                MessageBox.Show("YOU HAVE WON!");
                Spawn.Stop();
                Movement.Stop();
                Spawn.Enabled = false;
            }
            else if(picBoxCount == 11)
            {
                MessageBox.Show("GAME OVER!");
                Spawn.Stop();
                Movement.Stop();
                Spawn.Enabled = false;
            }

            
        }

        //Çubuğun sağa sola hareketi
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = cubuk.Location.X;
            int y = cubuk.Location.Y;

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
            else if (x > 500)
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

            cubuk.Location = new Point(x, y);
        }

        //Hareketi sağlamak için !TAMAMLANMADI!
        private void Movement_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
