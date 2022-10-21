using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCalcApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Gerekli değişkenler
        double result;
        string oprtr = "";
        bool oprtrState = false;
        
        //Rakamlar
        private void NumberClicked(object sender, EventArgs e)
        {
            //Sayı girildiğinde baştaki sıfırı silmek için
            if (textBox1.Text == "0" || oprtrState)
            {
                textBox1.Clear();
            }
            oprtrState = false;

            //Tıklanan buton içerisindeki text alınıp textBox1'e yazılır
            var button = (Button)sender;
            textBox1.Text += button.Text;
        }

        //Ekranı temizleme
        private void btnClear(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            oprtr = "";
            oprtrState = false;
            result = 0;
        }

        //Matematiksel operatörler
        private void MathOps(object sender, EventArgs e)
        {
            oprtrState = true;
            var button = (Button)sender;
            string newOprtr = button.Text;

            //Hesaplamada bi önceki sonucun tutulması için işlemlerin burada da yapılması gereklidir
            switch (oprtr)
            {
                case "+":
                    textBox1.Text = (result + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (result - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "x":
                    textBox1.Text = (result * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "÷":
                    textBox1.Text = (result / Double.Parse(textBox1.Text)).ToString();
                    break;
            }
            result = Double.Parse(textBox1.Text);
            textBox1.Text = result.ToString();
            textBox1.Text += button.Text;
            oprtr = newOprtr;
        }

        //Sonuç yazdırma
        private void Sonuc(object sender, EventArgs e)
        {
            oprtrState = true;
            //String olarak alınan sayılar Double.Parse ile double formuna dönüştürülür
            switch (oprtr)
            {
                case "+":
                    textBox1.Text = (result + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (result - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "x":
                    textBox1.Text = (result * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "÷":
                    textBox1.Text = (result / Double.Parse(textBox1.Text)).ToString();
                    break;
            }
            result = Double.Parse(textBox1.Text);
            textBox1.Text = result.ToString();
            oprtr = "";
        }

        //Ondalıklı sayı
        private void Decimal(object sender, EventArgs e)
        {
            //Başta sıfır olma durumunda
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else if (oprtrState)
            {
                textBox1.Text = "0";
            }

            if (!textBox1.Text.Contains(","))
            {
                textBox1.Text += ".";
            }
            oprtrState = false;
        }

        //Silme
        private void Delete(object sender, EventArgs e)
        {
            /*Substring metodu ile textBox1'deki 0.indexten başlayıp
            son karakter-1 e kadar olanları göstererek son karakteri silebiliriz.*/
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }

        //Negatif Pozitif değer değiştirme
        private void NegOrPos(object sender, EventArgs e)
        {
            if (oprtr == "")
            {
                result *= -1;
                textBox1.Text = result.ToString();
            }
        }
    }
}
