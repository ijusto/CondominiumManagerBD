namespace CondominiumManager
{
    partial class TaskListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskListForm));
            this.Tenant_input_textBox = new System.Windows.Forms.TextBox();
            this.Back_button = new System.Windows.Forms.Button();
            this.Description_input_textBox = new System.Windows.Forms.TextBox();
            this.Description_textBox = new System.Windows.Forms.TextBox();
            this.Address_input_textBox = new System.Windows.Forms.TextBox();
            this.Address_textBox = new System.Windows.Forms.TextBox();
            this.Tenant_textBox = new System.Windows.Forms.TextBox();
            this.Date_input_textBox = new System.Windows.Forms.TextBox();
            this.Date_textBox = new System.Windows.Forms.TextBox();
            this.Complaints_textBox = new System.Windows.Forms.TextBox();
            this.TasklistBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Tenant_input_textBox
            // 
            this.Tenant_input_textBox.Location = new System.Drawing.Point(346, 108);
            this.Tenant_input_textBox.Name = "Tenant_input_textBox";
            this.Tenant_input_textBox.Size = new System.Drawing.Size(194, 20);
            this.Tenant_input_textBox.TabIndex = 22;
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
            this.Back_button.TabIndex = 21;
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Description_input_textBox
            // 
            this.Description_input_textBox.Location = new System.Drawing.Point(346, 181);
            this.Description_input_textBox.Multiline = true;
            this.Description_input_textBox.Name = "Description_input_textBox";
            this.Description_input_textBox.Size = new System.Drawing.Size(194, 141);
            this.Description_input_textBox.TabIndex = 20;
            // 
            // Description_textBox
            // 
            this.Description_textBox.BackColor = System.Drawing.Color.White;
            this.Description_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Description_textBox.Enabled = false;
            this.Description_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description_textBox.ForeColor = System.Drawing.Color.Black;
            this.Description_textBox.Location = new System.Drawing.Point(252, 185);
            this.Description_textBox.Name = "Description_textBox";
            this.Description_textBox.ReadOnly = true;
            this.Description_textBox.Size = new System.Drawing.Size(78, 16);
            this.Description_textBox.TabIndex = 19;
            this.Description_textBox.Text = "Description:";
            // 
            // Address_input_textBox
            // 
            this.Address_input_textBox.Location = new System.Drawing.Point(346, 145);
            this.Address_input_textBox.Name = "Address_input_textBox";
            this.Address_input_textBox.Size = new System.Drawing.Size(194, 20);
            this.Address_input_textBox.TabIndex = 18;
            // 
            // Address_textBox
            // 
            this.Address_textBox.BackColor = System.Drawing.Color.White;
            this.Address_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Address_textBox.Enabled = false;
            this.Address_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address_textBox.ForeColor = System.Drawing.Color.Black;
            this.Address_textBox.Location = new System.Drawing.Point(252, 149);
            this.Address_textBox.Name = "Address_textBox";
            this.Address_textBox.ReadOnly = true;
            this.Address_textBox.Size = new System.Drawing.Size(61, 16);
            this.Address_textBox.TabIndex = 17;
            this.Address_textBox.Text = "Address:";
            // 
            // Tenant_textBox
            // 
            this.Tenant_textBox.BackColor = System.Drawing.Color.White;
            this.Tenant_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tenant_textBox.Enabled = false;
            this.Tenant_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tenant_textBox.ForeColor = System.Drawing.Color.Black;
            this.Tenant_textBox.Location = new System.Drawing.Point(252, 112);
            this.Tenant_textBox.Name = "Tenant_textBox";
            this.Tenant_textBox.ReadOnly = true;
            this.Tenant_textBox.Size = new System.Drawing.Size(61, 16);
            this.Tenant_textBox.TabIndex = 16;
            this.Tenant_textBox.Text = "Tenant:";
            // 
            // Date_input_textBox
            // 
            this.Date_input_textBox.Location = new System.Drawing.Point(346, 68);
            this.Date_input_textBox.Name = "Date_input_textBox";
            this.Date_input_textBox.Size = new System.Drawing.Size(89, 20);
            this.Date_input_textBox.TabIndex = 15;
            // 
            // Date_textBox
            // 
            this.Date_textBox.BackColor = System.Drawing.Color.White;
            this.Date_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Date_textBox.Enabled = false;
            this.Date_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_textBox.ForeColor = System.Drawing.Color.Black;
            this.Date_textBox.Location = new System.Drawing.Point(252, 72);
            this.Date_textBox.Name = "Date_textBox";
            this.Date_textBox.ReadOnly = true;
            this.Date_textBox.Size = new System.Drawing.Size(37, 16);
            this.Date_textBox.TabIndex = 14;
            this.Date_textBox.Text = "Date\r\n:";
            // 
            // Complaints_textBox
            // 
            this.Complaints_textBox.BackColor = System.Drawing.Color.White;
            this.Complaints_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Complaints_textBox.Enabled = false;
            this.Complaints_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Complaints_textBox.ForeColor = System.Drawing.Color.Black;
            this.Complaints_textBox.Location = new System.Drawing.Point(24, 49);
            this.Complaints_textBox.Name = "Complaints_textBox";
            this.Complaints_textBox.ReadOnly = true;
            this.Complaints_textBox.Size = new System.Drawing.Size(100, 16);
            this.Complaints_textBox.TabIndex = 13;
            this.Complaints_textBox.Text = "Complaints:";
            // 
            // TasklistBox
            // 
            this.TasklistBox.FormattingEnabled = true;
            this.TasklistBox.Location = new System.Drawing.Point(24, 71);
            this.TasklistBox.Name = "TasklistBox";
            this.TasklistBox.Size = new System.Drawing.Size(211, 251);
            this.TasklistBox.TabIndex = 12;
            this.TasklistBox.SelectedIndexChanged += new System.EventHandler(this.TasklistBox_SelectedIndexChanged);
            // 
            // TaskListForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(580, 365);
            this.Controls.Add(this.Tenant_input_textBox);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.Description_input_textBox);
            this.Controls.Add(this.Description_textBox);
            this.Controls.Add(this.Address_input_textBox);
            this.Controls.Add(this.Address_textBox);
            this.Controls.Add(this.Tenant_textBox);
            this.Controls.Add(this.Date_input_textBox);
            this.Controls.Add(this.Date_textBox);
            this.Controls.Add(this.Complaints_textBox);
            this.Controls.Add(this.TasklistBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(580, 365);
            this.Name = "TaskListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CondominiumManager";
            this.Load += new System.EventHandler(this.TaskListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tenant_input_textBox;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.TextBox Description_input_textBox;
        private System.Windows.Forms.TextBox Description_textBox;
        private System.Windows.Forms.TextBox Address_input_textBox;
        private System.Windows.Forms.TextBox Address_textBox;
        private System.Windows.Forms.TextBox Tenant_textBox;
        private System.Windows.Forms.TextBox Date_input_textBox;
        private System.Windows.Forms.TextBox Date_textBox;
        private System.Windows.Forms.TextBox Complaints_textBox;
        private System.Windows.Forms.ListBox TasklistBox;
    }
}