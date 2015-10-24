using semanaTec.Aplicacao;
//using semanaTec.Repositorio;
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

        private void conEventoForms_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'semanaTecNomeEvento.tblEvento' table. You can move, or remove it, as needed.
            //this.tblEventoTableAdapter.Fill(this.semanaTecNomeEvento.tblEvento);

        }

        private void eventoCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(eventoCB.Text != "")
                {
                    //DataTable dtInfoEventos = infoevento.BuscaX(id);
                    //Contexto contexto = new Contexto();
                    eventoAplicacao appEvento = new eventoAplicacao();
                   // appEvento.selectEventos(select);
                    SqlConnection conn = new SqlConnection(@"data source=.\SQLEXPRESS; Integrated Security = SSPI; Initial Catalog=semanaTec");
                    conn.Open();
                    string select = string.Format("SELECT * FROM tblEvento WHERE sNome = '{0}'", eventoCB.Text);
                    SqlDataAdapter data = new SqlDataAdapter(select, conn);
                    DataTable dt = new DataTable();
                    data.Fill(dt);
                    eventoGV.DataSource = dt;
                    conn.Close();
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
