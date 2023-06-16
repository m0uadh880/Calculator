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
            string buttonContent = (sender as Button).Content.ToString();

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
                operation = (sender as Button).Content.ToString();
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
            if (double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                lastNumber /= 100 ;
                resultLabel.Content = lastNumber.ToString();
            }
        }

        private void acButton_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "0";
        }

        private void pointButton_Click(object sender, RoutedEventArgs e)
        {
            if(!resultLabel.Content.ToString().Contains(','))
                resultLabel.Content = $"{resultLabel.Content},";
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
                    try
                    {
                        if (lastNumber == 0)
                            throw new Exception();
                        result /= lastNumber;
                    }
                    catch(Exception ex) { 
                        MessageBox.Show("Division by 0 is not supported !", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
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
