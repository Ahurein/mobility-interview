namespace PrimeNumbers
{
    partial class Prime
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
            this.listOne = new System.Windows.Forms.ListBox();
            this.listTwo = new System.Windows.Forms.ListBox();
            this.textBoxOne = new System.Windows.Forms.TextBox();
            this.textBoxTwo = new System.Windows.Forms.TextBox();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.buttonOne = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listOne
            // 
            this.listOne.FormattingEnabled = true;
            this.listOne.Location = new System.Drawing.Point(71, 124);
            this.listOne.Name = "listOne";
            this.listOne.Size = new System.Drawing.Size(168, 394);
            this.listOne.TabIndex = 0;
            this.listOne.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listTwo
            // 
            this.listTwo.FormattingEnabled = true;
            this.listTwo.Location = new System.Drawing.Point(556, 124);
            this.listTwo.Name = "listTwo";
            this.listTwo.Size = new System.Drawing.Size(168, 394);
            this.listTwo.TabIndex = 1;
            // 
            // textBoxOne
            // 
            this.textBoxOne.Location = new System.Drawing.Point(71, 68);
            this.textBoxOne.Name = "textBoxOne";
            this.textBoxOne.Size = new System.Drawing.Size(168, 20);
            this.textBoxOne.TabIndex = 4;
            // 
            // textBoxTwo
            // 
            this.textBoxTwo.Location = new System.Drawing.Point(556, 68);
            this.textBoxTwo.Name = "textBoxTwo";
            this.textBoxTwo.Size = new System.Drawing.Size(168, 20);
            this.textBoxTwo.TabIndex = 5;
            // 
            // buttonTwo
            // 
            this.buttonTwo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonTwo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTwo.Location = new System.Drawing.Point(592, 581);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.buttonTwo.Size = new System.Drawing.Size(90, 46);
            this.buttonTwo.TabIndex = 6;
            this.buttonTwo.Text = "Generate";
            this.buttonTwo.UseVisualStyleBackColor = false;
            this.buttonTwo.Click += new System.EventHandler(this.buttonTwo_Click);
            // 
            // buttonOne
            // 
            this.buttonOne.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonOne.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOne.Location = new System.Drawing.Point(102, 581);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.buttonOne.Size = new System.Drawing.Size(90, 46);
            this.buttonOne.TabIndex = 7;
            this.buttonOne.Text = "Generate";
            this.buttonOne.UseVisualStyleBackColor = false;
            this.buttonOne.Click += new System.EventHandler(this.buttonOne_Click);
            // 
            // Prime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 692);
            this.Controls.Add(this.buttonOne);
            this.Controls.Add(this.buttonTwo);
            this.Controls.Add(this.textBoxTwo);
            this.Controls.Add(this.textBoxOne);
            this.Controls.Add(this.listTwo);
            this.Controls.Add(this.listOne);
            this.Name = "Prime";
            this.Text = "Prime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listOne;
        private System.Windows.Forms.ListBox listTwo;
        private System.Windows.Forms.TextBox textBoxOne;
        private System.Windows.Forms.TextBox textBoxTwo;
        private System.Windows.Forms.Button buttonTwo;
        private System.Windows.Forms.Button buttonOne;
    }
}

