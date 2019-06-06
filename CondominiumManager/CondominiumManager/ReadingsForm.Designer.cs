namespace CondominiumManager
{
    partial class ReadingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadingsForm));
            this.Tenant_Name_textBox = new System.Windows.Forms.TextBox();
            this.Apartments_textBox = new System.Windows.Forms.TextBox();
            this.apart_listBox = new System.Windows.Forms.ListBox();
            this.Back_button = new System.Windows.Forms.Button();
            this.Mobile_input_textBox = new System.Windows.Forms.TextBox();
            this.Mobile_textBox = new System.Windows.Forms.TextBox();
            this.Tenant_Name_input_textBox = new System.Windows.Forms.TextBox();
            this.Water_input_textBox = new System.Windows.Forms.TextBox();
            this.Water_textBox = new System.Windows.Forms.TextBox();
            this.Light_input_textBox = new System.Windows.Forms.TextBox();
            this.Light_textBox = new System.Windows.Forms.TextBox();
            this.Gas_input_textBox = new System.Windows.Forms.TextBox();
            this.Gas_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Tenant_Name_textBox
            // 
            this.Tenant_Name_textBox.BackColor = System.Drawing.Color.White;
            this.Tenant_Name_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tenant_Name_textBox.Enabled = false;
            this.Tenant_Name_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tenant_Name_textBox.ForeColor = System.Drawing.Color.Black;
            this.Tenant_Name_textBox.Location = new System.Drawing.Point(290, 70);
            this.Tenant_Name_textBox.Name = "Tenant_Name_textBox";
            this.Tenant_Name_textBox.ReadOnly = true;
            this.Tenant_Name_textBox.Size = new System.Drawing.Size(93, 16);
            this.Tenant_Name_textBox.TabIndex = 18;
            this.Tenant_Name_textBox.Text = "Tenant name:";
            // 
            // Apartments_textBox
            // 
            this.Apartments_textBox.BackColor = System.Drawing.Color.White;
            this.Apartments_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Apartments_textBox.Enabled = false;
            this.Apartments_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apartments_textBox.ForeColor = System.Drawing.Color.Black;
            this.Apartments_textBox.Location = new System.Drawing.Point(41, 48);
            this.Apartments_textBox.Name = "Apartments_textBox";
            this.Apartments_textBox.ReadOnly = true;
            this.Apartments_textBox.Size = new System.Drawing.Size(85, 16);
            this.Apartments_textBox.TabIndex = 17;
            this.Apartments_textBox.Text = "Apartments:";
            // 
            // apart_listBox
            // 
            this.apart_listBox.FormattingEnabled = true;
            this.apart_listBox.Location = new System.Drawing.Point(41, 70);
            this.apart_listBox.Name = "apart_listBox";
            this.apart_listBox.Size = new System.Drawing.Size(218, 238);
            this.apart_listBox.TabIndex = 16;
            this.apart_listBox.SelectedIndexChanged += new System.EventHandler(this.Apart_listBox_SelectedIndexChanged);
            // 
            // Back_button
            // 
            this.Back_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Back_button.BackColor = System.Drawing.SystemColors.Window;
            this.Back_button.BackgroundImage = global::CondominiumManager.Properties.Resources.back_icon_web;
            this.Back_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Back_button.FlatAppearance.BorderSize = 0;
            this.Back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_button.Location = new System.Drawing.Point(1, 1);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(30, 30);
            this.Back_button.TabIndex = 15;
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Mobile_input_textBox
            // 
            this.Mobile_input_textBox.Location = new System.Drawing.Point(290, 143);
            this.Mobile_input_textBox.Name = "Mobile_input_textBox";
            this.Mobile_input_textBox.Size = new System.Drawing.Size(229, 20);
            this.Mobile_input_textBox.TabIndex = 47;
            // 
            // Mobile_textBox
            // 
            this.Mobile_textBox.BackColor = System.Drawing.Color.White;
            this.Mobile_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Mobile_textBox.Enabled = false;
            this.Mobile_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mobile_textBox.ForeColor = System.Drawing.Color.Black;
            this.Mobile_textBox.Location = new System.Drawing.Point(290, 121);
            this.Mobile_textBox.Name = "Mobile_textBox";
            this.Mobile_textBox.ReadOnly = true;
            this.Mobile_textBox.Size = new System.Drawing.Size(60, 16);
            this.Mobile_textBox.TabIndex = 46;
            this.Mobile_textBox.Text = "Mobile:";
            // 
            // Tenant_Name_input_textBox
            // 
            this.Tenant_Name_input_textBox.Location = new System.Drawing.Point(290, 95);
            this.Tenant_Name_input_textBox.Name = "Tenant_Name_input_textBox";
            this.Tenant_Name_input_textBox.Size = new System.Drawing.Size(229, 20);
            this.Tenant_Name_input_textBox.TabIndex = 48;
            // 
            // Water_input_textBox
            // 
            this.Water_input_textBox.Location = new System.Drawing.Point(290, 192);
            this.Water_input_textBox.Name = "Water_input_textBox";
            this.Water_input_textBox.Size = new System.Drawing.Size(229, 20);
            this.Water_input_textBox.TabIndex = 50;
            // 
            // Water_textBox
            // 
            this.Water_textBox.BackColor = System.Drawing.Color.White;
            this.Water_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Water_textBox.Enabled = false;
            this.Water_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Water_textBox.ForeColor = System.Drawing.Color.Black;
            this.Water_textBox.Location = new System.Drawing.Point(290, 170);
            this.Water_textBox.Name = "Water_textBox";
            this.Water_textBox.ReadOnly = true;
            this.Water_textBox.Size = new System.Drawing.Size(60, 16);
            this.Water_textBox.TabIndex = 49;
            this.Water_textBox.Text = "Water:";
            // 
            // Light_input_textBox
            // 
            this.Light_input_textBox.Location = new System.Drawing.Point(290, 240);
            this.Light_input_textBox.Name = "Light_input_textBox";
            this.Light_input_textBox.Size = new System.Drawing.Size(229, 20);
            this.Light_input_textBox.TabIndex = 52;
            // 
            // Light_textBox
            // 
            this.Light_textBox.BackColor = System.Drawing.Color.White;
            this.Light_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Light_textBox.Enabled = false;
            this.Light_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Light_textBox.ForeColor = System.Drawing.Color.Black;
            this.Light_textBox.Location = new System.Drawing.Point(290, 218);
            this.Light_textBox.Name = "Light_textBox";
            this.Light_textBox.ReadOnly = true;
            this.Light_textBox.Size = new System.Drawing.Size(60, 16);
            this.Light_textBox.TabIndex = 51;
            this.Light_textBox.Text = "Light:";
            // 
            // Gas_input_textBox
            // 
            this.Gas_input_textBox.Location = new System.Drawing.Point(290, 288);
            this.Gas_input_textBox.Name = "Gas_input_textBox";
            this.Gas_input_textBox.Size = new System.Drawing.Size(229, 20);
            this.Gas_input_textBox.TabIndex = 54;
            // 
            // Gas_textBox
            // 
            this.Gas_textBox.BackColor = System.Drawing.Color.White;
            this.Gas_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Gas_textBox.Enabled = false;
            this.Gas_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gas_textBox.ForeColor = System.Drawing.Color.Black;
            this.Gas_textBox.Location = new System.Drawing.Point(290, 266);
            this.Gas_textBox.Name = "Gas_textBox";
            this.Gas_textBox.ReadOnly = true;
            this.Gas_textBox.Size = new System.Drawing.Size(60, 16);
            this.Gas_textBox.TabIndex = 53;
            this.Gas_textBox.Text = "Gas:";
            // 
            // ReadingsForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(580, 365);
            this.Controls.Add(this.Gas_input_textBox);
            this.Controls.Add(this.Gas_textBox);
            this.Controls.Add(this.Light_input_textBox);
            this.Controls.Add(this.Light_textBox);
            this.Controls.Add(this.Water_input_textBox);
            this.Controls.Add(this.Water_textBox);
            this.Controls.Add(this.Tenant_Name_input_textBox);
            this.Controls.Add(this.Mobile_input_textBox);
            this.Controls.Add(this.Mobile_textBox);
            this.Controls.Add(this.Tenant_Name_textBox);
            this.Controls.Add(this.Apartments_textBox);
            this.Controls.Add(this.apart_listBox);
            this.Controls.Add(this.Back_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(580, 365);
            this.Name = "ReadingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CondominiumManager";
            this.Load += new System.EventHandler(this.ReadingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tenant_Name_textBox;
        private System.Windows.Forms.TextBox Apartments_textBox;
        private System.Windows.Forms.ListBox apart_listBox;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.TextBox Mobile_input_textBox;
        private System.Windows.Forms.TextBox Mobile_textBox;
        private System.Windows.Forms.TextBox Tenant_Name_input_textBox;
        private System.Windows.Forms.TextBox Water_input_textBox;
        private System.Windows.Forms.TextBox Water_textBox;
        private System.Windows.Forms.TextBox Light_input_textBox;
        private System.Windows.Forms.TextBox Light_textBox;
        private System.Windows.Forms.TextBox Gas_input_textBox;
        private System.Windows.Forms.TextBox Gas_textBox;
    }
}