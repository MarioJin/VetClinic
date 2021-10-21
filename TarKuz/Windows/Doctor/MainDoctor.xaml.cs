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
using System.Windows.Shapes;

namespace TarKuz.Windows.Doctor
{
    /// <summary>
    /// Логика взаимодействия для MainDoctor.xaml
    /// </summary>
    public partial class MainDoctor : Window
    {
        public MainDoctor()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            SignWindow signWindow = new SignWindow();
            signWindow.Show();
            Application.Current.MainWindow.Close();
        }

        private void btnRecord_Click(object sender, RoutedEventArgs e)
        {
            RecordMain recordMain = new RecordMain();
            recordMain.Show();
            Application.Current.MainWindow.Close();
        }

        private void btnGraphic_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
