using semanaTec.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace semanaTec
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }
        cadEventoForms cadEventoForm;

        private void eventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Hide();
            }
            cadEventoForm = null;

            if (cadEventoForm == null)
            {
                cadEventoForm = new cadEventoForms();
            }

            cadEventoForm.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            cadEventoForm.MdiParent = this;
            cadEventoForm.Show();   
        }
    }
}
