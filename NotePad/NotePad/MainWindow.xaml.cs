﻿using System;
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
using System.IO;
using Microsoft.Win32;

namespace NotePad
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

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.Filter = "純文字資料 (*.txt)|*.txt|All files (*.*)|*.*";
            if (dlg.ShowDialog() == true)
            {
                // 建立一個檔案資料流，並且設定檔案名稱與檔案開啟模式為「新增檔案」
                FileStream fileStream = new FileStream(dlg.FileName, FileMode.Create);
                // 取得rtbText元件中文字的範圍，取得的範圍是「全部文字」
                TextRange range = new TextRange(rtbText.Document.ContentStart, rtbText.Document.ContentEnd);
                // 儲存檔案，並且設定為純文字文件檔案（*.txt）
                range.Save(fileStream, DataFormats.Text);
                // 關閉檔案資料流
                fileStream.Close();
            }
        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.Filter = "純文字資料 (*.txt)|*.txt|All files (*.*)|*.*";
            if (dlg.ShowDialog() == true)
            {
                // 建立一個檔案資料流，並且設定檔案名稱與檔案開啟模式為「開啟檔案」
                FileStream fileStream = new FileStream(dlg.FileName, FileMode.Open);
                TextRange range = new TextRange(rtbText.Document.ContentStart, rtbText.Document.ContentEnd);
                // 將檔案資料流以純文字格式，放進rtbText元件之中顯示
                range.Load(fileStream, DataFormats.Text);
                fileStream.Close();
            }
        }
    }
}