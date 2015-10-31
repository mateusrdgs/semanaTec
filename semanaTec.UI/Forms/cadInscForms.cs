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
    public partial class cadInscForms : Form
    {
        public cadInscForms()
        {
            InitializeComponent();
            ActiveControl = eventoCB;
        }
        eventoAplicacao appEvento;
        inscricaoAplicacao appInsc;
        participanteAplicacao appPart;
        Inscricao inscricao;

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
            try
            {
                foreach (Control child in inscricaoEvento.Controls)
                {
                    if (child is MaskedTextBox && string.IsNullOrEmpty(child.Text))
                    {
                        throw new Exception();
                    }
                    else if (child is ComboBox && ((ComboBox)child).SelectedIndex < 0)
                    {
                        throw new Exception();
                    }
                }

                appInsc = new inscricaoAplicacao();
                appPart = new participanteAplicacao();
                inscricao = new Inscricao();

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