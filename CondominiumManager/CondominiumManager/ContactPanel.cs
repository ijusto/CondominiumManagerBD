﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CondominiumManager
{
    public partial class ContactPanel : UserControl
    {
        public ContactPanel()
        {
            InitializeComponent();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.SendToBack();
            this.Hide();
        }

        private void ContactPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
