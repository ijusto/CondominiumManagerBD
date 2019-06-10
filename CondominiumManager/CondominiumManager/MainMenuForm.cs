using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Windows.Forms;

namespace CondominiumManager
{
    public partial class MainMenuForm : Form
    {
        private SqlConnection cn;
        SqlCommand cmd;
        private static String tomsDB = "data source= DESKTOP-RLLMGBE\\SQLEXPRESS;integrated security=true;initial catalog=condomanagerdb";
        private static String inesDB = "data source= DESKTOP-ACJ8GCN\\SQLEXPRESS;integrated security=true;initial catalog=condomanagerdb";
        private static String p2g8 = "data source = tcp:mednat.ieeta.pt\\sqlserver,8101; initial catalog=p2g8;uid=p2g8;password=1358054938@Bd";
        public static String path = inesDB;

        public MainMenuForm()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            Fill_condo_comboBox();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            if (Chosencondo.Index != 0)
            {
                Condo_choose_comboBox.SelectedIndex = Chosencondo.Index;
            }
        }

        private void Fill_condo_comboBox()
        {
            cn = GetSGBDConnection();
            Condo_choose_comboBox.Items.Clear();
            cn.Open();
            cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * from condomanager.view_condos";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Condo_choose_comboBox.Items.Add(dr["Endereco"].ToString());
            }
            cn.Close();
        }

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

        private void Events_button_Click(object sender, EventArgs e)
        {
            ChangeForm("Events");
        }

        private void Readings_button_Click(object sender, EventArgs e)
        {
            ChangeForm("Readings");
        }

        private void Contacts_button_Click(object sender, EventArgs e)
        {
            ChangeForm("Contacts");
        }

        private void Payments_button_Click(object sender, EventArgs e)
        {
            ChangeForm("Payments");
        }

        private void Complaints_button_Click(object sender, EventArgs e)
        {
            ChangeForm("Complaints");
        }

        private void ChangeForm(string name)
        {
            if(Condo_choose_comboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a condominium first.", "Warning");
            }
            else
            {
                //Hide the main form before showing the secondary
                this.Hide();

                // Show secondary form, code execution stop until next_form is closed
                if (name.Equals("Events"))
                {
                    EventsForm next_form = new EventsForm();
                    next_form.ShowDialog(); 
                }
                else if (name.Equals("Readings"))
                {
                    ReadingsForm next_form = new ReadingsForm();
                    next_form.ShowDialog();
                }
                else if (name.Equals("Contacts"))
                {
                    ContactsForm next_form = new ContactsForm();
                    next_form.ShowDialog();
                }
                else if (name.Equals("Payments"))
                {
                    PaymentsForm next_form = new PaymentsForm();
                    next_form.ShowDialog();
                }
                else if (name.Equals("Complaints"))
                {
                    ComplaintsForm next_form = new ComplaintsForm();
                    next_form.ShowDialog();
                }
                else if (name.Equals("History"))
                {
                    HistoryForm next_form = new HistoryForm();
                    next_form.ShowDialog();
                }

                //When next_form is closed, continue with the code (show main form)
                this.Show(); 
            }
        }

        private void Condo_choose_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Chosencondo.Chosen_condo = Condo_choose_comboBox.Text.ToString();
            Chosencondo.Index = Condo_choose_comboBox.SelectedIndex;
            cn = GetSGBDConnection();
            cn.Open();
          /*  cmd = new SqlCommand("condomanager.showphoto", cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("endereco", Chosencondo.Chosen_condo);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            string photo_path;
            string[] s = { "\\bin" };
            photo_path = Application.StartupPath.Split(s, StringSplitOptions.None)[0] +  dt.Rows[0]["localizacao"].ToString();
            */
            cn.Close();
            /*
            var request = WebRequest.Create(photo_path);

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                photo_pictureBox.Image = Bitmap.FromStream(stream);
            }
            */
           // photo_pictureBox.BackgroundImage = Image.FromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), photo_path));
        }

        public static class Chosencondo
        {
            private static string _chosen_condo;
            private static int _index;

            public static String Chosen_condo
            {
                get { return _chosen_condo; }
                set { _chosen_condo = value; }
            }

            public static int Index
            {
                get { return _index; }
                set { _index = value; }
            }
        }

        private void history_button1_Click(object sender, EventArgs e)
        {
            ChangeForm("History");
        }

        private void history_button2_Click(object sender, EventArgs e)
        {
            ChangeForm("History");
        }
    }

}
