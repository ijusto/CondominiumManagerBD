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
        private SqlCommand cmd_ok;
        private SqlCommand cmd_meet;
        private SqlCommand cmd_repair;
        private string condo = Chosencondo.Chosen_condo;
        private List<Meeting> meetList;
        private List<Repair> repairList;
        private int currentEvent;
        private int m_index = 0;
        private int r_index = 0;
        private bool edit = false;
        private bool delete = false;

        private bool creating_event = false;

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
            currentEvent = Events_At_Date_listBox.SelectedIndex;
            Info_Visibility("events");
        }

        private void Repair_button_Click(object sender, EventArgs e)
        {
            creating_event = true;
            Info_Visibility("Repair");
        }

        private void Meeting_button_Click(object sender, EventArgs e)
        {
            creating_event = true;
            Info_Visibility("Meeting");
        }

        private void Book_Cancel_button_Click(object sender, EventArgs e)
        {
            creating_event = false;
            Info_Visibility("cancel");
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            var form = new MainMenuForm();
            form.ShowDialog();
            this.SendToBack();
            this.Close();
        }

        private void Book_Ok_button_Click(object sender, EventArgs e)
        {
            creating_event = false;
            cn = GetSGBDConnection();
            cn.Open();
            if (Type_input_textBox.Text.Equals("Meeting"))
            {
                cmd_ok = new SqlCommand("insertmeeting", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd_ok.Parameters.AddWithValue("nome", Name_input_textBox.Text);
                cmd_ok.Parameters.AddWithValue("data", date + " " + Hour_input_textBox.Text + ":" + Minute_input_textBox.Text + ":00");
                cmd_ok.Parameters.AddWithValue("descricao", Description_input_textBox.Text);
                cmd_ok.Parameters.AddWithValue("localizacao", Location_input_textBox.Text);
                cmd_ok.Parameters.AddWithValue("endereco", Chosencondo.Chosen_condo);
                cmd_ok.ExecuteNonQuery();
            }
            else if (Type_input_textBox.Text.Equals("Repair"))
            {
                cmd_ok = new SqlCommand("insertrepair", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd_ok.Parameters.AddWithValue("nome", Name_input_textBox.Text);
                cmd_ok.Parameters.AddWithValue("data", date + " " + Hour_input_textBox.Text + ":" + Minute_input_textBox.Text + ":00");
                cmd_ok.Parameters.AddWithValue("descricao", Description_input_textBox.Text);
                cmd_ok.Parameters.AddWithValue("danificado", Damaged_input_textBox.Text);
                cmd_ok.Parameters.AddWithValue("endereco", Chosencondo.Chosen_condo);
                cmd_ok.ExecuteNonQuery();
            }
            cn.Close();
            Info_Visibility("cancel");
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            creating_event = false;
            Info_Visibility("events");
            string startDate = monthCalendar.SelectionRange.Start.ToString("dd MMM yyyy");
            string endDate = monthCalendar.SelectionRange.End.ToString("dd MMM yyyy");
            date = startDate;
            Date_input_textBox.Text = date;
            CheckEventInDate();
        }

        private void CheckEventInDate()
        {
            m_index = 0;
            r_index = 0;
            Events_At_Date_listBox.Items.Clear();
            meetList = new List<Meeting>();
            repairList = new List<Repair>();
            Events_At_Date_listBox.ClearSelected();
            cn = GetSGBDConnection();
            cn.Open();
            cmd_repair = new SqlCommand("showrepairs", cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd_meet = new SqlCommand("showmeetings", cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd_meet.Parameters.AddWithValue("date", date);
            cmd_repair.Parameters.AddWithValue("date", date);
            cmd_meet.Parameters.AddWithValue("condo", condo);
            cmd_repair.Parameters.AddWithValue("condo", condo);
            cmd_meet.ExecuteNonQuery();
            cmd_repair.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd_meet);
            da.Fill(dt);
            DataTable dt_repair = new DataTable();
            SqlDataAdapter da_repair = new SqlDataAdapter(cmd_repair);
            da_repair.Fill(dt_repair);
            foreach (DataRow dr in dt.Rows)
            {
                Meeting meet = new Meeting
                {
                    Name = dr["nome"].ToString(),
                    Location = dr["localizacao"].ToString(),
                    Date = dr["data"].ToString(),
                    Description = dr["descricao"].ToString(),
                    Condo = dr["endereco"].ToString(),
                    Index = m_index
                };
                meetList.Add(meet);
                Events_At_Date_listBox.Items.Add(dr["nome"].ToString());
                m_index++;
                if (!creating_event)
                {
                    Info_Visibility("event_info");
                }
            }
            foreach (DataRow dr in dt_repair.Rows)
            {
                Repair rep = new Repair
                {
                    Name = dr["nome"].ToString(),
                    Damaged = dr["danificado"].ToString(),
                    Date = dr["data"].ToString(),
                    Description = dr["descricao"].ToString(),
                    Condo = dr["endereco"].ToString(),
                    Index = m_index
                };
                repairList.Add(rep);
                Events_At_Date_listBox.Items.Add(dr["nome"].ToString());
                r_index++;
                if (!creating_event)
                {
                    Info_Visibility("event_info");
                }
            }
            cn.Close();
        }
        
        private void Events_At_Date_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentEvent = Events_At_Date_listBox.SelectedIndex;
            ShowEvent();
        }

        private void ShowEvent()
        {
            if (currentEvent != -1)
            {
                foreach (Meeting m in meetList)
                {
                    if (m.Index == currentEvent)
                    {
                        // Show Event info
                        Name_Event_Info_textBox.Show();
                        Name_input_Event_Info_textBox.Show();
                        Name_input_Event_Info_textBox.Text = m.Name;
                        Location_OR_Damage_Event_Info_textBox.Text = "Location";
                        Location_OR_Damage_Event_Info_textBox.Show();
                        Location_OR_Damage_input_Event_Info_textBox.Show();
                        Location_OR_Damage_input_Event_Info_textBox.Text = m.Location;
                        Desc_Event_Info_textBox.Show();
                        Desc_input_Event_Info_textBox.Text = m.Description;
                        Desc_input_Event_Info_textBox.Show();
                    }
                }
                foreach (Repair r in repairList)
                {
                    if (r.Index == currentEvent)
                    {
                        // Show Event info
                        Name_Event_Info_textBox.Show();
                        Name_input_Event_Info_textBox.Show();
                        Name_input_Event_Info_textBox.Text = r.Name;
                        Location_OR_Damage_Event_Info_textBox.Text = "Damaged";
                        Location_OR_Damage_Event_Info_textBox.Show();
                        Location_OR_Damage_input_Event_Info_textBox.Show();
                        Location_OR_Damage_input_Event_Info_textBox.Text = r.Damaged;
                        Desc_Event_Info_textBox.Show();
                        Desc_input_Event_Info_textBox.Text = r.Description;
                        Desc_input_Event_Info_textBox.Show();
                    }
                }
            }
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            edit = true;
            delete = false;
            Cancel_Edit_OR_Delete_button.Show();
            OK_Edit_OR_Delete_button.Show();
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            edit = false;
            delete = true;
            Cancel_Edit_OR_Delete_button.Show();
            OK_Edit_OR_Delete_button.Show();
        }

        private void Cancel_Edit_OR_Delete_button_Click(object sender, EventArgs e)
        {
            Cancel_Edit_OR_Delete_button.Hide();
            OK_Edit_OR_Delete_button.Hide();
        }

        private void OK_Edit_OR_Delete_button_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                // TODO Edit Event
            }
            else if(delete)
            {
                // TODO Delete Event
            }
            Cancel_Edit_OR_Delete_button.Hide();
            OK_Edit_OR_Delete_button.Hide();
        }

        private void Info_Visibility(string name)
        {
            if (name.Equals("events"))
            {
                // Hide Events info
                Events_At_Date_textBox.Hide();
                Events_At_Date_listBox.Hide();
                Name_Event_Info_textBox.Hide();
                Name_input_Event_Info_textBox.Hide();
                Location_OR_Damage_Event_Info_textBox.Hide();
                Location_OR_Damage_input_Event_Info_textBox.Hide();
                Desc_Event_Info_textBox.Hide();
                Desc_input_Event_Info_textBox.Hide();
                Edit_button.Hide();
                Delete_button.Hide();
                Cancel_Edit_OR_Delete_button.Hide();
                OK_Edit_OR_Delete_button.Hide();

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
                Location_textBox.Hide();
                Location_input_textBox.Hide();
                Damaged_textBox.Hide();
                Damaged_input_textBox.Hide();
                Description_textBox.Hide();
                Description_input_textBox.Hide();
                Book_Ok_button.Hide();
                Book_Cancel_button.Hide();
            }
            else if (name.Equals("cancel"))
            {
                // Hide Events info
                Events_At_Date_textBox.Hide();
                Events_At_Date_listBox.Hide();
                Name_Event_Info_textBox.Hide();
                Name_input_Event_Info_textBox.Hide();
                Location_OR_Damage_Event_Info_textBox.Hide();
                Location_OR_Damage_input_Event_Info_textBox.Hide();
                Desc_Event_Info_textBox.Hide();
                Desc_input_Event_Info_textBox.Hide();
                Edit_button.Hide();
                Delete_button.Hide();
                Cancel_Edit_OR_Delete_button.Hide();
                OK_Edit_OR_Delete_button.Hide();

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
                Location_textBox.Hide();
                Location_input_textBox.Hide();
                Damaged_textBox.Hide();
                Damaged_input_textBox.Hide();
                Description_textBox.Hide();
                Description_input_textBox.Hide();
                Book_Ok_button.Hide();
                Book_Cancel_button.Hide();
            }
            else if (name.Equals("Meeting"))
            {
                // Hide Events info
                Events_At_Date_textBox.Hide();
                Events_At_Date_listBox.Hide();
                Name_Event_Info_textBox.Hide();
                Name_input_Event_Info_textBox.Hide();
                Location_OR_Damage_Event_Info_textBox.Hide();
                Location_OR_Damage_input_Event_Info_textBox.Hide();
                Desc_Event_Info_textBox.Hide();
                Desc_input_Event_Info_textBox.Hide();
                Edit_button.Hide();
                Delete_button.Hide();
                Cancel_Edit_OR_Delete_button.Hide();
                OK_Edit_OR_Delete_button.Hide();

                // Show Meeting attributs
                Damaged_textBox.Hide();
                Damaged_input_textBox.Hide();
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
                Location_textBox.Show();
                Location_input_textBox.Text = "";
                Location_input_textBox.Show();
                Description_textBox.Show();
                Description_input_textBox.Text = "";
                Description_input_textBox.Show();
                Book_Ok_button.Show();
                Book_Cancel_button.Show();
            }
            else if (name.Equals("Repair"))
            {
                // Hide Events info
                Events_At_Date_textBox.Hide();
                Events_At_Date_listBox.Hide();
                Name_Event_Info_textBox.Hide();
                Name_input_Event_Info_textBox.Hide();
                Location_OR_Damage_Event_Info_textBox.Hide();
                Location_OR_Damage_input_Event_Info_textBox.Hide();
                Desc_Event_Info_textBox.Hide();
                Desc_input_Event_Info_textBox.Hide();
                Edit_button.Hide();
                Delete_button.Hide();
                Cancel_Edit_OR_Delete_button.Hide();
                OK_Edit_OR_Delete_button.Hide();

                // Show Repair attributs
                Location_textBox.Hide();
                Location_input_textBox.Hide();
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
                Book_Ok_button.Show();
                Book_Cancel_button.Show();
            }
            else if (name.Equals("event_info"))
            {
                // Show Events info
                Events_At_Date_textBox.Show();
                Events_At_Date_textBox.Text = "Events on " + date;
                Events_At_Date_listBox.Show();
                Cancel_Edit_OR_Delete_button.Hide();
                OK_Edit_OR_Delete_button.Hide();

                // Hide Events info
                Name_Event_Info_textBox.Hide();
                Name_input_Event_Info_textBox.Hide();
                Location_OR_Damage_Event_Info_textBox.Hide();
                Location_OR_Damage_input_Event_Info_textBox.Hide();
                Desc_Event_Info_textBox.Hide();
                Desc_input_Event_Info_textBox.Hide();

                //Show buttons
                Edit_button.Show();
                Delete_button.Show();
            }
        }
    }
}
