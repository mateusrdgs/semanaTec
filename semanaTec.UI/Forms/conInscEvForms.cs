using semanaTec.Aplicacao;
using semanaTec.Metodos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace semanaTec.Forms
{
    public partial class conInscEvForms : Form
    {
        public conInscEvForms()
        {
            InitializeComponent();
            ActiveControl = cpfMsk;
        }

        private void conInscEvForms_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Perfil == "Administrador")
            { }
            else
            {
                cpfMsk.Text = Properties.Settings.Default.CPF;
                cpfMsk.Enabled = false;
            }
            this.ActiveMdiChild.Dock = DockStyle.Fill;
        }

        inscricaoEventoAplicacao appEvento = new inscricaoEventoAplicacao();

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            isEmpty validaControles = new isEmpty();
            try
            {
                foreach (Control child in this.Controls)
                {
                    string tag = validaControles.empty(child);
                    if (tag != "")
                    {
                        throw new Exception("O campo " + "'" + tag + "'" + " está vazio");
                    }
                    else
                    { }
                }
                inscGV.DataSource = appEvento.retornaEventosInscritos(cpfMsk.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
