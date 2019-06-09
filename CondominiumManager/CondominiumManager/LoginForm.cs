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
            cmd.Parameters.Add("@nif", username);
            cmd.Parameters.Add("@password", passwordhash);
            bool returnvalue =  (bool)cmd.ExecuteScalar();

            if (returnvalue)
            {
                var mainmenu = new MainMenuForm();
                mainmenu.ShowDialog();
                this.SendToBack();
                this.Dispose();
                this.Close();
                
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
