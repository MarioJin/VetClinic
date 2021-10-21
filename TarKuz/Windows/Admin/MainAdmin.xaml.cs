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

namespace TarKuz.Windows.Admin
{
    /// <summary>
    /// Логика взаимодействия для MainAdmin.xaml
    /// </summary>
    public partial class MainAdmin : Window
    {
        public MainAdmin()
        {
            InitializeComponent();
        }

        private void btnRecord_Click(object sender, RoutedEventArgs e)
        {
            RecordMain recordMain = new RecordMain();
            recordMain.Show();
            Application.Current.MainWindow.Close();
        }

        private void btnMedicalCard_Click(object sender, RoutedEventArgs e)
        {
            MedicalCardMain medicalCardMain = new MedicalCardMain();
            medicalCardMain.Show();
            Application.Current.MainWindow.Close();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            SignWindow signWindow = new SignWindow();
            signWindow.Show();
            Application.Current.MainWindow.Close();
        }

        private void btnGraphic_Click(object sender, RoutedEventArgs e)
        {

        }

        private void lvInformation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
