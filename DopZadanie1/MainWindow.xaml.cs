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

namespace DopZadanie1
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

            int n = Convert.ToInt32(textBoxA.Text);

            if (n == 0)
            {
                Result4.Content = "Ноль";
            }

            if (n / 10 == 1)
            {
                switch (n)
                {
                    case 10:
                        Result.Content="десять учебных заданий.";
                        break;
                    case 11:
                        Result.Content = ("одинадцать учебных заданий.");
                        break;
                    case 12:
                        Result.Content = ("двенадцать учебных заданий.");
                        break;
                    case 13:
                        Result.Content = ("тринадцать учебных заданий.");
                        break;
                    case 14:
                        Result.Content = ("четырнадцать учебных заданий.");
                        break;
                    case 15:
                        Result.Content = ("пятнадцать учебных заданий.");
                        break;
                    case 16:
                        Result.Content = ("шестнадцать учебных заданий.");
                        break;
                    case 17:
                        Result.Content = ("семнадцать учебных заданий.");
                        break;
                    case 18:
                        Result.Content = ("восемнадцать учебных заданий.");
                        break;
                    case 19:
                        Result.Content = ("девятнадцать учебных заданий.");
                        break;
                }
            }
            else
            {
                switch (n / 10)
                {
                    case 2:
                        Result2.Content = ("двадцать ");
                        break;
                    case 3:
                        Result2.Content = ("тридцать ");
                        break;
                    case 4:
                        Result2.Content = ("сорок ");
                        break;
                }

                switch (n % 10)
                {
                    case 1:
                        Result3.Content = ("одно ");
                        break;
                    case 2:
                        Result3.Content = ("два ");
                        break;
                    case 3:
                        Result3.Content = ("три ");
                        break;
                    case 4:
                        Result3.Content = ("четыре ");
                        break;
                    case 5:
                        Result3.Content = ("пять ");
                        break;
                    case 6:
                        Result3.Content = ("шесть ");
                        break;
                    case 7:
                        Result3.Content = ("семь ");
                        break;
                    case 8:
                        Result3.Content = ("восемь ");
                        break;
                    case 9:
                        Result3.Content = ("девять ");
                        break;
                }

                switch (n % 10)
                {
                    case 0:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                        Result4.Content = ("учебных заданий.");
                        break;
                    case 1:
                        Result4.Content = ("учебное задание.");
                        break;
                    case 2:
                    case 3:
                    case 4:
                        Result4.Content = ("учебных задания.");
                        break;
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
