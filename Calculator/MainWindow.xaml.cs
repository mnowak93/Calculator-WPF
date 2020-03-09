using System.Windows;

namespace Calculator
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        long number1 = 0;
        long number2 = 0;
        string operation = "";
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10 + 1);
                txtDispaly.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10 + 1);
                txtDispaly.Text = number2.ToString();
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10 + 2);
                txtDispaly.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10 + 2);
                txtDispaly.Text = number2.ToString();
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10 + 3);
                txtDispaly.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10 + 3);
                txtDispaly.Text = number2.ToString();
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10 + 4);
                txtDispaly.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10 + 4);
                txtDispaly.Text = number2.ToString();
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10 + 5);
                txtDispaly.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10 + 5);
                txtDispaly.Text = number2.ToString();
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10 + 6);
                txtDispaly.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10 + 6);
                txtDispaly.Text = number2.ToString();
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10 + 7);
                txtDispaly.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10 + 7);
                txtDispaly.Text = number2.ToString();
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10 + 8);
                txtDispaly.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10 + 8);
                txtDispaly.Text = number2.ToString();
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10 + 9);
                txtDispaly.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10 + 9);
                txtDispaly.Text = number2.ToString();
            }
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10);
                txtDispaly.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10);
                txtDispaly.Text = number2.ToString();
            }
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            txtDispaly.Text = "0";
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            txtDispaly.Text = "0";
        }

        private void btnTimes_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            txtDispaly.Text = "0";
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            txtDispaly.Text = "0";
        }

        private void btnPwr_Click(object sender, RoutedEventArgs e)
        {
            operation = "^";
            txtDispaly.Text = "0";
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "+":
                    txtDispaly.Text = (number1 + number2).ToString();
                    break;
                case "-":
                    txtDispaly.Text = (number1 - number2).ToString();
                    break;
                case "*":
                    txtDispaly.Text = (number1 * number2).ToString();
                    break;
                case "/":
                    txtDispaly.Text = (number1 / number2).ToString();
                    break;
                case "^":
                    long res = number1;
                    for (int i = 1; i < number2; i++) res *= number1;
                    txtDispaly.Text = res.ToString();
                    break;
            }
            number1 = 0;
            number2 = 0;
            operation = "";
        }

        private void btnClearEntry_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = 0;
            }
            else
            {
                number2 = 0;
            }
            txtDispaly.Text = "0";
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            operation = "";
            txtDispaly.Text = "0";
        }

        private void btnBackspace_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 / 10);
                txtDispaly.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 / 10);
                txtDispaly.Text = number2.ToString();
            }
        }

        private void btnPosNeg_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 *= -1;
                txtDispaly.Text = number1.ToString();
            }
            else
            {
                number2 *= -1;
                txtDispaly.Text = number2.ToString();
            }
        }        
    }
}
