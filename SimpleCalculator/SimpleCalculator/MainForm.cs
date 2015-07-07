using System;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class MainForm : Form
    {
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
            double FirstValue = Convert.ToDouble(FirstArgument.Text);
            double SecondValue = Convert.ToDouble(SecondArgument.Text);
            switch (((Button)sender).Name)
            {
                case "Division":
                    {
                        if (SecondValue == 0)
                        {
                            throw new Exception("Division by zero");
                        }
                        result = FirstValue / SecondValue;
                        break;
                    }
                case "Addition":
                    {
                        result = FirstValue + SecondValue;
                        break;
                    }
                case "Multiplication":
                    {
                        result = FirstValue * SecondValue;
                        break;
                    }
                case "Substraction":
                    {
                        result = FirstValue - SecondValue;
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
                if (e.KeyChar == ',' || e.KeyChar == '.')
                {

                }
                else
                {
                    e.Handled = e.KeyChar != (char)Keys.Back;
                }
        }

        private void SinClick(object sender, EventArgs e)
        {
            double result;
            double FirstValue = Convert.ToDouble(FirstArgument.Text);
            if (String.IsNullOrEmpty(FirstArgument.Text))
            {
                throw new Exception("Enter arguments");
            }
            result = Math.Sin(FirstValue);
            Result.Text = result.ToString();
        }



    }
}
