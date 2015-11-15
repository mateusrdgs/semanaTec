using semanaTec.Aplicacao;
using semanaTec.Dominio;
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
    public partial class editPartForms : Form
    {
        public editPartForms()
        {
            InitializeComponent();
        }
        participanteAplicacao appPart;
        Participantes participante = new Participantes();
        private void editPartForms_Load(object sender, EventArgs e)
        {

        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            appPart = new participanteAplicacao();
            participante = appPart.selectParticipantesWhere("12728661650");
            cpfMsk.Text = participante.Cpf;
            nomeTxt.Text = participante.Nome;
            telTxt.Text = participante.Telefone;
            emailTxt.Text = participante.Email;
            cursoCB.Text = participante.Curso;
            periodoTxt.Text = (participante.Periodo).ToString();
            senhaTxt.Text = participante.Senha;
            perfilCB.Text = participante.Perfil;
            loginTxt.Text = participante.Login;
        }

        private void salvarBtn_Click(object sender, EventArgs e)
        {
            var cpf = participante.Cpf;
            participante.Cpf = cpfMsk.Text;
            participante.Nome = nomeTxt.Text;
            participante.Telefone = telTxt.Text;
            participante.Email = emailTxt.Text;
            participante.Curso = cursoCB.Text;
            participante.Periodo = int.Parse(periodoTxt.Text);
            participante.Senha = senhaTxt.Text;
            participante.Perfil = perfilCB.Text;
            participante.Login = loginTxt.Text;
            appPart.salvaParticipante(participante, cpf);
            MessageBox.Show("Informação(ões) alterada(s) com sucesso");
        }

        private void limparBtn_Click(object sender, EventArgs e)
        {
            cleanControls limpaControles = new cleanControls();
            foreach (Control child in this.Controls.OfType<GroupBox>())
            {
                limpaControles.limpa(child);
            }
        }
    }
}
