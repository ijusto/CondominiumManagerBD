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
    public partial class PaymentsForm : Form
    {
        private List<Quota_Invoice> quotaList;
        private List<Service_Invoice> spList;
        private int currentQuotaInvoice;
        private int currentServiceInvoice;
        private SqlConnection cn;
        private SqlCommand cmd;
        private int q_index = 0;
        private int sp_index = 0;


        public PaymentsForm()
        {
            InitializeComponent();
        }

        private void PaymentsForm_Load(object sender, EventArgs e)
        {
            Fill_Quota();
            currentQuotaInvoice = Quotas_Invoice_listBox.SelectedIndex;

            Fill_Service();
            currentServiceInvoice = Services_Invoice_listBox.SelectedIndex;

        }

        private void Fill_Quota()
        {
            currentServiceInvoice = Services_Invoice_listBox.SelectedIndex;
            currentQuotaInvoice = Quotas_Invoice_listBox.SelectedIndex;
            q_index = 0;
            Quotas_Invoice_listBox.Items.Clear();
            quotaList = new List<Quota_Invoice>();
            cn = GetSGBDConnection();
            Quotas_Invoice_listBox.Items.Clear();
            cn.Open();
            cmd = new SqlCommand("showcomplaints", cn) //TODO
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("endereco", Chosencondo.Chosen_condo);  //TODO
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                //quotaList.Add(new Quota_Invoice((int)dr["id"], dr["data"].ToString(), dr["Descricao"].ToString(), "", q_index)); //TODO
                Quotas_Invoice_listBox.Items.Add(dr["Descricao"].ToString());
                q_index++;
            }
            cn.Close();
        }

        private void Fill_Service()
        {
            currentServiceInvoice = Services_Invoice_listBox.SelectedIndex;
            currentQuotaInvoice = Quotas_Invoice_listBox.SelectedIndex;
            sp_index = 0;
            Services_Invoice_listBox.Items.Clear();
            spList = new List<Service_Invoice>();
            cn = GetSGBDConnection();
            Services_Invoice_listBox.Items.Clear();
            cn.Open();
            cmd = new SqlCommand("showcomplaints", cn) //TODO
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("endereco", Chosencondo.Chosen_condo); //TODO
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                //spList.Add(new Service_Invoice((int)dr["id"], dr["data"].ToString(), dr["Descricao"].ToString(), "", sp_index));  //TODO
                Services_Invoice_listBox.Items.Add(dr["Descricao"].ToString());
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

        private void Services_Invoice_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentServiceInvoice = Services_Invoice_listBox.SelectedIndex;
            ShowServiceInvoice();
        }

        private void ShowServiceInvoice()
        {
            if (currentServiceInvoice != -1)
            {
                foreach (Service_Invoice sp in spList)
                {
                    //if (sp.Index == currentServiceInvoice)
                    {
                        //TODO show info selected invoice
                    }
                }
            }
        }

        private void Quotas_Invoice_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentQuotaInvoice = Quotas_Invoice_listBox.SelectedIndex;
            ShowQuotaInvoice();
        }

        private void ShowQuotaInvoice()
        {
            if (currentQuotaInvoice != -1)
            {
                foreach (Quota_Invoice q in quotaList)
                {
                    //if (q.Index == currentQuotaInvoice)
                    {
                        //TODO show info selected invoice
                    }
                }
            }
        }


        private void Info_Visibility(string name)
        {
            //TODO
            if (name.Equals(""))
            {
                // Hide Events info
            }
        }
    }
}
