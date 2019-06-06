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
        private List<Tenant> tenList;
        private List<Services_Provider> spList = new List<Services_Provider>();
        private SqlConnection cn;
        private SqlCommand cmd;
        private int currentTenant;
        private int currentSrvProv;
        private int ten_index = 0;
        private int sp_index = 0;
        private bool showTenant = false;
        private bool showSP = false;
        private bool edit = false; 
        private bool AddTenant = false;
        private bool AddSP = false;
        private String curTenTaxNum = "";
        private String curTenName = "";
        private String curTenEmail = "";
        private String curTenMobile = "";
        private String curSPTaxNum = "";
        private String curSPName = "";
        private String curSPAdd = "";
        private String curSPMobile = "";

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
            ten_index = 0;
            Tenants_listBox.Items.Clear();
            tenList = new List<Tenant>();
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
            sp_index = 0;
            Serv_Providers_listBox.Items.Clear();
            spList = new List<Services_Provider>();
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
                Ok_button.Hide();
                Cancel_button.Hide();
                Add_Tenant_button.Show();
                Add_SP_button.Show();
                Edit_button.Hide();
                Delete_button.Hide();
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
                Ok_button.Hide();
                Cancel_button.Hide();
                Add_Tenant_button.Hide();
                Add_SP_button.Hide();
                Edit_button.Show();
                Delete_button.Show();
            }
            else if (name.Equals("EditTenant"))
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
                Ok_button.Show();
                Cancel_button.Show();
                Add_Tenant_button.Hide();
                Add_SP_button.Hide();
                Edit_button.Hide();
                Delete_button.Hide();
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
                Ok_button.Hide();
                Cancel_button.Hide();
                Add_Tenant_button.Hide();
                Add_SP_button.Hide();
                Edit_button.Show();
                Delete_button.Show();
            }
            else if (name.Equals("EditSP"))
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
                Ok_button.Show();
                Cancel_button.Show();
                Add_Tenant_button.Hide();
                Add_SP_button.Hide();
                Edit_button.Hide();
                Delete_button.Hide();

            }
            else if (name.Equals("AddTenant"))
            {
                Name_textBox.Hide();
                Name_input_textBox.Hide();
                Mobile_textBox.Hide();
                Mobile_input_textBox.Hide();
                Email_OR_Address_textBox.Hide();
                Email_OR_Address_input_textBox.Hide();
                Type_textBox.Hide();
                Type_input_textBox.Hide();
                Ok_button.Show();
                Cancel_button.Show();
                Add_Tenant_button.Hide();
                Add_SP_button.Hide();
                Edit_button.Hide();
                Delete_button.Hide();
            }
            else if (name.Equals("AddSP"))
            {
                Name_textBox.Hide();
                Name_input_textBox.Hide();
                Mobile_textBox.Hide();
                Mobile_input_textBox.Hide();
                Email_OR_Address_textBox.Hide();
                Email_OR_Address_input_textBox.Hide();
                Type_textBox.Hide();
                Type_input_textBox.Hide();
                Ok_button.Show();
                Cancel_button.Show();
                Add_Tenant_button.Hide();
                Add_SP_button.Hide();
                Edit_button.Hide();
                Delete_button.Hide();
            }
        }

        private void ShowTenantContact()
        {
            showTenant = true;
            showSP = false;
            AddTenant = false;
            AddSP = false;
            if (currentTenant != -1)
            {
                foreach (Tenant t in tenList)
                {
                    if (t.Index == currentTenant)
                    {

                        curTenTaxNum = t.Tax_Number;
                        curTenName = t.Name;
                        curTenEmail = t.Email;
                        curTenMobile = t.Mobile;
                        Name_input_textBox.Text = t.Name;
                        Mobile_input_textBox.Text = t.Mobile;
                        Email_OR_Address_input_textBox.Text = t.Email;
                    }
                }
            }
        }

        private void ShowSPContact()
        {
            showTenant = false;
            showSP = true;
            AddTenant = false;
            AddSP = false;
            if (currentSrvProv != -1)
            {
                foreach (Services_Provider sp in spList)
                {
                    if (sp.Index == currentSrvProv)
                    {

                        curSPTaxNum = sp.Tax_Number;
                        curSPName = sp.Name;
                        curSPAdd = sp.Address;
                        curSPMobile = sp.Mobile;
                        Name_input_textBox.Text = sp.Name;
                        Mobile_input_textBox.Text = sp.Mobile;
                        Email_OR_Address_input_textBox.Text = sp.Address;
                        Type_input_textBox.Text = sp.Type;
                    }
                }
            }
        }

        private void Add_Tenant_button_Click(object sender, EventArgs e)
        {
            showTenant = false;
            showSP = false;
            edit = false;
            AddTenant = true;
            AddSP = false;
            Info_Visibility("AddTenant");
        }

        private void Add_SP_button_Click(object sender, EventArgs e)
        {
            showTenant = false;
            showSP = false;
            edit = false;
            AddTenant = false;
            AddSP = true;
            Info_Visibility("AddSP");
        }

        private void Ok_button_Click(object sender, EventArgs e)
        {
            Name_input_textBox.Enabled = false;
            Name_input_textBox.ReadOnly = true;
            Mobile_input_textBox.Enabled = false;
            Mobile_input_textBox.ReadOnly = true;
            Email_OR_Address_input_textBox.Enabled = false;
            Email_OR_Address_input_textBox.ReadOnly = true;
            Type_input_textBox.Enabled = false;
            Type_input_textBox.ReadOnly = true;
            edit = true;
            if (edit && showTenant)
            {
                EditTenant();
            }
            else if (edit && showSP)
            {
                EditSP();
            }
            else if(AddTenant)
            {
                AddTen();
            }
            else if (AddSP)
            {
                AddServP();
            }
            Info_Visibility("Contacts_Load");
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            Name_input_textBox.Enabled = false;
            Name_input_textBox.ReadOnly = true;
            Mobile_input_textBox.Enabled = false;
            Mobile_input_textBox.ReadOnly = true;
            Email_OR_Address_input_textBox.Enabled = false;
            Email_OR_Address_input_textBox.ReadOnly = true;
            Type_input_textBox.Enabled = false;
            Type_input_textBox.ReadOnly = true;
            Info_Visibility("Contacts_Load");
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            Name_input_textBox.Enabled = true;
            Name_input_textBox.ReadOnly = false;
            Mobile_input_textBox.Enabled = true;
            Mobile_input_textBox.ReadOnly = false;
            Email_OR_Address_input_textBox.Enabled = true;
            Email_OR_Address_input_textBox.ReadOnly = false;
            Type_input_textBox.Enabled = true;
            Type_input_textBox.ReadOnly = false;
            AddTenant = false;
            AddSP = false;
            edit = true;
            if (showTenant) { Info_Visibility("EditTenant"); }
            else if (showSP) { Info_Visibility("EditSP"); }
        }
        
        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (showTenant)
            {
                DeleteTenant();
            }
            else if (showSP)
            {
                DeleteSP();
            }
            Info_Visibility("Contacts_Load");
        }

        private void EditTenant()
        {
            cn = GetSGBDConnection();
            cn.Open();
            cmd = new SqlCommand("edittenant", cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("nif", curTenTaxNum);
            cmd.Parameters.AddWithValue("nome", Name_input_textBox.Text);
            cmd.Parameters.AddWithValue("telemovel", Mobile_input_textBox.Text);
            cmd.Parameters.AddWithValue("email", Email_OR_Address_input_textBox.Text);
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        private void EditSP()
        {
            cn = GetSGBDConnection();
            cn.Open();
            cmd = new SqlCommand("editsp", cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("nif", curTenTaxNum);
            cmd.Parameters.AddWithValue("nome", Name_input_textBox.Text);
            cmd.Parameters.AddWithValue("telemovel", Mobile_input_textBox.Text);
            cmd.Parameters.AddWithValue("morada", Email_OR_Address_input_textBox.Text);
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        private void AddTen()
        {
            cn = GetSGBDConnection();
            cn.Open();
            cmd = new SqlCommand("addtenant", cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("nif", curTenTaxNum);
            cmd.Parameters.AddWithValue("nome", Name_input_textBox.Text);
            cmd.Parameters.AddWithValue("telemovel", Mobile_input_textBox.Text);
            cmd.Parameters.AddWithValue("email", Email_OR_Address_input_textBox.Text);
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        private void AddServP()
        {
            cn = GetSGBDConnection();
            cn.Open();
            cmd = new SqlCommand("addsp", cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("nif", curTenTaxNum);
            cmd.Parameters.AddWithValue("nome", Name_input_textBox.Text);
            cmd.Parameters.AddWithValue("telemovel", Mobile_input_textBox.Text);
            cmd.Parameters.AddWithValue("morada", Email_OR_Address_input_textBox.Text);
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        private void DeleteTenant()
        {
            cn = GetSGBDConnection();
            cn.Open();
            cmd = new SqlCommand("deletetenant", cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("nif", curTenTaxNum);
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        private void DeleteSP()
        {
            cn = GetSGBDConnection();
            cn.Open();
            cmd = new SqlCommand("deletesp", cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("nif", curSPTaxNum);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}