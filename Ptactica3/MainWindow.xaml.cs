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

namespace Ptactica3
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
                int N = Convert.ToInt32(TbNumberN.Text);
                int ch = N / 10;
                int ost = N % 10;
                int summ = ch + ost;
                if (summ % 2 == 0)
                {
                    TextBlockAnswer.Text = $"Ответ:\nСумма цифр числа четная";
                }
                else
                {
                    TextBlockAnswer.Text = $"Ответ:\nСумма цифр числа нечетная";
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
