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

        private void Logo_button_Click(object sender, EventArgs e)
        {

        }
        private void Payments_button_Click(object sender, EventArgs e)
        {

        }
        private void Events_button_Click(object sender, EventArgs e)
        {
            // TODO: Hide other user controls
            // Show current user control
            events_user_control.Show();
            events_user_control.BringToFront();
        }
        private void Task_List_button_Click(object sender, EventArgs e)
        {

        }
        private void Readings_button_Click(object sender, EventArgs e)
        {

        }
        private void Contacts_button_Click(object sender, EventArgs e)
        {

        }
        private void Profile_button_Click(object sender, EventArgs e)
        {

        }

        private void Panel_Main_menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // Hide user controls
            events_user_control.Hide();
            // TODO: Hide other user controls
        }

        private void profile_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void events_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Payments_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Task_list_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void readings_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Contacts_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
