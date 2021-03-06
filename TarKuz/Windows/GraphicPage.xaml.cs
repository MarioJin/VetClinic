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
using static TarKuz.EF.EntEF;

namespace TarKuz.Windows
{
    /// <summary>
    /// Логика взаимодействия для GraphicPage.xaml
    /// </summary>
    public partial class GraphicPage : Page
    {
        public GraphicPage()
        {
            InitializeComponent();
            LvGraphic.ItemsSource = Context.GraphicView.ToList();
        }

        private void LvProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
    }
}