﻿using System;
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
        private bool hide_add = false;

        public ContactsForm()
        {
            InitializeComponent();
        }

        private void ContactsForm_Load(object sender, EventArgs e)
        {
            updateAvailApart();
            search_input_textBox.Text = "";
            HideTextBoxes();
            HideButtons();
            Fill_TenantContacts(false, "");
            currentTenant = Tenants_listBox.SelectedIndex;
            Fill_Serv_Prov_Contacts(false, "");
            currentSrvProv = Serv_Providers_listBox.SelectedIndex;
            DisableAllWriteTextboxes();
        }

        private void Fill_TenantContacts(bool search, string searchquery)
        {
            string query = "";
            if (search)
            {
                query = "condomanager.showcontactsSearch";
            }
            else
            {
                query = "condomanager.showcontacts";
            }

            ten_index = 0;
            Tenants_listBox.Items.Clear();
            tenList = new List<Tenant>();
            cn = GetSGBDConnection();
            cn.Open();
            cmd = new SqlCommand(query, cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("endereco", Chosencondo.Chosen_condo);
            if (search)
            {
                cmd.Parameters.AddWithValue("search", searchquery);
            }
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                List<String> fracoes = new List<string>();
                fracoes.Add(dr["ref_fracao"].ToString());
                Tenant temp = new Tenant(dr["NIF"].ToString(), dr["Nome"].ToString(), dr["Telemovel"].ToString(), dr["Email"].ToString(), ten_index, fracoes);
                if (tenList.Contains(temp)){
                    foreach(Tenant ten in tenList)
                    {
                        if (temp.Equals(ten))
                        {
                            ten.fracao.Add(dr["ref_fracao"].ToString());
                        }
                    }
                }
                else
                {
                    tenList.Add(temp);
                    Tenants_listBox.Items.Add(dr["Nome"].ToString());
                    ten_index++;
                }
               
            }
            cn.Close();
        }

        private void Fill_Serv_Prov_Contacts(bool search, string searchquery)
        {
            
            sp_index = 0;
            Serv_Providers_listBox.Items.Clear();
            spList = new List<Services_Provider>();
            cn = GetSGBDConnection();
            cn.Open();
            if (search == false)
            {
                cmd = new SqlCommand("Select * from condomanager.getsupplierview", cn)
                {
                    CommandType = CommandType.Text
                };
                cmd.ExecuteNonQuery();
            }
            else
            {
                cmd = new SqlCommand("condomanager.showspsearch", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("search", searchquery);
            }
            
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

        private void Tenants_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentTenant = Tenants_listBox.SelectedIndex;
            if (currentTenant != -1)
            {
                Serv_Providers_listBox.ClearSelected();
                ShowTextBoxes("tenant");
                ShowButtons("tenant");
            }
            
            ShowTenantContact();
        }

        private void Serv_Providers_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentSrvProv = Serv_Providers_listBox.SelectedIndex;
            if(currentSrvProv!=-1)
            {
                Tenants_listBox.ClearSelected();
                ShowTextBoxes("sp");
                ShowButtons("sp");
            }
            ShowSPContact();
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

        private void EditTenant()
        {
            cn = GetSGBDConnection();
            cn.Open();
            cmd = new SqlCommand("condomanager.edittenant", cn)
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
            cmd = new SqlCommand("condomanager.editsp", cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("nif", curSPTaxNum);
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
            cmd = new SqlCommand("condomanager.addtenant", cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("nif", Tax_Number_input_textBox.Text);
            cmd.Parameters.AddWithValue("nome", Name_input_textBox.Text);
            cmd.Parameters.AddWithValue("telemovel", Mobile_input_textBox.Text);
            cmd.Parameters.AddWithValue("email", Email_OR_Address_input_textBox.Text);
            cmd.Parameters.AddWithValue("endereco", Chosencondo.Chosen_condo);
            apart_comboBox.Enabled = true;
            cmd.Parameters.AddWithValue("ref_fracao", apart_comboBox.SelectedItem.ToString().Split('-')[0]);
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        private void AddServP()
        {
            cn = GetSGBDConnection();
            cn.Open();
            cmd = new SqlCommand("condomanager.addsp", cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("nif", Tax_Number_input_textBox.Text);
            cmd.Parameters.AddWithValue("nome", Name_input_textBox.Text);
            cmd.Parameters.AddWithValue("telemovel", Mobile_input_textBox.Text);
            cmd.Parameters.AddWithValue("morada", Email_OR_Address_input_textBox.Text);
            cmd.Parameters.AddWithValue("tipo", Type_input_textBox.Text);
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        private void DeleteTenant()
        {
            cn = GetSGBDConnection();
            cn.Open();
            cmd = new SqlCommand("condomanager.deletetenant", cn)
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
            cmd = new SqlCommand("condomanager.deletesp", cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("nif", curSPTaxNum);
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        private void updateAvailApart()
        {
            apart_comboBox.Items.Clear();
            cn = GetSGBDConnection();
            cn.Open();
            cmd = new SqlCommand("condomanager.getfreeref", cn)
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
                apart_comboBox.Items.Add(dr["ref_fracao"].ToString() + "-" + dr["piso"].ToString());
            }
            if(apart_comboBox.Items.Count == 0)
            {
                hide_add = true;
            } else
            {
                hide_add = false;
            }
            cn.Close();
        }

        private void search_input_textBox_TextChanged(object sender, EventArgs e)
        {
            Fill_TenantContacts(true, search_input_textBox.Text.ToString());
            Fill_Serv_Prov_Contacts(true, search_input_textBox.Text.ToString());
        }

        // BUTTONS --------------------------------------------------------------------------------------------------

        private void Add_Tenant_button_Click(object sender, EventArgs e)
        {
            ResetAllInput();

            // Clickable away action does'nt cause lost of add info
            button1.Enabled = false;

            ShowTextBoxes("tenant");
           
            showTenant = false;
            showSP = false;
            edit = false;
            AddTenant = true;
            AddSP = false;

            Fill_TenantContacts(false, "");
        }

        private void Add_SP_button_Click(object sender, EventArgs e)
        {
            ResetAllInput();

            // Clickable away action does'nt cause lost of add info
            button1.Enabled = false;

            ShowTextBoxes("sp");
            
            showTenant = false;
            showSP = false;
            edit = false;
            AddTenant = false;
            AddSP = true;

            Fill_Serv_Prov_Contacts(false, "");
        }

        private void Ok_button_Click(object sender, EventArgs e)
        {
            // Clickable away action causes lost of contact/edit info
            button1.Enabled = true;
            ResetAllInput();
            Apartment_textBox.Show();
            apart_comboBox.Show();
            DisableAllWriteTextboxes();
            edit = true;
            if (edit && showTenant)
            {
                EditTenant();
                Fill_TenantContacts(false, "");
            }
            else if (edit && showSP)
            {
                EditSP();
                Fill_Serv_Prov_Contacts(false, "");
            }
            else if (AddTenant)
            {
                AddTen();
                Fill_TenantContacts(false, "");
            }
            else if (AddSP)
            {
                AddServP();
                Fill_Serv_Prov_Contacts(false, "");
            }
            updateAvailApart();
            search_input_textBox.Text = "";
            HideTextBoxes();
            HideButtons();
        }
        
        private void Cancel_button_Click(object sender, EventArgs e)
        {
            DisableAllWriteTextboxes();
            search_input_textBox.Text = "";
            HideTextBoxes();
            HideButtons();
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            EnableAllWriteTextboxes();
            Type_input_textBox.Enabled = true;
            Type_input_textBox.ReadOnly = false;
            AddTenant = false;
            AddSP = false;
            edit = true;
            if (showTenant) {
                ShowTextBoxes("tenant");
                ShowButtons("tenant");
            }
            else if (showSP)
            {
                ShowTextBoxes("sp");
                ShowButtons("sp");
            }

            Fill_Serv_Prov_Contacts(false, "");
            Fill_TenantContacts(false, "");
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
            search_input_textBox.Text = "";

            HideTextBoxes();
            HideButtons();

            Fill_Serv_Prov_Contacts(false, "");
            Fill_TenantContacts(false, "");
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tenants_listBox.ClearSelected();
            Serv_Providers_listBox.ClearSelected();
            search_input_textBox.Text = "";

            HideTextBoxes();
            HideButtons();
        }

        // ----------------------------------------------------------------------------------------------------------

        // HANDLE TEXTBOXES ----------------------------------------------------------------------------------------
        private void Info_Visibility(string name)
        {
            if (name.Equals("AddTenant"))
            {
                Name_textBox.Show();
                Name_input_textBox.Show();
                Name_input_textBox.ReadOnly = false;
                Name_input_textBox.Enabled = true;
                Mobile_textBox.Show();
                Mobile_input_textBox.Show();
                Mobile_input_textBox.ReadOnly = false;
                Mobile_input_textBox.Enabled = true;
                Email_OR_Address_textBox.Show();
                Email_OR_Address_input_textBox.Show();
                Email_OR_Address_input_textBox.ReadOnly = false;
                Email_OR_Address_input_textBox.Enabled = true;
                Type_textBox.Hide();
                Type_input_textBox.Hide();
                Ok_button.Show();
                Cancel_button.Show();
                Add_Tenant_button.Hide();
                Add_SP_button.Hide();
                Edit_button.Hide();
                Delete_button.Hide();
                if (hide_add)
                {
                    Add_Tenant_button.Hide();
                }
            }
            else if (name.Equals("AddSP"))
            {
                Name_textBox.Show();
                Name_input_textBox.Show();
                Name_input_textBox.ReadOnly = false;
                Name_input_textBox.Enabled = true;
                Mobile_textBox.Show();
                Mobile_input_textBox.Show();
                Mobile_input_textBox.ReadOnly = false;
                Mobile_input_textBox.Enabled = true;
                Email_OR_Address_textBox.Show();
                Email_OR_Address_input_textBox.Show();
                Email_OR_Address_input_textBox.ReadOnly = false;
                Email_OR_Address_input_textBox.Enabled = true;
                Type_textBox.Show();
                Type_input_textBox.Show();
                Type_input_textBox.ReadOnly = false;
                Type_input_textBox.Enabled = true;
                Ok_button.Show();
                Cancel_button.Show();
                Add_Tenant_button.Hide();
                Add_SP_button.Hide();
                Edit_button.Hide();
                Delete_button.Hide();
                if (hide_add)
                {
                    Add_Tenant_button.Hide();
                }
            }
        }

        private void HideButtons()
        {
            // Hide buttons (except Adds)
            Ok_button.Hide();
            Cancel_button.Hide();
            Edit_button.Hide();
            Delete_button.Hide();
            Add_Tenant_button.Show();
            Add_SP_button.Show();
        }

        private void HideTextBoxes()
        {
            // Hide Contact Info
            Name_textBox.Hide();
            Name_input_textBox.Hide();
            Mobile_textBox.Hide();
            Mobile_input_textBox.Hide();
            Email_OR_Address_textBox.Hide();
            Email_OR_Address_input_textBox.Hide();
            Type_textBox.Hide();
            Type_input_textBox.Hide();
            Apartment_textBox.Hide();
            apart_comboBox.Hide();
            Tax_Number_textBox.Hide();
            Tax_Number_input_textBox.Hide();
        }

        private void ShowTextBoxes(string str)
        {
            if(str.Equals("tenant"))
            {
                // Show Tenant attributs
                Name_textBox.Show();
                Name_input_textBox.Show();
                Mobile_textBox.Show();
                Mobile_input_textBox.Show();
                Email_OR_Address_textBox.Show();
                Email_OR_Address_textBox.Text = "Email:";
                Email_OR_Address_input_textBox.Show();
                Tax_Number_textBox.Show();
                Tax_Number_input_textBox.Show();
                Type_textBox.Hide();
                Type_input_textBox.Hide();
                if(AddTenant)
                {
                    Apartment_textBox.Show();
                    apart_comboBox.Show();
                }
            } else if(str.Equals("sp"))
            {
                // Show Service Provider attributs
                Name_textBox.Show();
                Name_input_textBox.Show();
                Mobile_textBox.Show();
                Mobile_input_textBox.Show();
                Email_OR_Address_textBox.Show();
                Email_OR_Address_textBox.Text = "Address:";
                Email_OR_Address_input_textBox.Show();
                Type_textBox.Show();
                Type_input_textBox.Show();
                Tax_Number_textBox.Show();
                Tax_Number_input_textBox.Show();
                if(AddSP)
                {
                    type_comboBox.Show();
                    //TODO fill dropdown
                }
            }
        }

        private void ShowButtons(string str)
        {
            if (str.Equals("tenant"))
            {
                // Hide all buttons (except edit and delete)
                Ok_button.Hide();
                Cancel_button.Hide();
                Add_Tenant_button.Hide();
                Add_SP_button.Hide();
                Edit_button.Show();
                Delete_button.Show();
                if(edit)
                {
                    Ok_button.Show();
                    Cancel_button.Show();
                    Edit_button.Hide();
                    Delete_button.Hide();
                }
            }
            else if(str.Equals("sp"))
            {
                // Hide all buttons (except edit and delete)
                Ok_button.Hide();
                Cancel_button.Hide();
                Add_Tenant_button.Hide();
                Add_SP_button.Hide();
                Edit_button.Show();
                Delete_button.Show();

                if(edit)
                {
                    Ok_button.Show();
                    Cancel_button.Show();
                    Edit_button.Hide();
                    Delete_button.Hide();
                }
            }
        }

        private void EnableAllWriteTextboxes()
        {
            Name_input_textBox.ReadOnly = false;
            Name_input_textBox.Enabled = true;
            Mobile_input_textBox.ReadOnly = false;
            Mobile_input_textBox.Enabled = true;
            Email_OR_Address_input_textBox.ReadOnly = false;
            Email_OR_Address_input_textBox.Enabled = true;
            Tax_Number_input_textBox.ReadOnly = false;
            Tax_Number_input_textBox.Enabled = true;
            Type_input_textBox.ReadOnly = false;
            Type_input_textBox.Enabled = true;
        }

        private void DisableAllWriteTextboxes()
        {
            Name_input_textBox.ReadOnly = true;
            Name_input_textBox.Enabled = false;
            Mobile_input_textBox.ReadOnly = true;
            Mobile_input_textBox.Enabled = false;
            Email_OR_Address_input_textBox.ReadOnly = true;
            Email_OR_Address_input_textBox.Enabled = false;
            Type_input_textBox.ReadOnly = true;
            Type_input_textBox.Enabled = false;
            Tax_Number_input_textBox.ReadOnly = true;
            Tax_Number_input_textBox.Enabled = false;
        }

        private void ResetAllInput()
        {
            Name_input_textBox.Text = "";
            Mobile_input_textBox.Text = "";
            Email_OR_Address_input_textBox.Text = "";
            Type_input_textBox.Text = "";
            Tax_Number_input_textBox.Text = "";
        }
        // ----------------------------------------------------------------------------------------------------------
    }
}
