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

namespace DopZadanie2
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

            if (n<100 && n>999)
            {
                Result.Content = "Введите числа в диапазоне 100-999";
            }
            else 
            {
                switch (n/100)
                {
                    case 1:
                        Result.Content = "сто";
                        break;
                    case 2:
                        Result.Content = "двести";
                        break;
                    case 3:
                        Result.Content = "триста";
                        break;
                    case 4:
                        Result.Content = "четыресто";
                        break;
                    case 5:
                        Result.Content = "пятьсот";
                        break;
                    case 6:
                        Result.Content = "шестьсот";
                        break;
                    case 7:
                        Result.Content = "семьсот";
                        break;
                    case 8:
                        Result.Content = "восемьсот";
                        break;
                    case 9:
                        Result.Content = "девятьсот";
                        break;
                    default:
                        Result.Content = "Ошибка";
                        break;

                }
                if ((n / 10) % 10 == 1)
                {
                    switch (n % 10)
                    {
                        
                        case 0:
                            Result2.Content = " десять";
                            break;
                        case 1:
                            Result2.Content = "одинадцать";
                            break;
                        case 2:
                            Result2.Content = " двенадцать";
                            break;
                        case 3:
                            Result2.Content = " тринадцать";
                            break;
                        case 4:
                            Result2.Content = " четырнадцать";
                            break;
                        case 5:
                            Result2.Content = " пятнадцать";
                            break;
                        case 6:
                            Result2.Content = " шестнадцать";
                            break;
                        case 7:
                            Result2.Content = " семнадцать";
                            break;
                        case 8:
                            Result2.Content = " восемнадцать";
                            break;
                        case 9:
                            Result2.Content = " девятнадцать";
                            break;
                    }
                    
                  
                }
                else
                {
                    switch((n/10)%10)
                    {
                        case 2:
                            Result3.Content = " двадцать";
                            break;
                        case 3:
                            Result3.Content = " тридцать";
                            break;
                        case 4:
                            Result3.Content = " сорок";
                            break;
                        case 5:
                            Result3.Content = " пятьдесят";
                            break;
                        case 6:
                            Result3.Content = " шестьдесят";
                            break;
                        case 7:
                            Result3.Content = " семьдесять";
                            break;
                        case 8:
                            Result3.Content = " восемьдесять";
                            break;
                        case 9:
                            Result3.Content = " девяносто";
                            break;
                    }
                    switch(n%10)
                    {
                        
                        case 1:
                            Result4.Content = "одно";
                            break;
                        case 2:
                            Result4.Content = " два";
                            break;
                        case 3:
                            Result4.Content = " три";
                            break;
                        case 4:
                            Result4.Content = " четыре";
                            break;
                        case 5:
                            Result4.Content = " пять";
                            break;
                        case 6:
                            Result4.Content = " шесть";
                            break;
                        case 7:
                            Result4.Content = " семь";
                            break;
                        case 8:
                            Result4.Content = " восемь";
                            break;
                        case 9:
                            Result4.Content = " девять";
                            break;
                    }
                }


            }
        }

      
    }
}
