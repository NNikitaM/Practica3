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
using static System.Math;

namespace Zadanie4
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
                double X = Convert.ToDouble(TbNumberX.Text);
                double y = 0;
                if (X < 0)
                {
                    y = Pow(X, 5) - 10 - Pow(PI + X, 1.0 / 4.0);
                }
                else if (X >= 1)
                {
                    y = X * (Pow(X, 4) + 3 * X) + Log(PI + X);
                }
                else
                {
                    y = Pow(Pow(X, 3) + 3, 3) - Sqrt(0.5 * PI + X);
                }

                TextBlockAnswer.Text = $"Ответ:\ny ={y:f2}";
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
