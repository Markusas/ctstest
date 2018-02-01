using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;


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
        private bool signSelect = false;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Num1Btn_Click(object sender, RoutedEventArgs e)
        {
            string buttonValue = ((Button)sender).Content.ToString();
            resultBox.Text = resultBox.Text + ((Button)sender).Content;
            part1 = part1 + buttonValue;
            signSelect = false;
        }



        private void action_Click(object sender, RoutedEventArgs e)
        {
            string buttonValue = ((Button)sender).Content.ToString();


            if (signSelect)
            {
                resultBox.Text = resultBox.Text.Substring(0, resultBox.Text.Length - 1).ToString();

            }
            else
            {
                part2 = part1;
                part1 = "";
            }

            resultBox.Text = resultBox.Text + ((Button)sender).Content;
            signSelect = true;

            
            action = buttonValue;

        }


        private void executeBtn_Click(object sender, RoutedEventArgs e)
        {
            double partOne = double.Parse(part1);
            double partTwo = double.Parse(part2);

            Arithmetics arithmetics = new Arithmetics();

            try
            {
                resultBox.Text = arithmetics.Calculate(partTwo, partOne, action).ToString();
            }
            catch (DivideByZeroException ex)
            {
                resultBox.Text = "Division by 0 not allowed!";
            }

            part1 = resultBox.Text;
        }

        private void clearBtn_Click(object sender, RoutedEventArgs e)
        {
            resultBox.Text = String.Empty;
            part1 = "";
        }
    }
}
