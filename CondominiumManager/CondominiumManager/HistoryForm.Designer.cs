namespace CondominiumManager
{
    partial class HistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryForm));
            this.Back_button = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
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
            this.Back_button.Location = new System.Drawing.Point(0, 0);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(30, 30);
            this.Back_button.TabIndex = 22;
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(58, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(482, 264);
            this.listBox1.TabIndex = 23;
            // 
            // HistoryForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(580, 365);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Back_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(596, 404);
            this.MinimumSize = new System.Drawing.Size(596, 404);
            this.Name = "HistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HistoryForm";
            this.Load += new System.EventHandler(this.HistoryForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.ListBox listBox1;
    }
}