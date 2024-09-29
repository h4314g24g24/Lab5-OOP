using OOp_lab_5.Controller;
using System;
using System.Windows.Forms;


namespace OOp_lab_5.View
{
    public partial class Calcform : Form
    {
        private readonly CalculatorController _calculatorController;

        public Calcform()
        {
            InitializeComponent();
            _calculatorController = new CalculatorController();
        }
















        private void Calcform_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(txtNum1.Text);
                double num2 = Convert.ToDouble(txtNum2.Text);
                double result = _calculatorController.PerformAddition(num1, num2);
                lblResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(txtNum1.Text);
                double num2 = Convert.ToDouble(txtNum2.Text);
                double result = _calculatorController.PerformSubtraction(num1, num2);
                lblResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(txtNum1.Text);
                double num2 = Convert.ToDouble(txtNum2.Text);
                double result = _calculatorController.PerformMultiplication(num1, num2);
                lblResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }




        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(txtNum1.Text);
                double num2 = Convert.ToDouble(txtNum2.Text);
                double result = _calculatorController.PerformDivision(num1, num2);
                lblResult.Text = result.ToString();
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
