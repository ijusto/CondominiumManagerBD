namespace CondominiumManager
{
    partial class ReadingsPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Back_button = new System.Windows.Forms.Button();
            this.apart_listBox = new System.Windows.Forms.ListBox();
            this.Apartments_textBox = new System.Windows.Forms.TextBox();
            this.Tenant_Name_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Back_button
            // 
            this.Back_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Back_button.BackColor = System.Drawing.SystemColors.Window;
            this.Back_button.BackgroundImage = global::CondominiumManager.Properties.Resources.back_icon_web;
            this.Back_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Back_button.FlatAppearance.BorderSize = 0;
            this.Back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_button.Location = new System.Drawing.Point(11, 1);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(30, 30);
            this.Back_button.TabIndex = 11;
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // apart_listBox
            // 
            this.apart_listBox.FormattingEnabled = true;
            this.apart_listBox.Location = new System.Drawing.Point(51, 70);
            this.apart_listBox.Name = "apart_listBox";
            this.apart_listBox.Size = new System.Drawing.Size(218, 238);
            this.apart_listBox.TabIndex = 12;
            // 
            // Apartments_textBox
            // 
            this.Apartments_textBox.BackColor = System.Drawing.Color.White;
            this.Apartments_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Apartments_textBox.Enabled = false;
            this.Apartments_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apartments_textBox.ForeColor = System.Drawing.Color.Black;
            this.Apartments_textBox.Location = new System.Drawing.Point(51, 48);
            this.Apartments_textBox.Name = "Apartments_textBox";
            this.Apartments_textBox.ReadOnly = true;
            this.Apartments_textBox.Size = new System.Drawing.Size(85, 16);
            this.Apartments_textBox.TabIndex = 13;
            this.Apartments_textBox.Text = "Apartments:";
            // 
            // Tenant_Name_textBox
            // 
            this.Tenant_Name_textBox.BackColor = System.Drawing.Color.White;
            this.Tenant_Name_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tenant_Name_textBox.Enabled = false;
            this.Tenant_Name_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tenant_Name_textBox.ForeColor = System.Drawing.Color.Black;
            this.Tenant_Name_textBox.Location = new System.Drawing.Point(300, 173);
            this.Tenant_Name_textBox.Name = "Tenant_Name_textBox";
            this.Tenant_Name_textBox.ReadOnly = true;
            this.Tenant_Name_textBox.Size = new System.Drawing.Size(93, 16);
            this.Tenant_Name_textBox.TabIndex = 14;
            this.Tenant_Name_textBox.Text = "Tenant name:";
            // 
            // ReadingsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Tenant_Name_textBox);
            this.Controls.Add(this.Apartments_textBox);
            this.Controls.Add(this.apart_listBox);
            this.Controls.Add(this.Back_button);
            this.MinimumSize = new System.Drawing.Size(580, 365);
            this.Name = "ReadingsPanel";
            this.Size = new System.Drawing.Size(580, 365);
            this.Load += new System.EventHandler(this.Readings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.ListBox apart_listBox;
        private System.Windows.Forms.TextBox Apartments_textBox;
        private System.Windows.Forms.TextBox Tenant_Name_textBox;
    }
}
