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
    public partial class EventsPanel : UserControl
    {
        private string Data = "";

        public EventsPanel()
        {
            InitializeComponent();
        }

        private void Events_Load(object sender, EventArgs e)
        {
            Buttons_Visibility("events");
        }

        private void Repair_button_Click(object sender, EventArgs e)
        {

            Buttons_Visibility("Repair");

            // TODO: Ok
        }
        private void Meeting_button_Click(object sender, EventArgs e)
        {
            Buttons_Visibility("Meeting");
        }
        private void Cancel_button_Click(object sender, EventArgs e)
        {
            Buttons_Visibility("cancel");
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.SendToBack();
            this.Hide();
        }

        private void Buttons_Visibility(string name)
        {
            if (name.Equals("events"))
            {
                // Hide Meeting/Repair attributs
                Name_textBox.Hide();
                Name_input_textBox.Hide();
                Date_textBox.Hide();
                Date_input_textBox.Hide();
                Time_textBox.Hide();
                Hour_input_textBox.Hide();
                Minute_input_textBox.Hide();
                Type_textBox.Hide();
                Type_input_textBox.Hide();
                Place_textBox.Hide();
                Place_input_textBox.Hide();
                Damaged_textBox.Hide();
                Damaged_input_textBox.Hide();
                Description_textBox.Hide();
                Description_input_textBox.Hide();
                Ok_button.Hide();
                Cancel_button.Hide();
            }
            else if (name.Equals("cancel"))
            {
                Name_textBox.Hide();
                Name_input_textBox.Hide();
                Date_textBox.Hide();
                Date_input_textBox.Hide();
                Time_textBox.Hide();
                Hour_input_textBox.Hide();
                Minute_input_textBox.Hide();
                Type_textBox.Hide();
                Type_input_textBox.Hide();
                Place_textBox.Hide();
                Place_input_textBox.Hide();
                Damaged_textBox.Hide();
                Damaged_input_textBox.Hide();
                Description_textBox.Hide();
                Description_input_textBox.Hide();
                Ok_button.Hide();
                Cancel_button.Hide();
            }
            else if(name.Equals("Meeting"))
            {
                Damaged_textBox.Hide();
                Damaged_input_textBox.Hide();
                // Show Meeting/Repair attributs
                Name_textBox.Show();
                Name_input_textBox.Text = "";
                Name_input_textBox.Show();
                Date_textBox.Show();
                Date_input_textBox.Text = Data;
                Date_input_textBox.Show();
                Time_textBox.Show();
                Hour_input_textBox.Text = "";
                Hour_input_textBox.Show();
                Minute_input_textBox.Text = "";
                Minute_input_textBox.Show();
                Type_textBox.Show();
                Type_input_textBox.Show();
                Type_input_textBox.Text = "Meeting";
                Place_textBox.Show();
                Place_input_textBox.Text = "";
                Place_input_textBox.Show();
                Description_textBox.Show();
                Description_input_textBox.Text = "";
                Description_input_textBox.Show();
                Ok_button.Show();
                Cancel_button.Show();
            }
            else if(name.Equals("Repair"))
            {
                Place_textBox.Hide();
                Place_input_textBox.Hide();
                // Show Meeting/Repair attributs
                Name_textBox.Show();
                Name_input_textBox.Text = "";
                Name_input_textBox.Show();
                Date_textBox.Show();
                Date_input_textBox.Text = Data;
                Date_input_textBox.Show();
                Time_textBox.Show();
                Hour_input_textBox.Text = "";
                Hour_input_textBox.Show();
                Minute_input_textBox.Text = "";
                Minute_input_textBox.Show();
                Type_textBox.Show();
                Type_input_textBox.Show();
                Type_input_textBox.Text = "Repair";
                Damaged_textBox.Show();
                Damaged_input_textBox.Text = "";
                Damaged_input_textBox.Show();
                Description_textBox.Show();
                Description_input_textBox.Text = "";
                Description_input_textBox.Show();
                Ok_button.Show();
                Cancel_button.Show();
            }
        }

        private void MonthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            string startDate = monthCalendar.SelectionRange.Start.ToString("dd MMM yyyy");
            string endDate = monthCalendar.SelectionRange.End.ToString("dd MMM yyyy");
            Data = startDate;
        }
    }
}
