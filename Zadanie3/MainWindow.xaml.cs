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

namespace Zadanie3
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
                int A = Convert.ToInt32(TbNumberA.Text);
                int B = Convert.ToInt32(TbNumberB.Text);
                int C = Convert.ToInt32(TbNumberC.Text);
                int max = 0, min = 0;
                //нахождение максимального
                if (A >= B && A >= C)
                { max = A; }
                else if (B >= A && B >= C)
                { max = B; }
                else if (C >= A && C >= B)
                { max = C; }
                //нахождение минимального
                if (A <= B && A <= C)
                { min = A; }
                else if (B <= A && B <= C)
                { min = B; }
                else if (C <= A && C <= B)
                { min = C; }
                TextBlockAnswer.Text = $"Ответ:\nМаксимальное: {max}" + $"\nМинимальное: {min}";
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
