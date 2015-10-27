using semanaTec.Aplicacao;
using semanaTec.Métodos_e_validações;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace semanaTec.Forms
{
    public partial class conEventoForms : Form
    {
        public conEventoForms()
        {
            InitializeComponent();
            ActiveControl = eventoCB;            
        }
        eventoAplicacao appEvento;
        private void conEventoForms_Load(object sender, EventArgs e)
        {            
            appEvento = new eventoAplicacao();
            appEvento.selectEventos();
            foreach (var evento in appEvento.selectEventos())
            {
                eventoCB.Items.Add(evento.Nome);
            }
            eventoCB.SelectedIndex = -1;
        }

        private void eventoCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(eventoCB.Text != "")
                {
                    vinculaObjeto bind = new vinculaObjeto();
                    eventoGV.DataSource = bind.vincula(eventoCB.SelectedItem.ToString());
                }                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
