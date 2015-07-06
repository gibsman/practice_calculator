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

        bool TextCheck(string text)
        {
            char[] symbol = Text.ToCharArray();
            for (int i = 0; i < text.Length; i++)
            {
                if (symbol[i] < '0' || symbol[i] > '9')
                    return false;
            }
            return true;

        }

        private void Operations(object sender, EventArgs e)
        {
            double result;
            bool DivisionCheck = false;
            if (TextCheck(FirstArgument.Text) == true || TextCheck(SecondArgument.Text) == true)
            {
                if (String.IsNullOrEmpty(FirstArgument.Text) || String.IsNullOrEmpty(SecondArgument.Text))
                    Result.Text = "Enter arguments";
                else
                {
                    switch (((Button) sender).Name)
                    {
                        case "Division":
                        {
                            if (Convert.ToDouble(SecondArgument.Text) == 0)
                            {
                                Result.Text = "Error. Division by zero";
                                DivisionCheck = true;
                                result = 0;
                            }
                            else
                            {
                                result = Convert.ToDouble(FirstArgument.Text)/Convert.ToDouble(SecondArgument.Text);
                            }
                            break;
                        }
                        case "Addition":
                        {
                            result = Convert.ToDouble(FirstArgument.Text) + Convert.ToDouble(SecondArgument.Text);
                            break;
                        }
                        case "Multiplication":
                        {
                            result = Convert.ToDouble(FirstArgument.Text)*Convert.ToDouble(SecondArgument.Text);
                            break;
                        }
                        case "Substraction":
                        {
                            result = Convert.ToDouble(FirstArgument.Text) - Convert.ToDouble(SecondArgument.Text);
                            break;
                        }
                        default:
                            throw new Exception("Error");

                    }
                    if (DivisionCheck == false)
                        Result.Text = result.ToString();
                }
            }
            else
            {
                Result.Text = "Enter numbers";
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
       
        private void reset_Click(object sender, EventArgs e)
        {
            FirstArgument.Text = "";
            SecondArgument.Text = "";
            Result.Text = "";
        }

        private void Result_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
