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
        private string part1 = "";
        private string part2 = "";
        private string action;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Num1Btn_Click(object sender, RoutedEventArgs e)
        {
            string buttonValue = ((Button)sender).Content.ToString();
            resultBox.Text = resultBox.Text + ((Button)sender).Content;
            part1 = part1 + buttonValue;
        }

        private void resultBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void plusBtn_Click(object sender, RoutedEventArgs e)
        {
            resultBox.Text = resultBox.Text + "+";
            part2 = part1;
            part1 = "";
            action = "+";
        }
    }
}
