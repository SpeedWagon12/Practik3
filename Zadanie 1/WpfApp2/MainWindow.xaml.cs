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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(Box1.Text, out double a))
            { MessageBox.Show("Поле только для чисел"); }

            if (!double.TryParse(Box2.Text, out double b))
            { MessageBox.Show("Поле только для чисел"); }
            double c, g;
            c = a / b;
            g = a % b;
            if (g == 0)
            { Answer.Text += "частное от деление равно = " + c; }
            else if (g != 0)
            { Answer.Text += "остаток от деления" + g; }

        }
    }
}
