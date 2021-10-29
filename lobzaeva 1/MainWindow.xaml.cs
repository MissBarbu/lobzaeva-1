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
using Lib_7;

namespace lobzaeva_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Main_Click(object sender, RoutedEventArgs e)
        {
            if (!Int32.TryParse(inputN.Text, out int n)) return;
            LibClass.Sum(n, out int sum, out string numbers);
            rezultSum.Text = sum.ToString();
            rezultNumbers.Text = numbers;
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void TextBoxesClear(object sender, RoutedEventArgs e)
        {
            if (rezultSum == null) return;
            rezultNumbers.Clear();
            rezultSum.Clear();
        }
        private void inputN_TextChanged(object sender, TextCompositionEventArgs e)
        {
            if (!Int32.TryParse(e.Text, out _))
            {
                e.Handled = true; // отклоняем ввод
                return;
            }
            TextBoxesClear(null, null);
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик - Лобзаева Мария ИСП-31 \n\n Вариант 7:\nНайти сумму n целых, случайных чисел, распределенных в диапазоне от 0 до n и меньше n/2. Вывести на экран на одной строке сгенерированные числа, на другой строке результат", "О программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
