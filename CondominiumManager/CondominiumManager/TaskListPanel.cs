using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CondominiumManager
{
    public partial class TaskListPanel : UserControl
    {
        private int currentContact;

        public TaskListPanel()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.SendToBack();
            this.Hide();
        }

        private void TasklistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TasklistBox.SelectedIndex > 0)
            {
                currentContact = TasklistBox.SelectedIndex;
                //ShowContact();
            }
        }

        private void Data_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}