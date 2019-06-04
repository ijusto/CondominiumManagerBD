using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CondominiumManager
{
    public partial class Form1 : Form
    {
        private SqlConnection cn;
        SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            Fill_condo_comboBox();
        }

        private void Fill_condo_comboBox()
        {
            cn = GetSGBDConnection();
            Condo_choose_comboBox.Items.Clear();
            cn.Open();
            cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Endereco FROM [CONDOMANAGER].[Condominio]";
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
            return new SqlConnection("data source= DESKTOP-ACJ8GCN\\SQLEXPRESS;integrated security=true;initial catalog=condomanagerdb");
        }

        private bool VerifySGBDConnection()
        {
            if (cn == null)
                cn = GetSGBDConnection();

            if (cn.State != ConnectionState.Open)
                cn.Open();

            return cn.State == ConnectionState.Open;
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

        private void Contacts_user_control_Load(object sender, EventArgs e)
        {

        }

        private void Payments_user_control_Load(object sender, EventArgs e)
        {

        }
    }
}
