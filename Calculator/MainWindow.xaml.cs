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

namespace Calculator
{
    
    public partial class MainWindow : Window
    {

        private double lastNumber = 0, result = 0;
        private string operation;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void numberButton_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = (Button)sender;
            string buttonContent = clickedButton.Content.ToString();

            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = buttonContent;
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}{buttonContent}";
            }
        }

        private void OperationButton_Click(object sender, RoutedEventArgs e)
        {
            if(double.TryParse(resultLabel.Content.ToString() , out lastNumber))
            {
                Button clickedButton = (Button)sender;
                operation = clickedButton.Content.ToString();
                result = lastNumber;
                resultLabel.Content = "0";

            }
        }



        private void negativeButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLabel.Content.ToString() , out lastNumber))
            {
                lastNumber *= -1;
                resultLabel.Content = lastNumber.ToString();
            }
            
        }

        private void percentageButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void acButton_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "0";
        }

        private void pointButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void equalButton_Click(object sender, RoutedEventArgs e)
        {


            if(double.TryParse(resultLabel.Content.ToString(), out lastNumber)){
                if (operation == "*")
                {
                    result *= lastNumber;
                }
                if (operation == "+")
                {
                    result += lastNumber;
                }
                if (operation == "/")
                {
                    result /= lastNumber;
                }
                if (operation == "-")
                {
                    result -= lastNumber;
                }

                resultLabel.Content = result.ToString();

            }


        }
    }
}
