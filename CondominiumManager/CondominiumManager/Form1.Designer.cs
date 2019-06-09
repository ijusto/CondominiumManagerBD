namespace CondominiumManager
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
            this.label1 = new System.Windows.Forms.Label();
            this.userinput = new System.Windows.Forms.TextBox();
            this.passwordinput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loginbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIF:";
            // 
            // userinput
            // 
            this.userinput.Location = new System.Drawing.Point(311, 121);
            this.userinput.Name = "userinput";
            this.userinput.Size = new System.Drawing.Size(100, 20);
            this.userinput.TabIndex = 1;
            // 
            // passwordinput
            // 
            this.passwordinput.Location = new System.Drawing.Point(311, 159);
            this.passwordinput.Name = "passwordinput";
            this.passwordinput.PasswordChar = '*';
            this.passwordinput.Size = new System.Drawing.Size(100, 20);
            this.passwordinput.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "PASSWORD:";
            // 
            // loginbutton
            // 
            this.loginbutton.Location = new System.Drawing.Point(311, 230);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(75, 23);
            this.loginbutton.TabIndex = 4;
            this.loginbutton.Text = "LOGIN";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.passwordinput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userinput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userinput;
        private System.Windows.Forms.TextBox passwordinput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginbutton;
    }
}