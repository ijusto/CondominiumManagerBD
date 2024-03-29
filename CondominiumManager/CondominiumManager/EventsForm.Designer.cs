﻿namespace CondominiumManager
{
    partial class EventsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventsForm));
            this.Date_input_textBox = new System.Windows.Forms.TextBox();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.Date_textBox = new System.Windows.Forms.TextBox();
            this.Back_button = new System.Windows.Forms.Button();
            this.Type_input_textBox = new System.Windows.Forms.TextBox();
            this.Type_textBox = new System.Windows.Forms.TextBox();
            this.Minute_input_textBox = new System.Windows.Forms.TextBox();
            this.Hour_input_textBox = new System.Windows.Forms.TextBox();
            this.Book_Cancel_button = new System.Windows.Forms.Button();
            this.Book_Ok_button = new System.Windows.Forms.Button();
            this.Description_input_textBox = new System.Windows.Forms.TextBox();
            this.Description_textBox = new System.Windows.Forms.TextBox();
            this.Damaged_input_textBox = new System.Windows.Forms.TextBox();
            this.Location_input_textBox = new System.Windows.Forms.TextBox();
            this.Location_textBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Time_textBox = new System.Windows.Forms.TextBox();
            this.Name_input_textBox = new System.Windows.Forms.TextBox();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.Book_textBox = new System.Windows.Forms.TextBox();
            this.Repair_button = new System.Windows.Forms.Button();
            this.Meeting_button = new System.Windows.Forms.Button();
            this.Damaged_textBox = new System.Windows.Forms.TextBox();
            this.Events_At_Date_textBox = new System.Windows.Forms.TextBox();
            this.Events_At_Date_listBox = new System.Windows.Forms.ListBox();
            this.Name_Event_Info_textBox = new System.Windows.Forms.TextBox();
            this.Name_input_Event_Info_textBox = new System.Windows.Forms.TextBox();
            this.Location_OR_Damage_Event_Info_textBox = new System.Windows.Forms.TextBox();
            this.Location_OR_Damage_input_Event_Info_textBox = new System.Windows.Forms.TextBox();
            this.Desc_Event_Info_textBox = new System.Windows.Forms.TextBox();
            this.Desc_input_Event_Info_textBox = new System.Windows.Forms.TextBox();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Edit_button = new System.Windows.Forms.Button();
            this.Cancel_Edit_OR_Delete_button = new System.Windows.Forms.Button();
            this.OK_Edit_OR_Delete_button = new System.Windows.Forms.Button();
            this.Delete_sure_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Date_input_textBox
            // 
            this.Date_input_textBox.BackColor = System.Drawing.Color.White;
            this.Date_input_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Date_input_textBox.Enabled = false;
            this.Date_input_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_input_textBox.ForeColor = System.Drawing.Color.Black;
            this.Date_input_textBox.Location = new System.Drawing.Point(329, 100);
            this.Date_input_textBox.Name = "Date_input_textBox";
            this.Date_input_textBox.ReadOnly = true;
            this.Date_input_textBox.Size = new System.Drawing.Size(67, 16);
            this.Date_input_textBox.TabIndex = 45;
            this.Date_input_textBox.Text = "05/06/2019 00:00:00";
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(28, 44);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 23;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // Date_textBox
            // 
            this.Date_textBox.BackColor = System.Drawing.Color.White;
            this.Date_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Date_textBox.Enabled = false;
            this.Date_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_textBox.ForeColor = System.Drawing.Color.Black;
            this.Date_textBox.Location = new System.Drawing.Point(267, 100);
            this.Date_textBox.Name = "Date_textBox";
            this.Date_textBox.ReadOnly = true;
            this.Date_textBox.Size = new System.Drawing.Size(56, 16);
            this.Date_textBox.TabIndex = 44;
            this.Date_textBox.Text = "Date:";
            // 
            // Back_button
            // 
            this.Back_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Back_button.BackColor = System.Drawing.SystemColors.Window;
            this.Back_button.BackgroundImage = global::CondominiumManager.Properties.Resources.back_icon_web;
            this.Back_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Back_button.FlatAppearance.BorderSize = 0;
            this.Back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_button.Location = new System.Drawing.Point(1, 2);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(30, 30);
            this.Back_button.TabIndex = 43;
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Type_input_textBox
            // 
            this.Type_input_textBox.BackColor = System.Drawing.Color.White;
            this.Type_input_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Type_input_textBox.Enabled = false;
            this.Type_input_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type_input_textBox.ForeColor = System.Drawing.Color.Black;
            this.Type_input_textBox.Location = new System.Drawing.Point(329, 122);
            this.Type_input_textBox.Name = "Type_input_textBox";
            this.Type_input_textBox.ReadOnly = true;
            this.Type_input_textBox.Size = new System.Drawing.Size(167, 16);
            this.Type_input_textBox.TabIndex = 42;
            // 
            // Type_textBox
            // 
            this.Type_textBox.BackColor = System.Drawing.Color.White;
            this.Type_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Type_textBox.Enabled = false;
            this.Type_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type_textBox.ForeColor = System.Drawing.Color.Black;
            this.Type_textBox.HideSelection = false;
            this.Type_textBox.Location = new System.Drawing.Point(267, 122);
            this.Type_textBox.Name = "Type_textBox";
            this.Type_textBox.ReadOnly = true;
            this.Type_textBox.Size = new System.Drawing.Size(37, 16);
            this.Type_textBox.TabIndex = 41;
            this.Type_textBox.Text = "Type:";
            // 
            // Minute_input_textBox
            // 
            this.Minute_input_textBox.Location = new System.Drawing.Point(475, 100);
            this.Minute_input_textBox.MaxLength = 2;
            this.Minute_input_textBox.Name = "Minute_input_textBox";
            this.Minute_input_textBox.Size = new System.Drawing.Size(21, 20);
            this.Minute_input_textBox.TabIndex = 31;
            // 
            // Hour_input_textBox
            // 
            this.Hour_input_textBox.Location = new System.Drawing.Point(445, 100);
            this.Hour_input_textBox.MaxLength = 2;
            this.Hour_input_textBox.Name = "Hour_input_textBox";
            this.Hour_input_textBox.Size = new System.Drawing.Size(21, 20);
            this.Hour_input_textBox.TabIndex = 30;
            // 
            // Book_Cancel_button
            // 
            this.Book_Cancel_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(146)))), ((int)(((byte)(202)))));
            this.Book_Cancel_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Book_Cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Book_Cancel_button.ForeColor = System.Drawing.Color.White;
            this.Book_Cancel_button.Location = new System.Drawing.Point(421, 236);
            this.Book_Cancel_button.Name = "Book_Cancel_button";
            this.Book_Cancel_button.Size = new System.Drawing.Size(75, 23);
            this.Book_Cancel_button.TabIndex = 40;
            this.Book_Cancel_button.Text = "Cancel";
            this.Book_Cancel_button.UseVisualStyleBackColor = false;
            this.Book_Cancel_button.Click += new System.EventHandler(this.Book_Cancel_button_Click);
            // 
            // Book_Ok_button
            // 
            this.Book_Ok_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(146)))), ((int)(((byte)(202)))));
            this.Book_Ok_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Book_Ok_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Book_Ok_button.ForeColor = System.Drawing.Color.White;
            this.Book_Ok_button.Location = new System.Drawing.Point(350, 236);
            this.Book_Ok_button.Name = "Book_Ok_button";
            this.Book_Ok_button.Size = new System.Drawing.Size(53, 23);
            this.Book_Ok_button.TabIndex = 39;
            this.Book_Ok_button.Text = "Ok";
            this.Book_Ok_button.UseVisualStyleBackColor = false;
            this.Book_Ok_button.Click += new System.EventHandler(this.Book_Ok_button_Click);
            // 
            // Description_input_textBox
            // 
            this.Description_input_textBox.Location = new System.Drawing.Point(350, 165);
            this.Description_input_textBox.Multiline = true;
            this.Description_input_textBox.Name = "Description_input_textBox";
            this.Description_input_textBox.Size = new System.Drawing.Size(146, 59);
            this.Description_input_textBox.TabIndex = 38;
            // 
            // Description_textBox
            // 
            this.Description_textBox.BackColor = System.Drawing.Color.White;
            this.Description_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Description_textBox.Enabled = false;
            this.Description_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description_textBox.ForeColor = System.Drawing.Color.Black;
            this.Description_textBox.Location = new System.Drawing.Point(267, 166);
            this.Description_textBox.Name = "Description_textBox";
            this.Description_textBox.ReadOnly = true;
            this.Description_textBox.Size = new System.Drawing.Size(77, 16);
            this.Description_textBox.TabIndex = 37;
            this.Description_textBox.Text = "Descrição:";
            // 
            // Damaged_input_textBox
            // 
            this.Damaged_input_textBox.Location = new System.Drawing.Point(350, 144);
            this.Damaged_input_textBox.Name = "Damaged_input_textBox";
            this.Damaged_input_textBox.Size = new System.Drawing.Size(146, 20);
            this.Damaged_input_textBox.TabIndex = 36;
            // 
            // Location_input_textBox
            // 
            this.Location_input_textBox.Location = new System.Drawing.Point(350, 144);
            this.Location_input_textBox.Name = "Location_input_textBox";
            this.Location_input_textBox.Size = new System.Drawing.Size(146, 20);
            this.Location_input_textBox.TabIndex = 35;
            // 
            // Location_textBox
            // 
            this.Location_textBox.BackColor = System.Drawing.Color.White;
            this.Location_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Location_textBox.Enabled = false;
            this.Location_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location_textBox.ForeColor = System.Drawing.Color.Black;
            this.Location_textBox.Location = new System.Drawing.Point(267, 144);
            this.Location_textBox.Name = "Location_textBox";
            this.Location_textBox.ReadOnly = true;
            this.Location_textBox.Size = new System.Drawing.Size(77, 16);
            this.Location_textBox.TabIndex = 33;
            this.Location_textBox.Text = "Location:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(466, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(10, 16);
            this.textBox1.TabIndex = 32;
            this.textBox1.Text = ":";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Time_textBox
            // 
            this.Time_textBox.BackColor = System.Drawing.Color.White;
            this.Time_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Time_textBox.Enabled = false;
            this.Time_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_textBox.ForeColor = System.Drawing.Color.Black;
            this.Time_textBox.Location = new System.Drawing.Point(402, 100);
            this.Time_textBox.Name = "Time_textBox";
            this.Time_textBox.ReadOnly = true;
            this.Time_textBox.Size = new System.Drawing.Size(39, 16);
            this.Time_textBox.TabIndex = 29;
            this.Time_textBox.Text = "Time:";
            // 
            // Name_input_textBox
            // 
            this.Name_input_textBox.Location = new System.Drawing.Point(329, 74);
            this.Name_input_textBox.Name = "Name_input_textBox";
            this.Name_input_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Name_input_textBox.Size = new System.Drawing.Size(167, 20);
            this.Name_input_textBox.TabIndex = 28;
            // 
            // Name_textBox
            // 
            this.Name_textBox.BackColor = System.Drawing.Color.White;
            this.Name_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Name_textBox.Enabled = false;
            this.Name_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_textBox.ForeColor = System.Drawing.Color.Black;
            this.Name_textBox.Location = new System.Drawing.Point(267, 75);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.ReadOnly = true;
            this.Name_textBox.Size = new System.Drawing.Size(56, 16);
            this.Name_textBox.TabIndex = 27;
            this.Name_textBox.Text = "Name:";
            // 
            // Book_textBox
            // 
            this.Book_textBox.BackColor = System.Drawing.Color.White;
            this.Book_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Book_textBox.Enabled = false;
            this.Book_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book_textBox.ForeColor = System.Drawing.Color.Black;
            this.Book_textBox.Location = new System.Drawing.Point(267, 47);
            this.Book_textBox.Name = "Book_textBox";
            this.Book_textBox.ReadOnly = true;
            this.Book_textBox.Size = new System.Drawing.Size(56, 16);
            this.Book_textBox.TabIndex = 26;
            this.Book_textBox.Text = "Book:";
            // 
            // Repair_button
            // 
            this.Repair_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(146)))), ((int)(((byte)(202)))));
            this.Repair_button.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.Repair_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Repair_button.ForeColor = System.Drawing.Color.White;
            this.Repair_button.Location = new System.Drawing.Point(421, 45);
            this.Repair_button.Name = "Repair_button";
            this.Repair_button.Size = new System.Drawing.Size(75, 23);
            this.Repair_button.TabIndex = 25;
            this.Repair_button.Text = "Repair";
            this.Repair_button.UseVisualStyleBackColor = false;
            this.Repair_button.Click += new System.EventHandler(this.Repair_button_Click);
            // 
            // Meeting_button
            // 
            this.Meeting_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(146)))), ((int)(((byte)(202)))));
            this.Meeting_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Meeting_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Meeting_button.ForeColor = System.Drawing.Color.White;
            this.Meeting_button.Location = new System.Drawing.Point(340, 44);
            this.Meeting_button.Name = "Meeting_button";
            this.Meeting_button.Size = new System.Drawing.Size(75, 23);
            this.Meeting_button.TabIndex = 24;
            this.Meeting_button.Text = "Meeting";
            this.Meeting_button.UseVisualStyleBackColor = false;
            this.Meeting_button.Click += new System.EventHandler(this.Meeting_button_Click);
            // 
            // Damaged_textBox
            // 
            this.Damaged_textBox.BackColor = System.Drawing.Color.White;
            this.Damaged_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Damaged_textBox.Enabled = false;
            this.Damaged_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Damaged_textBox.ForeColor = System.Drawing.Color.Black;
            this.Damaged_textBox.Location = new System.Drawing.Point(267, 144);
            this.Damaged_textBox.Name = "Damaged_textBox";
            this.Damaged_textBox.ReadOnly = true;
            this.Damaged_textBox.Size = new System.Drawing.Size(77, 16);
            this.Damaged_textBox.TabIndex = 34;
            this.Damaged_textBox.Text = "Damaged:";
            // 
            // Events_At_Date_textBox
            // 
            this.Events_At_Date_textBox.BackColor = System.Drawing.Color.White;
            this.Events_At_Date_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Events_At_Date_textBox.Enabled = false;
            this.Events_At_Date_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Events_At_Date_textBox.ForeColor = System.Drawing.Color.Black;
            this.Events_At_Date_textBox.Location = new System.Drawing.Point(267, 78);
            this.Events_At_Date_textBox.Name = "Events_At_Date_textBox";
            this.Events_At_Date_textBox.ReadOnly = true;
            this.Events_At_Date_textBox.Size = new System.Drawing.Size(229, 16);
            this.Events_At_Date_textBox.TabIndex = 46;
            this.Events_At_Date_textBox.Text = "Events at date:";
            // 
            // Events_At_Date_listBox
            // 
            this.Events_At_Date_listBox.FormattingEnabled = true;
            this.Events_At_Date_listBox.Location = new System.Drawing.Point(267, 100);
            this.Events_At_Date_listBox.Name = "Events_At_Date_listBox";
            this.Events_At_Date_listBox.Size = new System.Drawing.Size(229, 82);
            this.Events_At_Date_listBox.TabIndex = 47;
            this.Events_At_Date_listBox.SelectedIndexChanged += new System.EventHandler(this.Events_At_Date_listBox_SelectedIndexChanged);
            // 
            // Name_Event_Info_textBox
            // 
            this.Name_Event_Info_textBox.BackColor = System.Drawing.Color.White;
            this.Name_Event_Info_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Name_Event_Info_textBox.Enabled = false;
            this.Name_Event_Info_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Event_Info_textBox.ForeColor = System.Drawing.Color.Black;
            this.Name_Event_Info_textBox.Location = new System.Drawing.Point(267, 190);
            this.Name_Event_Info_textBox.Name = "Name_Event_Info_textBox";
            this.Name_Event_Info_textBox.ReadOnly = true;
            this.Name_Event_Info_textBox.Size = new System.Drawing.Size(56, 16);
            this.Name_Event_Info_textBox.TabIndex = 48;
            this.Name_Event_Info_textBox.Text = "Name:";
            // 
            // Name_input_Event_Info_textBox
            // 
            this.Name_input_Event_Info_textBox.Enabled = false;
            this.Name_input_Event_Info_textBox.Location = new System.Drawing.Point(267, 212);
            this.Name_input_Event_Info_textBox.Name = "Name_input_Event_Info_textBox";
            this.Name_input_Event_Info_textBox.ReadOnly = true;
            this.Name_input_Event_Info_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Name_input_Event_Info_textBox.Size = new System.Drawing.Size(229, 20);
            this.Name_input_Event_Info_textBox.TabIndex = 49;
            // 
            // Location_OR_Damage_Event_Info_textBox
            // 
            this.Location_OR_Damage_Event_Info_textBox.BackColor = System.Drawing.Color.White;
            this.Location_OR_Damage_Event_Info_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Location_OR_Damage_Event_Info_textBox.Enabled = false;
            this.Location_OR_Damage_Event_Info_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location_OR_Damage_Event_Info_textBox.ForeColor = System.Drawing.Color.Black;
            this.Location_OR_Damage_Event_Info_textBox.Location = new System.Drawing.Point(267, 238);
            this.Location_OR_Damage_Event_Info_textBox.Name = "Location_OR_Damage_Event_Info_textBox";
            this.Location_OR_Damage_Event_Info_textBox.ReadOnly = true;
            this.Location_OR_Damage_Event_Info_textBox.Size = new System.Drawing.Size(129, 16);
            this.Location_OR_Damage_Event_Info_textBox.TabIndex = 50;
            this.Location_OR_Damage_Event_Info_textBox.Text = "LocationORDamage:";
            // 
            // Location_OR_Damage_input_Event_Info_textBox
            // 
            this.Location_OR_Damage_input_Event_Info_textBox.Enabled = false;
            this.Location_OR_Damage_input_Event_Info_textBox.Location = new System.Drawing.Point(267, 260);
            this.Location_OR_Damage_input_Event_Info_textBox.Name = "Location_OR_Damage_input_Event_Info_textBox";
            this.Location_OR_Damage_input_Event_Info_textBox.ReadOnly = true;
            this.Location_OR_Damage_input_Event_Info_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Location_OR_Damage_input_Event_Info_textBox.Size = new System.Drawing.Size(229, 20);
            this.Location_OR_Damage_input_Event_Info_textBox.TabIndex = 51;
            // 
            // Desc_Event_Info_textBox
            // 
            this.Desc_Event_Info_textBox.BackColor = System.Drawing.Color.White;
            this.Desc_Event_Info_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Desc_Event_Info_textBox.Enabled = false;
            this.Desc_Event_Info_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desc_Event_Info_textBox.ForeColor = System.Drawing.Color.Black;
            this.Desc_Event_Info_textBox.Location = new System.Drawing.Point(267, 286);
            this.Desc_Event_Info_textBox.Name = "Desc_Event_Info_textBox";
            this.Desc_Event_Info_textBox.ReadOnly = true;
            this.Desc_Event_Info_textBox.Size = new System.Drawing.Size(77, 16);
            this.Desc_Event_Info_textBox.TabIndex = 52;
            this.Desc_Event_Info_textBox.Text = "Description:";
            // 
            // Desc_input_Event_Info_textBox
            // 
            this.Desc_input_Event_Info_textBox.Enabled = false;
            this.Desc_input_Event_Info_textBox.Location = new System.Drawing.Point(340, 285);
            this.Desc_input_Event_Info_textBox.Multiline = true;
            this.Desc_input_Event_Info_textBox.Name = "Desc_input_Event_Info_textBox";
            this.Desc_input_Event_Info_textBox.ReadOnly = true;
            this.Desc_input_Event_Info_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Desc_input_Event_Info_textBox.Size = new System.Drawing.Size(156, 44);
            this.Desc_input_Event_Info_textBox.TabIndex = 53;
            // 
            // Delete_button
            // 
            this.Delete_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(146)))), ((int)(((byte)(202)))));
            this.Delete_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete_button.ForeColor = System.Drawing.Color.White;
            this.Delete_button.Location = new System.Drawing.Point(411, 335);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(76, 23);
            this.Delete_button.TabIndex = 55;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = false;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Edit_button
            // 
            this.Edit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(146)))), ((int)(((byte)(202)))));
            this.Edit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Edit_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Edit_button.ForeColor = System.Drawing.Color.White;
            this.Edit_button.Location = new System.Drawing.Point(282, 335);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(76, 23);
            this.Edit_button.TabIndex = 54;
            this.Edit_button.Text = "Edit";
            this.Edit_button.UseVisualStyleBackColor = false;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // Cancel_Edit_OR_Delete_button
            // 
            this.Cancel_Edit_OR_Delete_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(146)))), ((int)(((byte)(202)))));
            this.Cancel_Edit_OR_Delete_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Cancel_Edit_OR_Delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancel_Edit_OR_Delete_button.ForeColor = System.Drawing.Color.White;
            this.Cancel_Edit_OR_Delete_button.Location = new System.Drawing.Point(412, 335);
            this.Cancel_Edit_OR_Delete_button.Name = "Cancel_Edit_OR_Delete_button";
            this.Cancel_Edit_OR_Delete_button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Edit_OR_Delete_button.TabIndex = 57;
            this.Cancel_Edit_OR_Delete_button.Text = "Cancel";
            this.Cancel_Edit_OR_Delete_button.UseVisualStyleBackColor = false;
            this.Cancel_Edit_OR_Delete_button.Click += new System.EventHandler(this.Cancel_Edit_OR_Delete_button_Click);
            // 
            // OK_Edit_OR_Delete_button
            // 
            this.OK_Edit_OR_Delete_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(146)))), ((int)(((byte)(202)))));
            this.OK_Edit_OR_Delete_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OK_Edit_OR_Delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OK_Edit_OR_Delete_button.ForeColor = System.Drawing.Color.White;
            this.OK_Edit_OR_Delete_button.Location = new System.Drawing.Point(295, 335);
            this.OK_Edit_OR_Delete_button.Name = "OK_Edit_OR_Delete_button";
            this.OK_Edit_OR_Delete_button.Size = new System.Drawing.Size(53, 23);
            this.OK_Edit_OR_Delete_button.TabIndex = 56;
            this.OK_Edit_OR_Delete_button.Text = "Ok";
            this.OK_Edit_OR_Delete_button.UseVisualStyleBackColor = false;
            this.OK_Edit_OR_Delete_button.Click += new System.EventHandler(this.OK_Edit_OR_Delete_button_Click);
            // 
            // Delete_sure_textBox
            // 
            this.Delete_sure_textBox.Location = new System.Drawing.Point(295, 285);
            this.Delete_sure_textBox.Multiline = true;
            this.Delete_sure_textBox.Name = "Delete_sure_textBox";
            this.Delete_sure_textBox.Size = new System.Drawing.Size(192, 73);
            this.Delete_sure_textBox.TabIndex = 58;
            this.Delete_sure_textBox.Text = "Are you sure you want to delete";
            // 
            // EventsForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(580, 365);
            this.Controls.Add(this.Cancel_Edit_OR_Delete_button);
            this.Controls.Add(this.OK_Edit_OR_Delete_button);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Edit_button);
            this.Controls.Add(this.Location_OR_Damage_Event_Info_textBox);
            this.Controls.Add(this.Date_input_textBox);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.Type_input_textBox);
            this.Controls.Add(this.Type_textBox);
            this.Controls.Add(this.Minute_input_textBox);
            this.Controls.Add(this.Hour_input_textBox);
            this.Controls.Add(this.Description_input_textBox);
            this.Controls.Add(this.Description_textBox);
            this.Controls.Add(this.Damaged_input_textBox);
            this.Controls.Add(this.Location_input_textBox);
            this.Controls.Add(this.Location_textBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Time_textBox);
            this.Controls.Add(this.Name_input_textBox);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.Book_textBox);
            this.Controls.Add(this.Repair_button);
            this.Controls.Add(this.Meeting_button);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.Damaged_textBox);
            this.Controls.Add(this.Name_input_Event_Info_textBox);
            this.Controls.Add(this.Name_Event_Info_textBox);
            this.Controls.Add(this.Events_At_Date_textBox);
            this.Controls.Add(this.Date_textBox);
            this.Controls.Add(this.Events_At_Date_listBox);
            this.Controls.Add(this.Delete_sure_textBox);
            this.Controls.Add(this.Desc_input_Event_Info_textBox);
            this.Controls.Add(this.Location_OR_Damage_input_Event_Info_textBox);
            this.Controls.Add(this.Book_Ok_button);
            this.Controls.Add(this.Book_Cancel_button);
            this.Controls.Add(this.Desc_Event_Info_textBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(596, 404);
            this.MinimumSize = new System.Drawing.Size(596, 404);
            this.Name = "EventsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CondominiumManager";
            this.Load += new System.EventHandler(this.EventsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Date_input_textBox;
        private System.Windows.Forms.TextBox Date_textBox;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.TextBox Type_input_textBox;
        private System.Windows.Forms.TextBox Type_textBox;
        private System.Windows.Forms.TextBox Minute_input_textBox;
        private System.Windows.Forms.TextBox Hour_input_textBox;
        private System.Windows.Forms.Button Book_Cancel_button;
        private System.Windows.Forms.Button Book_Ok_button;
        private System.Windows.Forms.TextBox Description_input_textBox;
        private System.Windows.Forms.TextBox Description_textBox;
        private System.Windows.Forms.TextBox Damaged_input_textBox;
        private System.Windows.Forms.TextBox Location_input_textBox;
        private System.Windows.Forms.TextBox Location_textBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Time_textBox;
        private System.Windows.Forms.TextBox Name_input_textBox;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.TextBox Book_textBox;
        private System.Windows.Forms.Button Repair_button;
        private System.Windows.Forms.Button Meeting_button;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.TextBox Damaged_textBox;
        private System.Windows.Forms.TextBox Events_At_Date_textBox;
        private System.Windows.Forms.ListBox Events_At_Date_listBox;
        private System.Windows.Forms.TextBox Name_Event_Info_textBox;
        private System.Windows.Forms.TextBox Name_input_Event_Info_textBox;
        private System.Windows.Forms.TextBox Location_OR_Damage_Event_Info_textBox;
        private System.Windows.Forms.TextBox Location_OR_Damage_input_Event_Info_textBox;
        private System.Windows.Forms.TextBox Desc_Event_Info_textBox;
        private System.Windows.Forms.TextBox Desc_input_Event_Info_textBox;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.Button Cancel_Edit_OR_Delete_button;
        private System.Windows.Forms.Button OK_Edit_OR_Delete_button;
        private System.Windows.Forms.TextBox Delete_sure_textBox;
    }
}