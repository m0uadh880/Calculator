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

        private float firstNumber = 0 , secondNumber = 0 , result = 0;
        private string operation;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void numberButton_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = (Button)sender;
            string buttonContent = clickedButton.Content.ToString();


            if(resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = buttonContent;
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}{buttonContent}";
            }
        }

        private void negativeButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() != "0")
            {
                resultLabel.Content = $"-{resultLabel.Content}";
            }
        }

        private void percentageButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void divisionButton_Click(object sender, RoutedEventArgs e)
        {

            if (resultLabel.Content.ToString() != "0" && int.TryParse(resultLabel.Content.ToString(), out int number))
            {
                Button clickedButton = (Button)sender;
                string buttonContent = clickedButton.Content.ToString();

                firstNumber = number;
                operation = buttonContent;
                resultLabel.Content = $"{resultLabel.Content} {buttonContent}";
            }

            else
            {
                resultLabel.Content = "0" ;
            }

        }

        private void muliplicationButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() != "0" && int.TryParse(resultLabel.Content.ToString(), out int number))
            {
                Button clickedButton = (Button)sender;
                string buttonContent = clickedButton.Content.ToString();

                firstNumber = number;
                operation = buttonContent;
                resultLabel.Content = $"{resultLabel.Content} {buttonContent}";
            }

            else
            {
                resultLabel.Content = "0";
            }
        }


        private void subtractionButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() != "0" && int.TryParse(resultLabel.Content.ToString(), out int number))
            {
                Button clickedButton = (Button)sender;
                string buttonContent = clickedButton.Content.ToString();

                firstNumber = number;
                operation = buttonContent;
                resultLabel.Content = $"{resultLabel.Content} {buttonContent}";
            }

            else
            {
                resultLabel.Content = "0";
            }
        }


        private void additionButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() != "0" && int.TryParse(resultLabel.Content.ToString(), out int number))
            {
                Button clickedButton = (Button)sender;
                string buttonContent = clickedButton.Content.ToString();

                firstNumber = number;
                operation = buttonContent;
                resultLabel.Content = $"{resultLabel.Content} {buttonContent}";
            }

            else
            {
                resultLabel.Content = "0";
            }
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
            if (resultLabel.Content.ToString() != "0" && !int.TryParse(resultLabel.Content.ToString(), out int number))
            {
                secondNumber = int.Parse(resultLabel.Content.ToString().Substring(resultLabel.Content.ToString().Length - 1));

                if(operation == "*")
                {
                    result = firstNumber * secondNumber;
                }
                else if(operation == "/")
                {
                    result = firstNumber / secondNumber   ;
                }
                else if (operation == "+")
                {
                    result = firstNumber + secondNumber;
                }
                else if (operation == "-")
                {
                    result = firstNumber - secondNumber;
                }

                resultLabel.Content = $"{result}";
            }

            else
            {
            }
        }
    }
}
