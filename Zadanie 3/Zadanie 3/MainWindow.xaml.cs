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

namespace Zadanie_3
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
            if(!double.TryParse(Box1.Text,out double a))
            { MessageBox.Show("Поле только дя чисел"); }

            if (!double.TryParse(Box2.Text, out double b))
            { MessageBox.Show("Поле только дя чисел"); }

            if (!double.TryParse(Box3.Text, out double c))
            { MessageBox.Show("Поле только дя чисел"); }

            if (!double.TryParse(Box4.Text, out double d))
            { MessageBox.Show("Поле только дя чисел"); }

            if (a == b && b == c)
            { Answer.Text += "4"; }

            if (a == b && b == d)
            { Answer.Text += "3"; }

            if (a == c && d == c)
            { Answer.Text += "2"; }

            if (c == b && b == d)
            { Answer.Text += "1"; }


        }
    }
}
