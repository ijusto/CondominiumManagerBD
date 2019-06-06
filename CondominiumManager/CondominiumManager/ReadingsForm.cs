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
            Gas_input_textBox.Hide();
            Light_input_textBox.Hide();
            Water_input_textBox.Hide();
            Mobile_input_textBox.Hide();
            Tenant_Name_input_textBox.Hide();
            Tenant_Name_textBox.Hide();
            Mobile_textBox.Hide();
            Water_textBox.Hide();
            Light_textBox.Hide();
            Gas_textBox.Hide();
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
            cmd = new SqlCommand("getreadings", cn)  //TODO
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
                Apartment apt = new Apartment();
                Tenant owner = new Tenant();
                owner.Name = dr["nome"].ToString();
                owner.Email = dr["email"].ToString();
                owner.Mobile = dr["telemovel"].ToString();
                apt.owner = owner;
                apt.Index = index;
                apt.Permil = dr["permilagem"].ToString();
                apt.ReadGas = dr["leitura_gas"].ToString();
                apt.ReadLight = dr["leitura_luz"].ToString();
                apt.ReadWater = dr["leitura_agua"].ToString();
                apt.Refer = dr["ref_fracao"].ToString();
                apt.Address = Chosencondo.Chosen_condo + " - " + dr["piso"].ToString();
                apList.Add(apt);
                //apList.Add(new Apartment((int)dr["id"], dr["data"].ToString(), dr["Descricao"].ToString(), "", index));  //TODO
                apart_listBox.Items.Add(dr["ref_fracao"].ToString() + " - " + dr["piso"].ToString());
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
                        Tenant_Name_input_textBox.Text = a.owner.Name;
                        Mobile_input_textBox.Text = a.owner.Mobile;
                        Water_input_textBox.Text = a.ReadWater;
                        Light_input_textBox.Text = a.ReadLight;
                        Gas_input_textBox.Text = a.ReadGas;

                        Gas_input_textBox.Show();
                        Light_input_textBox.Show();
                        Water_input_textBox.Show();
                        Mobile_input_textBox.Show();
                        Tenant_Name_input_textBox.Show();
                        Tenant_Name_textBox.Show();
                        Mobile_textBox.Show();
                        Water_textBox.Show();
                        Light_textBox.Show();
                        Gas_textBox.Show();
                    }
                }
            }
        }
    }
}
