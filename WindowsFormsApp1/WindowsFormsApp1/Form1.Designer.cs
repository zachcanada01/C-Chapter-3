namespace WindowsFormsApp1
{
    partial class LastYearsComp
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
            this.miles = new System.Windows.Forms.Label();
            this.txtMiles = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.kilometersResult = new System.Windows.Forms.Label();
            this.kilometers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // miles
            // 
            this.miles.AutoSize = true;
            this.miles.Location = new System.Drawing.Point(12, 38);
            this.miles.Name = "miles";
            this.miles.Size = new System.Drawing.Size(258, 13);
            this.miles.TabIndex = 0;
            this.miles.Text = "How many miles have you traveled or will be traveling";
            this.miles.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMiles
            // 
            this.txtMiles.Location = new System.Drawing.Point(305, 35);
            this.txtMiles.Name = "txtMiles";
            this.txtMiles.Size = new System.Drawing.Size(100, 20);
            this.txtMiles.TabIndex = 2;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(96, 75);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 4;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // kilometersResult
            // 
            this.kilometersResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.kilometersResult.Location = new System.Drawing.Point(305, 75);
            this.kilometersResult.Name = "kilometersResult";
            this.kilometersResult.Size = new System.Drawing.Size(100, 23);
            this.kilometersResult.TabIndex = 5;
            this.kilometersResult.Click += new System.EventHandler(this.kilometersResult_Click);
            // 
            // kilometers
            // 
            this.kilometers.AutoSize = true;
            this.kilometers.Location = new System.Drawing.Point(241, 80);
            this.kilometers.Name = "kilometers";
            this.kilometers.Size = new System.Drawing.Size(55, 13);
            this.kilometers.TabIndex = 6;
            this.kilometers.Text = "Kilometers";
            // 
            // LastYearsComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kilometers);
            this.Controls.Add(this.kilometersResult);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.txtMiles);
            this.Controls.Add(this.miles);
            this.Name = "LastYearsComp";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label miles;
        private System.Windows.Forms.TextBox txtMiles;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label kilometersResult;
        private System.Windows.Forms.Label kilometers;
    }
}

