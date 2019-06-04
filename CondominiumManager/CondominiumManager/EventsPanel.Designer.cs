namespace CondominiumManager
{
    partial class EventsPanel
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
            this.Damaged_textBox = new System.Windows.Forms.TextBox();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.Meeting_button = new System.Windows.Forms.Button();
            this.Repair_button = new System.Windows.Forms.Button();
            this.Book_textBox = new System.Windows.Forms.TextBox();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.Name_input_textBox = new System.Windows.Forms.TextBox();
            this.Time_textBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Place_textBox = new System.Windows.Forms.TextBox();
            this.Place_input_textBox = new System.Windows.Forms.TextBox();
            this.Damaged_input_textBox = new System.Windows.Forms.TextBox();
            this.Description_textBox = new System.Windows.Forms.TextBox();
            this.Description_input_textBox = new System.Windows.Forms.TextBox();
            this.Ok_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Hour_input_textBox = new System.Windows.Forms.TextBox();
            this.Minute_input_textBox = new System.Windows.Forms.TextBox();
            this.Type_textBox = new System.Windows.Forms.TextBox();
            this.Type_input_textBox = new System.Windows.Forms.TextBox();
            this.Back_button = new System.Windows.Forms.Button();
            this.Date_textBox = new System.Windows.Forms.TextBox();
            this.Date_input_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Damaged_textBox
            // 
            this.Damaged_textBox.BackColor = System.Drawing.Color.White;
            this.Damaged_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Damaged_textBox.Enabled = false;
            this.Damaged_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Damaged_textBox.ForeColor = System.Drawing.Color.Black;
            this.Damaged_textBox.Location = new System.Drawing.Point(277, 143);
            this.Damaged_textBox.Name = "Damaged_textBox";
            this.Damaged_textBox.ReadOnly = true;
            this.Damaged_textBox.Size = new System.Drawing.Size(77, 16);
            this.Damaged_textBox.TabIndex = 11;
            this.Damaged_textBox.Text = "Damaged:";
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(38, 43);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 0;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendar1_DateChanged);
            // 
            // Meeting_button
            // 
            this.Meeting_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(146)))), ((int)(((byte)(202)))));
            this.Meeting_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Meeting_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Meeting_button.ForeColor = System.Drawing.Color.White;
            this.Meeting_button.Location = new System.Drawing.Point(350, 43);
            this.Meeting_button.Name = "Meeting_button";
            this.Meeting_button.Size = new System.Drawing.Size(75, 23);
            this.Meeting_button.TabIndex = 1;
            this.Meeting_button.Text = "Meeting";
            this.Meeting_button.UseVisualStyleBackColor = false;
            this.Meeting_button.Click += new System.EventHandler(this.Meeting_button_Click);
            // 
            // Repair_button
            // 
            this.Repair_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(146)))), ((int)(((byte)(202)))));
            this.Repair_button.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.Repair_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Repair_button.ForeColor = System.Drawing.Color.White;
            this.Repair_button.Location = new System.Drawing.Point(431, 44);
            this.Repair_button.Name = "Repair_button";
            this.Repair_button.Size = new System.Drawing.Size(75, 23);
            this.Repair_button.TabIndex = 2;
            this.Repair_button.Text = "Repair";
            this.Repair_button.UseVisualStyleBackColor = false;
            this.Repair_button.Click += new System.EventHandler(this.Repair_button_Click);
            // 
            // Book_textBox
            // 
            this.Book_textBox.BackColor = System.Drawing.Color.White;
            this.Book_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Book_textBox.Enabled = false;
            this.Book_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book_textBox.ForeColor = System.Drawing.Color.Black;
            this.Book_textBox.Location = new System.Drawing.Point(277, 46);
            this.Book_textBox.Name = "Book_textBox";
            this.Book_textBox.ReadOnly = true;
            this.Book_textBox.Size = new System.Drawing.Size(56, 16);
            this.Book_textBox.TabIndex = 3;
            this.Book_textBox.Text = "Book:";
            // 
            // Name_textBox
            // 
            this.Name_textBox.BackColor = System.Drawing.Color.White;
            this.Name_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Name_textBox.Enabled = false;
            this.Name_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_textBox.ForeColor = System.Drawing.Color.Black;
            this.Name_textBox.Location = new System.Drawing.Point(277, 74);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.ReadOnly = true;
            this.Name_textBox.Size = new System.Drawing.Size(56, 16);
            this.Name_textBox.TabIndex = 4;
            this.Name_textBox.Text = "Name:";
            // 
            // Name_input_textBox
            // 
            this.Name_input_textBox.Location = new System.Drawing.Point(339, 73);
            this.Name_input_textBox.Name = "Name_input_textBox";
            this.Name_input_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Name_input_textBox.Size = new System.Drawing.Size(167, 20);
            this.Name_input_textBox.TabIndex = 5;
            // 
            // Time_textBox
            // 
            this.Time_textBox.BackColor = System.Drawing.Color.White;
            this.Time_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Time_textBox.Enabled = false;
            this.Time_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_textBox.ForeColor = System.Drawing.Color.Black;
            this.Time_textBox.Location = new System.Drawing.Point(412, 99);
            this.Time_textBox.Name = "Time_textBox";
            this.Time_textBox.ReadOnly = true;
            this.Time_textBox.Size = new System.Drawing.Size(39, 16);
            this.Time_textBox.TabIndex = 6;
            this.Time_textBox.Text = "Time:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(476, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(10, 16);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = ":";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Place_textBox
            // 
            this.Place_textBox.BackColor = System.Drawing.Color.White;
            this.Place_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Place_textBox.Enabled = false;
            this.Place_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Place_textBox.ForeColor = System.Drawing.Color.Black;
            this.Place_textBox.Location = new System.Drawing.Point(277, 143);
            this.Place_textBox.Name = "Place_textBox";
            this.Place_textBox.ReadOnly = true;
            this.Place_textBox.Size = new System.Drawing.Size(45, 16);
            this.Place_textBox.TabIndex = 10;
            this.Place_textBox.Text = "Place:";
            // 
            // Place_input_textBox
            // 
            this.Place_input_textBox.Location = new System.Drawing.Point(339, 143);
            this.Place_input_textBox.Name = "Place_input_textBox";
            this.Place_input_textBox.Size = new System.Drawing.Size(167, 20);
            this.Place_input_textBox.TabIndex = 12;
            // 
            // Damaged_input_textBox
            // 
            this.Damaged_input_textBox.Location = new System.Drawing.Point(360, 143);
            this.Damaged_input_textBox.Name = "Damaged_input_textBox";
            this.Damaged_input_textBox.Size = new System.Drawing.Size(146, 20);
            this.Damaged_input_textBox.TabIndex = 13;
            // 
            // Description_textBox
            // 
            this.Description_textBox.BackColor = System.Drawing.Color.White;
            this.Description_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Description_textBox.Enabled = false;
            this.Description_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description_textBox.ForeColor = System.Drawing.Color.Black;
            this.Description_textBox.Location = new System.Drawing.Point(277, 165);
            this.Description_textBox.Name = "Description_textBox";
            this.Description_textBox.ReadOnly = true;
            this.Description_textBox.Size = new System.Drawing.Size(77, 16);
            this.Description_textBox.TabIndex = 14;
            this.Description_textBox.Text = "Descrição:";
            // 
            // Description_input_textBox
            // 
            this.Description_input_textBox.Location = new System.Drawing.Point(360, 164);
            this.Description_input_textBox.Multiline = true;
            this.Description_input_textBox.Name = "Description_input_textBox";
            this.Description_input_textBox.Size = new System.Drawing.Size(146, 59);
            this.Description_input_textBox.TabIndex = 15;
            // 
            // Ok_button
            // 
            this.Ok_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(146)))), ((int)(((byte)(202)))));
            this.Ok_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ok_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Ok_button.ForeColor = System.Drawing.Color.White;
            this.Ok_button.Location = new System.Drawing.Point(360, 235);
            this.Ok_button.Name = "Ok_button";
            this.Ok_button.Size = new System.Drawing.Size(53, 23);
            this.Ok_button.TabIndex = 16;
            this.Ok_button.Text = "Ok";
            this.Ok_button.UseVisualStyleBackColor = false;
            // 
            // Cancel_button
            // 
            this.Cancel_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(146)))), ((int)(((byte)(202)))));
            this.Cancel_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancel_button.ForeColor = System.Drawing.Color.White;
            this.Cancel_button.Location = new System.Drawing.Point(431, 235);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_button.TabIndex = 17;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = false;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // Hour_input_textBox
            // 
            this.Hour_input_textBox.Location = new System.Drawing.Point(455, 99);
            this.Hour_input_textBox.MaxLength = 2;
            this.Hour_input_textBox.Name = "Hour_input_textBox";
            this.Hour_input_textBox.Size = new System.Drawing.Size(21, 20);
            this.Hour_input_textBox.TabIndex = 7;
            // 
            // Minute_input_textBox
            // 
            this.Minute_input_textBox.Location = new System.Drawing.Point(485, 99);
            this.Minute_input_textBox.MaxLength = 2;
            this.Minute_input_textBox.Name = "Minute_input_textBox";
            this.Minute_input_textBox.Size = new System.Drawing.Size(21, 20);
            this.Minute_input_textBox.TabIndex = 8;
            // 
            // Type_textBox
            // 
            this.Type_textBox.BackColor = System.Drawing.Color.White;
            this.Type_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Type_textBox.Enabled = false;
            this.Type_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type_textBox.ForeColor = System.Drawing.Color.Black;
            this.Type_textBox.HideSelection = false;
            this.Type_textBox.Location = new System.Drawing.Point(277, 121);
            this.Type_textBox.Name = "Type_textBox";
            this.Type_textBox.ReadOnly = true;
            this.Type_textBox.Size = new System.Drawing.Size(37, 16);
            this.Type_textBox.TabIndex = 18;
            this.Type_textBox.Text = "Type:";
            // 
            // Type_input_textBox
            // 
            this.Type_input_textBox.BackColor = System.Drawing.Color.White;
            this.Type_input_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Type_input_textBox.Enabled = false;
            this.Type_input_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type_input_textBox.ForeColor = System.Drawing.Color.Black;
            this.Type_input_textBox.Location = new System.Drawing.Point(320, 120);
            this.Type_input_textBox.Name = "Type_input_textBox";
            this.Type_input_textBox.ReadOnly = true;
            this.Type_input_textBox.Size = new System.Drawing.Size(77, 16);
            this.Type_input_textBox.TabIndex = 19;
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
            this.Back_button.TabIndex = 20;
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Date_textBox
            // 
            this.Date_textBox.BackColor = System.Drawing.Color.White;
            this.Date_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Date_textBox.Enabled = false;
            this.Date_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_textBox.ForeColor = System.Drawing.Color.Black;
            this.Date_textBox.Location = new System.Drawing.Point(277, 99);
            this.Date_textBox.Name = "Date_textBox";
            this.Date_textBox.ReadOnly = true;
            this.Date_textBox.Size = new System.Drawing.Size(56, 16);
            this.Date_textBox.TabIndex = 21;
            this.Date_textBox.Text = "Date:";
            // 
            // Date_input_textBox
            // 
            this.Date_input_textBox.BackColor = System.Drawing.Color.White;
            this.Date_input_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Date_input_textBox.Enabled = false;
            this.Date_input_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_input_textBox.ForeColor = System.Drawing.Color.Black;
            this.Date_input_textBox.Location = new System.Drawing.Point(339, 99);
            this.Date_input_textBox.Name = "Date_input_textBox";
            this.Date_input_textBox.ReadOnly = true;
            this.Date_input_textBox.Size = new System.Drawing.Size(67, 16);
            this.Date_input_textBox.TabIndex = 22;
            // 
            // EventsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Date_input_textBox);
            this.Controls.Add(this.Date_textBox);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.Type_input_textBox);
            this.Controls.Add(this.Type_textBox);
            this.Controls.Add(this.Minute_input_textBox);
            this.Controls.Add(this.Hour_input_textBox);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Ok_button);
            this.Controls.Add(this.Description_input_textBox);
            this.Controls.Add(this.Description_textBox);
            this.Controls.Add(this.Damaged_input_textBox);
            this.Controls.Add(this.Place_input_textBox);
            this.Controls.Add(this.Place_textBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Time_textBox);
            this.Controls.Add(this.Name_input_textBox);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.Book_textBox);
            this.Controls.Add(this.Repair_button);
            this.Controls.Add(this.Meeting_button);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.Damaged_textBox);
            this.MinimumSize = new System.Drawing.Size(580, 365);
            this.Name = "EventsPanel";
            this.Size = new System.Drawing.Size(580, 365);
            this.Load += new System.EventHandler(this.Events_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Damaged_textBox;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Button Meeting_button;
        private System.Windows.Forms.Button Repair_button;
        private System.Windows.Forms.TextBox Book_textBox;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.TextBox Name_input_textBox;
        private System.Windows.Forms.TextBox Time_textBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Place_textBox;
        private System.Windows.Forms.TextBox Place_input_textBox;
        private System.Windows.Forms.TextBox Damaged_input_textBox;
        private System.Windows.Forms.TextBox Description_textBox;
        private System.Windows.Forms.TextBox Description_input_textBox;
        private System.Windows.Forms.Button Ok_button;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.TextBox Hour_input_textBox;
        private System.Windows.Forms.TextBox Minute_input_textBox;
        private System.Windows.Forms.TextBox Type_textBox;
        private System.Windows.Forms.TextBox Type_input_textBox;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.TextBox Date_textBox;
        private System.Windows.Forms.TextBox Date_input_textBox;
    }
}
