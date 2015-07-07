﻿using System;
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

        private void OperationsWithTwoAgument(object sender, EventArgs e)
        {
            double result;
            if ((String.IsNullOrEmpty(FirstArgument.Text) || String.IsNullOrEmpty(SecondArgument.Text)))
            {
                throw new Exception("Enter arguments");
            }
            double firstValue = Convert.ToDouble(FirstArgument.Text);
            double secondValue = Convert.ToDouble(SecondArgument.Text);
            string nameButton = ((Button) sender).Name;
            IOperationWithTwoArguments factory = FactoryWithTwoArguments.GetCalculator(nameButton);
            Result.Text = factory.Calculate(firstValue,secondValue).ToString();
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
            string nameButton = ((Button)sender).Name;
            IOperationWithOneArgument factory = FactoryWithOneArgument.GetCalculator(nameButton);
            Result.Text = factory.Calculate(firstValue).ToString();
        }





    }
}
