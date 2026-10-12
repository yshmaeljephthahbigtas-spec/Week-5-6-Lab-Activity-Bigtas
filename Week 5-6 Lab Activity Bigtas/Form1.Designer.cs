namespace Week_5_6_Lab_Activity_Bigtas
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
            label2 = new Label();
            lblSubtitle = new Label();
            cmbCategory = new ComboBox();
            cmbExample = new ComboBox();
            btnRun = new Button();
            btnClear = new Button();
            lstOutput = new ListBox();
            lblComplexity = new Label();
            lblDescription = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gold;
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(3, 9);
            label2.Name = "label2";
            label2.Size = new Size(969, 73);
            label2.TabIndex = 0;
            label2.Text = "BIG O VODOO";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.Transparent;
            lblSubtitle.Location = new Point(287, 82);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(387, 55);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "LETS GAMBLE AND Big-O VODONESS";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            lblSubtitle.Click += lblSubtitle_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(112, 172);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(121, 23);
            cmbCategory.TabIndex = 2;
            cmbCategory.Text = "Choose Category:";
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // cmbExample
            // 
            cmbExample.FormattingEnabled = true;
            cmbExample.Location = new Point(527, 172);
            cmbExample.Name = "cmbExample";
            cmbExample.Size = new Size(121, 23);
            cmbExample.TabIndex = 3;
            cmbExample.Text = "Choose Example:";
            // 
            // btnRun
            // 
            btnRun.FlatStyle = FlatStyle.Flat;
            btnRun.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRun.ForeColor = Color.Gold;
            btnRun.Location = new Point(113, 234);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(75, 34);
            btnRun.TabIndex = 4;
            btnRun.Text = "RUN ";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // btnClear
            // 
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.Gold;
            btnClear.Location = new Point(527, 234);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(118, 34);
            btnClear.TabIndex = 5;
            btnClear.Text = "CLEAR OUTPUT";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lstOutput
            // 
            lstOutput.BackColor = Color.FromArgb(20, 20, 25);
            lstOutput.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstOutput.ForeColor = Color.White;
            lstOutput.FormattingEnabled = true;
            lstOutput.Location = new Point(112, 283);
            lstOutput.Name = "lstOutput";
            lstOutput.Size = new Size(595, 220);
            lstOutput.TabIndex = 6;
            // 
            // lblComplexity
            // 
            lblComplexity.AutoSize = true;
            lblComplexity.ForeColor = Color.Gold;
            lblComplexity.Location = new Point(12, 527);
            lblComplexity.Name = "lblComplexity";
            lblComplexity.Size = new Size(71, 15);
            lblComplexity.TabIndex = 7;
            lblComplexity.Text = "Complexity:";
            // 
            // lblDescription
            // 
            lblDescription.ForeColor = Color.Gold;
            lblDescription.Location = new Point(12, 559);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(189, 23);
            lblDescription.TabIndex = 8;
            lblDescription.Text = "Select an example and press Run.";
            lblDescription.Click += lblDescription_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 40);
            ClientSize = new Size(984, 611);
            Controls.Add(lblDescription);
            Controls.Add(lblComplexity);
            Controls.Add(lstOutput);
            Controls.Add(btnClear);
            Controls.Add(btnRun);
            Controls.Add(cmbExample);
            Controls.Add(cmbCategory);
            Controls.Add(lblSubtitle);
            Controls.Add(label2);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BIG O VODOO";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label lblSubtitle;
        private ComboBox cmbCategory;
        private ComboBox cmbExample;
        private Button btnRun;
        private Button btnClear;
        private ListBox lstOutput;
        private Label lblComplexity;
        private Label lblDescription;
    }
}
