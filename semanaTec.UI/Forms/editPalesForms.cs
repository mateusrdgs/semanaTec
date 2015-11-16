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
    public partial class editPalesForms : Form
    {
        public editPalesForms()
        {
            InitializeComponent();
        }
        palestranteAplicacao palesApp;
        Palestrante palestrante;
        string nome = "";

        private void editPalesForms_Load(object sender, EventArgs e)
        {
            this.ActiveMdiChild.Dock = DockStyle.Fill;
            palesApp = new palestranteAplicacao();
            try
            {
                foreach (var nome in palesApp.selectPalestranteNome())
                {
                    palestranteCB.Items.Add(nome);
                }
            }
            catch (Exception ex)
            {
                string y = ex.ToString();
            }
        }

        private void palestranteCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            palestrante = new Palestrante();
            palesApp = new palestranteAplicacao();
            palestrante = (palesApp.selectPalestranteWhere(palestranteCB.Text));
            if (palestrante != null)
            {
                nomeTxt.Text = palestrante.Nome;
                cidadeTxt.Text = palestrante.Cidade;
                emailTxt.Text = palestrante.Email;
                miniCTxt.Text = palestrante.MiniCurriculum;
                telMsk.Text = palestrante.Telefone;
                titulacaoCB.Text = palestrante.Titulacao;
                codValorLbl.Text = palestrante.Codigo.ToString();
                nome = nomeTxt.Text;
            }
        }

        private void salvarBtn_Click(object sender, EventArgs e)
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

                palestrante = new Palestrante();
                palestrante.Codigo = int.Parse(codValorLbl.Text);
                palestrante.Nome = nomeTxt.Text;
                palestrante.Cidade = cidadeTxt.Text;
                palestrante.Email = emailTxt.Text;
                palestrante.MiniCurriculum = miniCTxt.Text;
                palestrante.Telefone = telMsk.Text;
                palestrante.Titulacao = titulacaoCB.Text;
                palesApp.salvaPalestrante(palestrante, nome);
                MessageBox.Show("Palestrante salvo com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
