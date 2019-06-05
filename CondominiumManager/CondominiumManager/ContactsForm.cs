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
    public partial class ContactsForm : Form
    {
        private List<Tenant> tenList = new List<Tenant>();
        private List<Services_Provider> spList = new List<Services_Provider>();
        private SqlConnection cn;
        private SqlCommand cmd;
        private int currentTenant;
        private int currentSrvProv;
        private int ten_index = 0;
        private int sp_index = 0;

        public ContactsForm()
        {
            InitializeComponent();
        }

        private void ContactsForm_Load(object sender, EventArgs e)
        {
            Info_Visibility("Contacts_Load");
            Fill_TenantContacts();
            currentTenant = Tenants_listBox.SelectedIndex;
            Fill_Serv_Prov_Contacts();
            currentSrvProv = Serv_Providers_listBox.SelectedIndex;
        }

        private void Fill_TenantContacts()
        {
            cn = GetSGBDConnection();
            Serv_Providers_listBox.Items.Clear();
            cn.Open();
            cmd = new SqlCommand("showcontacts", cn)
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
                tenList.Add(new Tenant(dr["NIF"].ToString(), dr["Nome"].ToString(), dr["Telemovel"].ToString(), dr["Email"].ToString(), ten_index));
                Tenants_listBox.Items.Add(dr["Nome"].ToString());
                ten_index++;
            }
            cn.Close();
        }

        private void Fill_Serv_Prov_Contacts()
        {
            cn = GetSGBDConnection();
            Serv_Providers_listBox.Items.Clear();
            cn.Open();
            cmd = new SqlCommand("getsupplier", cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                spList.Add(new Services_Provider(dr["NIF"].ToString(), dr["Nome"].ToString(), dr["Telemovel"].ToString(), dr["Morada"].ToString(), dr["descricao"].ToString(), sp_index));
                Serv_Providers_listBox.Items.Add(dr["Nome"].ToString());
                sp_index++;
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

        private void Tenants_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentTenant = Tenants_listBox.SelectedIndex;
            if (currentTenant != -1) { Serv_Providers_listBox.ClearSelected(); }
            Info_Visibility("TenantContact");
            ShowTenantContact();
        }

        private void Serv_Providers_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentSrvProv = Serv_Providers_listBox.SelectedIndex;
            if(currentSrvProv!=-1) { Tenants_listBox.ClearSelected(); }
            Info_Visibility("SPContact");
            ShowSPContact();
        }

        private void Info_Visibility(string name)
        {
            if (name.Equals("Contacts_Load"))
            {
                // Hide Tenant/Service_Provider attributs
                Name_textBox.Hide();
                Name_input_textBox.Hide();
                Mobile_textBox.Hide();
                Mobile_input_textBox.Hide();
                Email_OR_Address_textBox.Hide();
                Email_OR_Address_input_textBox.Hide();
                Type_textBox.Hide();
                Type_input_textBox.Hide();
            }
            else if(name.Equals("TenantContact"))
            {
                // Show Tenant attributs
                Name_textBox.Show();
                Name_input_textBox.Show();
                Mobile_textBox.Show();
                Mobile_input_textBox.Show();
                Email_OR_Address_textBox.Show();
                Email_OR_Address_textBox.Text = "Email:";
                Email_OR_Address_input_textBox.Show();
                Type_textBox.Hide();
                Type_input_textBox.Hide();
            }
            else if(name.Equals("SPContact"))
            {
                // Show Tenant attributs
                Name_textBox.Show();
                Name_input_textBox.Show();
                Mobile_textBox.Show();
                Mobile_input_textBox.Show();
                Email_OR_Address_textBox.Show();
                Email_OR_Address_textBox.Text = "Address:";
                Email_OR_Address_input_textBox.Show();
                Type_textBox.Show();
                Type_input_textBox.Show();
            }
        }

        private void ShowTenantContact()
        {
            if (currentTenant != -1)
            {
                foreach (Tenant t in tenList)
                {
                    if (t.Index == currentTenant)
                    {
                        Name_input_textBox.Text = t.Name;
                        Mobile_input_textBox.Text = t.Mobile;
                        Email_OR_Address_input_textBox.Text = t.Email;
                    }
                }
            }
        }

        private void ShowSPContact()
        {
            if (currentSrvProv != -1)
            {
                foreach (Services_Provider sp in spList)
                {
                    if (sp.Index == currentSrvProv)
                    {
                        Name_input_textBox.Text = sp.Name;
                        Mobile_input_textBox.Text = sp.Mobile;
                        Email_OR_Address_input_textBox.Text = sp.Address;
                        Type_input_textBox.Text = sp.Type;
                    }
                }
            }
        }
    }
}