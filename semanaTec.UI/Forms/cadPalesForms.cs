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
    public partial class cadPalesForms : Form
    {
        public cadPalesForms()
        {
            InitializeComponent();
            ActiveControl = nomeTxt;
        }

        private void salvarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                telMsk.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                foreach (Control child in infoPalest.Controls)
                {
                    if(child is TextBox && (string.IsNullOrEmpty(child.Text)
                    || string.IsNullOrWhiteSpace(child.Text)) || 
                    child.Text==string.Empty)
                    {
                        throw new Exception("O campo " + child.Tag + " está vazio...");
                    }
                }
                var appPalest = new palestranteAplicacao();
                Palestrante palestrante = new Palestrante();
                palestrante.Nome = nomeTxt.Text;
                palestrante.Titulacao = titulacaoCB.Text;
                palestrante.Cidade = cidadeTxt.Text;
                palestrante.Email = emailTxt.Text;
                palestrante.Telefone = telMsk.Text;
                palestrante.MiniCurriculum = miniCTxt.Text;
                appPalest.salvaPalestrante(palestrante);
                MessageBox.Show("Palestrante salvo com sucesso!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
