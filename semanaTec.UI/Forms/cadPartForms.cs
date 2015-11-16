using semanaTec.Aplicacao;
using semanaTec.Dominio;
using semanaTec.Metodos;
using System;
using System.Windows.Forms;
using System.Linq;

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
            this.ActiveMdiChild.Dock = DockStyle.Fill;        
        }
        criaLogin novoLogin = new criaLogin();
        Participantes participante = new Participantes();
        participanteAplicacao appPart = new participanteAplicacao();

        private void salvarBtn_Click(object sender, EventArgs e)
        {
            isEmpty validaControles = new isEmpty();
            try
            {
                foreach (Control child in this.Controls.Cast<Control>().OrderBy(c => c.TabIndex))
                {
                    string tag = validaControles.empty(child);
                    if (tag != "")
                    {
                        throw new Exception("O campo " + "'" + tag + "'" + " está vazio");
                    }
                    else
                    { }
                }
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
                appPart.salvaParticipante(participante, participante.Cpf);
                MessageBox.Show("Participante salvo com sucesso!");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loginGnrBtn_Click(object sender, EventArgs e)
        {
            try
            {
                loginTxt.Text = novoLogin.crialogin(nomeTxt.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("O campo 'Nome' está vazio");
            }
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
