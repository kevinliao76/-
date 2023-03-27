using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace Change2
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        string strInput; 
        double douOutput;

        private void caculateAnswer(int _kind, double _value)
        {
            if (_kind != 0)
                txtmg1.Text = string.Format("{0:0.##########}", _value);
            if (_kind != 1)
                txtg1.Text = string.Format("{0:0.##########}", douOutput / 1000);
            if (_kind != 2)
                txtkg1.Text = string.Format("{0:0.##########}", douOutput / 1000000);
            if (_kind != 3)
                txtt1.Text = string.Format("{0:0.##########}", douOutput / 1000000000);
            if (_kind != 4)
                txtoz1.Text = string.Format("{0:0.##########}", douOutput / 28349);
            if (_kind != 5)
                txtib1.Text = string.Format("{0:0.##########}", douOutput / 45359);
        }
        private void txtmg_KeyUP(object sender, KeyEventArgs e)
        {
            strInput = txtmg1.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(0, douOutput);
            }
            else
            {
                txtinfo1.Text = "請輸入數字";
                txtmg1.Text = "";
            }
        }

        private void txtg_KeyUP(object sender, KeyEventArgs e)
        {
            strInput = txtg1.Text;
            
            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(1, douOutput * 1000); 
            }
            else
            {
                txtinfo1.Text = "請輸入數字";
                txtg1.Text = "";
            }
        }

        private void txtkg_KeyUP(object sender, KeyEventArgs e)
        {
            strInput = txtkg1.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(2, douOutput * 1000000);
            }
            else
            {
                txtinfo1.Text = "請輸入數字";
                txtkg1.Text = "";
            }
        }

        private void txtt_KeyUP(object sender, KeyEventArgs e)
        {
            strInput = txtt1.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(3, douOutput * 1000000000);
            }
            else
            {
                txtinfo1.Text = "請輸入數字";
                txtt1.Text = "";
            }
        }

        private void txtoz_KeyUP(object sender, KeyEventArgs e)
        {
            strInput = txtoz1.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(4, douOutput * 28349);
            }
            else
            {
                txtinfo1.Text = "請輸入數字";
                txtoz1.Text = "";
            }
        }

        private void txtib_KeyUP(object sender, KeyEventArgs e)
        {
            strInput = txtib1.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(5, douOutput * 45359);
            }
            else
            {
                txtinfo1.Text = "請輸入數字";
                txtib1.Text = "";
            }
        }


        private void btnALLClear_Click(object sender, RoutedEventArgs e)
        {
            txtmg1.Text = "";
            txtg1.Text = "";
            txtkg1.Text = "";
            txtt1.Text = "";
            txtoz1.Text = "";
            txtib1.Text = "";
        }

    }
}
