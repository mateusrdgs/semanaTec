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
        inscricaoSeminfoAplicacao appInscSem;
        isEmpty validaControles;
        Evento evento;

        private void cadInscForms_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Perfil == "Administrador")
            { }
            else
            {
                cpfMsk.Text = Properties.Settings.Default.CPF;
                cpfMsk.Enabled = false;
            }

            appEvento = new eventoAplicacao();
            foreach (var evento in appEvento.selectEventos())
            {
                eventoCB.Items.Add(evento.Nome);
            }
            eventoCB.SelectedIndex = -1;
            this.ActiveMdiChild.Dock = DockStyle.Fill;            
        }

        private void salvarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                validaControles = new isEmpty();        
                foreach (Control child in this.Controls)
                {
                    string tag = validaControles.empty(child);
                    if (tag != "")
                    {
                        throw new Exception("O campo '" + tag + "' está vazio");
                    }
                    else
                    {
                        appInsc = new inscricaoEventoAplicacao();
                        appPart = new participanteAplicacao();
                        inscricao = new inscricaoEvento();
                        appInscSem = new inscricaoSeminfoAplicacao();
                        appEvento = new eventoAplicacao();
                        evento = new Evento();

                        if (!appInscSem.jaCadastrado(cpfMsk.Text))
                        {
                            throw new Exception("CPF ainda não cadastrado!!!");
                        }

                        if (appInsc.cadastradoEvento(appEvento.retornaCodEv(eventoCB.Text), cpfMsk.Text))
                        {
                            throw new Exception("CPF já cadastrado neste evento!!!");
                        }
                        evento = appEvento.selectEventoWhere(eventoCB.Text);
                        int codSeminfo = appInsc.retornoCodSeminfo(cpfMsk.Text);
                        if (appEvento.evSameTime(codSeminfo, evento.Data, evento.Hora))
                        {
                            throw new Exception("CPF já cadastrado em outro evento no mesmo horário");
                        }
                        else
                        {
                            inscricao.Evento = evento.Codigo;
                            inscricao.Data = evento.Data;
                            inscricao.codigoSeminfo = codSeminfo;
                            appInsc.salvar(inscricao);
                            MessageBox.Show("Espectador cadastrado com sucesso!");
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void limparBtn_Click(object sender, EventArgs e)
        {
            cpfMsk.Clear();
            eventoCB.SelectedIndex = -1;
        }
    }
}