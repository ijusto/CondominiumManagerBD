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
        private static String tomsDB = "data source= DESKTOP-RLLMGBE\\SQLEXPRESS;integrated security=true;initial catalog=condomanagerdb";
        private static String inesDB = "data source= DESKTOP-ACJ8GCN\\SQLEXPRESS;integrated security=true;initial catalog=condomanagerdb";
        private static String p2g8 = "data source = tcp:mednat.ieeta.pt\\sqlserver,8101; initial catalog=p2g8;uid=p2g8;password=1358054938@Bd";
        public static String path = tomsDB;

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
                else if (name.Equals("Complaints"))
                {
                    var form = new ComplaintsForm();
                    form.ShowDialog();
                }
                this.SendToBack();
                this.Close();
            }
        }

        private void Condo_choose_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Chosencondo.Chosen_condo = Condo_choose_comboBox.Text.ToString();
            Chosencondo.Index = Condo_choose_comboBox.SelectedIndex;
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
    }

}
