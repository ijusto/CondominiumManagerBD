﻿using System;
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

        }

        private void Back_button_Click(object sender, EventArgs e)
        {

            var form = new MainMenuForm();
            form.ShowDialog();
            this.SendToBack();
            this.Close();
        }
    }
}
