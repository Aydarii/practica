using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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

namespace pract
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void voyti_Click(object sender, RoutedEventArgs e)
        {
            var log = login.Text;
            var pass = password.Text;
            var context = new AppDbContext();

            var user = context.Users.SingleOrDefault(x => x.Login == log && x.Password == pass);
            if(user is null)
            {
                MessageBox.Show("Неправильный логин или пароль!");
                return;
            }
            else
            {
                Магазин_товаров_для_кухни_и_кулинарии маг = new Магазин_товаров_для_кухни_и_кулинарии();
                маг.Show();
                this.Hide();
            }
            MessageBox.Show("Вы успешно вошли в аккаунт!");

        } 

        private void regis_Click(object sender, RoutedEventArgs e)
        {

                Регистрация регистрация = new Регистрация();
                регистрация.Show();
                this.Hide();
            }
        }

    }




