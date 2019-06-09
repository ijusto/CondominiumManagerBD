namespace CondominiumManager
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.Condo_choose_comboBox = new System.Windows.Forms.ComboBox();
            this.Contacts_button = new System.Windows.Forms.Button();
            this.Readings_button = new System.Windows.Forms.Button();
            this.Logo_button = new System.Windows.Forms.Button();
            this.Contacts_textBox = new System.Windows.Forms.TextBox();
            this.Complaints_textBox = new System.Windows.Forms.TextBox();
            this.Events_button = new System.Windows.Forms.Button();
            this.Readings_textBox = new System.Windows.Forms.TextBox();
            this.Events_textBox = new System.Windows.Forms.TextBox();
            this.Payments_textBox = new System.Windows.Forms.TextBox();
            this.Payments_button = new System.Windows.Forms.Button();
            this.Complaints_button = new System.Windows.Forms.Button();
            this.CondominumSelect_textBox = new System.Windows.Forms.TextBox();
            this.photo_pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.photo_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Condo_choose_comboBox
            // 
            this.Condo_choose_comboBox.BackColor = System.Drawing.Color.White;
            this.Condo_choose_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Condo_choose_comboBox.FormattingEnabled = true;
            this.Condo_choose_comboBox.Location = new System.Drawing.Point(239, 49);
            this.Condo_choose_comboBox.Name = "Condo_choose_comboBox";
            this.Condo_choose_comboBox.Size = new System.Drawing.Size(280, 21);
            this.Condo_choose_comboBox.TabIndex = 31;
            this.Condo_choose_comboBox.SelectedIndexChanged += new System.EventHandler(this.Condo_choose_comboBox_SelectedIndexChanged);
            // 
            // Contacts_button
            // 
            this.Contacts_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Contacts_button.BackColor = System.Drawing.Color.Transparent;
            this.Contacts_button.BackgroundImage = global::CondominiumManager.Properties.Resources.contacts_icon_web;
            this.Contacts_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Contacts_button.FlatAppearance.BorderSize = 0;
            this.Contacts_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Contacts_button.Location = new System.Drawing.Point(439, 91);
            this.Contacts_button.Margin = new System.Windows.Forms.Padding(0);
            this.Contacts_button.Name = "Contacts_button";
            this.Contacts_button.Size = new System.Drawing.Size(80, 80);
            this.Contacts_button.TabIndex = 25;
            this.Contacts_button.UseVisualStyleBackColor = false;
            this.Contacts_button.Click += new System.EventHandler(this.Contacts_button_Click);
            // 
            // Readings_button
            // 
            this.Readings_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Readings_button.BackColor = System.Drawing.Color.Transparent;
            this.Readings_button.BackgroundImage = global::CondominiumManager.Properties.Resources.utilities_web;
            this.Readings_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Readings_button.FlatAppearance.BorderSize = 0;
            this.Readings_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Readings_button.Location = new System.Drawing.Point(340, 91);
            this.Readings_button.Name = "Readings_button";
            this.Readings_button.Size = new System.Drawing.Size(80, 80);
            this.Readings_button.TabIndex = 24;
            this.Readings_button.UseVisualStyleBackColor = false;
            this.Readings_button.Click += new System.EventHandler(this.Readings_button_Click);
            // 
            // Logo_button
            // 
            this.Logo_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Logo_button.BackColor = System.Drawing.Color.Transparent;
            this.Logo_button.BackgroundImage = global::CondominiumManager.Properties.Resources.condo_manager_app_icon_web;
            this.Logo_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logo_button.Enabled = false;
            this.Logo_button.FlatAppearance.BorderSize = 0;
            this.Logo_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logo_button.Location = new System.Drawing.Point(192, 38);
            this.Logo_button.Name = "Logo_button";
            this.Logo_button.Size = new System.Drawing.Size(41, 42);
            this.Logo_button.TabIndex = 20;
            this.Logo_button.UseVisualStyleBackColor = false;
            // 
            // Contacts_textBox
            // 
            this.Contacts_textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Contacts_textBox.BackColor = System.Drawing.Color.White;
            this.Contacts_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Contacts_textBox.Enabled = false;
            this.Contacts_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Contacts_textBox.Location = new System.Drawing.Point(439, 176);
            this.Contacts_textBox.Name = "Contacts_textBox";
            this.Contacts_textBox.ReadOnly = true;
            this.Contacts_textBox.Size = new System.Drawing.Size(80, 16);
            this.Contacts_textBox.TabIndex = 29;
            this.Contacts_textBox.Text = "Contacts";
            this.Contacts_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Complaints_textBox
            // 
            this.Complaints_textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Complaints_textBox.BackColor = System.Drawing.Color.White;
            this.Complaints_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Complaints_textBox.Enabled = false;
            this.Complaints_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Complaints_textBox.ForeColor = System.Drawing.Color.Black;
            this.Complaints_textBox.Location = new System.Drawing.Point(340, 300);
            this.Complaints_textBox.Name = "Complaints_textBox";
            this.Complaints_textBox.ReadOnly = true;
            this.Complaints_textBox.Size = new System.Drawing.Size(80, 16);
            this.Complaints_textBox.TabIndex = 30;
            this.Complaints_textBox.Text = "Complaints";
            this.Complaints_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Events_button
            // 
            this.Events_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Events_button.BackColor = System.Drawing.Color.Transparent;
            this.Events_button.BackgroundImage = global::CondominiumManager.Properties.Resources.events_icon_web;
            this.Events_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Events_button.FlatAppearance.BorderSize = 0;
            this.Events_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Events_button.Location = new System.Drawing.Point(239, 91);
            this.Events_button.Name = "Events_button";
            this.Events_button.Size = new System.Drawing.Size(80, 80);
            this.Events_button.TabIndex = 22;
            this.Events_button.UseVisualStyleBackColor = false;
            this.Events_button.Click += new System.EventHandler(this.Events_button_Click);
            // 
            // Readings_textBox
            // 
            this.Readings_textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Readings_textBox.BackColor = System.Drawing.Color.White;
            this.Readings_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Readings_textBox.Enabled = false;
            this.Readings_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Readings_textBox.Location = new System.Drawing.Point(340, 176);
            this.Readings_textBox.Name = "Readings_textBox";
            this.Readings_textBox.ReadOnly = true;
            this.Readings_textBox.Size = new System.Drawing.Size(80, 16);
            this.Readings_textBox.TabIndex = 27;
            this.Readings_textBox.Text = "Readings";
            this.Readings_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Events_textBox
            // 
            this.Events_textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Events_textBox.BackColor = System.Drawing.Color.White;
            this.Events_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Events_textBox.Enabled = false;
            this.Events_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Events_textBox.ForeColor = System.Drawing.Color.Black;
            this.Events_textBox.Location = new System.Drawing.Point(239, 176);
            this.Events_textBox.Name = "Events_textBox";
            this.Events_textBox.ReadOnly = true;
            this.Events_textBox.Size = new System.Drawing.Size(80, 16);
            this.Events_textBox.TabIndex = 26;
            this.Events_textBox.Text = "Events";
            this.Events_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Payments_textBox
            // 
            this.Payments_textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Payments_textBox.BackColor = System.Drawing.Color.White;
            this.Payments_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Payments_textBox.Enabled = false;
            this.Payments_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Payments_textBox.Location = new System.Drawing.Point(239, 300);
            this.Payments_textBox.Name = "Payments_textBox";
            this.Payments_textBox.ReadOnly = true;
            this.Payments_textBox.Size = new System.Drawing.Size(80, 16);
            this.Payments_textBox.TabIndex = 28;
            this.Payments_textBox.Text = "Payments";
            this.Payments_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Payments_button
            // 
            this.Payments_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Payments_button.BackColor = System.Drawing.Color.Transparent;
            this.Payments_button.BackgroundImage = global::CondominiumManager.Properties.Resources.payments_icon_web;
            this.Payments_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Payments_button.FlatAppearance.BorderSize = 0;
            this.Payments_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Payments_button.Location = new System.Drawing.Point(239, 214);
            this.Payments_button.Name = "Payments_button";
            this.Payments_button.Size = new System.Drawing.Size(80, 80);
            this.Payments_button.TabIndex = 21;
            this.Payments_button.UseVisualStyleBackColor = false;
            this.Payments_button.Click += new System.EventHandler(this.Payments_button_Click);
            // 
            // Complaints_button
            // 
            this.Complaints_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Complaints_button.BackColor = System.Drawing.Color.Transparent;
            this.Complaints_button.BackgroundImage = global::CondominiumManager.Properties.Resources.tasklist_web;
            this.Complaints_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Complaints_button.FlatAppearance.BorderSize = 0;
            this.Complaints_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Complaints_button.Location = new System.Drawing.Point(340, 214);
            this.Complaints_button.Name = "Complaints_button";
            this.Complaints_button.Size = new System.Drawing.Size(80, 80);
            this.Complaints_button.TabIndex = 23;
            this.Complaints_button.UseVisualStyleBackColor = false;
            this.Complaints_button.Click += new System.EventHandler(this.Complaints_button_Click);
            // 
            // CondominumSelect_textBox
            // 
            this.CondominumSelect_textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CondominumSelect_textBox.BackColor = System.Drawing.Color.White;
            this.CondominumSelect_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CondominumSelect_textBox.Enabled = false;
            this.CondominumSelect_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CondominumSelect_textBox.ForeColor = System.Drawing.Color.Black;
            this.CondominumSelect_textBox.Location = new System.Drawing.Point(239, 27);
            this.CondominumSelect_textBox.Name = "CondominumSelect_textBox";
            this.CondominumSelect_textBox.ReadOnly = true;
            this.CondominumSelect_textBox.Size = new System.Drawing.Size(100, 16);
            this.CondominumSelect_textBox.TabIndex = 32;
            this.CondominumSelect_textBox.Text = "Condominium:";
            // 
            // photo_pictureBox
            // 
            this.photo_pictureBox.Location = new System.Drawing.Point(35, 112);
            this.photo_pictureBox.Name = "photo_pictureBox";
            this.photo_pictureBox.Size = new System.Drawing.Size(178, 162);
            this.photo_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photo_pictureBox.TabIndex = 34;
            this.photo_pictureBox.TabStop = false;
            // 
            // MainMenuForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(580, 365);
            this.Controls.Add(this.photo_pictureBox);
            this.Controls.Add(this.CondominumSelect_textBox);
            this.Controls.Add(this.Condo_choose_comboBox);
            this.Controls.Add(this.Contacts_button);
            this.Controls.Add(this.Readings_button);
            this.Controls.Add(this.Logo_button);
            this.Controls.Add(this.Contacts_textBox);
            this.Controls.Add(this.Complaints_textBox);
            this.Controls.Add(this.Events_button);
            this.Controls.Add(this.Readings_textBox);
            this.Controls.Add(this.Events_textBox);
            this.Controls.Add(this.Payments_textBox);
            this.Controls.Add(this.Payments_button);
            this.Controls.Add(this.Complaints_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(596, 404);
            this.MinimumSize = new System.Drawing.Size(596, 404);
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CondominiumManager";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.photo_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Condo_choose_comboBox;
        private System.Windows.Forms.Button Contacts_button;
        private System.Windows.Forms.Button Readings_button;
        private System.Windows.Forms.Button Logo_button;
        private System.Windows.Forms.TextBox Contacts_textBox;
        private System.Windows.Forms.TextBox Complaints_textBox;
        private System.Windows.Forms.Button Events_button;
        private System.Windows.Forms.TextBox Readings_textBox;
        private System.Windows.Forms.TextBox Events_textBox;
        private System.Windows.Forms.TextBox Payments_textBox;
        private System.Windows.Forms.Button Payments_button;
        private System.Windows.Forms.Button Complaints_button;
        private System.Windows.Forms.TextBox CondominumSelect_textBox;
        private System.Windows.Forms.PictureBox photo_pictureBox;
    }
}

