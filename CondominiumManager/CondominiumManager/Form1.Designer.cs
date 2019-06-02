﻿namespace CondominiumManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.events_textBox = new System.Windows.Forms.TextBox();
            this.readings_textBox = new System.Windows.Forms.TextBox();
            this.Payments_textBox = new System.Windows.Forms.TextBox();
            this.Contacts_textBox = new System.Windows.Forms.TextBox();
            this.Task_list_textBox = new System.Windows.Forms.TextBox();
            this.Panel_Main_menu = new System.Windows.Forms.Panel();
            this.Contacts_button = new System.Windows.Forms.Button();
            this.Readings_button = new System.Windows.Forms.Button();
            this.Logo_button = new System.Windows.Forms.Button();
            this.Events_button = new System.Windows.Forms.Button();
            this.Payments_button = new System.Windows.Forms.Button();
            this.Task_List_button = new System.Windows.Forms.Button();
            this.events_user_control = new CondominiumManager.Events();
            this.taskList_user_control = new CondominiumManager.TaskList();
            this.contacts_user_control = new CondominiumManager.Contact();
            this.payments_user_control = new CondominiumManager.Payments();
            this.readings_user_control = new CondominiumManager.Readings();
            this.Panel_Main_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // events_textBox
            // 
            this.events_textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.events_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.events_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.events_textBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.events_textBox.Location = new System.Drawing.Point(211, 154);
            this.events_textBox.Name = "events_textBox";
            this.events_textBox.Size = new System.Drawing.Size(80, 13);
            this.events_textBox.TabIndex = 8;
            this.events_textBox.Text = "Events";
            this.events_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // readings_textBox
            // 
            this.readings_textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.readings_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readings_textBox.Location = new System.Drawing.Point(312, 154);
            this.readings_textBox.Name = "readings_textBox";
            this.readings_textBox.Size = new System.Drawing.Size(80, 13);
            this.readings_textBox.TabIndex = 9;
            this.readings_textBox.Text = "Readings";
            // 
            // Payments_textBox
            // 
            this.Payments_textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Payments_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Payments_textBox.Location = new System.Drawing.Point(211, 278);
            this.Payments_textBox.Name = "Payments_textBox";
            this.Payments_textBox.Size = new System.Drawing.Size(80, 13);
            this.Payments_textBox.TabIndex = 11;
            this.Payments_textBox.Text = "Payments";
            this.Payments_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Contacts_textBox
            // 
            this.Contacts_textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Contacts_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Contacts_textBox.Location = new System.Drawing.Point(411, 154);
            this.Contacts_textBox.Name = "Contacts_textBox";
            this.Contacts_textBox.Size = new System.Drawing.Size(80, 13);
            this.Contacts_textBox.TabIndex = 12;
            this.Contacts_textBox.Text = "Contacts";
            this.Contacts_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Task_list_textBox
            // 
            this.Task_list_textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Task_list_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Task_list_textBox.Location = new System.Drawing.Point(312, 278);
            this.Task_list_textBox.Name = "Task_list_textBox";
            this.Task_list_textBox.Size = new System.Drawing.Size(80, 13);
            this.Task_list_textBox.TabIndex = 13;
            this.Task_list_textBox.Text = "Task List";
            this.Task_list_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Panel_Main_menu
            // 
            this.Panel_Main_menu.Controls.Add(this.Contacts_button);
            this.Panel_Main_menu.Controls.Add(this.Readings_button);
            this.Panel_Main_menu.Controls.Add(this.Logo_button);
            this.Panel_Main_menu.Controls.Add(this.Contacts_textBox);
            this.Panel_Main_menu.Controls.Add(this.Task_list_textBox);
            this.Panel_Main_menu.Controls.Add(this.Events_button);
            this.Panel_Main_menu.Controls.Add(this.readings_textBox);
            this.Panel_Main_menu.Controls.Add(this.events_textBox);
            this.Panel_Main_menu.Controls.Add(this.Payments_textBox);
            this.Panel_Main_menu.Controls.Add(this.Payments_button);
            this.Panel_Main_menu.Controls.Add(this.Task_List_button);
            this.Panel_Main_menu.Controls.Add(this.events_user_control);
            this.Panel_Main_menu.Controls.Add(this.taskList_user_control);
            this.Panel_Main_menu.Controls.Add(this.contacts_user_control);
            this.Panel_Main_menu.Controls.Add(this.payments_user_control);
            this.Panel_Main_menu.Controls.Add(this.readings_user_control);
            this.Panel_Main_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Main_menu.Location = new System.Drawing.Point(0, 0);
            this.Panel_Main_menu.Name = "Panel_Main_menu";
            this.Panel_Main_menu.Size = new System.Drawing.Size(542, 365);
            this.Panel_Main_menu.TabIndex = 14;
            // 
            // Contacts_button
            // 
            this.Contacts_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Contacts_button.BackColor = System.Drawing.Color.Transparent;
            this.Contacts_button.BackgroundImage = global::CondominiumManager.Properties.Resources.contacts_icon_web;
            this.Contacts_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Contacts_button.FlatAppearance.BorderSize = 0;
            this.Contacts_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Contacts_button.Location = new System.Drawing.Point(411, 69);
            this.Contacts_button.Margin = new System.Windows.Forms.Padding(0);
            this.Contacts_button.Name = "Contacts_button";
            this.Contacts_button.Size = new System.Drawing.Size(80, 80);
            this.Contacts_button.TabIndex = 6;
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
            this.Readings_button.Location = new System.Drawing.Point(312, 69);
            this.Readings_button.Name = "Readings_button";
            this.Readings_button.Size = new System.Drawing.Size(80, 80);
            this.Readings_button.TabIndex = 4;
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
            this.Logo_button.Location = new System.Drawing.Point(33, 109);
            this.Logo_button.Name = "Logo_button";
            this.Logo_button.Size = new System.Drawing.Size(140, 140);
            this.Logo_button.TabIndex = 0;
            this.Logo_button.UseVisualStyleBackColor = false;
            // 
            // Events_button
            // 
            this.Events_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Events_button.BackColor = System.Drawing.Color.Transparent;
            this.Events_button.BackgroundImage = global::CondominiumManager.Properties.Resources.events_icon_web;
            this.Events_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Events_button.FlatAppearance.BorderSize = 0;
            this.Events_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Events_button.Location = new System.Drawing.Point(211, 69);
            this.Events_button.Name = "Events_button";
            this.Events_button.Size = new System.Drawing.Size(80, 80);
            this.Events_button.TabIndex = 2;
            this.Events_button.UseVisualStyleBackColor = false;
            this.Events_button.Click += new System.EventHandler(this.Events_button_Click);
            // 
            // Payments_button
            // 
            this.Payments_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Payments_button.BackColor = System.Drawing.Color.Transparent;
            this.Payments_button.BackgroundImage = global::CondominiumManager.Properties.Resources.payments_icon_web;
            this.Payments_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Payments_button.FlatAppearance.BorderSize = 0;
            this.Payments_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Payments_button.Location = new System.Drawing.Point(211, 192);
            this.Payments_button.Name = "Payments_button";
            this.Payments_button.Size = new System.Drawing.Size(80, 80);
            this.Payments_button.TabIndex = 1;
            this.Payments_button.UseVisualStyleBackColor = false;
            this.Payments_button.Click += new System.EventHandler(this.Payments_button_Click);
            // 
            // Task_List_button
            // 
            this.Task_List_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Task_List_button.BackColor = System.Drawing.Color.Transparent;
            this.Task_List_button.BackgroundImage = global::CondominiumManager.Properties.Resources.tasklist_web;
            this.Task_List_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Task_List_button.FlatAppearance.BorderSize = 0;
            this.Task_List_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Task_List_button.Location = new System.Drawing.Point(312, 192);
            this.Task_List_button.Name = "Task_List_button";
            this.Task_List_button.Size = new System.Drawing.Size(80, 80);
            this.Task_List_button.TabIndex = 3;
            this.Task_List_button.UseVisualStyleBackColor = false;
            this.Task_List_button.Click += new System.EventHandler(this.Task_List_button_Click);
            // 
            // events_user_control
            // 
            this.events_user_control.Dock = System.Windows.Forms.DockStyle.Right;
            this.events_user_control.Location = new System.Drawing.Point(3, 0);
            this.events_user_control.MinimumSize = new System.Drawing.Size(539, 326);
            this.events_user_control.Name = "events_user_control";
            this.events_user_control.Size = new System.Drawing.Size(539, 365);
            this.events_user_control.TabIndex = 14;
            // 
            // taskList_user_control
            // 
            this.taskList_user_control.Location = new System.Drawing.Point(0, 0);
            this.taskList_user_control.Name = "taskList_user_control";
            this.taskList_user_control.Size = new System.Drawing.Size(556, 365);
            this.taskList_user_control.TabIndex = 15;
            // 
            // contacts_user_control
            // 
            this.contacts_user_control.Location = new System.Drawing.Point(0, 0);
            this.contacts_user_control.Name = "contacts_user_control";
            this.contacts_user_control.Size = new System.Drawing.Size(556, 365);
            this.contacts_user_control.TabIndex = 16;
            // 
            // payments_user_control
            // 
            this.payments_user_control.Location = new System.Drawing.Point(0, 0);
            this.payments_user_control.Name = "payments_user_control";
            this.payments_user_control.Size = new System.Drawing.Size(556, 365);
            this.payments_user_control.TabIndex = 17;
            // 
            // readings_user_control
            // 
            this.readings_user_control.Location = new System.Drawing.Point(0, -1);
            this.readings_user_control.Name = "readings_user_control";
            this.readings_user_control.Size = new System.Drawing.Size(556, 366);
            this.readings_user_control.TabIndex = 18;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(557, 365);
            this.Controls.Add(this.Panel_Main_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(557, 365);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CondominiumManager";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.Panel_Main_menu.ResumeLayout(false);
            this.Panel_Main_menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Logo_button;
        private System.Windows.Forms.Button Payments_button;
        private System.Windows.Forms.Button Events_button;
        private System.Windows.Forms.Button Task_List_button;
        private System.Windows.Forms.Button Readings_button;
        private System.Windows.Forms.Button Contacts_button;
        private System.Windows.Forms.TextBox events_textBox;
        private System.Windows.Forms.TextBox readings_textBox;
        private System.Windows.Forms.TextBox Payments_textBox;
        private System.Windows.Forms.TextBox Contacts_textBox;
        private System.Windows.Forms.TextBox Task_list_textBox;
        private System.Windows.Forms.Panel Panel_Main_menu;
        private Events events_user_control;
        private TaskList taskList_user_control;
        private Contact contacts_user_control;
        private Payments payments_user_control;
        private Readings readings_user_control;
    }
}

