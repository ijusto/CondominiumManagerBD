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
        private List<Complaint> compList = new List<Complaint>();
        private SqlConnection cn;
        private SqlCommand cmd;
        private int currentComplaint;
        private int index = 0;

        public ComplaintsForm()
        {
            InitializeComponent();
        }

        private void ComplaintsForm_Load(object sender, EventArgs e)
        {
            FillComplaint();
            currentComplaint = Combo_complaints.SelectedIndex;
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
                compList.Add(new Complaint((int)dr["id"], dr["data"].ToString(), dr["Descricao"].ToString(), index));
                Combo_complaints.Items.Add(dr["Descricao"].ToString());
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

        private void Combo_complaints_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentComplaint = Combo_complaints.SelectedIndex;
            ShowComplaint();
        }

        private void ShowComplaint()
        {
            if(currentComplaint!=-1)
            {
                foreach(Complaint c in compList)
                {
                    if(c.Index == currentComplaint)
                    {
                        Date_input_textBox.Text = c.Date.Split(' ')[0];
                        Description_input_textBox.Text = c.Desc;
                    }
                }
            }
        }
        public class Complaint
        {
            private int _index;
            private int _id;
            private string _date;
            private string _desc;

            public Complaint(int id, string date, string desc, int index)
            {
                _id = id;
                _date = date;
                _desc = desc;
                _index = index;
            }

            public int Index
            {
                get { return _index; }
                set { _index = value; }
            }

            public int Id
            {
                get { return _id; }
                set { _id = value; }
            }

            public string Date
            {
                get { return _date; }
                set { _date = value; }
            }

            public string Desc
            {
                get { return _desc; }
                set { _desc = value; }
            }
        }
    }
}
