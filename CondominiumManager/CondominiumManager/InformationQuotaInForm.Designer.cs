namespace CondominiumManager
{
    partial class InformationQuotaInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformationQuotaInForm));
            this.label1 = new System.Windows.Forms.Label();
            this.fractionselector = new System.Windows.Forms.ComboBox();
            this.createquotabutton = new System.Windows.Forms.Button();
            this.Desc_input_quota_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wich fraction do you wish to create an invoice?";
            // 
            // fractionselector
            // 
            this.fractionselector.FormattingEnabled = true;
            this.fractionselector.Location = new System.Drawing.Point(101, 35);
            this.fractionselector.Name = "fractionselector";
            this.fractionselector.Size = new System.Drawing.Size(165, 21);
            this.fractionselector.TabIndex = 1;
            // 
            // createquotabutton
            // 
            this.createquotabutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(146)))), ((int)(((byte)(202)))));
            this.createquotabutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createquotabutton.ForeColor = System.Drawing.Color.White;
            this.createquotabutton.Location = new System.Drawing.Point(147, 127);
            this.createquotabutton.Name = "createquotabutton";
            this.createquotabutton.Size = new System.Drawing.Size(75, 23);
            this.createquotabutton.TabIndex = 2;
            this.createquotabutton.Text = "Create";
            this.createquotabutton.UseVisualStyleBackColor = false;
            this.createquotabutton.Click += new System.EventHandler(this.createquotabutton_Click);
            // 
            // Desc_input_quota_textBox
            // 
            this.Desc_input_quota_textBox.Location = new System.Drawing.Point(101, 81);
            this.Desc_input_quota_textBox.Multiline = true;
            this.Desc_input_quota_textBox.Name = "Desc_input_quota_textBox";
            this.Desc_input_quota_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Desc_input_quota_textBox.Size = new System.Drawing.Size(165, 40);
            this.Desc_input_quota_textBox.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "Description:";
            // 
            // InformationQuotaInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(370, 154);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Desc_input_quota_textBox);
            this.Controls.Add(this.createquotabutton);
            this.Controls.Add(this.fractionselector);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(386, 193);
            this.MinimumSize = new System.Drawing.Size(386, 193);
            this.Name = "InformationQuotaInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Information required";
            this.Load += new System.EventHandler(this.InformationQuotaInForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox fractionselector;
        private System.Windows.Forms.Button createquotabutton;
        private System.Windows.Forms.TextBox Desc_input_quota_textBox;
        private System.Windows.Forms.Label label2;
    }
}