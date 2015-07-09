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
            try
            {
                double firstValue = ValidateNumbers.ValidateAndConvert(FirstArgument.Text);
                double secondValue = ValidateNumbers.ValidateAndConvert(SecondArgument.Text);
                string nameButton = ((Button)sender).Name;
                IOperationWithTwoArguments calculator = FactoryWithTwoArguments.GetCalculator(nameButton);
                Result.Text = calculator.Calculate(firstValue, secondValue).ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Method that sorts arrays
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sortingarrays(object sender, EventArgs e)
        {
            try
            {
                int[] mas = Validatearrays.ValidateAndConvert(FirstArgument.Text);
                string nameButton = ((Button)sender).Name;
                ISorters sorter = FactorySorters.GetSorting(nameButton);
                int[] array = sorter.Sort(mas);
                string result = "";
                for (int j = 0; j < array.Length; j++)
                {
                    result += Convert.ToString(array[j] + " ");
                }
                Result.Text = result;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
            try
            {
                double firstValue = ValidateNumbers.ValidateAndConvert(FirstArgument.Text);
                string nameButton = ((Button)sender).Name;
                IOperationWithOneArgument calculator = FactoryWithOneArgument.GetCalculator(nameButton);
                Result.Text = calculator.Calculate(firstValue).ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
