using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopSektirmeSkorlu
{
    public partial class Form1 : Form
    {

        Random rand = new Random();
        //PictureBoxları tutacağımız listemiz
        List<PictureBox> PicBoxList = new List<PictureBox>();
        //Top sayısı
        int picBoxCount = 0;

        public Form1()
        {
            InitializeComponent();
            threadSkor();
        }

        //Daireleri çizecek metod
        public void PictureDraw()
        {
            Random rnd = new Random();
            int num = rnd.Next(0, 500);

            //Kare şeklinde PictureBox çizdirme
            PictureBox newPic = new PictureBox();
            newPic.Height = 40;
            newPic.Width = 40;

            //Renkleri rastgele belirlemek için
            if (num % 2 == 0)
            {
                newPic.BackColor = Color.Red;
            }
            else if (num % 3 == 0)
            {
                newPic.BackColor = Color.Yellow;
            }
            else if (num % 5 == 0)
            {
                newPic.BackColor = Color.Blue;
            }
            else if (num % 7 == 0)
            {
                newPic.BackColor = Color.Green;
            }
            else
            {
                newPic.BackColor = Color.White;
            }
            //PictureBoxtan Daire çizdirme
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, newPic.Width - 3, newPic.Height - 3);
            Region rg = new Region(gp);
            newPic.Region = rg;

            //Dairenin çizdireleceği aralıklar
            int x = rand.Next(100, 600);
            int y = rand.Next(50, 300);
            newPic.Location = new Point(x, y);
            //Topu PicBoxList listesine ekler
            PicBoxList.Add(newPic);
            //class TopSektirmeSkorlu.Form1 e topu ekler
            this.Controls.Add(newPic);
            //top sayısı artırılır
            picBoxCount++;
        }

        //Form yüklendiği an ekrana top basılır
        private void Form1_Load(object sender, EventArgs e)
        {
            PictureDraw();
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

        //Oyunu sıfırla
        private void reset_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }

        //Oyun Skorunun güncellenmesi
        int gamescore = 0;
        private void threadSkor()
        {
            while (gamescore > 0)
            {
                //Gamescore değişimine göre textin değişmesi
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
                //1 saniyeliğine işlemi askıya sonra devam et
                Thread.Sleep(1000);
            }
        }

        //Verilen interval değere göre ekrana topların çizilmesi
        private void TimerEvent(object sender, EventArgs e)
        {

            if (picBoxCount < 6)
            {
                PictureDraw();
            }
            else if (picBoxCount == 10)
            {
                MessageBox.Show("GAME OVER!");
                Spawn.Stop();
                Movement.Stop();
                Spawn.Enabled = false;
            }
            else if (picBoxCount == 0)
            {
                MessageBox.Show("YOU HAVE WON!");
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

        //Backup tuşu TAMAMLANMADI
        private void backup_Click(object sender, EventArgs e)
        {

        }

        //Restore tuşu TAMAMLANMADI
        private void restore_Click(object sender, EventArgs e)
        {

        }

        //--------------------------------TOP HAREKETLERİ-------------------------------------------------------
        //Topların hızları
        int hizx1 = 2;
        int hizy1 = 2;
        int hizx2 = 2;
        int hizy2 = 2;
        int hizx3 = 2;
        int hizy3 = 2;
        int hizx4 = 2;
        int hizy4 = 2;
        int hizx5 = 2;
        int hizy5 = 2;
        int hizx6 = 2;
        int hizy6 = 2;
        int hizx7 = 2;
        int hizy7 = 2;
        int hizx8 = 2;
        int hizy8 = 2;
        int hizx9 = 2;
        int hizy9 = 2;
        int hizx10 = 2;
        int hizy10 = 2;

        //Hareketi sağlamak için
        private void Movement_Tick(object sender, EventArgs e)
        {
            if (picBoxCount > 0)
            {
                PictureBox firstPic = PicBoxList.ElementAt(0);

                firstPic.Top = firstPic.Top + hizy1;
                firstPic.Left = firstPic.Left - hizx1;
                //Yanlardan sekmesi
                if (firstPic.Bounds.IntersectsWith(sag.Bounds) || firstPic.Bounds.IntersectsWith(sol.Bounds))
                {
                    hizx1 *= -1;
                }
                //Üstteki sınırlardan sekmesi
                if (firstPic.Bounds.IntersectsWith(sagUst.Bounds) || firstPic.Bounds.IntersectsWith(solUst.Bounds))
                {
                    hizy1 *= -1;
                }
                //Çubukla etkileşim sonucu sekmesi
                if (firstPic.Bounds.IntersectsWith(cubuk.Bounds))
                {
                    hizy1 *= -1;
                    skor.Text = (1 + Double.Parse(skor.Text)).ToString();
                }
                //Yukarıdaki boşluktan çıkması
                if (firstPic.Bounds.IntersectsWith(CıkanTopUst.Bounds))
                {
                    firstPic.Dispose();
                    hizy1 *= -1;
                    skor.Text = (10 + Double.Parse(skor.Text)).ToString();
                }
                //Alttaki boşluktan çıkması
                if (firstPic.Bounds.IntersectsWith(CıkanTopAlt.Bounds))
                {
                    firstPic.Dispose();
                    hizy1 *= -1;
                    PictureDraw();
                    PictureDraw();
                    skor.Text = (-20 + Double.Parse(skor.Text)).ToString();
                }
            }

            if (picBoxCount > 1)
            {
                PictureBox secondPic = PicBoxList.ElementAt(1);
                secondPic.Top = secondPic.Top - hizy2;
                secondPic.Left = secondPic.Left - hizx2;

                if (secondPic.Bounds.IntersectsWith(sag.Bounds) || secondPic.Bounds.IntersectsWith(sol.Bounds))
                {
                    hizx2 *= -1;
                }

                if (secondPic.Bounds.IntersectsWith(sagUst.Bounds) || secondPic.Bounds.IntersectsWith(solUst.Bounds))
                {
                    hizy2 *= -1;
                }

                if (secondPic.Bounds.IntersectsWith(cubuk.Bounds))
                {
                    hizy2 *= -1;
                    skor.Text = (1 + Double.Parse(skor.Text)).ToString();
                }

                if (secondPic.Bounds.IntersectsWith(CıkanTopUst.Bounds))
                {
                    hizy2 *= -1;
                    secondPic.Dispose();
                    skor.Text = (10 + Double.Parse(skor.Text)).ToString();
                }

                if (secondPic.Bounds.IntersectsWith(CıkanTopAlt.Bounds))
                {
                    hizy2 *= -1;
                    secondPic.Dispose();
                    PictureDraw();
                    PictureDraw();
                    skor.Text = (-20 + Double.Parse(skor.Text)).ToString();
                }
            }

            if (picBoxCount > 2)
            {
                PictureBox thirdPic = PicBoxList.ElementAt(2);
                thirdPic.Top = thirdPic.Top - hizy3;
                thirdPic.Left = thirdPic.Left + hizx3;

                if (thirdPic.Bounds.IntersectsWith(sag.Bounds) || thirdPic.Bounds.IntersectsWith(sol.Bounds))
                {
                    hizx3 *= -1;
                }

                if (thirdPic.Bounds.IntersectsWith(sagUst.Bounds) || thirdPic.Bounds.IntersectsWith(solUst.Bounds))
                {
                    hizy3 *= -1;
                }

                if (thirdPic.Bounds.IntersectsWith(cubuk.Bounds))
                {
                    hizy3 *= -1;
                    skor.Text = (1 + Double.Parse(skor.Text)).ToString();
                }

                if (thirdPic.Bounds.IntersectsWith(CıkanTopUst.Bounds))
                {
                    hizy3 *= -1;
                    thirdPic.Dispose();
                    skor.Text = (10 + Double.Parse(skor.Text)).ToString();
                }

                if (thirdPic.Bounds.IntersectsWith(CıkanTopAlt.Bounds))
                {
                    hizy3 *= -1;
                    thirdPic.Dispose();
                    PictureDraw();
                    PictureDraw();
                    skor.Text = (-20 + Double.Parse(skor.Text)).ToString();
                }
            }

            if (picBoxCount > 3)
            {
                PictureBox fourthPic = PicBoxList.ElementAt(3);
                fourthPic.Top = fourthPic.Top + hizy4;
                fourthPic.Left = fourthPic.Left - hizx4;

                if (fourthPic.Bounds.IntersectsWith(sag.Bounds) || fourthPic.Bounds.IntersectsWith(sol.Bounds))
                {
                    hizx4 *= -1;
                }

                if (fourthPic.Bounds.IntersectsWith(sagUst.Bounds) || fourthPic.Bounds.IntersectsWith(solUst.Bounds))
                {
                    hizy4 *= -1;
                }

                if (fourthPic.Bounds.IntersectsWith(cubuk.Bounds))
                {
                    hizy4 *= -1;
                    skor.Text = (1 + Double.Parse(skor.Text)).ToString();
                }

                if (fourthPic.Bounds.IntersectsWith(CıkanTopUst.Bounds))
                {
                    hizy4 *= -1;
                    fourthPic.Dispose();
                    skor.Text = (10 + Double.Parse(skor.Text)).ToString();
                }

                if (fourthPic.Bounds.IntersectsWith(CıkanTopAlt.Bounds))
                {
                    hizy4 *= -1;
                    fourthPic.Dispose();
                    PictureDraw();
                    PictureDraw();
                    skor.Text = (-20 + Double.Parse(skor.Text)).ToString();
                }
            }

            if (picBoxCount > 4)
            {
                PictureBox fifthPic = PicBoxList.ElementAt(4);
                fifthPic.Top = fifthPic.Top + hizy5;
                fifthPic.Left = fifthPic.Left + hizx5;

                if (fifthPic.Bounds.IntersectsWith(sag.Bounds) || fifthPic.Bounds.IntersectsWith(sol.Bounds))
                {
                    hizx5 *= -1;
                }

                if (fifthPic.Bounds.IntersectsWith(sagUst.Bounds) || fifthPic.Bounds.IntersectsWith(solUst.Bounds))
                {
                    hizy5 *= -1;
                }

                if (fifthPic.Bounds.IntersectsWith(cubuk.Bounds))
                {
                    hizy5 *= -1;
                    skor.Text = (1 + Double.Parse(skor.Text)).ToString();
                }

                if (fifthPic.Bounds.IntersectsWith(CıkanTopUst.Bounds))
                {
                    hizy5 *= -1;
                    fifthPic.Dispose();
                    skor.Text = (10 + Double.Parse(skor.Text)).ToString();
                }

                if (fifthPic.Bounds.IntersectsWith(CıkanTopAlt.Bounds))
                {
                    hizy5 *= -1;
                    fifthPic.Dispose();
                    PictureDraw();
                    PictureDraw();
                    skor.Text = (-20 + Double.Parse(skor.Text)).ToString();
                }
            }

            if (picBoxCount > 5)
            {
                PictureBox sixthPic = PicBoxList.ElementAt(5);
                sixthPic.Left = sixthPic.Left + hizx6;
                sixthPic.Top = sixthPic.Top - hizy6;

                if (sixthPic.Bounds.IntersectsWith(sag.Bounds) || sixthPic.Bounds.IntersectsWith(sol.Bounds))
                {
                    hizx6 *= -1;
                }

                if (sixthPic.Bounds.IntersectsWith(sagUst.Bounds) || sixthPic.Bounds.IntersectsWith(solUst.Bounds))
                {
                    hizy6 *= -1;
                }

                if (sixthPic.Bounds.IntersectsWith(cubuk.Bounds))
                {
                    hizy6 *= -1;
                }

                if (sixthPic.Bounds.IntersectsWith(CıkanTopUst.Bounds))
                {
                    hizy6 *= -1;
                    sixthPic.Dispose();
                    skor.Text = (10 + Double.Parse(skor.Text)).ToString();
                }

                if (sixthPic.Bounds.IntersectsWith(CıkanTopAlt.Bounds))
                {
                    hizy6 *= -1;
                    sixthPic.Dispose();
                    PictureDraw();
                    PictureDraw();
                    skor.Text = (-20 + Double.Parse(skor.Text)).ToString();
                }
            }

            if (picBoxCount > 6)
            {
                PictureBox seventhPic = PicBoxList.ElementAt(6);
                seventhPic.Left = seventhPic.Left - hizx7;
                seventhPic.Top = seventhPic.Top + hizy7;

                if (seventhPic.Bounds.IntersectsWith(sag.Bounds) || seventhPic.Bounds.IntersectsWith(sol.Bounds))
                {
                    hizx7 *= -1;
                }

                if (seventhPic.Bounds.IntersectsWith(sagUst.Bounds) || seventhPic.Bounds.IntersectsWith(solUst.Bounds))
                {
                    hizy7 *= -1;
                }

                if (seventhPic.Bounds.IntersectsWith(cubuk.Bounds))
                {
                    hizy7 *= -1;
                }

                if (seventhPic.Bounds.IntersectsWith(CıkanTopUst.Bounds))
                {
                    hizy7 *= -1;
                    seventhPic.Dispose();
                    skor.Text = (10 + Double.Parse(skor.Text)).ToString();
                }

                if (seventhPic.Bounds.IntersectsWith(CıkanTopAlt.Bounds))
                {
                    hizy7 *= -1;
                    seventhPic.Dispose();
                    PictureDraw();
                    PictureDraw();
                    skor.Text = (-20 + Double.Parse(skor.Text)).ToString();
                }
            }

            if (picBoxCount > 7)
            {
                PictureBox eigthPic = PicBoxList.ElementAt(7);
                eigthPic.Left = eigthPic.Left - hizx8;
                eigthPic.Top = eigthPic.Top - hizy8;

                if (eigthPic.Bounds.IntersectsWith(sag.Bounds) || eigthPic.Bounds.IntersectsWith(sol.Bounds))
                {
                    hizx8 *= -1;
                }

                if (eigthPic.Bounds.IntersectsWith(sagUst.Bounds) || eigthPic.Bounds.IntersectsWith(solUst.Bounds))
                {
                    hizy8 *= -1;
                }

                if (eigthPic.Bounds.IntersectsWith(cubuk.Bounds))
                {
                    hizy8 *= -1;
                }

                if (eigthPic.Bounds.IntersectsWith(CıkanTopUst.Bounds))
                {
                    hizy8 *= -1;
                    eigthPic.Dispose();
                    skor.Text = (10 + Double.Parse(skor.Text)).ToString();
                }

                if (eigthPic.Bounds.IntersectsWith(CıkanTopAlt.Bounds))
                {
                    hizy8 *= -1;
                    eigthPic.Dispose();
                    PictureDraw();
                    PictureDraw();
                    skor.Text = (-20 + Double.Parse(skor.Text)).ToString();
                }
            }

            if (picBoxCount > 8)
            {
                PictureBox ninthPic = PicBoxList.ElementAt(8);
                ninthPic.Left = ninthPic.Left + hizx9;
                ninthPic.Top = ninthPic.Top + hizy9;

                if (ninthPic.Bounds.IntersectsWith(sag.Bounds) || ninthPic.Bounds.IntersectsWith(sol.Bounds))
                {
                    hizx9 *= -1;
                }

                if (ninthPic.Bounds.IntersectsWith(sagUst.Bounds) || ninthPic.Bounds.IntersectsWith(solUst.Bounds))
                {
                    hizy9 *= -1;
                }

                if (ninthPic.Bounds.IntersectsWith(cubuk.Bounds))
                {
                    hizy9 *= -1;
                }

                if (ninthPic.Bounds.IntersectsWith(CıkanTopUst.Bounds))
                {
                    hizy9 *= -1;
                    ninthPic.Dispose();
                    skor.Text = (10 + Double.Parse(skor.Text)).ToString();
                }

                if (ninthPic.Bounds.IntersectsWith(CıkanTopAlt.Bounds))
                {
                    hizy9 *= -1;
                    ninthPic.Dispose();
                    PictureDraw();
                    PictureDraw();
                    skor.Text = (-20 + Double.Parse(skor.Text)).ToString();
                }
            }

            if (picBoxCount > 9)
            {
                PictureBox tenthPic = PicBoxList.ElementAt(9);
                tenthPic.Left = tenthPic.Left + hizx10;
                tenthPic.Top = tenthPic.Top - hizy10;

                if (tenthPic.Bounds.IntersectsWith(sag.Bounds) || tenthPic.Bounds.IntersectsWith(sol.Bounds))
                {
                    hizx10 *= -1;
                }

                if (tenthPic.Bounds.IntersectsWith(sagUst.Bounds) || tenthPic.Bounds.IntersectsWith(solUst.Bounds))
                {
                    hizy10 *= -1;
                }

                if (tenthPic.Bounds.IntersectsWith(cubuk.Bounds))
                {
                    hizy10 *= -1;
                }

                if (tenthPic.Bounds.IntersectsWith(CıkanTopUst.Bounds))
                {
                    hizy10 *= -1;
                    tenthPic.Dispose();
                    skor.Text = (10 + Double.Parse(skor.Text)).ToString();
                }

                if (tenthPic.Bounds.IntersectsWith(CıkanTopAlt.Bounds))
                {
                    hizy10 *= -1;
                    tenthPic.Dispose();
                    PictureDraw();
                    PictureDraw();
                    skor.Text = (-20 + Double.Parse(skor.Text)).ToString();
                }
            }

        }

    }

}