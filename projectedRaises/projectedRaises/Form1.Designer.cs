namespace projectedRaises
{
    partial class Form1
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
            this.salaryPrompt = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.nextYearPrompt = new System.Windows.Forms.Label();
            this.salaryResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // salaryPrompt
            // 
            this.salaryPrompt.AutoSize = true;
            this.salaryPrompt.Location = new System.Drawing.Point(88, 57);
            this.salaryPrompt.Name = "salaryPrompt";
            this.salaryPrompt.Size = new System.Drawing.Size(138, 13);
            this.salaryPrompt.TabIndex = 0;
            this.salaryPrompt.Text = "What is your current salary?";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(227, 55);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 20);
            this.txtSalary.TabIndex = 1;
            this.txtSalary.TextChanged += new System.EventHandler(this.txtSalary_TextChanged);
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(123, 104);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(59, 23);
            this.Calculate.TabIndex = 2;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // nextYearPrompt
            // 
            this.nextYearPrompt.AutoSize = true;
            this.nextYearPrompt.Location = new System.Drawing.Point(178, 89);
            this.nextYearPrompt.Name = "nextYearPrompt";
            this.nextYearPrompt.Size = new System.Drawing.Size(119, 13);
            this.nextYearPrompt.TabIndex = 3;
            this.nextYearPrompt.Text = "Next years salary will be";
            // 
            // salaryResult
            // 
            this.salaryResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.salaryResult.Location = new System.Drawing.Point(188, 104);
            this.salaryResult.Name = "salaryResult";
            this.salaryResult.Size = new System.Drawing.Size(100, 23);
            this.salaryResult.TabIndex = 4;
            this.salaryResult.Click += new System.EventHandler(this.salaryResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.salaryResult);
            this.Controls.Add(this.nextYearPrompt);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.salaryPrompt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label salaryPrompt;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label nextYearPrompt;
        private System.Windows.Forms.Label salaryResult;
    }
}

