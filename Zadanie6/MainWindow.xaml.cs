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

            if (N<9)
            {

                if (N % 2 == 0)
                {
                    Result.Content = "false  ";
                }
                else
                {
                    Result.Content = "true  ";
                    
                }
                return;
                
            }
            

            if (N>9 && N<100)
            {
                int a = N % 10;
                int b = (N % 10) / 1;

                if ( a%2 == 0)
                {
                    Result.Content = "false";
                }
                else Result.Content = "true ";

                if (b % 2 == 0)
                {
                    Result2.Content = "false ";
                }
                else Result2.Content = "true ";

                return;
            }
            else
            {
                int a = N % 10;
                int b = N / 10;
                int c = (N % 10) / 1;

                if (a % 2 == 0)
                {
                    Result.Content = "false ";
                }
                else Result.Content = "truе ";

                if (b % 2 == 0)
                {
                    Result2.Content = "false ";
                }
                else Result2.Content = "true ";

                if (c%2 == 0)
                {
                    Result3.Content = "false ";
                }
                else Result3.Content = "true ";

                return;

            }
        }
    }
}
