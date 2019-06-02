using System;
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
    public partial class Events : UserControl
    {
        public Events()
        {
            InitializeComponent();
        }

        private void Events_Load(object sender, EventArgs e)
        {
            // Hide Reuniao/Reparacao attributs
            Nome_textBox.Hide();
            Nome_input_textBox.Hide();
            Hora_textBox.Hide();
            Hora_input_textBox.Hide();
            Minuto_input_textBox.Hide();
            Tipo_textBox.Hide();
            Tipo_input_textBox.Hide();
            Local_textBox.Hide();
            Local_input_textBox.Hide();
            Danificado_textBox.Hide();
            Danificado_input_textBox.Hide();
            Desc_textBox.Hide();
            Descricao_input_textBox.Hide();
            Ok_button.Hide();
            Cancel_button.Hide();
        }

        private void Marcar_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Hora_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Hora_input_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Local_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Desc_textBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void Reparacao_button_Click(object sender, EventArgs e)
        {
            // Show Reuniao/Reparacao attributs
            Nome_textBox.Show();
            Nome_input_textBox.Show();
            Hora_textBox.Show();
            Hora_input_textBox.Show();
            Minuto_input_textBox.Show();
            Tipo_textBox.Show();
            Tipo_input_textBox.Show();
            Tipo_input_textBox.Text = "Reparação";
            Danificado_textBox.Show();
            Danificado_input_textBox.Show();
            Desc_textBox.Show();
            Descricao_input_textBox.Show();
            Ok_button.Show();
            Cancel_button.Show();

            // TODO: Ok
            // TODO: Cancel
        }
        private void Reuniao_button_Click(object sender, EventArgs e)
        {
            // Show Reuniao/Reparacao attributs
            Nome_textBox.Show();
            Nome_input_textBox.Show();
            Hora_textBox.Show();
            Hora_input_textBox.Show();
            Minuto_input_textBox.Show();
            Tipo_textBox.Show();
            Tipo_input_textBox.Show();
            Tipo_input_textBox.Text = "Reunião";
            Local_textBox.Show();
            Local_input_textBox.Show();
            Desc_textBox.Show();
            Descricao_input_textBox.Show();
            Ok_button.Show();
            Cancel_button.Show();
        }
        private void Cancel_button_Click(object sender, EventArgs e)
        {
            Nome_textBox.Hide();
            Nome_input_textBox.Hide();
            Hora_textBox.Hide();
            Hora_input_textBox.Hide();
            Minuto_input_textBox.Hide();
            Tipo_textBox.Hide();
            Tipo_input_textBox.Hide();
            Local_textBox.Hide();
            Local_input_textBox.Hide();
            Danificado_textBox.Hide();
            Danificado_input_textBox.Hide();
            Desc_textBox.Hide();
            Descricao_input_textBox.Hide();
            Ok_button.Hide();
            Cancel_button.Hide();
        }
        private void Tipo_textBox_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
