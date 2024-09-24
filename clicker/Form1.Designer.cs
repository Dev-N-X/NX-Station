namespace CookieClickerApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.buttonClickMe = new System.Windows.Forms.Button();
            this.labelCookies = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonClickMe
            // 
            this.buttonClickMe.Location = new System.Drawing.Point(14, 15);
            this.buttonClickMe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonClickMe.Name = "buttonClickMe";
            this.buttonClickMe.Size = new System.Drawing.Size(112, 38);
            this.buttonClickMe.TabIndex = 0;
            this.buttonClickMe.Text = "Click me!";
            this.buttonClickMe.UseVisualStyleBackColor = true;
            this.buttonClickMe.Click += new System.EventHandler(this.button_Click);
            // 
            // labelCookies
            // 
            this.labelCookies.AutoSize = true;
            this.labelCookies.Location = new System.Drawing.Point(14, 69);
            this.labelCookies.Name = "labelCookies";
            this.labelCookies.Size = new System.Drawing.Size(83, 20);
            this.labelCookies.TabIndex = 1;
            this.labelCookies.Text = "Cookies: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 306);
            this.Controls.Add(this.labelCookies);
            this.Controls.Add(this.buttonClickMe);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Cookie Clicker";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button buttonClickMe;
        private System.Windows.Forms.Label labelCookies;
    }
}
