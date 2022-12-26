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
using Gruzdev.Pages;
using Gruzdev.DataBase;

namespace Gruzdev.Pages
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Page
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void AuthoBtn_Click(object sender, RoutedEventArgs e)
        {
            var ContextUser = TradeEntities.GetContext().User;
            var Autho = ContextUser.Where(p => p.UserLogin == UsLog.Text && p.UserPassword == UsPass.Text).FirstOrDefault();
            if (Autho != null)
                NavigationService.Navigate(new Capcha());
            else MessageBox.Show("Вы ввели некорректные данные","Упс...");



        }

        private void SignInGuessBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Service());
        }
    }
}
