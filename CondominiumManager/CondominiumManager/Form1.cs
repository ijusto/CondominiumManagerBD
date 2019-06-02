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
            events_user_control.Hide();
            taskList_user_control.Hide();
            payments_user_control.Hide();
            readings_user_control.Hide();
            contacts_user_control.Hide();

            // TODO: Hide other user controls
        }

        private void Events_button_Click(object sender, EventArgs e)
        {
            // Show current user control
            events_user_control.Show();
            events_user_control.BringToFront();
        }

        private void Task_List_button_Click(object sender, EventArgs e)
        {
            // Show current user control
            taskList_user_control.Show();
            taskList_user_control.BringToFront();
        }

        private void Payments_button_Click(object sender, EventArgs e)
        {
            // Show current user control
            payments_user_control.Show();
            payments_user_control.BringToFront(); 
        }

        private void Readings_button_Click(object sender, EventArgs e)
        {
            // Show current user control
            readings_user_control.Show();
            readings_user_control.BringToFront();
        }

        private void Contacts_button_Click(object sender, EventArgs e)
        {            
            // Show current user control
            contacts_user_control.Show();
            contacts_user_control.BringToFront();
        }

    }
}
