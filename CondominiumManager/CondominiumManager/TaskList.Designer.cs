namespace CondominiumManager
{
    partial class TaskList
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
            this.tasklistBox = new System.Windows.Forms.ListBox();
            this.Reclamacoes_textBox = new System.Windows.Forms.TextBox();
            this.Data_textBox = new System.Windows.Forms.TextBox();
            this.Data_input_textBox = new System.Windows.Forms.TextBox();
            this.Condomino_textBox = new System.Windows.Forms.TextBox();
            this.Condomino_input_textBox = new System.Windows.Forms.TextBox();
            this.Morada_textBox = new System.Windows.Forms.TextBox();
            this.Morada_input_textBox = new System.Windows.Forms.TextBox();
            this.Desc_textBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tasklistBox
            // 
            this.tasklistBox.FormattingEnabled = true;
            this.tasklistBox.Location = new System.Drawing.Point(34, 45);
            this.tasklistBox.Name = "tasklistBox";
            this.tasklistBox.Size = new System.Drawing.Size(211, 251);
            this.tasklistBox.TabIndex = 0;
            // 
            // Reclamacoes_textBox
            // 
            this.Reclamacoes_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Reclamacoes_textBox.Location = new System.Drawing.Point(34, 26);
            this.Reclamacoes_textBox.Name = "Reclamacoes_textBox";
            this.Reclamacoes_textBox.Size = new System.Drawing.Size(100, 13);
            this.Reclamacoes_textBox.TabIndex = 1;
            this.Reclamacoes_textBox.Text = "Reclamações:";
            this.Reclamacoes_textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Data_textBox
            // 
            this.Data_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Data_textBox.Location = new System.Drawing.Point(264, 45);
            this.Data_textBox.Name = "Data_textBox";
            this.Data_textBox.Size = new System.Drawing.Size(37, 13);
            this.Data_textBox.TabIndex = 2;
            this.Data_textBox.Text = "Data\r\n:";
            // 
            // Data_input_textBox
            // 
            this.Data_input_textBox.Location = new System.Drawing.Point(331, 42);
            this.Data_input_textBox.Name = "Data_input_textBox";
            this.Data_input_textBox.Size = new System.Drawing.Size(89, 20);
            this.Data_input_textBox.TabIndex = 3;
            // 
            // Condomino_textBox
            // 
            this.Condomino_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Condomino_textBox.Location = new System.Drawing.Point(264, 85);
            this.Condomino_textBox.Name = "Condomino_textBox";
            this.Condomino_textBox.Size = new System.Drawing.Size(61, 13);
            this.Condomino_textBox.TabIndex = 4;
            this.Condomino_textBox.Text = "Condomino:";
            // 
            // Condomino_input_textBox
            // 
            this.Condomino_input_textBox.Location = new System.Drawing.Point(331, 82);
            this.Condomino_input_textBox.Name = "Condomino_input_textBox";
            this.Condomino_input_textBox.Size = new System.Drawing.Size(194, 20);
            this.Condomino_input_textBox.TabIndex = 5;
            // 
            // Morada_textBox
            // 
            this.Morada_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Morada_textBox.Location = new System.Drawing.Point(264, 122);
            this.Morada_textBox.Name = "Morada_textBox";
            this.Morada_textBox.Size = new System.Drawing.Size(61, 13);
            this.Morada_textBox.TabIndex = 6;
            this.Morada_textBox.Text = "Morada:";
            // 
            // Morada_input_textBox
            // 
            this.Morada_input_textBox.Location = new System.Drawing.Point(331, 119);
            this.Morada_input_textBox.Name = "Morada_input_textBox";
            this.Morada_input_textBox.Size = new System.Drawing.Size(194, 20);
            this.Morada_input_textBox.TabIndex = 7;
            // 
            // Desc_textBox
            // 
            this.Desc_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Desc_textBox.Location = new System.Drawing.Point(264, 158);
            this.Desc_textBox.Name = "Desc_textBox";
            this.Desc_textBox.Size = new System.Drawing.Size(61, 13);
            this.Desc_textBox.TabIndex = 8;
            this.Desc_textBox.Text = "Descrição:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(331, 155);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 141);
            this.textBox1.TabIndex = 9;
            // 
            // TaskList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Desc_textBox);
            this.Controls.Add(this.Morada_input_textBox);
            this.Controls.Add(this.Morada_textBox);
            this.Controls.Add(this.Condomino_input_textBox);
            this.Controls.Add(this.Condomino_textBox);
            this.Controls.Add(this.Data_input_textBox);
            this.Controls.Add(this.Data_textBox);
            this.Controls.Add(this.Reclamacoes_textBox);
            this.Controls.Add(this.tasklistBox);
            this.MinimumSize = new System.Drawing.Size(557, 365);
            this.Name = "TaskList";
            this.Size = new System.Drawing.Size(580, 365);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox tasklistBox;
        private System.Windows.Forms.TextBox Reclamacoes_textBox;
        private System.Windows.Forms.TextBox Data_textBox;
        private System.Windows.Forms.TextBox Data_input_textBox;
        private System.Windows.Forms.TextBox Condomino_textBox;
        private System.Windows.Forms.TextBox Condomino_input_textBox;
        private System.Windows.Forms.TextBox Morada_textBox;
        private System.Windows.Forms.TextBox Morada_input_textBox;
        private System.Windows.Forms.TextBox Desc_textBox;
        private System.Windows.Forms.TextBox textBox1;
    }
}
