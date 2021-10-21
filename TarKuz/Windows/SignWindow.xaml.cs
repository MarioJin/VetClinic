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
using TarKuz.Windows.Admin;
using TarKuz.Windows.Doctor;
using TarKuz.Windows.Manager;

namespace TarKuz
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class SignWindow : Window
    {
        public SignWindow()
        {
            InitializeComponent();
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
           var user = EF.EntEF.Context.User.Where(i => i.Login == txbLogin.Text && i.Password == psbPassword.Password).FirstOrDefault();

            switch (user.IdRole)
            {
                case 1:
                    MainManager mainManager = new MainManager();
                    mainManager.Show();
                    Application.Current.MainWindow.Close();
                    break;

                case 2:
                    MainAdmin mainAdmin = new MainAdmin();
                    mainAdmin.Show();
                    Application.Current.MainWindow.Close();
                    break;

                case 3:
                    MainDoctor mainDoctor = new MainDoctor();
                    mainDoctor.Show();
                    Application.Current.MainWindow.Close();
                    break;

                default:
                    break;
            }
        }
    }
}
