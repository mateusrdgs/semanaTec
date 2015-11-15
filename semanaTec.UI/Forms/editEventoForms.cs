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
    public partial class editEventoForms : Form
    {
        public editEventoForms()
        {
            InitializeComponent();
        }
        eventoAplicacao appEvento = new eventoAplicacao();
        Evento evento = new Evento();
        int codigo = 0;

        private void editEventoForms_Load(object sender, EventArgs e)
        {
            foreach (var evento in appEvento.selectNomesEventos())
            {
                eventoCB.Items.Add(evento);
            }
            eventoCB.SelectedIndex = -1;
        }

        private void eventoCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            evento = appEvento.selectEventoWhere(eventoCB.Text);
            codigo = evento.Codigo;
            nomeTxt.Text = evento.Nome;
            localTxt.Text = evento.Local;
            dataPck.Text = (evento.Data).ToString();
            horaPck.Text = (evento.Hora).ToString();
            codPTxt.Text = (evento.CodPal).ToString();
            duracaoTxt.Text = (evento.Duracao).ToString();
            vagasTxt.Text = (evento.Vagas).ToString();
            descricaoTxt.Text = evento.Descricao;
        }

        private void salvarBtn_Click(object sender, EventArgs e)
        {
            evento.Codigo = codigo;
            evento.Nome = nomeTxt.Text;
            evento.Local = localTxt.Text;
            evento.Data = DateTime.Parse(dataPck.Text);
            evento.Hora = DateTime.Parse(horaPck.Text);
            evento.CodPal = int.Parse(codPTxt.Text);
            evento.Duracao = int.Parse(duracaoTxt.Text);
            evento.Vagas = int.Parse(vagasTxt.Text);
            evento.Descricao = descricaoTxt.Text;
            appEvento.salvaEvento(evento, codigo);
            MessageBox.Show("Alterações salvas com sucesso!");
        }        
    }
}
