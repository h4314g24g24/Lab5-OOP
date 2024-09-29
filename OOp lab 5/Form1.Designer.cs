namespace OOp_lab_5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnOpenCalculator = new Button();
            btnOpenAgeForm = new Button();
            btnOpenMultiplicationTable = new Button();
            SuspendLayout();
            // 
            // btnOpenCalculator
            // 
            btnOpenCalculator.Location = new Point(154, 89);
            btnOpenCalculator.Name = "btnOpenCalculator";
            btnOpenCalculator.Size = new Size(132, 29);
            btnOpenCalculator.TabIndex = 0;
            btnOpenCalculator.Text = "Калькулятор";
            btnOpenCalculator.UseVisualStyleBackColor = true;
            btnOpenCalculator.Click += btnOpenCalculator_Click;
            // 
            // btnOpenAgeForm
            // 
            btnOpenAgeForm.Location = new Point(154, 163);
            btnOpenAgeForm.Name = "btnOpenAgeForm";
            btnOpenAgeForm.Size = new Size(132, 29);
            btnOpenAgeForm.TabIndex = 1;
            btnOpenAgeForm.Text = "Перевірка віку";
            btnOpenAgeForm.UseVisualStyleBackColor = true;
            btnOpenAgeForm.Click += btnOpenAgeForm_Click;
            // 
            // btnOpenMultiplicationTable
            // 
            btnOpenMultiplicationTable.Location = new Point(154, 257);
            btnOpenMultiplicationTable.Name = "btnOpenMultiplicationTable";
            btnOpenMultiplicationTable.Size = new Size(201, 29);
            btnOpenMultiplicationTable.TabIndex = 2;
            btnOpenMultiplicationTable.Text = "Таблиця множення";
            btnOpenMultiplicationTable.UseVisualStyleBackColor = true;
            btnOpenMultiplicationTable.Click += btnOpenMultiplicationTable_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 450);
            Controls.Add(btnOpenMultiplicationTable);
            Controls.Add(btnOpenAgeForm);
            Controls.Add(btnOpenCalculator);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnOpenCalculator;
        private Button btnOpenAgeForm;
        private Button btnOpenMultiplicationTable;
    }
}
