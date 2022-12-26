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
    /// Логика взаимодействия для Capcha.xaml
    /// </summary>
    public partial class Capcha : Page
    {
        public Capcha()
        {
            InitializeComponent();

            GenerationCaphca();
        }

        private void OutPutCapcha_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void CapchaBtn_Click(object sender, RoutedEventArgs e)
        {
            if (InPutCapcha == OutPutCapcha)
                NavigationService.Navigate(new Service());
           


        }

        public void GenerationCaphca()
        {
            Random rand = new Random();
            OutPutCapcha.Text = "";
            for (int i = 0; i < 5; i++)
                OutPutCapcha.Text += (char)('a') + (rand.Next(26));
        }
          




        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            GenerationCaphca();
        }
    }
}
