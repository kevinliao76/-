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

namespace Change
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

        private void txtCM_KeyUP(object sender, KeyEventArgs e)
        {
            double douCM; //宣告一個double變數，變數名稱叫douCM
            douCM = Convert.ToDouble(txtCM1.Text); //從txtCM輸入文字框取得輸入的文字，並且轉換成double的資料型態

            //透過string.Format格式化成小數點後共10位的數字，轉型成文字型態，在txtM顯示結果
            txtM1.Text = string.Format("{0:0.##########}", douCM / 100);
            txtKM1.Text = string.Format("{0:0.##########}", douCM / 100000);
            txtIn1.Text = string.Format("{0:0.##########}", douCM / 2.54);
            txtFt1.Text = string.Format("{0:0.##########}", douCM / 30.48);
            txtYard1.Text = string.Format("{0:0.##########}", douCM / 91.44);
        }
    }
}