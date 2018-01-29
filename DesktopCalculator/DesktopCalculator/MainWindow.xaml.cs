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



        private void plusBtn_Click(object sender, RoutedEventArgs e)
        {
            resultBox.Text = resultBox.Text + "+";
            part2 = part1;
            part1 = "";
            action = "+";
        }

        private void minusBtn_Click(object sender, RoutedEventArgs e)
        {
            resultBox.Text = resultBox.Text + "-";
            part2 = part1;
            part1 = "";
            action = "-";
        }

        private void executeBtn_Click(object sender, RoutedEventArgs e)
        {
            int partOne = int.Parse(part1);
            int partTwo = int.Parse(part2);
            if (action == "+")
            {
                resultBox.Text = (partOne + partTwo).ToString();
            } else if (action == "-")
            {
                resultBox.Text = (partTwo - partOne).ToString();
            }

           part1 = resultBox.Text;
        }


    }
}
