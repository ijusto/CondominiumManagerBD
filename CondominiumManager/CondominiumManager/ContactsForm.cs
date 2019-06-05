using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CondominiumManager
{
    public partial class ContactsForm : Form
    {
        public ContactsForm()
        {
            InitializeComponent();
        }

        private void Contacts_Load(object sender, EventArgs e)
        {
            Info_Visibility("Contacts_Load");
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

        }

        private void Serv_Providers_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

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
        }
    }
}