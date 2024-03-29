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
    public partial class InformationQuotaInForm : Form
    {
        private SqlConnection cn;
        public static string chosenfraction = "";
        public static string desc = "";

        public InformationQuotaInForm()
        {
            InitializeComponent();
        }

        private void InformationQuotaInForm_Load(object sender, EventArgs e)
        {
            fill_fraction();
        }


        private void fill_fraction()
        {
            VerifySGBDConnection();

            var cmd = new SqlCommand("condomanager.getoccupiedfractions", cn)
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
                fractionselector.Items.Add(dr["ref_fracao"] + "-" + dr["piso"]);
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

        private void createquotabutton_Click(object sender, EventArgs e)
        {
            if(fractionselector.SelectedIndex < 0 && Desc_input_quota_textBox.Text.Equals("")) 
            {
                MessageBox.Show("Please select a fraction and write a description");
            }
            else
            {
                chosenfraction = fractionselector.SelectedItem.ToString().Split('-')[0];
                desc = Desc_input_quota_textBox.Text.ToString();
                this.Close();
            }
        }
        
    }
}
