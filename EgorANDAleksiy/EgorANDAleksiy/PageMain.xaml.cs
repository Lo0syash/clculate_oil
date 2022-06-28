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

namespace EgorANDAleksiy
{
    /// <summary>
    /// Логика взаимодействия для PageMain.xaml
    /// </summary>
    public partial class PageMain : Window
    {
        public PageMain()
        {
            InitializeComponent();
        }
        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            avg.Text = "";
            thiss.Text = "";
            price.Text = "";
            label_wrap.Text = "";
        }

        private void age_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }

        private void math_Click(object sender, RoutedEventArgs e)
        {
            if (avg.Text == "" || thiss.Text == "" || price.Text == "" || avg.Text == "0" || thiss.Text == "0" || price.Text == "0")
            {
                MessageBox.Show("Введено некорректное значение");
            }
            else
            {
                double AVG = Convert.ToDouble(avg.Text);
                double THIS = Convert.ToDouble(thiss.Text);
                double PRICE = Convert.ToDouble(price.Text);

                double v, q;

                v = AVG / THIS;
                q = AVG * PRICE;
                label_wrap.Text = "Средний расход: " + v * 100
                    + " Стоимость: " + q + " руб.";
            }
        }

        private void weight_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }
        private void height_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow aw = new MainWindow();
            aw.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Вы уже тут");
        }
    }
}
