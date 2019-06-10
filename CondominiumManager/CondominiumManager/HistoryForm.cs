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
    public partial class HistoryForm : Form
    {
        private SqlConnection cn;
        private SqlCommand cmd;

        public HistoryForm()
        {
            InitializeComponent();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            fill_logs();
        }

        private void fill_logs()
        {
            VerifySGBDConnection();

            var cmd = new SqlCommand("select * from condomanager.view_logs")
            {
                CommandType = CommandType.Text
            };

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                listBox1.Items.Add(dr["data"].ToString() + "  " + dr["command"].ToString() + "  " + dr["descricao"].ToString());
            }

            cn.Close();
        }
    }
}
