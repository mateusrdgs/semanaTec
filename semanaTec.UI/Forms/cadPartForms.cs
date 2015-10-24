using semanaTec.Aplicacao;
using semanaTec.Dominio;
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
    public partial class cadPartForms : Form
    {
        public cadPartForms()
        {
            InitializeComponent();
        }

        private void cadPartForms_Load(object sender, EventArgs e)
        {
            ActiveControl = nomeTxt;
        }

        private void salvarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                cpfMsk.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                telTxt.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                foreach(Control group in Controls)
                {
                    foreach(Control child in group.Controls)
                    {
                        if(child is TextBox && (string.IsNullOrEmpty(child.Text)
                        || string.IsNullOrWhiteSpace(child.Text)) || 
                        child.Text == string.Empty)
                        {
                            throw new Exception("O campo " + child.Tag + " está vazio...");
                        }
                    }
                }

                Participantes participante = new Participantes();
                participanteAplicacao appPart = new participanteAplicacao();
                cpfMsk.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                telTxt.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                participante.Cpf = cpfMsk.Text;
                participante.Nome = nomeTxt.Text;
                participante.Curso = cursoCB.Text;
                participante.Periodo = int.Parse(periodoTxt.Text);
                participante.Telefone = telTxt.Text;
                participante.Email = emailTxt.Text;
                participante.Login = loginTxt.Text;
                participante.Senha = senhaTxt.Text;
                participante.Perfil = perfilCB.Text;
                appPart.salvaParticipante(participante);
                MessageBox.Show("Participante salvo com sucesso!");
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
