using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CondominiumManager.MainMenuForm;

namespace CondominiumManager
{
    public partial class EventsForm : Form
    {
        private string date = "";
        private SqlConnection cn;
        private SqlCommand cmd;
        private string condo = Chosencondo.Chosen_condo;
        private string querydate = "";
        private List<Meeting> meetingsList;

        private SqlConnection GetSGBDConnection()
        {
            return new SqlConnection(path);
        }

        private bool VerifySGBDConnection()
        {
            if (cn == null)
                cn = GetSGBDConnection();

            if (cn.State != ConnectionState.Open)
                cn.Open();

            return cn.State == ConnectionState.Open;
        }

        public EventsForm()
        {
            InitializeComponent();
            date = Date_input_textBox.Text;
        }

        private void EventsForm_Load(object sender, EventArgs e)
        {
            Info_Visibility("events");
        }

        private void Repair_button_Click(object sender, EventArgs e)
        {
            Info_Visibility("Repair");
        }

        private void Meeting_button_Click(object sender, EventArgs e)
        {
            Info_Visibility("Meeting");
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            Info_Visibility("cancel");
        }

        private void Info_Visibility(string name)
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
            else if (name.Equals("Meeting"))
            {
                Damaged_textBox.Hide();
                Damaged_input_textBox.Hide();
                // Show Meeting/Repair attributs
                Name_textBox.Show();
                Name_input_textBox.Text = "";
                Name_input_textBox.Show();
                Date_textBox.Show();
                Date_input_textBox.Text = date;
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
            else if (name.Equals("Repair"))
            {
                Place_textBox.Hide();
                Place_input_textBox.Hide();
                // Show Meeting/Repair attributs
                Name_textBox.Show();
                Name_input_textBox.Text = "";
                Name_input_textBox.Show();
                Date_textBox.Show();
                Date_input_textBox.Text = date;
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
        
        private void Back_button_Click(object sender, EventArgs e)
        {
            var form = new MainMenuForm();
            form.ShowDialog();
            this.SendToBack();
            this.Close();
        }

        private void Ok_button_Click(object sender, EventArgs e)
        {
            //TODO: Save event in database
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            string startDate = monthCalendar.SelectionRange.Start.ToString("dd MMM yyyy");
            string endDate = monthCalendar.SelectionRange.End.ToString("dd MMM yyyy");
            string dateq = monthCalendar.SelectionRange.Start.ToString();
            date = startDate;
            querydate = dateq;
            Date_input_textBox.Text = date;
            CheckEventInDate();
        }

        private void CheckEventInDate()
        {
            meetingsList = new List<Meeting>();
            cn = GetSGBDConnection();
            cn.Open();
            cmd = new SqlCommand("showevents", cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            querydate = querydate.Split('/')[2]+ querydate.Split('/')[1]+ querydate.Split('/')[0];
            cmd.Parameters.AddWithValue("date", date);
            cmd.Parameters.AddWithValue("condo", condo);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Meeting meet = new Meeting();
                meet.id = (int)dr["id"];
                meet.name = dr["name"].ToString();
                meet.location = dr["localizacao"].ToString();
                meet.date = dr["data"].ToString();
                meet.description = dr["description"].ToString();
                meet.condo = dr["endereco"].ToString();

                meetingsList.Add(meet);
            }




        }
    }
}
