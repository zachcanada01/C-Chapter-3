namespace EggsInteractive
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
            this.chickenPrompt1 = new System.Windows.Forms.Label();
            this.chickenPrompt2 = new System.Windows.Forms.Label();
            this.chickenPrompt3 = new System.Windows.Forms.Label();
            this.chickenPrompt4 = new System.Windows.Forms.Label();
            this.chickenPrompt5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.eggAmount1 = new System.Windows.Forms.TextBox();
            this.eggAmount2 = new System.Windows.Forms.TextBox();
            this.eggAmount3 = new System.Windows.Forms.TextBox();
            this.eggAmount4 = new System.Windows.Forms.TextBox();
            this.eggAmount5 = new System.Windows.Forms.TextBox();
            this.calculateEggs = new System.Windows.Forms.Button();
            this.totalAmountOfEggs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chickenPrompt1
            // 
            this.chickenPrompt1.AutoSize = true;
            this.chickenPrompt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chickenPrompt1.Location = new System.Drawing.Point(55, 41);
            this.chickenPrompt1.Name = "chickenPrompt1";
            this.chickenPrompt1.Size = new System.Drawing.Size(57, 15);
            this.chickenPrompt1.TabIndex = 0;
            this.chickenPrompt1.Text = "Chicken 1";
            // 
            // chickenPrompt2
            // 
            this.chickenPrompt2.AutoSize = true;
            this.chickenPrompt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chickenPrompt2.Location = new System.Drawing.Point(55, 68);
            this.chickenPrompt2.Name = "chickenPrompt2";
            this.chickenPrompt2.Size = new System.Drawing.Size(57, 15);
            this.chickenPrompt2.TabIndex = 1;
            this.chickenPrompt2.Text = "Chicken 2";
            this.chickenPrompt2.Click += new System.EventHandler(this.label2_Click);
            // 
            // chickenPrompt3
            // 
            this.chickenPrompt3.AutoSize = true;
            this.chickenPrompt3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chickenPrompt3.Location = new System.Drawing.Point(55, 93);
            this.chickenPrompt3.Name = "chickenPrompt3";
            this.chickenPrompt3.Size = new System.Drawing.Size(57, 15);
            this.chickenPrompt3.TabIndex = 2;
            this.chickenPrompt3.Text = "Chicken 3";
            // 
            // chickenPrompt4
            // 
            this.chickenPrompt4.AutoSize = true;
            this.chickenPrompt4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chickenPrompt4.Location = new System.Drawing.Point(55, 119);
            this.chickenPrompt4.Name = "chickenPrompt4";
            this.chickenPrompt4.Size = new System.Drawing.Size(57, 15);
            this.chickenPrompt4.TabIndex = 3;
            this.chickenPrompt4.Text = "Chicken 4";
            // 
            // chickenPrompt5
            // 
            this.chickenPrompt5.AutoSize = true;
            this.chickenPrompt5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chickenPrompt5.Location = new System.Drawing.Point(55, 144);
            this.chickenPrompt5.Name = "chickenPrompt5";
            this.chickenPrompt5.Size = new System.Drawing.Size(57, 15);
            this.chickenPrompt5.TabIndex = 4;
            this.chickenPrompt5.Text = "Chicken 5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Please enter the amount of eggs each chicken has produced.";
            // 
            // eggAmount1
            // 
            this.eggAmount1.Location = new System.Drawing.Point(132, 38);
            this.eggAmount1.Name = "eggAmount1";
            this.eggAmount1.Size = new System.Drawing.Size(100, 20);
            this.eggAmount1.TabIndex = 6;
            // 
            // eggAmount2
            // 
            this.eggAmount2.Location = new System.Drawing.Point(132, 65);
            this.eggAmount2.Name = "eggAmount2";
            this.eggAmount2.Size = new System.Drawing.Size(100, 20);
            this.eggAmount2.TabIndex = 7;
            // 
            // eggAmount3
            // 
            this.eggAmount3.Location = new System.Drawing.Point(132, 90);
            this.eggAmount3.Name = "eggAmount3";
            this.eggAmount3.Size = new System.Drawing.Size(100, 20);
            this.eggAmount3.TabIndex = 8;
            // 
            // eggAmount4
            // 
            this.eggAmount4.Location = new System.Drawing.Point(132, 116);
            this.eggAmount4.Name = "eggAmount4";
            this.eggAmount4.Size = new System.Drawing.Size(100, 20);
            this.eggAmount4.TabIndex = 9;
            // 
            // eggAmount5
            // 
            this.eggAmount5.Location = new System.Drawing.Point(132, 141);
            this.eggAmount5.Name = "eggAmount5";
            this.eggAmount5.Size = new System.Drawing.Size(100, 20);
            this.eggAmount5.TabIndex = 10;
            // 
            // calculateEggs
            // 
            this.calculateEggs.Location = new System.Drawing.Point(270, 36);
            this.calculateEggs.Name = "calculateEggs";
            this.calculateEggs.Size = new System.Drawing.Size(75, 23);
            this.calculateEggs.TabIndex = 11;
            this.calculateEggs.Text = "Calculate Eggs";
            this.calculateEggs.UseVisualStyleBackColor = true;
            // 
            // totalAmountOfEggs
            // 
            this.totalAmountOfEggs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalAmountOfEggs.Location = new System.Drawing.Point(270, 65);
            this.totalAmountOfEggs.Name = "totalAmountOfEggs";
            this.totalAmountOfEggs.Size = new System.Drawing.Size(121, 37);
            this.totalAmountOfEggs.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.totalAmountOfEggs);
            this.Controls.Add(this.calculateEggs);
            this.Controls.Add(this.eggAmount5);
            this.Controls.Add(this.eggAmount4);
            this.Controls.Add(this.eggAmount3);
            this.Controls.Add(this.eggAmount2);
            this.Controls.Add(this.eggAmount1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chickenPrompt5);
            this.Controls.Add(this.chickenPrompt4);
            this.Controls.Add(this.chickenPrompt3);
            this.Controls.Add(this.chickenPrompt2);
            this.Controls.Add(this.chickenPrompt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chickenPrompt1;
        private System.Windows.Forms.Label chickenPrompt2;
        private System.Windows.Forms.Label chickenPrompt3;
        private System.Windows.Forms.Label chickenPrompt4;
        private System.Windows.Forms.Label chickenPrompt5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox eggAmount1;
        private System.Windows.Forms.TextBox eggAmount2;
        private System.Windows.Forms.TextBox eggAmount3;
        private System.Windows.Forms.TextBox eggAmount4;
        private System.Windows.Forms.TextBox eggAmount5;
        private System.Windows.Forms.Button calculateEggs;
        private System.Windows.Forms.Label totalAmountOfEggs;
    }
}

