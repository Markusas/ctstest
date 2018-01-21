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

namespace DesktopCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int sum = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void executeButton_Click(object sender, RoutedEventArgs e)
        {
            //result.Content = num1.Text;
            //int inputNumber = int.Parse(num1.Text);
            //int squareNumber = inputNumber * inputNumber;
            //result.Content = squareNumber;
            result.Content = sum;
        }

        private void clearResult_Click(object sender, RoutedEventArgs e)
        {
            num1.Text = String.Empty;
            result.Content = "";
            sum = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
 
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            int inputNumber = int.Parse(num1.Text);
            result.Content = inputNumber;
            sum = sum + inputNumber;
            num1.Text = String.Empty;
        }
    }
}
