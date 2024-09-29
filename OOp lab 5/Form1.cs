using OOp_lab_5.Controller;
using OOp_lab_5.View;
using System;
using System.Windows.Forms;



namespace OOp_lab_5


{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOpenCalculator_Click(object sender, EventArgs e)
        {
            Calcform calculatorForm = new Calcform(); 
            calculatorForm.Show(); 
        }

        private void btnOpenAgeForm_Click(object sender, EventArgs e)
        {
            FormAge ageForm = new FormAge(); 
            ageForm.Show(); 
        }

        

        private void btnOpenMultiplicationTable_Click_1(object sender, EventArgs e)
        {
            CalcForm2 multiplicationTableForm = new CalcForm2();
            multiplicationTableForm.Show();
        }
    }
}
