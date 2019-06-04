﻿namespace CondominiumManager
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
            this.TaskList_textBox = new System.Windows.Forms.TextBox();
            this.Events_button = new System.Windows.Forms.Button();
            this.Readings_textBox = new System.Windows.Forms.TextBox();
            this.Events_textBox = new System.Windows.Forms.TextBox();
            this.Payments_textBox = new System.Windows.Forms.TextBox();
            this.Payments_button = new System.Windows.Forms.Button();
            this.TaskList_button = new System.Windows.Forms.Button();
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
            this.Logo_button.FlatAppearance.BorderSize = 0;
            this.Logo_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logo_button.Location = new System.Drawing.Point(61, 113);
            this.Logo_button.Name = "Logo_button";
            this.Logo_button.Size = new System.Drawing.Size(140, 140);
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
            // TaskList_textBox
            // 
            this.TaskList_textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TaskList_textBox.BackColor = System.Drawing.Color.White;
            this.TaskList_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TaskList_textBox.Enabled = false;
            this.TaskList_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TaskList_textBox.ForeColor = System.Drawing.Color.Black;
            this.TaskList_textBox.Location = new System.Drawing.Point(340, 300);
            this.TaskList_textBox.Name = "TaskList_textBox";
            this.TaskList_textBox.ReadOnly = true;
            this.TaskList_textBox.Size = new System.Drawing.Size(80, 16);
            this.TaskList_textBox.TabIndex = 30;
            this.TaskList_textBox.Text = "Task List";
            this.TaskList_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // TaskList_button
            // 
            this.TaskList_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TaskList_button.BackColor = System.Drawing.Color.Transparent;
            this.TaskList_button.BackgroundImage = global::CondominiumManager.Properties.Resources.tasklist_web;
            this.TaskList_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TaskList_button.FlatAppearance.BorderSize = 0;
            this.TaskList_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TaskList_button.Location = new System.Drawing.Point(340, 214);
            this.TaskList_button.Name = "TaskList_button";
            this.TaskList_button.Size = new System.Drawing.Size(80, 80);
            this.TaskList_button.TabIndex = 23;
            this.TaskList_button.UseVisualStyleBackColor = false;
            this.TaskList_button.Click += new System.EventHandler(this.Task_List_button_Click);
            // 
            // MainMenuForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(580, 365);
            this.Controls.Add(this.Condo_choose_comboBox);
            this.Controls.Add(this.Contacts_button);
            this.Controls.Add(this.Readings_button);
            this.Controls.Add(this.Logo_button);
            this.Controls.Add(this.Contacts_textBox);
            this.Controls.Add(this.TaskList_textBox);
            this.Controls.Add(this.Events_button);
            this.Controls.Add(this.Readings_textBox);
            this.Controls.Add(this.Events_textBox);
            this.Controls.Add(this.Payments_textBox);
            this.Controls.Add(this.Payments_button);
            this.Controls.Add(this.TaskList_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(580, 365);
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CondominiumManager";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Condo_choose_comboBox;
        private System.Windows.Forms.Button Contacts_button;
        private System.Windows.Forms.Button Readings_button;
        private System.Windows.Forms.Button Logo_button;
        private System.Windows.Forms.TextBox Contacts_textBox;
        private System.Windows.Forms.TextBox TaskList_textBox;
        private System.Windows.Forms.Button Events_button;
        private System.Windows.Forms.TextBox Readings_textBox;
        private System.Windows.Forms.TextBox Events_textBox;
        private System.Windows.Forms.TextBox Payments_textBox;
        private System.Windows.Forms.Button Payments_button;
        private System.Windows.Forms.Button TaskList_button;
    }
}
