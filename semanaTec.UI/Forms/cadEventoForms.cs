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
    public partial class cadEventoForms : Form
    {
        public cadEventoForms()
        {
            InitializeComponent();
            ActiveControl = nomeTxt;
        }

        private void cadEventoForms_Load(object sender, EventArgs e)
        {
            this.MdiParent.Size = new Size(550, (450 + (this.MdiParent.MainMenuStrip.Size).Height));
        }

        private void salvarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control child in eventoInfo.Controls)
                {
                    if (child is TextBox && (child.Text == null || child.Text == ""))
                    {
                        throw new Exception("O campo " + child.Tag + " está vazio...");
                    }
                }

                var appEvento = new eventoAplicacao();
                var evento = new Evento();
                evento.Nome = nomeTxt.Text;
                evento.Local = localTxt.Text;
                evento.Data = Convert.ToDateTime(dataPck.Text);
                evento.Hora = Convert.ToDateTime(horaPck.Text);
                if (palestraRB.Checked)
                    evento.Tipo = palestraRB.Text;
                else
                    evento.Tipo = minicursoRB.Text;

                evento.Duracao = Convert.ToInt32(duracaoTxt.Text);
                evento.Descricao = descricaoTxt.Text;
                evento.CodPal = Convert.ToInt32(codPTxt.Text);
                evento.Vagas = Convert.ToInt32(vagasTxt.Text);
                
                appEvento.salvaEvento(evento);
                MessageBox.Show("Salvo com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

