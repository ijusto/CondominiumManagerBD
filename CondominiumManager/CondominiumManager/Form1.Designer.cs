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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Panel_Main_menu = new System.Windows.Forms.Panel();
            this.Condo_choose_comboBox = new System.Windows.Forms.ComboBox();
            this.Contacts_button = new System.Windows.Forms.Button();
            this.Readings_button = new System.Windows.Forms.Button();
            this.Logo_button = new System.Windows.Forms.Button();
            this.Contacts_textBox = new System.Windows.Forms.TextBox();
            this.Task_list_textBox = new System.Windows.Forms.TextBox();
            this.Events_button = new System.Windows.Forms.Button();
            this.Readings_textBox = new System.Windows.Forms.TextBox();
            this.Events_textBox = new System.Windows.Forms.TextBox();
            this.Payments_textBox = new System.Windows.Forms.TextBox();
            this.Payments_button = new System.Windows.Forms.Button();
            this.Task_List_button = new System.Windows.Forms.Button();
            this.eventsPanel = new CondominiumManager.EventsPanel();
            this.readingsPanel = new CondominiumManager.ReadingsPanel();
            this.contactPanel = new CondominiumManager.ContactPanel();
            this.paymentsPanel = new CondominiumManager.PaymentsPanel();
            this.taskListPanel = new CondominiumManager.TaskListPanel();
            this.Panel_Main_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Main_menu
            // 
            this.Panel_Main_menu.Controls.Add(this.Condo_choose_comboBox);
            this.Panel_Main_menu.Controls.Add(this.Contacts_button);
            this.Panel_Main_menu.Controls.Add(this.Readings_button);
            this.Panel_Main_menu.Controls.Add(this.Logo_button);
            this.Panel_Main_menu.Controls.Add(this.Contacts_textBox);
            this.Panel_Main_menu.Controls.Add(this.Task_list_textBox);
            this.Panel_Main_menu.Controls.Add(this.Events_button);
            this.Panel_Main_menu.Controls.Add(this.Readings_textBox);
            this.Panel_Main_menu.Controls.Add(this.Events_textBox);
            this.Panel_Main_menu.Controls.Add(this.Payments_textBox);
            this.Panel_Main_menu.Controls.Add(this.Payments_button);
            this.Panel_Main_menu.Controls.Add(this.Task_List_button);
            this.Panel_Main_menu.Controls.Add(this.eventsPanel);
            this.Panel_Main_menu.Controls.Add(this.readingsPanel);
            this.Panel_Main_menu.Controls.Add(this.contactPanel);
            this.Panel_Main_menu.Controls.Add(this.paymentsPanel);
            this.Panel_Main_menu.Controls.Add(this.taskListPanel);
            this.Panel_Main_menu.Location = new System.Drawing.Point(0, 0);
            this.Panel_Main_menu.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Main_menu.MinimumSize = new System.Drawing.Size(580, 365);
            this.Panel_Main_menu.Name = "Panel_Main_menu";
            this.Panel_Main_menu.Size = new System.Drawing.Size(580, 365);
            this.Panel_Main_menu.TabIndex = 14;
            // 
            // Condo_choose_comboBox
            // 
            this.Condo_choose_comboBox.BackColor = System.Drawing.Color.White;
            this.Condo_choose_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Condo_choose_comboBox.FormattingEnabled = true;
            this.Condo_choose_comboBox.Location = new System.Drawing.Point(230, 45);
            this.Condo_choose_comboBox.Name = "Condo_choose_comboBox";
            this.Condo_choose_comboBox.Size = new System.Drawing.Size(280, 21);
            this.Condo_choose_comboBox.TabIndex = 19;
            // 
            // Contacts_button
            // 
            this.Contacts_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Contacts_button.BackColor = System.Drawing.Color.Transparent;
            this.Contacts_button.BackgroundImage = global::CondominiumManager.Properties.Resources.contacts_icon_web;
            this.Contacts_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Contacts_button.FlatAppearance.BorderSize = 0;
            this.Contacts_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Contacts_button.Location = new System.Drawing.Point(430, 87);
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
            this.Readings_button.Location = new System.Drawing.Point(331, 87);
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
            this.Logo_button.Location = new System.Drawing.Point(52, 109);
            this.Logo_button.Name = "Logo_button";
            this.Logo_button.Size = new System.Drawing.Size(140, 140);
            this.Logo_button.TabIndex = 0;
            this.Logo_button.UseVisualStyleBackColor = false;
            // 
            // Contacts_textBox
            // 
            this.Contacts_textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Contacts_textBox.BackColor = System.Drawing.Color.White;
            this.Contacts_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Contacts_textBox.Enabled = false;
            this.Contacts_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Contacts_textBox.Location = new System.Drawing.Point(430, 172);
            this.Contacts_textBox.Name = "Contacts_textBox";
            this.Contacts_textBox.ReadOnly = true;
            this.Contacts_textBox.Size = new System.Drawing.Size(80, 16);
            this.Contacts_textBox.TabIndex = 12;
            this.Contacts_textBox.Text = "Contacts";
            this.Contacts_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Task_list_textBox
            // 
            this.Task_list_textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Task_list_textBox.BackColor = System.Drawing.Color.White;
            this.Task_list_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Task_list_textBox.Enabled = false;
            this.Task_list_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Task_list_textBox.ForeColor = System.Drawing.Color.Black;
            this.Task_list_textBox.Location = new System.Drawing.Point(331, 296);
            this.Task_list_textBox.Name = "Task_list_textBox";
            this.Task_list_textBox.ReadOnly = true;
            this.Task_list_textBox.Size = new System.Drawing.Size(80, 16);
            this.Task_list_textBox.TabIndex = 13;
            this.Task_list_textBox.Text = "Task List";
            this.Task_list_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Events_button
            // 
            this.Events_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Events_button.BackColor = System.Drawing.Color.Transparent;
            this.Events_button.BackgroundImage = global::CondominiumManager.Properties.Resources.events_icon_web;
            this.Events_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Events_button.FlatAppearance.BorderSize = 0;
            this.Events_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Events_button.Location = new System.Drawing.Point(230, 87);
            this.Events_button.Name = "Events_button";
            this.Events_button.Size = new System.Drawing.Size(80, 80);
            this.Events_button.TabIndex = 2;
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
            this.Readings_textBox.Location = new System.Drawing.Point(331, 172);
            this.Readings_textBox.Name = "Readings_textBox";
            this.Readings_textBox.ReadOnly = true;
            this.Readings_textBox.Size = new System.Drawing.Size(80, 16);
            this.Readings_textBox.TabIndex = 9;
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
            this.Events_textBox.Location = new System.Drawing.Point(230, 172);
            this.Events_textBox.Name = "Events_textBox";
            this.Events_textBox.ReadOnly = true;
            this.Events_textBox.Size = new System.Drawing.Size(80, 16);
            this.Events_textBox.TabIndex = 8;
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
            this.Payments_textBox.Location = new System.Drawing.Point(230, 296);
            this.Payments_textBox.Name = "Payments_textBox";
            this.Payments_textBox.ReadOnly = true;
            this.Payments_textBox.Size = new System.Drawing.Size(80, 16);
            this.Payments_textBox.TabIndex = 11;
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
            this.Payments_button.Location = new System.Drawing.Point(230, 210);
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
            this.Task_List_button.Location = new System.Drawing.Point(331, 210);
            this.Task_List_button.Name = "Task_List_button";
            this.Task_List_button.Size = new System.Drawing.Size(80, 80);
            this.Task_List_button.TabIndex = 3;
            this.Task_List_button.UseVisualStyleBackColor = false;
            this.Task_List_button.Click += new System.EventHandler(this.Task_List_button_Click);
            // 
            // eventsPanel
            // 
            this.eventsPanel.Location = new System.Drawing.Point(0, 0);
            this.eventsPanel.MinimumSize = new System.Drawing.Size(580, 365);
            this.eventsPanel.Name = "eventsPanel";
            this.eventsPanel.Size = new System.Drawing.Size(580, 365);
            this.eventsPanel.TabIndex = 20;
            // 
            // readingsPanel
            // 
            this.readingsPanel.Location = new System.Drawing.Point(0, 0);
            this.readingsPanel.MinimumSize = new System.Drawing.Size(580, 365);
            this.readingsPanel.Name = "readingsPanel";
            this.readingsPanel.Size = new System.Drawing.Size(580, 365);
            this.readingsPanel.TabIndex = 21;
            // 
            // contactPanel
            // 
            this.contactPanel.Location = new System.Drawing.Point(0, 0);
            this.contactPanel.MinimumSize = new System.Drawing.Size(580, 365);
            this.contactPanel.Name = "contactPanel";
            this.contactPanel.Size = new System.Drawing.Size(580, 365);
            this.contactPanel.TabIndex = 22;
            // 
            // paymentsPanel
            // 
            this.paymentsPanel.Location = new System.Drawing.Point(0, 0);
            this.paymentsPanel.MinimumSize = new System.Drawing.Size(580, 365);
            this.paymentsPanel.Name = "paymentsPanel";
            this.paymentsPanel.Size = new System.Drawing.Size(580, 365);
            this.paymentsPanel.TabIndex = 23;
            // 
            // taskListPanel
            // 
            this.taskListPanel.Location = new System.Drawing.Point(0, 0);
            this.taskListPanel.MinimumSize = new System.Drawing.Size(580, 365);
            this.taskListPanel.Name = "taskListPanel";
            this.taskListPanel.Size = new System.Drawing.Size(580, 365);
            this.taskListPanel.TabIndex = 24;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(580, 365);
            this.Controls.Add(this.Panel_Main_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(580, 365);
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
        private System.Windows.Forms.Button Readings_button;
        private System.Windows.Forms.Button Contacts_button;
        private System.Windows.Forms.TextBox Events_textBox;
        private System.Windows.Forms.TextBox Readings_textBox;
        private System.Windows.Forms.TextBox Payments_textBox;
        private System.Windows.Forms.TextBox Contacts_textBox;
        private System.Windows.Forms.TextBox Task_list_textBox;
        private System.Windows.Forms.Panel Panel_Main_menu;
        private System.Windows.Forms.Button Task_List_button;
        private System.Windows.Forms.ComboBox Condo_choose_comboBox;
        private EventsPanel eventsPanel;
        private ReadingsPanel readingsPanel;
        private ContactPanel contactPanel;
        private PaymentsPanel paymentsPanel;
        private TaskListPanel taskListPanel;
    }
}

