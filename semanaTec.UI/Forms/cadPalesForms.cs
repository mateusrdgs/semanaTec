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
    public partial class cadPalesForms : Form
    {
        public cadPalesForms()
        {
            InitializeComponent();
            ActiveControl = nomeTxt;
        }

        private void cadPalesForms_Load(object sender, EventArgs e)
        {
            this.ActiveMdiChild.Dock = DockStyle.Fill;
        }

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
                var appPalest = new palestranteAplicacao();
                Palestrante palestrante = new Palestrante();
                palestrante.Nome = nomeTxt.Text;
                palestrante.Titulacao = titulacaoCB.Text;
                palestrante.Cidade = cidadeTxt.Text;
                palestrante.Email = emailTxt.Text;
                palestrante.Telefone = telMsk.Text;
                palestrante.MiniCurriculum = miniCTxt.Text;
                appPalest.salvaPalestrante(palestrante, palestrante.Nome);
                MessageBox.Show("Palestrante salvo com sucesso!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void limparBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
