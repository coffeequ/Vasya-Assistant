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
using System.Windows.Shapes;

namespace Реализация_проекта
{
    /*-----------------------------------------------------------------
     *  Программа будет использовать вещественный тип данных (double) *
     *  для рассчета вводимых данных. Программа использует класс.     *
     *  Данные получают с формы.                                      *
     *----------------------------------------------------------------*/

    /// <summary>
    /// Логика взаимодействия для Рассчет_параметров.xaml
    /// </summary>
    public partial class Рассчет_параметров : Window
    {
        public Рассчет_параметров()
        {
            InitializeComponent();
        }
        ParametrsWinAndMan temp = new ParametrsWinAndMan();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Класс для хранения параметорв окна и головый Васи
            ParametrsWinAndMan parametrsWinAndMan;
            try
            {
                double valueA = double.Parse(tbA.Text);
                double valueB = double.Parse(tbB.Text);
                double valueD = double.Parse(tbD.Text);
                parametrsWinAndMan = new ParametrsWinAndMan();
                parametrsWinAndMan.A = valueA;
                parametrsWinAndMan.B = valueB;
                parametrsWinAndMan.D = valueD;
                temp = parametrsWinAndMan;
                MessageBox.Show($"{parametrsWinAndMan.Calculation()}");
            }
            catch
            {
                MessageBox.Show("Введены не правильные значения");
            }
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(temp.A.ToString()) || !string.IsNullOrEmpty(temp.B.ToString()) || !string.IsNullOrEmpty(temp.D.ToString()))
            {
                MessageBox.Show("Данные отправлены на печать");
            }
            else
            {
                MessageBox.Show("Вывод на печать невозможен");
            }
        }

        private void tbD_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
