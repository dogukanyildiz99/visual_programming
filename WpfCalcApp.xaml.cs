/*
 * BUTON AKSİYONLARININ TANIMLANMASI 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfCalcApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Gerekli değişkenler
        float num1 = 0;
        float num2 = 0;
        bool oprtrState = false;
        string oprtr = "";

        //Rakamlar
        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            //Operatör tuşuna basılıp basılmama durumu
            if (oprtr == "")
            {
                num1 = (num1 * 10);
                txtDisplay.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10);
                txtDisplay.Text = num2.ToString();
            }
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (oprtr == "")
            {
                num1 = (num1 * 10) + 1;
                txtDisplay.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 1;
                txtDisplay.Text = num2.ToString();
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (oprtr == "")
            {
                num1 = (num1 * 10) + 2;
                txtDisplay.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 2;
                txtDisplay.Text = num2.ToString();
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (oprtr == "")
            {
                num1 = (num1 * 10) + 3;
                txtDisplay.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 3;
                txtDisplay.Text = num2.ToString();
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (oprtr == "")
            {
                num1 = (num1 * 10) + 4;
                txtDisplay.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 4;
                txtDisplay.Text = num2.ToString();
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (oprtr == "")
            {
                num1 = (num1 * 10) + 5;
                txtDisplay.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 5;
                txtDisplay.Text = num2.ToString();
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (oprtr == "")
            {
                num1 = (num1 * 10) + 6;
                txtDisplay.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 6;
                txtDisplay.Text = num2.ToString();
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (oprtr == "")
            {
                num1 = (num1 * 10) + 7;
                txtDisplay.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 7;
                txtDisplay.Text = num2.ToString();
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (oprtr == "")
            {
                num1 = (num1 * 10) + 8;
                txtDisplay.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 8;
                txtDisplay.Text = num2.ToString();
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (oprtr == "")
            {
                num1 = (num1 * 10) + 9;
                txtDisplay.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 9;
                txtDisplay.Text = num2.ToString();
            }
        }

        //Matematiksel Operatörler
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            oprtrState = true;
            oprtr = "+";
            txtDisplay.Text = "+";
        }

        private void btnSub_Click(object sender, RoutedEventArgs e)
        {
            oprtrState = true;
            oprtr = "-";
            txtDisplay.Text = "-";
        }

        private void btnMul_Click(object sender, RoutedEventArgs e)
        {
            oprtrState = true;
            oprtr = "x";
            txtDisplay.Text = "x";
        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            oprtrState = true;
            oprtr = "÷";
            txtDisplay.Text = "÷";
        }

        //İşlem Sonucu
        private void btnRes_Click(object sender, RoutedEventArgs e)
        {
            switch (oprtr)
            {
                case "+":
                    txtDisplay.Text = (num1 + num2).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (num1 - num2).ToString();
                    break;
                case "x":
                    txtDisplay.Text = (num1 * num2).ToString();
                    break;
                case "÷":
                    txtDisplay.Text = (num1 / num2).ToString();
                    break;
            }
            oprtrState = false;
        }

        //Ondalık
        private void btnDec_Click(object sender, RoutedEventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "0";
            }
            else if (oprtrState)
            {
                txtDisplay.Text = "0";
            }

            if (!txtDisplay.Text.Contains(","))
            {
                txtDisplay.Text += ".";
            }
            oprtrState = false;
        }

        //İşaret Değiştirme
        private void btnPtN_Click(object sender, RoutedEventArgs e)
        {
            if (oprtr == "")
            {
                num1 *= -1;
                txtDisplay.Text = num1.ToString();
            }
            else
            {
                num2 *= -1;
                txtDisplay.Text = num2.ToString();
            }
        }

        //Silme İşlemi
        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            if (oprtr == "")
            {
                num1 = (num1 / 10);
                txtDisplay.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 / 10);
                txtDisplay.Text = num2.ToString();
            }
        }

        //Temizleme
        private void btnClr_Click(object sender, RoutedEventArgs e)
        {
            num1 = 0;
            num2 = 0;
            txtDisplay.Text = "0";
            oprtr = "";
        }
    }
}
