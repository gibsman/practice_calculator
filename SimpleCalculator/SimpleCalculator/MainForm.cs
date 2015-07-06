using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Substraction button behavior
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Substraction_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(FirstArgument.Text) || String.IsNullOrEmpty(SecondArgument.Text))
                Result.Text = "Enter arguments";
            else
            {
                double SubstractionResult = Convert.ToDouble(FirstArgument.Text) - Convert.ToDouble(SecondArgument.Text);
                Result.Text = SubstractionResult.ToString();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Addition button behavior
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Addition_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(FirstArgument.Text) || String.IsNullOrEmpty(SecondArgument.Text))
                Result.Text = "Enter arguments";
            else
            {
                double AdditionResult = Convert.ToDouble(FirstArgument.Text) + Convert.ToDouble(SecondArgument.Text);
                Result.Text = AdditionResult.ToString();
            }
        }

        /// <summary>
        /// Multiplication button behavior
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Multiplication_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(FirstArgument.Text) || String.IsNullOrEmpty(SecondArgument.Text))
                Result.Text = "Enter arguments";
            else
            {
                double MultiplicationResult = Convert.ToDouble(FirstArgument.Text) * Convert.ToDouble(SecondArgument.Text);
                Result.Text = MultiplicationResult.ToString();
            }
        }
        /// <summary>
        /// Division button behavior
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Division_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(FirstArgument.Text) || String.IsNullOrEmpty(SecondArgument.Text))
                Result.Text = "Enter arguments";
            else
            {
                if (Convert.ToDouble(SecondArgument.Text) == 0)
                    Result.Text = "Error. Division by zero";
                else
                {
                    double DivisionResult = Convert.ToDouble(FirstArgument.Text) / Convert.ToDouble(SecondArgument.Text);
                    Result.Text = DivisionResult.ToString();
                }
            }
        }
        /// <summary>
        /// Reset button behavior
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reset_Click(object sender, EventArgs e)
        {
            FirstArgument.Text = "";
            SecondArgument.Text = "";
            Result.Text = "";
        }

    }
}
