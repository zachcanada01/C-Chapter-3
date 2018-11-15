namespace TestInteractive
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
            this.test1 = new System.Windows.Forms.Label();
            this.test2 = new System.Windows.Forms.Label();
            this.test3 = new System.Windows.Forms.Label();
            this.test4 = new System.Windows.Forms.Label();
            this.test5 = new System.Windows.Forms.Label();
            this.answer1 = new System.Windows.Forms.TextBox();
            this.answer2 = new System.Windows.Forms.TextBox();
            this.answer3 = new System.Windows.Forms.TextBox();
            this.answer4 = new System.Windows.Forms.TextBox();
            this.answer5 = new System.Windows.Forms.TextBox();
            this.calculateAverage = new System.Windows.Forms.Button();
            this.averageTestScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prompt
            // 
            this.prompt.AutoSize = true;
            this.prompt.Location = new System.Drawing.Point(73, 48);
            this.prompt.Name = "prompt";
            this.prompt.Size = new System.Drawing.Size(242, 13);
            this.prompt.TabIndex = 0;
            this.prompt.Text = "Enter test scores here to calculate average score.";
            // 
            // test1
            // 
            this.test1.AutoSize = true;
            this.test1.Location = new System.Drawing.Point(73, 80);
            this.test1.Name = "test1";
            this.test1.Size = new System.Drawing.Size(37, 13);
            this.test1.TabIndex = 1;
            this.test1.Text = "Test 1";
            this.test1.Click += new System.EventHandler(this.label2_Click);
            // 
            // test2
            // 
            this.test2.AutoSize = true;
            this.test2.Location = new System.Drawing.Point(73, 113);
            this.test2.Name = "test2";
            this.test2.Size = new System.Drawing.Size(37, 13);
            this.test2.TabIndex = 2;
            this.test2.Text = "Text 2";
            // 
            // test3
            // 
            this.test3.AutoSize = true;
            this.test3.Location = new System.Drawing.Point(73, 148);
            this.test3.Name = "test3";
            this.test3.Size = new System.Drawing.Size(37, 13);
            this.test3.TabIndex = 3;
            this.test3.Text = "Test 3";
            // 
            // test4
            // 
            this.test4.AutoSize = true;
            this.test4.Location = new System.Drawing.Point(73, 183);
            this.test4.Name = "test4";
            this.test4.Size = new System.Drawing.Size(37, 13);
            this.test4.TabIndex = 4;
            this.test4.Text = "Test 4";
            // 
            // test5
            // 
            this.test5.AutoSize = true;
            this.test5.Location = new System.Drawing.Point(73, 219);
            this.test5.Name = "test5";
            this.test5.Size = new System.Drawing.Size(37, 13);
            this.test5.TabIndex = 5;
            this.test5.Text = "Test 5";
            // 
            // answer1
            // 
            this.answer1.Location = new System.Drawing.Point(151, 77);
            this.answer1.Name = "answer1";
            this.answer1.Size = new System.Drawing.Size(58, 20);
            this.answer1.TabIndex = 6;
            // 
            // answer2
            // 
            this.answer2.Location = new System.Drawing.Point(151, 110);
            this.answer2.Name = "answer2";
            this.answer2.Size = new System.Drawing.Size(58, 20);
            this.answer2.TabIndex = 7;
            // 
            // answer3
            // 
            this.answer3.Location = new System.Drawing.Point(151, 145);
            this.answer3.Name = "answer3";
            this.answer3.Size = new System.Drawing.Size(58, 20);
            this.answer3.TabIndex = 8;
            // 
            // answer4
            // 
            this.answer4.Location = new System.Drawing.Point(151, 180);
            this.answer4.Name = "answer4";
            this.answer4.Size = new System.Drawing.Size(58, 20);
            this.answer4.TabIndex = 9;
            // 
            // answer5
            // 
            this.answer5.Location = new System.Drawing.Point(151, 216);
            this.answer5.Name = "answer5";
            this.answer5.Size = new System.Drawing.Size(58, 20);
            this.answer5.TabIndex = 10;
            // 
            // calculateAverage
            // 
            this.calculateAverage.Location = new System.Drawing.Point(76, 247);
            this.calculateAverage.Name = "calculateAverage";
            this.calculateAverage.Size = new System.Drawing.Size(75, 23);
            this.calculateAverage.TabIndex = 11;
            this.calculateAverage.Text = "Calculate Average";
            this.calculateAverage.UseVisualStyleBackColor = true;
            this.calculateAverage.Click += new System.EventHandler(this.calculateAverage_Click);
            // 
            // averageTestScore
            // 
            this.averageTestScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.averageTestScore.Location = new System.Drawing.Point(157, 247);
            this.averageTestScore.Name = "averageTestScore";
            this.averageTestScore.Size = new System.Drawing.Size(52, 23);
            this.averageTestScore.TabIndex = 12;
            this.averageTestScore.Click += new System.EventHandler(this.averageTestScore_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.averageTestScore);
            this.Controls.Add(this.calculateAverage);
            this.Controls.Add(this.answer5);
            this.Controls.Add(this.answer4);
            this.Controls.Add(this.answer3);
            this.Controls.Add(this.answer2);
            this.Controls.Add(this.answer1);
            this.Controls.Add(this.test5);
            this.Controls.Add(this.test4);
            this.Controls.Add(this.test3);
            this.Controls.Add(this.test2);
            this.Controls.Add(this.test1);
            this.Controls.Add(this.prompt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label prompt;
        private System.Windows.Forms.Label test1;
        private System.Windows.Forms.Label test2;
        private System.Windows.Forms.Label test3;
        private System.Windows.Forms.Label test4;
        private System.Windows.Forms.Label test5;
        private System.Windows.Forms.TextBox answer1;
        private System.Windows.Forms.TextBox answer2;
        private System.Windows.Forms.TextBox answer3;
        private System.Windows.Forms.TextBox answer4;
        private System.Windows.Forms.TextBox answer5;
        private System.Windows.Forms.Button calculateAverage;
        private System.Windows.Forms.Label averageTestScore;
    }
}

