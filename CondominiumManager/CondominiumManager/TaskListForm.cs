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
    public partial class TaskListForm : Form
    {
        private SqlConnection cn;
        SqlCommand cmd;

        private SqlConnection GetSGBDConnection()
        {
            return new SqlConnection("data source= DESKTOP-RLLMGBE\\SQLEXPRESS;integrated security=true;initial catalog=condomanagerdb");
            //return new SqlConnection("data source= DESKTOP-ACJ8GCN\\SQLEXPRESS;integrated security=true;initial catalog=condomanagerdb");
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

        public TaskListForm()
        {
            InitializeComponent();
        }

        private void fillComplaint()
        {
            cn = GetSGBDConnection();
            Combo_complaints.Items.Clear();
            cn.Open();
            SqlCommand cmd = new SqlCommand("showcomplaints", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("endereco", chosencondo.chosen_condo);
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
            fillComplaint();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            var form = new MainMenuForm();
            form.ShowDialog();
            this.SendToBack();
            this.Close();
        }

        private void TasklistBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (TasklistBox.SelectedIndex > 0)
            {
                currentContact = TasklistBox.SelectedIndex;
                //ShowContact();
            }
        }
    }
}
