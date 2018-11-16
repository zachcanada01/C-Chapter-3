namespace PayRoll
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
            this.prompt = new System.Windows.Forms.Label();
            this.employee = new System.Windows.Forms.Label();
            this.ssn = new System.Windows.Forms.Label();
            this.hpr = new System.Windows.Forms.Label();
            this.hoursWorked = new System.Windows.Forms.Label();
            this.enterName = new System.Windows.Forms.TextBox();
            this.enterSocialSecurity = new System.Windows.Forms.TextBox();
            this.enterHourlyPay = new System.Windows.Forms.TextBox();
            this.enterHoursWorked = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prompt
            // 
            this.prompt.AutoSize = true;
            this.prompt.Location = new System.Drawing.Point(41, 13);
            this.prompt.Name = "prompt";
            this.prompt.Size = new System.Drawing.Size(216, 13);
            this.prompt.TabIndex = 0;
            this.prompt.Text = "Please enter the following information below.";
            // 
            // employee
            // 
            this.employee.AutoSize = true;
            this.employee.Location = new System.Drawing.Point(41, 66);
            this.employee.Name = "employee";
            this.employee.Size = new System.Drawing.Size(38, 13);
            this.employee.TabIndex = 1;
            this.employee.Text = "Name:";
            // 
            // ssn
            // 
            this.ssn.AutoSize = true;
            this.ssn.Location = new System.Drawing.Point(200, 66);
            this.ssn.Name = "ssn";
            this.ssn.Size = new System.Drawing.Size(32, 13);
            this.ssn.TabIndex = 2;
            this.ssn.Text = "SSN:";
            // 
            // hpr
            // 
            this.hpr.AutoSize = true;
            this.hpr.Location = new System.Drawing.Point(353, 66);
            this.hpr.Name = "hpr";
            this.hpr.Size = new System.Drawing.Size(87, 13);
            this.hpr.TabIndex = 3;
            this.hpr.Text = "Hourly Pay Rate:";
            // 
            // hoursWorked
            // 
            this.hoursWorked.AutoSize = true;
            this.hoursWorked.Location = new System.Drawing.Point(41, 119);
            this.hoursWorked.Name = "hoursWorked";
            this.hoursWorked.Size = new System.Drawing.Size(79, 13);
            this.hoursWorked.TabIndex = 4;
            this.hoursWorked.Text = "Hours Worked:";
            // 
            // enterName
            // 
            this.enterName.Location = new System.Drawing.Point(85, 63);
            this.enterName.Name = "enterName";
            this.enterName.Size = new System.Drawing.Size(100, 20);
            this.enterName.TabIndex = 5;
            this.enterName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // enterSocialSecurity
            // 
            this.enterSocialSecurity.Location = new System.Drawing.Point(238, 63);
            this.enterSocialSecurity.Name = "enterSocialSecurity";
            this.enterSocialSecurity.Size = new System.Drawing.Size(100, 20);
            this.enterSocialSecurity.TabIndex = 6;
            // 
            // enterHourlyPay
            // 
            this.enterHourlyPay.Location = new System.Drawing.Point(446, 63);
            this.enterHourlyPay.Name = "enterHourlyPay";
            this.enterHourlyPay.Size = new System.Drawing.Size(100, 20);
            this.enterHourlyPay.TabIndex = 7;
            this.enterHourlyPay.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // enterHoursWorked
            // 
            this.enterHoursWorked.Location = new System.Drawing.Point(126, 116);
            this.enterHoursWorked.Name = "enterHoursWorked";
            this.enterHoursWorked.Size = new System.Drawing.Size(100, 20);
            this.enterHoursWorked.TabIndex = 8;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(277, 114);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 9;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // result
            // 
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.result.Location = new System.Drawing.Point(375, 114);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(271, 86);
            this.result.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.enterHoursWorked);
            this.Controls.Add(this.enterHourlyPay);
            this.Controls.Add(this.enterSocialSecurity);
            this.Controls.Add(this.enterName);
            this.Controls.Add(this.hoursWorked);
            this.Controls.Add(this.hpr);
            this.Controls.Add(this.ssn);
            this.Controls.Add(this.employee);
            this.Controls.Add(this.prompt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label prompt;
        private System.Windows.Forms.Label employee;
        private System.Windows.Forms.Label ssn;
        private System.Windows.Forms.Label hpr;
        private System.Windows.Forms.Label hoursWorked;
        private System.Windows.Forms.TextBox enterName;
        private System.Windows.Forms.TextBox enterSocialSecurity;
        private System.Windows.Forms.TextBox enterHourlyPay;
        private System.Windows.Forms.TextBox enterHoursWorked;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label result;
    }
}

