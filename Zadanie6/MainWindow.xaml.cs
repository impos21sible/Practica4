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

namespace Zadanie6
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
            if (N <= 0)
            {
                Result.Content = "Ошибка ввода";
            }

            bool didnt = false;
            while (N != 0)
            {
                int Number = N % 10;
                if (Number % 2 != 0)
                {
                    didnt = true; 
                    break;
                }
                N /= 10;
            }
            Result.Content = didnt.ToString();
        }
    }

}