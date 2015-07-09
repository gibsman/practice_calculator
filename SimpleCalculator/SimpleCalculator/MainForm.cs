using System;
using System.Windows.Forms;
using SimpleCalculator.TwoArguments;

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
            if ((String.IsNullOrEmpty(FirstArgument.Text) || String.IsNullOrEmpty(SecondArgument.Text)))
            {
                throw new Exception("Enter arguments");
            }
            double firstValue = Convert.ToDouble(FirstArgument.Text);
            double secondValue = Convert.ToDouble(SecondArgument.Text);
            string nameButton = ((Button)sender).Name;
            IOperationWithTwoArguments calculator = FactoryWithTwoArguments.GetCalculator(nameButton);
            Result.Text = calculator.Calculate(firstValue, secondValue).ToString();
        }

        private void SortingMassives(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(FirstArgument.Text))
            {
                throw new Exception("Enter first argument");
            }
            string[] split = FirstArgument.Text.Split(' ');
            int[] mas = new int[split.Length];
            for (int i = 0; i < split.Length; i++)
            {
                mas[i] = Convert.ToInt32(split[i]);
            }
            string nameButton = ((Button)sender).Name;
            ISorters sorter = FactorySorters.GetSorting(nameButton);
            int[] massive = sorter.Sort(mas);
            string result = "";
            for (int j = 0; j < massive.Length; j++)
            {
                result += Convert.ToString(massive[j] + " ");
            }
            Result.Text = result;
        }

        private void MainFormLoad(object sender, EventArgs e)
        {

        }

        private void ResetClick(object sender, EventArgs e)
        {
            FirstArgument.Text = "";
            SecondArgument.Text = "";
            Result.Text = "";
        }

        private void FirstArgumentKeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {

            }
            else
                if (e.KeyChar == ' ' || e.KeyChar == ',' || e.KeyChar == '-')
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
            IOperationWithOneArgument calculator = FactoryWithOneArgument.GetCalculator(nameButton);
            Result.Text = calculator.Calculate(firstValue).ToString();
        }
    }
}
