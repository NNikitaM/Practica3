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
        private void BtnCancelClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void BtnOKClick(object sender, RoutedEventArgs e)
        {
            try
            {
                double N = Convert.ToDouble(TbNumberN.Text);
                if (N == 0)
                { TextBlockAnswer.Text = $"Ответ:\nНулевое число"; }
                else if (N % 2 == 0)
                {
                    if (N > 0)
                    { TextBlockAnswer.Text = $"Ответ:\nЧетное положительное число"; }
                    else { TextBlockAnswer.Text = $"Ответ:\nЧетное отрицательное число"; }
                }
                else
                {
                    if (N > 0)
                    { TextBlockAnswer.Text = $"Ответ:\nНечетное положительное число"; }
                    else { TextBlockAnswer.Text = $"Ответ:\nНечетное отрицательное число"; }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены не корректные данные");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
