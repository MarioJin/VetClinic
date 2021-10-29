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

namespace TarKuz.Windows.Manager
{
    /// <summary>
    /// Логика взаимодействия для MainManager.xaml
    /// </summary>
    public partial class MainManager : Window
    {
        public MainManager()
        {
            InitializeComponent();
            var user = EF.EntEF.Context.User.Where(i => i.IdUser == ClassUserId.ClassUserId.Instance.idUserInt).FirstOrDefault();
            string f = user.LastName;
            string l = user.FirstName;
            string o = user.Patronymic;
            string fio = f + " " + l + " " + o;
            txbManagerFIO.Text = fio;
            txbSpecialization.Text = user.Specialization.NameSpecialization;
            frGraphic.Navigate(new GraphicPage());
        }

        private void btnRecord_Click(object sender, RoutedEventArgs e)
        {
            RecordMain recordMain = new RecordMain();
            this.Close();
            recordMain.Show();
        }

        private void btnMedicalCard_Click(object sender, RoutedEventArgs e)
        {
            MedicalCardMain medicalCardMain = new MedicalCardMain();
            this.Close();
            medicalCardMain.Show();
        }

        private void btnEmployee_Click(object sender, RoutedEventArgs e)
        {
            EmployeeMain employeeMain = new EmployeeMain();
            this.Close();
            employeeMain.Show();
        }

        private void btnGraphicEdit_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            SignWindow signWindow = new SignWindow();
            this.Close();
            signWindow.Show();
        }

        private void btnGraphic_Click(object sender, RoutedEventArgs e)
        {
            Graphic graphicMain = new Graphic();
            this.Close();
            graphicMain.Show();
        }
    }
}