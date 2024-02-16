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
    
    public partial class Магазин_товаров_для_кухни_и_кулинарии : Window
    {
        public Магазин_товаров_для_кухни_и_кулинарии()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Каталог_товаров кат = new Каталог_товаров();
            кат.Show();
            this.Hide();
        }

        private void korzina_Click(object sender, RoutedEventArgs e)
        {
            Корзина кор = new Корзина();
            кор.Show();
            this.Hide();
        }
    }
}
