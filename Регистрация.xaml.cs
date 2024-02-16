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

namespace pract
{
    /// <summary>
    /// Логика взаимодействия для Регистрация.xaml
    /// </summary>
    public partial class Регистрация : Window
    {
        public Регистрация()
        {
            InitializeComponent();
        }

        private void voyti_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Hide();
        }

        private void regis_Click(object sender, RoutedEventArgs e)
        {
            var log = login.Text;
            var pass = password.Text;
            var context = new AppDbContext();

            var user_exists = context.Users.FirstOrDefault(x => x.Login == log);
            if (user_exists is not null)
            {
                MessageBox.Show("Такой пользователь уже зарегистрирован");
                return;
            }
            var user = new User { Login = log, Password = pass };
            context.Users.Add(user);
            context.SaveChanges();
            MessageBox.Show("Вы успешно зарегистрированы!");
        }

    }
}
