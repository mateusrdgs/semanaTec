﻿using semanaTec.Dominio;
using semanaTec.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
        cadPalesForms cadPalesForm;
        cadPartForms cadPartForm;
        cadInscEvForms cadInscForm;
        conEventoForms conEventoForm;
        conInscEvForms conInscForm;
        Evento evento = new Evento();
        inscricaoEvento insc = new inscricaoEvento();
        cadInscSemForms cadInscSemForm;
        cadInscEvForms cadInscEvForm;

        private void mainForm_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Bem vindo Mateus", "Mateus", MessageBoxButtons.OK);
            MaximizeBox = false;
        }

        private void eventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Hide();
            }
            cadEventoForm = null;

            if (cadEventoForm == null || cadEventoForm.IsDisposed)
            {
                cadEventoForm = new cadEventoForms();
            }

            cadEventoForm.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            cadEventoForm.MdiParent = this;
            cadEventoForm.Show();   
        }

        private void palestranteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Hide();
            }
            cadPalesForm = null;

            if (cadPalesForm == null || cadPalesForm.IsDisposed)
            {
                cadPalesForm = new cadPalesForms();
            }

            cadPalesForm.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            cadPalesForm.MdiParent = this;
            cadPalesForm.Show();   
        }

        private void participanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Hide();
            }
            cadEventoForm = null;

            if (cadPartForm == null || cadPartForm.IsDisposed)
            {
                cadPartForm = new cadPartForms();
            }

            cadPartForm.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            cadPartForm.MdiParent = this;
            cadPartForm.Show();   
        }

        private void inscriçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Hide();
            }
            cadInscForm = null;

            if (cadInscForm == null || cadInscForm.IsDisposed)
            {
                cadInscForm = new cadInscEvForms();
            }

            cadInscForm.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            cadInscForm.MdiParent = this;
            cadInscForm.Show();  
        }

        private void eventoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Hide();
            }
            conEventoForm = null;

            if (conEventoForm == null || conEventoForm.IsDisposed)
            {
                conEventoForm = new conEventoForms();
            }

            conEventoForm.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            conEventoForm.MdiParent = this;
            conEventoForm.Show();   
        }

        private void inscriçãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Hide();
            }
            conInscForm = null;

            if (conInscForm == null || conInscForm.IsDisposed)
            {
                conInscForm = new conInscEvForms();
            }

            conInscForm.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            conInscForm.MdiParent = this;
            conInscForm.Show();  
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja realmente efetuar o logout?", "Confirmar logout", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Thread th;
                MessageBox.Show("Logout efetuado com sucesso");
                this.Close();
                th = new Thread(openNewForm);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else { }
            
        }

        private void seminfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Hide();
            }
            cadInscSemForm = null;

            if (cadInscSemForm == null || cadInscSemForm.IsDisposed)
            {
                cadInscSemForm = new cadInscSemForms();
            }

            cadInscSemForm.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            cadInscSemForm.MdiParent = this;
            cadInscSemForm.Show();  
        }

        private void openNewForm(object obj)
        {
            Application.Run(new loginForms());
        }

        private void eventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Hide();
            }
            cadInscEvForm = null;

            if (cadInscEvForm == null || cadInscEvForm.IsDisposed)
            {
                cadInscEvForm = new cadInscEvForms();
            }

            cadInscEvForm.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            cadInscEvForm.MdiParent = this;
            cadInscEvForm.Show();  
        }
    }
}
