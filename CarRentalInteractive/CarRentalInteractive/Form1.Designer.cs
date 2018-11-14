namespace CarRentalInteractive
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
            this.Prices = new System.Windows.Forms.Label();
            this.calculatePrice = new System.Windows.Forms.Button();
            this.miles = new System.Windows.Forms.TextBox();
            this.days = new System.Windows.Forms.TextBox();
            this.milesPrompt = new System.Windows.Forms.Label();
            this.daysPrompt = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Prices
            // 
            this.Prices.AutoSize = true;
            this.Prices.Location = new System.Drawing.Point(46, 40);
            this.Prices.Name = "Prices";
            this.Prices.Size = new System.Drawing.Size(315, 13);
            this.Prices.TabIndex = 0;
            this.Prices.Text = "The charge for renting a car is $20 per day and 25 cents per mile.";
            this.Prices.Click += new System.EventHandler(this.label1_Click);
            // 
            // calculatePrice
            // 
            this.calculatePrice.Location = new System.Drawing.Point(117, 145);
            this.calculatePrice.Name = "calculatePrice";
            this.calculatePrice.Size = new System.Drawing.Size(93, 24);
            this.calculatePrice.TabIndex = 1;
            this.calculatePrice.Text = "Calculate Price";
            this.calculatePrice.UseVisualStyleBackColor = true;
            this.calculatePrice.Click += new System.EventHandler(this.calculatePrice_Click);
            // 
            // miles
            // 
            this.miles.Location = new System.Drawing.Point(261, 106);
            this.miles.Name = "miles";
            this.miles.Size = new System.Drawing.Size(100, 20);
            this.miles.TabIndex = 2;
            // 
            // days
            // 
            this.days.Location = new System.Drawing.Point(261, 72);
            this.days.Name = "days";
            this.days.Size = new System.Drawing.Size(100, 20);
            this.days.TabIndex = 3;
            this.days.TextChanged += new System.EventHandler(this.days_TextChanged);
            // 
            // milesPrompt
            // 
            this.milesPrompt.AutoSize = true;
            this.milesPrompt.Location = new System.Drawing.Point(46, 113);
            this.milesPrompt.Name = "milesPrompt";
            this.milesPrompt.Size = new System.Drawing.Size(175, 13);
            this.milesPrompt.TabIndex = 4;
            this.milesPrompt.Text = "How many miles will you be driving?";
            this.milesPrompt.Click += new System.EventHandler(this.milesPrompt_Click);
            // 
            // daysPrompt
            // 
            this.daysPrompt.AutoSize = true;
            this.daysPrompt.Location = new System.Drawing.Point(46, 75);
            this.daysPrompt.Name = "daysPrompt";
            this.daysPrompt.Size = new System.Drawing.Size(206, 13);
            this.daysPrompt.TabIndex = 5;
            this.daysPrompt.Text = "How many days would you like to rent for?";
            // 
            // price
            // 
            this.price.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.price.Location = new System.Drawing.Point(261, 146);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(100, 23);
            this.price.TabIndex = 6;
            this.price.Click += new System.EventHandler(this.price_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.price);
            this.Controls.Add(this.daysPrompt);
            this.Controls.Add(this.milesPrompt);
            this.Controls.Add(this.days);
            this.Controls.Add(this.miles);
            this.Controls.Add(this.calculatePrice);
            this.Controls.Add(this.Prices);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Prices;
        private System.Windows.Forms.Button calculatePrice;
        private System.Windows.Forms.TextBox miles;
        private System.Windows.Forms.TextBox days;
        private System.Windows.Forms.Label milesPrompt;
        private System.Windows.Forms.Label daysPrompt;
        private System.Windows.Forms.Label price;
    }
}

