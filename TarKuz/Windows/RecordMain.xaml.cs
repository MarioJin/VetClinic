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
using static TarKuz.EF.EntEF;

namespace TarKuz.Windows
{
    /// <summary>
    /// Логика взаимодействия для RecordMain.xaml
    /// </summary>
    public partial class RecordMain : Window
    {
        public RecordMain()
        {
            InitializeComponent();
            lvRecord.ItemsSource = Context.Reception.ToList();
        }

        private void btnActive_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnArchive_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}