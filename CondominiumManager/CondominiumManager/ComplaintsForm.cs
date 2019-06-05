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
    public partial class ComplaintsForm : Form
    {
        private SqlConnection cn;
        SqlCommand cmd;

        private SqlConnection GetSGBDConnection()
        {
            SqlConnection toms = new SqlConnection("data source= DESKTOP-RLLMGBE\\SQLEXPRESS;integrated security=true;initial catalog=condomanagerdb");
            SqlConnection ines = new SqlConnection("data source= DESKTOP-ACJ8GCN\\SQLEXPRESS;integrated security=true;initial catalog=condomanagerdb");
            return toms;
        }

        private bool VerifySGBDConnection()
        {
            if (cn == null)
                cn = GetSGBDConnection();

            if (cn.State != ConnectionState.Open)
                cn.Open();

            return cn.State == ConnectionState.Open;
        }


        private int currentContact;

        public ComplaintsForm()
        {
            InitializeComponent();
        }

        private void FillComplaint()
        {
            cn = GetSGBDConnection();
            Combo_complaints.Items.Clear();
            cn.Open();
            cmd = new SqlCommand("showcomplaints", cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("endereco", Chosencondo.Chosen_condo);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Combo_complaints.Items.Add(dr["Descricao"].ToString());
            }
            cn.Close();


        }

        private void TaskListForm_Load(object sender, EventArgs e)
        {
            FillComplaint();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            var form = new MainMenuForm();
            form.ShowDialog();
            this.SendToBack();
            this.Close();
        }

        private void Combo_complaints_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Combo_complaints.SelectedIndex > 0)
            {
                currentContact = Combo_complaints.SelectedIndex;
                //ShowContact();
            }
        }
    }
}
