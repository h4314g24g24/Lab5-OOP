namespace OOp_lab_5.View
{
    partial class FormAge
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtAge = new TextBox();
            btnCheckAge = new Button();
            lblAgeCategory = new Label();
            SuspendLayout();
            // 
            // txtAge
            // 
            txtAge.Location = new Point(179, 201);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(125, 27);
            txtAge.TabIndex = 0;
            // 
            // btnCheckAge
            // 
            btnCheckAge.Location = new Point(179, 131);
            btnCheckAge.Name = "btnCheckAge";
            btnCheckAge.Size = new Size(163, 29);
            btnCheckAge.TabIndex = 1;
            btnCheckAge.Text = "Перевірка віку";
            btnCheckAge.UseVisualStyleBackColor = true;
            btnCheckAge.Click += btnCheckAge_Click;
            // 
            // lblAgeCategory
            // 
            lblAgeCategory.AutoSize = true;
            lblAgeCategory.Location = new Point(179, 284);
            lblAgeCategory.Name = "lblAgeCategory";
            lblAgeCategory.Size = new Size(0, 20);
            lblAgeCategory.TabIndex = 2;
            // 
            // FormAge
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 450);
            Controls.Add(lblAgeCategory);
            Controls.Add(btnCheckAge);
            Controls.Add(txtAge);
            Name = "FormAge";
            Text = "FormAge";
            Load += FormAge_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAge;
        private Button btnCheckAge;
        private Label lblAgeCategory;
    }
}