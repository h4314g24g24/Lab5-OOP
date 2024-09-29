using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOp_lab_5.View
{
    public partial class CalcForm2 : Form
    {
        public CalcForm2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerateTable_Click(object sender, EventArgs e)
        {
            try
            {
                int number = Convert.ToInt32(txtNumber.Text);
                txtMultiplicationTable.Clear();

                
                txtMultiplicationTable.AppendText($"Таблиця множення для {number}:\n");
                txtMultiplicationTable.AppendText(new string('-', 20) + "\n"); 
                for (int i = 1; i <= 10; i++)
                {
                    
                    txtMultiplicationTable.AppendText($"{number,-2} x {i,-2} = {number * i,-2}\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }

        private void txtMultiplicationTable_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalcForm2_Load(object sender, EventArgs e)
        {

        }
    }
}
