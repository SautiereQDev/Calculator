using System.Windows;
namespace Calculator
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        long number1 = 0;
        long number2 = 0;
        string operation = "";
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = this;

        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                // On augmente d'une dizaine en multipliant par 10
                // et on ajoute l'unités correspondant au boutton clické
                number1 = (number1 * 10);
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10);
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 1;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 1;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 2;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 2;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 3;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 3;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 4;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 4;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 5;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 5;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 6;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 6;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 7;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 7;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 8;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 8;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 9;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 9;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            txtDisplay.Text = "0";
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            txtDisplay.Text = "0";
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            txtDisplay.Text = "0";
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            txtDisplay.Text = "0";
        }

        private void btnPositiveNegative_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 *= -1;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 *= -1;
                txtDisplay.Text = number2.ToString();
            }

        }

        private void btnClearEntry_Click(object sender, RoutedEventArgs e)
        {
            //Ne vide que ce qui est affiché
            if (operation == "")
            {
                number1 = 0;
            }
            else
            {
                number2 = 0;
            }

            txtDisplay.Text = "0";
        }
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            //Remet à zero la calculatrice
            number1 = 0;
            number2 = 0;
            operation = "";
            txtDisplay.Text = "0";
        }
        private void btnSupr_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                //On enlève une dizaine pour enlever le dernier chiffre
                number1 = (number1 / 10);
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 / 10);
                txtDisplay.Text = number2.ToString();
            }
        }
        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "+":
                    txtDisplay.Text = (number1 + number2).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (number1 - number2).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (number1 * number2).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (number1 / number2).ToString();
                    break;
            }
        }
    }
}
