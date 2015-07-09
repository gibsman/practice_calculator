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
        
        private void OperationsWithTwoAgument(object sender, EventArgs e)
        {
            if ((String.IsNullOrEmpty(FirstArgument.Text) || String.IsNullOrEmpty(SecondArgument.Text)))
            {
                throw new Exception("Enter arguments");
            }
            double firstValue = ValidateNumbers.ValidateAndConvert(FirstArgument.Text);
            double secondValue = ValidateNumbers.ValidateAndConvert(SecondArgument.Text);
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
            int[] mas = ValidateMassives.ValidateAndConvert(FirstArgument.Text);
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

        private void OperationsWithOneArgument(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(FirstArgument.Text))
            {
                throw new Exception("Enter first argument");
            }
            double firstValue = ValidateNumbers.ValidateAndConvert(FirstArgument.Text);
            string nameButton = ((Button)sender).Name;
            IOperationWithOneArgument calculator = FactoryWithOneArgument.GetCalculator(nameButton);
            Result.Text = calculator.Calculate(firstValue).ToString();
        }
    }
}
