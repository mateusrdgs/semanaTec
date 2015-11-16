using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using semanaTec.Metodos;
using semanaTec.Aplicacao;
using semanaTec.Dominio;

namespace semanaTec.Forms
{
    public partial class cadInscSemForms : Form
    {
        public cadInscSemForms()
        {
            InitializeComponent();
            dataPck.Value = DateTime.Now.Date;
        }
        private void cadInscSemForms_Load(object sender, EventArgs e)
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

        private void salvarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                isEmpty validaControles = new isEmpty();
                foreach (Control child in this.Controls)
                {
                    string tag = validaControles.empty(child);
                    if (tag != "") {
                        throw new Exception("O campo '"+ tag + "' está vazio");
                    }
                    else
                    { }
                }
                inscricaoSeminfoAplicacao appInsc = new inscricaoSeminfoAplicacao();
                if (appInsc.jaCadastrado(cpfMsk.Text))
                {
                    throw new Exception("CPF já cadastrado na SEMINFO!");
                }
                else if (!appInsc.jaCadastrado(cpfMsk.Text))
                {
                    throw new Exception("CPF inexistente!");
                }
                else
                {
                    inscricaoSeminfo insc = new inscricaoSeminfo();
                    insc.Data = DateTime.Parse(dataPck.Text);
                    insc.ParticipanteCpf = cpfMsk.Text;
                    appInsc.insereInscricao(insc);
                    MessageBox.Show("Participante cadastrado com sucesso!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
