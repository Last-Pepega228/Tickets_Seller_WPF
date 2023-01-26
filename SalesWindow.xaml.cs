using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Diagnostics;
using PdfSharp.Drawing.Layout;

namespace Sign_Up_Form
{
    /// <summary>
    /// Логика взаимодействия для SalesWindow.xaml
    /// </summary>
    public partial class SalesWindow : Window
    {
     
        public SalesWindow()
        {
            InitializeComponent();
        }

        public string PracticeName { get; private set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("TheHattersTicketKR.pdf") { UseShellExecute = true });
        }

        private void EXTButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Application.Current.MainWindow.Close();
        }

        private void LogButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Manager.LogSingFrame.Navigate(new LogInPage());
            this.Hide();
        }

        private void SignButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Manager.LogSingFrame.Navigate(new SingUpPage());
            this.Hide();
        }
    }
}
