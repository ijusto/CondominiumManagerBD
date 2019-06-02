using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CondominiumManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // Hide user controls
            Events_user_control.Hide();
            TaskList_user_control.Hide();
            Payments_user_control.Hide();
            Readings_user_control.Hide();
            Contacts_user_control.Hide();
        }

        private void Events_button_Click(object sender, EventArgs e)
        {
            // Show current user control
            Events_user_control.Show();
            Events_user_control.BringToFront();
        }

        private void Task_List_button_Click(object sender, EventArgs e)
        {
            // Show current user control
            TaskList_user_control.Show();
            TaskList_user_control.BringToFront();
        }

        private void Payments_button_Click(object sender, EventArgs e)
        {
            // Show current user control
            Payments_user_control.Show();
            Payments_user_control.BringToFront(); 
        }

        private void Readings_button_Click(object sender, EventArgs e)
        {
            // Show current user control
            Readings_user_control.Show();
            Readings_user_control.BringToFront();
        }

        private void Contacts_button_Click(object sender, EventArgs e)
        {
            // Show current user control
            Contacts_user_control.Show();
            Contacts_user_control.BringToFront();
        }
    }
}
