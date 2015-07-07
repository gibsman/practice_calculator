using System;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class MainForm : Form
    {
        public Add Add1;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Operations(object sender, EventArgs e)
        {
            double result;
            if ((String.IsNullOrEmpty(FirstArgument.Text) || String.IsNullOrEmpty(SecondArgument.Text)))
            {
                throw new Exception("Enter arguments");
            }
            double firstValue = Convert.ToDouble(FirstArgument.Text);
            double secondValue = Convert.ToDouble(SecondArgument.Text);
            switch (((Button)sender).Name)
            {
                case "Division":
                    {
                        if (secondValue == 0)
                        {
                            throw new Exception("Division by zero");
                        }
                        result = firstValue / secondValue;
                        break;
                    }
                case "Addition":
                {
                    result=Add1.AddOperation(firstValue, secondValue);
                        break;
                    }
                case "Multiplication":
                    {
                        result = firstValue * secondValue;
                        break;
                    }
                case "Substraction":
                    {
                        result = firstValue - secondValue;
                        break;
                    }
                default:
                    throw new Exception("Error");
            }
            Result.Text = result.ToString();
        }

        private void MainFormLoad(object sender, EventArgs e)
        {

        }

        private void resetClick(object sender, EventArgs e)
        {
            FirstArgument.Text = "";
            SecondArgument.Text = "";
            Result.Text = "";
        }

        private void ResultTextChanged(object sender, EventArgs e)
        {

        }

        private void FirstArgumentKeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {

            }
            else
                if (e.KeyChar == ',' || e.KeyChar == '.' || e.KeyChar == '-')
                {

                }
                else
                {
                    e.Handled = e.KeyChar != (char)Keys.Back;
                }
        }

        private void OperationsWithOneArgument(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(FirstArgument.Text))
            {
                throw new Exception("Enter first argument");
            }
            double result;
            double firstValue = Convert.ToDouble(FirstArgument.Text);
            switch (((Button)sender).Name)
            {
                case "Sin":
                    {
                        result = Math.Sin(firstValue);
                        break;
                    }
                case "Squared":
                    {
                        result = Math.Pow(firstValue, 2);
                        break;
                    }
                default:
                    throw new Exception("Error");
            }
            Result.Text = result.ToString();
        }




    }
}
