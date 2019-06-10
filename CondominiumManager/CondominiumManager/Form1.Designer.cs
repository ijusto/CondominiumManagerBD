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
            this.fractionselector = new System.Windows.Forms.ComboBox();
            this.createquotabutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wich fraction do you wish to create an invoice?";
            // 
            // fractionselector
            // 
            this.fractionselector.FormattingEnabled = true;
            this.fractionselector.Location = new System.Drawing.Point(102, 48);
            this.fractionselector.Name = "fractionselector";
            this.fractionselector.Size = new System.Drawing.Size(165, 21);
            this.fractionselector.TabIndex = 1;
            // 
            // createquotabutton
            // 
            this.createquotabutton.Location = new System.Drawing.Point(143, 89);
            this.createquotabutton.Name = "createquotabutton";
            this.createquotabutton.Size = new System.Drawing.Size(75, 23);
            this.createquotabutton.TabIndex = 2;
            this.createquotabutton.Text = "Create";
            this.createquotabutton.UseVisualStyleBackColor = true;
            this.createquotabutton.Click += new System.EventHandler(this.createquotabutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 154);
            this.Controls.Add(this.createquotabutton);
            this.Controls.Add(this.fractionselector);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox fractionselector;
        private System.Windows.Forms.Button createquotabutton;
    }
}