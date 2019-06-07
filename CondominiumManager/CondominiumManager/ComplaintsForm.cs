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
        private List<Complaint> compList;
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
            Fill_Complaint();
            currentComplaint = Listbox_complaints.SelectedIndex;
        }

        private void Fill_Complaint()
        {
            index = 0;
            Listbox_complaints.Items.Clear();
            compList = new List<Complaint>();
            cn = GetSGBDConnection();
            Listbox_complaints.Items.Clear();
            cn.Open();
            cmd = new SqlCommand("condomanager.showcomplaints", cn) //TODO
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
                Complaint comp = new Complaint
                {
                    Id = (int)dr["id"],
                    Date = dr["data"].ToString(),
                    Desc = dr["Descricao"].ToString(),
                    Index = index,
                    Tname = dr["nome"].ToString(),
                    Address = Chosencondo.Chosen_condo + " " + dr["ref_fracao"].ToString()
                };
                compList.Add(comp);
                Listbox_complaints.Items.Add(dr["Descricao"].ToString());
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

        private void Listbox_complaints_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentComplaint = Listbox_complaints.SelectedIndex;
            ShowComplaint();
        }

        private void ShowComplaint()
        {
            if(currentComplaint!=-1)
            {
                foreach(Complaint c in compList)
                {
                    if (c.Index == currentComplaint)
                    {
                        Date_input_textBox.Text = c.Date.Split(' ')[0];
                        Description_input_textBox.Text = c.Desc;
                        Tenant_input_textBox.Text = c.Tname;
                        Address_input_textBox.Text = c.Address;
                        if (c.Address.Split(' ')[1].ToString().Equals(""))
                        {
                            Info_Visibility("notF");
                        }
                        else
                        {
                            Info_Visibility("witchF");
                        }
                    }
                }
            }
        }

        private void Info_Visibility(string name)
        {
            if (name.Equals("load"))
            {
                Tenant_input_textBox.Hide();
                Tenant_textBox.Hide();
                Address_textBox.Hide();
                Address_input_textBox.Hide();

                Date_textBox.Hide();
                Date_input_textBox.Hide();
                Description_textBox.Hide();
                Description_input_textBox.Hide();
            }
            else if (name.Equals("notF"))
            {
                Tenant_input_textBox.Show();
                Tenant_textBox.Show();
                Address_textBox.Hide();
                Address_input_textBox.Hide();

                Date_textBox.Show();
                Date_input_textBox.Show();
                Description_textBox.Show();
                Description_input_textBox.Show();
            }
            else if (name.Equals("witchF"))
            {
                Tenant_input_textBox.Show();
                Tenant_textBox.Show();
                Address_textBox.Show();
                Address_input_textBox.Show();

                Date_textBox.Show();
                Date_input_textBox.Show();
                Description_textBox.Show();
                Description_input_textBox.Show();
            }


        }
    }
}
