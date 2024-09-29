using OOp_lab_5.Controller;
using System;
using System.Windows.Forms;

namespace OOp_lab_5.View
{
    public partial class FormAge : Form
    {
        private readonly AgeController _ageController;

        public  FormAge()
        {
            InitializeComponent();
            _ageController = new AgeController();
        }

        private void FormAge_Load(object sender, EventArgs e)
        {

        }

        private void btnCheckAge_Click(object sender, EventArgs e)
        {
            try
            {
                int age = Convert.ToInt32(txtAge.Text);
                string category = _ageController.GetAgeCategory(age);
                lblAgeCategory.Text = category;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }
    }
}
