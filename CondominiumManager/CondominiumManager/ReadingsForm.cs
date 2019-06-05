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
    public partial class ReadingsForm : Form
    {
        private List<Apartment> apList;
        private SqlConnection cn;
        private SqlCommand cmd;
        private int currentAppart;
        private int index = 0;

        public ReadingsForm()
        {
            InitializeComponent();
        }

        private void ReadingsForm_Load(object sender, EventArgs e)
        {
            Fill_Apart();
            currentAppart = apart_listBox.SelectedIndex;
        }

        private void Fill_Apart()
        {
            index = 0;
            apart_listBox.Items.Clear();
            apList = new List<Apartment>();
            cn = GetSGBDConnection();
            apart_listBox.Items.Clear();
            cn.Open();
            cmd = new SqlCommand("showcomplaints", cn)  //TODO
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("endereco", Chosencondo.Chosen_condo);   //TODO
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                //apList.Add(new Apartment((int)dr["id"], dr["data"].ToString(), dr["Descricao"].ToString(), "", index));  //TODO
                apart_listBox.Items.Add(dr["Descricao"].ToString());
                index++;
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

        private void Back_button_Click(object sender, EventArgs e)
        {
            var form = new MainMenuForm();
            form.ShowDialog();
            this.SendToBack();
            this.Close();
        }

        private void Apart_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentAppart = apart_listBox.SelectedIndex;
            ShowReadings();
        }

        private void ShowReadings()
        {
            if (currentAppart != -1)
            {
                foreach (Apartment a in apList)
                {
                    if (a.Index == currentAppart)
                    {
                        //TODO
                    }
                }
            }
        }
    }
}
