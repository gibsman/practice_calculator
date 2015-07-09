using System;
using System.Windows.Forms;

namespace SimpleCalculator
{
    /// <summary>
    /// Main form for calculator
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Method that initialize calculator
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Method that calculates operations with two arguments
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OperationsWithTwoAguments(object sender, EventArgs e)
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

        /// <summary>
        /// Method that sorts massives
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Method that loads form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainFormLoad(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Method that clears input and output boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetClick(object sender, EventArgs e)
        {
            FirstArgument.Text = "";
            SecondArgument.Text = "";
            Result.Text = "";
        }
        /// <summary>
        /// Method that calculates operations wtih one argument 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
