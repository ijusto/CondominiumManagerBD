using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CondominiumManager
{
    public partial class MainMenuForm : Form
    {
        private SqlConnection cn;
        SqlCommand cmd;

        public MainMenuForm()
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
            //return new SqlConnection("data source= DESKTOP-RLLMGBE\\SQLEXPRESS;integrated security=true;initial catalog=condomanagerdb");
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

        private void Task_List_button_Click(object sender, EventArgs e)
        {
            ChangeForm("TaskList");
        }

        private void ChangeForm(string name)
        {
            if (name.Equals("Events"))
            {
                var form = new EventsForm();
                form.ShowDialog();
            }
            else if (name.Equals("Readings"))
            {
                var form = new ReadingsForm();
                form.ShowDialog();
            }
            else if (name.Equals("Contacts"))
            {
                var form = new ContactsForm();
                form.ShowDialog();
            }
            else if (name.Equals("Payments"))
            {
                var form = new PaymentsForm();
                form.ShowDialog();
            }
            else if (name.Equals("TaskList"))
            {
                var form = new TaskListForm();
                form.ShowDialog();
            }
            this.SendToBack();
            this.Close();
        }
    }
}
