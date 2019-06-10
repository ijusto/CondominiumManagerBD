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
        private List<Meeting> meetListBold;
        private List<Repair> repairListBold;
        private int currentEvent;
        private int e_index = 0;
        private bool edit_event = false;
        private bool delete_event = false;
        private bool creating_event = false;
        private DateTime check_date;
        private bool isMeeting;

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
            check_date = monthCalendar.TodayDate;
        }

        private void EventsForm_Load(object sender, EventArgs e)
        {
            BoldCalendarDates();
            currentEvent = Events_At_Date_listBox.SelectedIndex;
            Info_Visibility("load");
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
            Info_Visibility("load");
        }

        private void Book_Ok_button_Click(object sender, EventArgs e)
        {
            creating_event = false;
            cn = GetSGBDConnection();
            cn.Open();
            if (Type_input_textBox.Text.Equals("Meeting"))
            {
                cmd_ok = new SqlCommand("condomanager.insertmeeting", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd_ok.Parameters.AddWithValue("nome", Name_input_textBox.Text);
                cmd_ok.Parameters.AddWithValue("data", check_date);
                cmd_ok.Parameters.AddWithValue("descricao", Description_input_textBox.Text);
                cmd_ok.Parameters.AddWithValue("localizacao", Location_input_textBox.Text);
                cmd_ok.Parameters.AddWithValue("endereco", Chosencondo.Chosen_condo);
                cmd_ok.ExecuteNonQuery();
            }
            else if (Type_input_textBox.Text.Equals("Repair"))
            {
                cmd_ok = new SqlCommand("condomanager.insertrepair", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd_ok.Parameters.AddWithValue("nome", Name_input_textBox.Text);
                cmd_ok.Parameters.AddWithValue("data", check_date);
                cmd_ok.Parameters.AddWithValue("descricao", Description_input_textBox.Text);
                cmd_ok.Parameters.AddWithValue("danificado", Damaged_input_textBox.Text);
                cmd_ok.Parameters.AddWithValue("endereco", Chosencondo.Chosen_condo);
                cmd_ok.ExecuteNonQuery();
            }
            cn.Close();
            Info_Visibility("event_info");
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            creating_event = false;
            Info_Visibility("load");
            string startDate = monthCalendar.SelectionRange.Start.ToString("dd MMM yyyy");
            string endDate = monthCalendar.SelectionRange.End.ToString("dd MMM yyyy");

            check_date = monthCalendar.SelectionRange.Start;
            date = startDate;
            Date_input_textBox.Text = date;
            CheckEventInDate();
        }

        private void CheckEventInDate()
        {
            e_index = 0;
            Events_At_Date_listBox.Items.Clear();
            meetList = new List<Meeting>();
            repairList = new List<Repair>();
            Events_At_Date_listBox.ClearSelected();
            cn = GetSGBDConnection();
            cn.Open();
            cmd_repair = new SqlCommand("condomanager.showrepairs", cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd_meet = new SqlCommand("condomanager.showmeetings", cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd_meet.Parameters.AddWithValue("date", check_date);
            cmd_repair.Parameters.AddWithValue("date", check_date);
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
            List<DateTime> d = new List<DateTime>();
            foreach (DataRow dr in dt.Rows)
            {
                Meeting meet = new Meeting
                {
                    Name = dr["nome"].ToString(),
                    Location = dr["localizacao"].ToString(),
                    Date = dr["data"].ToString(),
                    Description = dr["descricao"].ToString(),
                    Condo = dr["endereco"].ToString(),
                    Id = (int)dr["id"],
                    Index = e_index
                };
                meetList.Add(meet);
                Events_At_Date_listBox.Items.Add(dr["nome"].ToString());
                e_index++;
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
                    Id = (int)dr["id"],
                    Index = e_index
                };
                repairList.Add(rep);
                Events_At_Date_listBox.Items.Add(dr["nome"].ToString());
                e_index++;
                if (!creating_event)
                {
                    Info_Visibility("event_info");
                }
            }
            cn.Close();
        }

        private void BoldCalendarDates()
        {
            List<DateTime> d = new List<DateTime>();
            meetListBold = new List<Meeting>();
            repairListBold = new List<Repair>();
            foreach (String day in GetMonth())
            {
                cn = GetSGBDConnection();
                cn.Open();
                cmd_repair = new SqlCommand("condomanager.showrepairs", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd_meet = new SqlCommand("condomanager.showmeetings", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                String todayDate = day + "/" + monthCalendar.TodayDate.Month.ToString() + "/" + monthCalendar.TodayDate.Year.ToString();
                cmd_meet.Parameters.AddWithValue("date", new DateTime(int.Parse(monthCalendar.TodayDate.Year.ToString()), int.Parse(monthCalendar.TodayDate.Month.ToString()), int.Parse(day)));
                cmd_repair.Parameters.AddWithValue("date", new DateTime(int.Parse(monthCalendar.TodayDate.Year.ToString()), int.Parse(monthCalendar.TodayDate.Month.ToString()), int.Parse(day)));
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
                    if (todayDate.Split('/')[0].Equals(dr["data"].ToString().Split(' ')[0].Split('/')[0]))
                    {
                        d.Add(new DateTime(int.Parse(dr["data"].ToString().Split(' ')[0].Split('/')[2]), Int32.Parse(dr["data"].ToString().Split(' ')[0].Split('/')[1]), Int32.Parse(dr["data"].ToString().Split(' ')[0].Split('/')[0])));
                    }
                }
                foreach (DataRow dr in dt_repair.Rows)
                {
                    if (todayDate.Split('/')[0].Equals(dr["data"].ToString().Split(' ')[0]))
                    {
                        d.Add(new DateTime(int.Parse(dr["data"].ToString().Split(' ')[0].Split('/')[2]), Int32.Parse(dr["data"].ToString().Split(' ')[0].Split('/')[1]), Int32.Parse(dr["data"].ToString().Split(' ')[0].Split('/')[0])));
                    }
                }
                cn.Close();
            }
            monthCalendar.BoldedDates = d.ToArray();
        }

        private void Events_At_Date_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentEvent = Events_At_Date_listBox.SelectedIndex;
            ShowEvent();
            if(currentEvent>-1)
            {
                //Show buttons
                Edit_button.Show();
                Delete_button.Show();
            }
        }

        private void ShowEvent()
        {
            if (currentEvent != -1)
            {
                foreach (Meeting m in meetList)
                {
                    if (m.Index == currentEvent)
                    {
                        isMeeting = true;
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
                        isMeeting = false;
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
            edit_event = true;
            Cancel_Edit_OR_Delete_button.Show();
            OK_Edit_OR_Delete_button.Show();
            Edit_button.Hide();
            Delete_button.Hide();
            Name_input_Event_Info_textBox.ReadOnly = false;
            Name_input_Event_Info_textBox.Enabled = true;
            Location_OR_Damage_input_Event_Info_textBox.ReadOnly = false;
            Location_OR_Damage_input_Event_Info_textBox.Enabled = true;
            Desc_input_Event_Info_textBox.ReadOnly = false;
            Desc_input_Event_Info_textBox.Enabled = true;
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {

            delete_event = true;
            Cancel_Edit_OR_Delete_button.Show();
            OK_Edit_OR_Delete_button.Show();
            Edit_button.Hide();
            Delete_button.Hide();
            Delete_sure_textBox.Text = "Are you sure you want to delete \"" + Name_input_Event_Info_textBox.Text + "\" on " + date + "?";
            Delete_sure_textBox.Show();
        }

        private void Cancel_Edit_OR_Delete_button_Click(object sender, EventArgs e)
        {
            edit_event = false;
            delete_event = false;
            Cancel_Edit_OR_Delete_button.Hide();
            OK_Edit_OR_Delete_button.Hide();
            Edit_button.Show();
            Delete_button.Show();
            Delete_sure_textBox.Hide();
        }

        private void OK_Edit_OR_Delete_button_Click(object sender, EventArgs e)
        {
            Delete_sure_textBox.Hide();
            if (edit_event)
            {
                if (isMeeting)
                {
                    Meeting m;
                    foreach(Meeting meet in meetList)
                    {
                        if(meet.Index == Events_At_Date_listBox.SelectedIndex)
                        {
                            m = meet;
                            cn = GetSGBDConnection();
                            cn.Open();
                            cmd_meet = new SqlCommand("condomanager.editmeeting", cn)
                            {
                                CommandType = CommandType.StoredProcedure
                            };
                            cmd_meet.Parameters.AddWithValue("id", m.Id);
                            cmd_meet.Parameters.AddWithValue("nome", Name_input_Event_Info_textBox.Text);
                            cmd_meet.Parameters.AddWithValue("localizacao", Location_OR_Damage_input_Event_Info_textBox.Text);
                            cmd_meet.Parameters.AddWithValue("descricao", Desc_input_Event_Info_textBox.Text);
                            cmd_meet.ExecuteNonQuery();
                            break;
                        }
                    }
                }
                else
                {
                    Repair r;
                    foreach (Repair repair in repairList)
                    {
                        if (repair.Index == Events_At_Date_listBox.SelectedIndex)
                        {
                            r = repair;
                            cn = GetSGBDConnection();
                            cn.Open();
                            cmd_repair = new SqlCommand("condomanager.editrepair", cn)
                            {
                                CommandType = CommandType.StoredProcedure
                            };
                            cmd_repair.Parameters.AddWithValue("id", r.Id);
                            cmd_repair.Parameters.AddWithValue("nome", Name_input_Event_Info_textBox.Text);
                            cmd_repair.Parameters.AddWithValue("danificado", Location_OR_Damage_input_Event_Info_textBox.Text);
                            cmd_repair.Parameters.AddWithValue("descricao", Desc_input_Event_Info_textBox.Text);
                            cmd_repair.ExecuteNonQuery();
                            break;
                        }
                    }
                }
            }
            else if(delete_event)
            {
                if(isMeeting)
                {
                    Meeting m;
                    foreach (Meeting meet in meetList)
                    {
                        if (meet.Index == Events_At_Date_listBox.SelectedIndex)
                        {
                            m = meet;
                            cn = GetSGBDConnection();
                            cn.Open();
                            cmd_meet = new SqlCommand("condomanager.deletemeeting", cn)
                            {
                                CommandType = CommandType.StoredProcedure
                            };
                            cmd_meet.Parameters.AddWithValue("id", m.Id);
                            cmd_meet.ExecuteNonQuery();
                        }
                    }
                } else
                {
                    Repair r;
                    foreach (Repair repair in repairList)
                    {
                        if (repair.Index == Events_At_Date_listBox.SelectedIndex)
                        {
                            r = repair;
                            cn = GetSGBDConnection();
                            cn.Open();
                            cmd_repair = new SqlCommand("condomanager.deleterepair", cn)
                            {
                                CommandType = CommandType.StoredProcedure
                            };
                            cmd_repair.Parameters.AddWithValue("id", r.Id);
                            cmd_repair.ExecuteNonQuery();
                        }
                    }
                }
                Name_Event_Info_textBox.Hide();
                Name_input_Event_Info_textBox.Hide();
                Location_OR_Damage_Event_Info_textBox.Hide();
                Location_OR_Damage_input_Event_Info_textBox.Hide();
                Desc_Event_Info_textBox.Hide();
                Desc_input_Event_Info_textBox.Hide();
            }
            CheckEventInDate();
            BoldCalendarDates();
            edit_event = false;
            delete_event = false;
            Cancel_Edit_OR_Delete_button.Hide();
            OK_Edit_OR_Delete_button.Hide();
            Edit_button.Hide();
            Delete_button.Hide();

            Name_input_Event_Info_textBox.ReadOnly = true;
            Name_input_Event_Info_textBox.Enabled = false;
            Location_OR_Damage_input_Event_Info_textBox.ReadOnly = true;
            Location_OR_Damage_input_Event_Info_textBox.Enabled = false;
            Desc_input_Event_Info_textBox.ReadOnly = true;
            Desc_input_Event_Info_textBox.Enabled = false;

        }

        private void Info_Visibility(string name)
        {
            if (name.Equals("load"))
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

                Delete_sure_textBox.Hide();
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
        }

        private List<String> GetMonth()
        {
            List<String> days = new List<String>();
            int num = 0;
            while (num < 31)
            {
                num++;
                days.Add(num.ToString());
            }
            switch (check_date.Month)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    return days;

                case 4: case 6: case 9: case 11:
                    days.Remove("31");
                    return days;

                case 2:
                    days.Remove("31");
                    days.Remove("30");
                    return days;

                default:
                    days.Remove("31");
                    days.Remove("30");
                    return days;
            }
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}




