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

namespace Practica4Zadanie1
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
            double result = 0;
            double NN = Convert.ToInt32(textBoxNumber.Text);
            var AA = Convert.ToDouble(textBoxAA.Text);
            double BB = Convert.ToDouble(textBoxBB.Text);

            if (BB == 0)
            {
                MessageBox.Show("B не равно нулю");
                return; 
            }
             
            switch (NN)
            {
                case 1:
                    result = AA + BB;
                    Result.Content = $"ответ сложения{result}";
                    break;
                case 2:
                    result = AA - BB;
                    Result.Content = $"ответ вычитания {result}";
                    break;
                case 3:
                    result = AA * BB;
                    Result.Content = $"ответ умножения{result}";
                    break;
                case 4:
                    result = AA / BB;
                    Result.Content = $"ответ деления{result}";
                    break;
                default:
                    MessageBox.Show("Введены некоректные значения");
                    break;
            }
        }


    }
}

