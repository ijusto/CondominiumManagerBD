using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;
using static CondominiumManager.MainMenuForm;

namespace CondominiumManager
{
    public partial class LoginForm : Form
    {
        private SqlCommand cmd;
        private SqlConnection cn;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            String username = userinput.Text.ToString();
            String password = passwordinput.Text.ToString();

            var crypt = new System.Security.Cryptography.SHA256Managed();
            var hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(password));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }

            string passwordhash = hash.ToString();

            cn = GetSGBDConnection();
            cn.Open();
            cmd = new SqlCommand("select condomanager.authenticate(@nif, @password)", cn)
            {
                CommandType = CommandType.Text
            };
            cmd.Parameters.AddWithValue("nif", username);
            cmd.Parameters.AddWithValue("password", passwordhash);
            bool returnvalue =  (bool)cmd.ExecuteScalar();

            if (returnvalue)
            {
                MainMenuForm mainmenu = new MainMenuForm();
                this.Hide();           //Hide the main form before showing the secondary
                passwordinput.Text = "";
                mainmenu.ShowDialog();     //Show secondary form, code execution stop until frm2 is closed
                this.Show();           //When frm2 is closed, continue with the code (show main form)
                /*
                var mainmenu = new MainMenuForm();
                mainmenu.ShowDialog();
                this.SendToBack();
                this.Dispose();
                this.Close();
                */
                
            }


            
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
       
    }
}
