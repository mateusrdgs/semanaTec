﻿using semanaTec.Aplicacao;
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
    public partial class cadEventoForms : Form
    {
        public cadEventoForms()
        {
            InitializeComponent();
            ActiveControl = nomeTxt;
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
                
                appEvento.salvaEvento(evento, 0);
                MessageBox.Show("Salvo com sucesso!");
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

