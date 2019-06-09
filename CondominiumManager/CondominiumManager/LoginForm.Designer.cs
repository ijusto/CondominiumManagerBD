namespace CondominiumManager
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.tax_number_label = new System.Windows.Forms.Label();
            this.userinput = new System.Windows.Forms.TextBox();
            this.passwordinput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loginbutton = new System.Windows.Forms.Button();
            this.User_pictureBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.User_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tax_number_label
            // 
            this.tax_number_label.AutoSize = true;
            this.tax_number_label.Location = new System.Drawing.Point(161, 152);
            this.tax_number_label.Name = "tax_number_label";
            this.tax_number_label.Size = new System.Drawing.Size(81, 13);
            this.tax_number_label.TabIndex = 0;
            this.tax_number_label.Text = "TAX NUMBER:";
            // 
            // userinput
            // 
            this.userinput.Location = new System.Drawing.Point(245, 149);
            this.userinput.Name = "userinput";
            this.userinput.Size = new System.Drawing.Size(100, 20);
            this.userinput.TabIndex = 1;
            // 
            // passwordinput
            // 
            this.passwordinput.Location = new System.Drawing.Point(245, 200);
            this.passwordinput.Name = "passwordinput";
            this.passwordinput.PasswordChar = '*';
            this.passwordinput.Size = new System.Drawing.Size(100, 20);
            this.passwordinput.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "PASSWORD:";
            // 
            // loginbutton
            // 
            this.loginbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(146)))), ((int)(((byte)(202)))));
            this.loginbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.loginbutton.FlatAppearance.BorderSize = 0;
            this.loginbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginbutton.Location = new System.Drawing.Point(254, 274);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(75, 23);
            this.loginbutton.TabIndex = 4;
            this.loginbutton.Text = "LOGIN";
            this.loginbutton.UseVisualStyleBackColor = false;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // User_pictureBox
            // 
            this.User_pictureBox.BackgroundImage = global::CondominiumManager.Properties.Resources.condo_manager_app_icon_web;
            this.User_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.User_pictureBox.Location = new System.Drawing.Point(245, 23);
            this.User_pictureBox.Name = "User_pictureBox";
            this.User_pictureBox.Size = new System.Drawing.Size(100, 94);
            this.User_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.User_pictureBox.TabIndex = 5;
            this.User_pictureBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(376, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "*For DEMO Purposes - TAX NUMBER: \'250238280\'; PASSWORD: \'password\'";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(580, 365);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.User_pictureBox);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.passwordinput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userinput);
            this.Controls.Add(this.tax_number_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(596, 404);
            this.MinimumSize = new System.Drawing.Size(596, 404);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Condominium Manager Login";
            ((System.ComponentModel.ISupportInitialize)(this.User_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tax_number_label;
        private System.Windows.Forms.TextBox userinput;
        private System.Windows.Forms.TextBox passwordinput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.PictureBox User_pictureBox;
        private System.Windows.Forms.Label label3;
    }
}