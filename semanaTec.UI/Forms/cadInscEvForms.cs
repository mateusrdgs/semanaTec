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
    public partial class cadInscEvForms : Form
    {
        public cadInscEvForms()
        {
            InitializeComponent();
            ActiveControl = eventoCB;
        }
        eventoAplicacao appEvento;
        inscricaoEventoAplicacao appInsc;
        participanteAplicacao appPart;
        inscricaoEvento inscricao;

        private void cadInscForms_Load(object sender, EventArgs e)
        {
            appEvento = new eventoAplicacao();
            appEvento.selectEventos();
            foreach (var evento in appEvento.selectEventos())
            {
                eventoCB.Items.Add(evento.Nome);
            }
            eventoCB.SelectedIndex = -1;
        }

        private void salvarBtn_Click(object sender, EventArgs e)
        {
            cpfMsk.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
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

                appInsc = new inscricaoEventoAplicacao();
                appPart = new participanteAplicacao();
                inscricao = new inscricaoEvento();

                if (appPart.selectParticipantesWhere(cpfMsk.Text).Cpf == cpfMsk.Text)
                {
                    inscricao.Cpf = cpfMsk.Text;
                }
                else
                {
                    throw new Exception("CPF ainda não cadastrado!!!");
                }

                if (appInsc.cpfJaCadastradoEvento(appEvento.selectEventoWhere(eventoCB.Text).Codigo, inscricao.Cpf) == true)
                {
                    throw new Exception("CPF já cadastrado neste evento!!!");
                };

                if (appEvento.selectEventos().Count > 0)
                {
                    inscricao.Evento = appEvento.selectEventoWhere(eventoCB.Text).Codigo;
                    inscricao.Data = appEvento.selectEventoWhere(eventoCB.Text).Data;
                }
                else
                {
                    throw new Exception("Evento não cadastrado!!!");
                }
                appInsc.salvar(inscricao);
                MessageBox.Show("Espectador cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}