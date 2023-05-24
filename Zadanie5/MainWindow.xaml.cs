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

namespace Zadanie5
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int N = Convert.ToInt32(textBoxA.Text);
            if (N <=  0)
            {
                Result.Content = "Ошибка ввода";
                return;
            }
            int sum = 0;
            int k = 1;

            while (sum +k <= N)
            {
                sum += k;
                k++; 
            }
            Result.Content = $"Наиб значение K = {k-1}\nСумма = {sum}";
        }
    }
}
