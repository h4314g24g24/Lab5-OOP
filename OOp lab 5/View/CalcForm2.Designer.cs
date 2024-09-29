namespace OOp_lab_5.View
{
    partial class CalcForm2
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
            txtNumber = new TextBox();
            btnGenerateTable = new Button();
            txtMultiplicationTable = new RichTextBox();
            SuspendLayout();
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(171, 74);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(125, 27);
            txtNumber.TabIndex = 0;
            // 
            // btnGenerateTable
            // 
            btnGenerateTable.Location = new Point(171, 147);
            btnGenerateTable.Name = "btnGenerateTable";
            btnGenerateTable.Size = new Size(94, 29);
            btnGenerateTable.TabIndex = 1;
            btnGenerateTable.Text = "button1";
            btnGenerateTable.UseVisualStyleBackColor = true;
            btnGenerateTable.Click += btnGenerateTable_Click;
            // 
            // txtMultiplicationTable
            // 
            txtMultiplicationTable.Location = new Point(171, 215);
            txtMultiplicationTable.Name = "txtMultiplicationTable";
            txtMultiplicationTable.Size = new Size(172, 167);
            txtMultiplicationTable.TabIndex = 3;
            txtMultiplicationTable.Text = "";
            // 
            // CalcForm2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtMultiplicationTable);
            Controls.Add(btnGenerateTable);
            Controls.Add(txtNumber);
            Name = "CalcForm2";
            Text = "CalcForm2";
            Load += CalcForm2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumber;
        private Button btnGenerateTable;
        private RichTextBox txtMultiplicationTable;
    }
}