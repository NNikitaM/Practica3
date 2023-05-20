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
        private void BtnCancelClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void BtnOKClick(object sender, RoutedEventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(TbNumberX.Text);
                int y = Convert.ToInt32(TbNumberY.Text);
                if ((x * x + y * y < 10 * 10) && (y > -x))
                {
                    TextBlockAnswer.Text = $"Ответ:\nДа";
                }
                else if ((x * x + y * y > 10 * 10) || (y < -x))
                {
                    TextBlockAnswer.Text = $"Ответ:\nНет";
                }
                else
                {
                    TextBlockAnswer.Text = $"Ответ:\nНа границе";
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
