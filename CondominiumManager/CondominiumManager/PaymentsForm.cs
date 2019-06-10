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
using static CondominiumManager.Form1;

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
        private int id_f_quotas;
        private int id_f_sp;


        public PaymentsForm()
        {
            InitializeComponent();
            Info_Visibility("load");
            Add_Quota_button.Show();
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
            cmd = new SqlCommand("condomanager.getfaturaquota", cn) 
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
                Quota_Invoice invoice = new Quota_Invoice
                {
                    Amount = dr["quantia"].ToString(),
                    Date = dr["data"].ToString(),
                    Description = dr["descricao"].ToString(),
                    Index = q_index,
                    ID = (int)dr["id_fatura"]
                };

                cmd = new SqlCommand("condomanager.gettenantnifname", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("ref_fracao", dr["ref_fracao"]);
                cmd.Parameters.AddWithValue("endereco", dr["endereco"]);
                cmd.ExecuteNonQuery();
                DataTable dtt = new DataTable();
                SqlDataAdapter daa = new SqlDataAdapter(cmd);
                daa.Fill(dtt);
                invoice.Entity_Name = dtt.Rows[0]["nome"].ToString();
                invoice.Tax_Number = dtt.Rows[0]["nif"].ToString();
                invoice.ref_fracao = dr["ref_fracao"].ToString();
                Quotas_Invoice_listBox.Items.Add(dr["Descricao"].ToString());
                quotaList.Add(invoice);
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
            cmd = new SqlCommand("condomanager.getfaturaservico", cn)
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
                Service_Invoice invoice = new Service_Invoice
                {
                    Index = sp_index,
                    Description = dr["descricao"].ToString(),
                    Date = dr["data"].ToString(),
                    Amount = dr["quantia"].ToString(),
                    ID = (int)dr["id_fatura"]
                    
                };
                cmd = new SqlCommand("condomanager.getmanager", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("endereco", Chosencondo.Chosen_condo);
                cmd.ExecuteNonQuery();
                DataTable dtt = new DataTable();
                SqlDataAdapter daa = new SqlDataAdapter(cmd);
                daa.Fill(dtt);
                invoice.Tax_Number = dtt.Rows[0]["nif_gestor"].ToString();
                spList.Add(invoice);
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
                    if (sp.Index == currentServiceInvoice)
                    {
                        id_f_sp = sp.ID;
                        Info_Visibility("showServiceInvoice");
                        VerifySGBDConnection();

                        cmd = new SqlCommand("condomanager.ispaidservicos", cn) 
                        {
                            CommandType = CommandType.StoredProcedure
                        };

                        cmd.Parameters.AddWithValue("id_fatura", sp.ID); 
                        cmd.ExecuteNonQuery();
                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);

                        Date_input_Service_Invoice_textBox.Text = sp.Date;
                        TaxNumber_input_Service_Invoice_textBox.Text = sp.Tax_Number;
                        Amount_input_Service_Invoice_textBox.Text = sp.Amount;
                        Desc_input_Service_Invoice_textBox.Text = sp.Description;

                        Date_Service_Invoice_textBox.Show();
                        TaxNumber_Service_Invoice_textBox.Show();
                        Amount_Service_Invoice_textBox.Show();
                        Ref_Service_Invoice_textBox.Show();
                        Desc_Service_Invoice_textBox.Show();
                        Invoice_Service_textBox.Show();
                        if (dt.Rows.Count != 0)
                        {
                            //payment
                            Payment_Service_textBox.Show();
                            Date_Service_Payment_textBox.Show();
                            Date_input_Service_Payment_textBox.Show();
                            Desc_Service_Payment_textBox.Show();
                            Desc_input_Service_Payment_textBox.Show();
                            //add payment values
                            Date_input_Service_Payment_textBox.Text = dt.Rows[0]["data"].ToString();
                            Desc_input_Service_Payment_textBox.Text = dt.Rows[0]["descricao"].ToString();
                            Mark_Paid_Quota_button.Hide();
                        }
                        else
                        {
                            //payment
                            Payment_Service_textBox.Hide();
                            Date_Service_Payment_textBox.Hide();
                            Date_input_Service_Payment_textBox.Hide();
                            Desc_Service_Payment_textBox.Hide();
                            Desc_input_Service_Payment_textBox.Hide();
                            Mark_Paid_Service_button.Show();
                        }
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
            cn = GetSGBDConnection();
            cn.Open();
            if (currentQuotaInvoice != -1)
            {
                foreach (Quota_Invoice q in quotaList)
                {
                    if (q.Index == currentQuotaInvoice)
                    {
                        id_f_quotas = q.ID;
                        Info_Visibility("showQuotaInvoice");

                        cmd = new SqlCommand("condomanager.ispaidquotas", cn)
                        {
                            CommandType = CommandType.StoredProcedure
                        };

                        cmd.Parameters.AddWithValue("id_fatura", q.ID);
                        cmd.ExecuteNonQuery();
                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);

                        Date_input_Quota_Invoice_textBox.Text = q.Date;
                        TaxNumber_input_Quota_Invoice_textBox.Text = q.Tax_Number;
                        Amount_input_Quota_Invoice_textBox.Text = q.Amount;
                        Ref_input_Quota_Invoice_textBox.Text = q.ref_fracao;
                        Desc_input_Quota_Invoice_textBox.Text = q.Description;

                        Date_Quota_Invoice_textBox.Show();
                        TaxNumber_Quota_Invoice_textBox.Show();
                        Amount_Quota_Invoice_textBox.Show();
                        Ref_Quota_Invoice_textBox.Show();
                        Desc_Quota_Invoice_textBox.Show();
                        Invoice_Quota_textBox.Show();
                        if (dt.Rows.Count != 0)
                        {
                            //payment
                            Payment_Quota_textBox.Show();
                            Date_Quota_Payment_textBox.Show();
                            Date_input_Quota_Payment_textBox.Show();
                            Desc_Quota_Payment_textBox.Show();
                            Desc_input_Quota_Payment_textBox.Show();
                            // add payment values
                            Date_input_Quota_Payment_textBox.Text = dt.Rows[0]["data"].ToString();
                            Desc_input_Quota_Payment_textBox.Text = dt.Rows[0]["descricao"].ToString();
                            Mark_Paid_Quota_button.Hide();
                        }
                        else
                        {
                            //payment
                            Payment_Quota_textBox.Hide();
                            Date_Quota_Payment_textBox.Hide();
                            Date_input_Quota_Payment_textBox.Hide();
                            Desc_Quota_Payment_textBox.Hide();
                            Desc_input_Quota_Payment_textBox.Hide();
                            Mark_Paid_Quota_button.Show();
                        }
                    }
                }
            }
        }

        private void Info_Visibility(string name)
        {
            if (name.Equals("load"))
            {
                //hide info selected quota invoice/payment
                Invoice_Quota_textBox.Hide();
                Date_Quota_Invoice_textBox.Hide();
                Date_input_Quota_Invoice_textBox.Hide();
                TaxNumber_Quota_Invoice_textBox.Hide();
                TaxNumber_input_Quota_Invoice_textBox.Hide();
                Amount_Quota_Invoice_textBox.Hide();
                Amount_input_Quota_Invoice_textBox.Hide();
                Ref_Quota_Invoice_textBox.Hide();
                Ref_input_Quota_Invoice_textBox.Hide();
                Desc_Quota_Invoice_textBox.Hide();
                Desc_input_Quota_Invoice_textBox.Hide();
                Mark_Paid_Quota_button.Hide();
                Payment_Quota_textBox.Hide();
                Date_Quota_Payment_textBox.Hide();
                Date_input_Quota_Payment_textBox.Hide();
                Desc_Quota_Payment_textBox.Hide();
                Desc_input_Quota_Payment_textBox.Hide();
                Add_Quota_button.Hide();
                Delete_Quota_button.Hide();
                //hide info selected service invoice /payment
                Invoice_Service_textBox.Hide();
                Date_Service_Invoice_textBox.Hide();
                Date_input_Service_Invoice_textBox.Hide();
                TaxNumber_Service_Invoice_textBox.Hide();
                TaxNumber_input_Service_Invoice_textBox.Hide();
                Amount_Service_Invoice_textBox.Hide();
                Amount_input_Service_Invoice_textBox.Hide();
                Ref_Service_Invoice_textBox.Hide();
                Ref_input_Service_Invoice_textBox.Hide();
                Desc_Service_Invoice_textBox.Hide();
                Desc_input_Service_Invoice_textBox.Hide();
                Mark_Paid_Service_button.Hide();
                Payment_Service_textBox.Hide();
                Date_Service_Payment_textBox.Hide();
                Date_input_Service_Payment_textBox.Hide();
                Desc_Service_Payment_textBox.Hide();
                Desc_input_Service_Payment_textBox.Hide();
                Delete_Service_button.Hide();
            }
            else if (name.Equals("showServiceInvoice"))
            {
                //show info selected invoice
                Invoice_Service_textBox.Show();
                Date_Service_Invoice_textBox.Show();
                Date_input_Service_Invoice_textBox.Show();
                TaxNumber_Service_Invoice_textBox.Show();
                TaxNumber_input_Service_Invoice_textBox.Show();
                Amount_Service_Invoice_textBox.Show();
                Amount_input_Service_Invoice_textBox.Show();
                Ref_Service_Invoice_textBox.Show();
                Ref_input_Service_Invoice_textBox.Show();
                Desc_Service_Invoice_textBox.Show();
                Desc_input_Service_Invoice_textBox.Show();
                Delete_Service_button.Show();
            }
            else if (name.Equals("showQuotaInvoice"))
            {
                //show info selected invoice
                Invoice_Quota_textBox.Show();
                Date_Quota_Invoice_textBox.Show();
                Date_input_Quota_Invoice_textBox.Show();
                TaxNumber_Quota_Invoice_textBox.Show();
                TaxNumber_input_Quota_Invoice_textBox.Show();
                Amount_Quota_Invoice_textBox.Show();
                Amount_input_Quota_Invoice_textBox.Show();
                Ref_Quota_Invoice_textBox.Show();
                Ref_input_Quota_Invoice_textBox.Show();
                Desc_Quota_Invoice_textBox.Show();
                Desc_input_Quota_Invoice_textBox.Show();
                Delete_Quota_button.Show();
            }
        }

        private void Mark_Paid_Quota_button_Click(object sender, EventArgs e)
        {
            cn = GetSGBDConnection();
            cn.Open();

            cmd = new SqlCommand("condomanager.markaspaidquota", cn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("id_to", id_f_quotas);
            cmd.ExecuteNonQuery();
            ShowQuotaInvoice();
           
        }

        private void Mark_Paid_Service_button_Click(object sender, EventArgs e)
        {
            //TODO
            cn = GetSGBDConnection();
            cn.Open();

            cmd = new SqlCommand("condomanager.markaspaid", cn) //TODO
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("id_to", id_f_sp); //TODO
            cmd.ExecuteNonQuery();
            ShowServiceInvoice();
        }

        private void Add_Quota_button_Click(object sender, EventArgs e)
        {
            var Form1 = new Form1();
            Form1.ShowDialog();
            cn = GetSGBDConnection();
            cn.Open();

            cmd = new SqlCommand("condomanager.createquota", cn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("endereco", Chosencondo.Chosen_condo);
            cmd.Parameters.AddWithValue("ref_fracao", chosenfraction);
            cmd.Parameters.AddWithValue("descricao", "Fatura de quotas");
            cmd.ExecuteNonQuery();
            Fill_Quota();
        }

        private void Delete_Quota_button_Click(object sender, EventArgs e)
        {

            VerifySGBDConnection();

            cmd = new SqlCommand("condomanager.deletequota", cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("id_fatura", id_f_quotas);
            cmd.ExecuteNonQuery();
            Fill_Quota();

        }

        private void Delete_Service_button_Click(object sender, EventArgs e)
        {


            VerifySGBDConnection();

            cmd = new SqlCommand("condomanager.deleteservicos", cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("id_fatura", id_f_sp);
            cmd.ExecuteNonQuery();
            Fill_Service();

        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
