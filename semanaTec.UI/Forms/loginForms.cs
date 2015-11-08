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
using System.Threading;

namespace semanaTec.Forms
{
    public partial class loginForms : Form
    {
        public loginForms()
        {
            InitializeComponent();
        }
        private void newUserLbl_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void newUserLbl_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void newUserLbl_Click(object sender, EventArgs e)
        {
            cadPartForms novoCadastro = new cadPartForms();
            novoCadastro.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            validaLogin logar = new validaLogin();
            isEmpty validaControles = new isEmpty();
            Thread th;
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

                Properties.Settings.Default.Perfil = logar.logar(loginTxt.Text, senhaTxt.Text);
                if (Properties.Settings.Default.Perfil == "Aluno" || Properties.Settings.Default.Perfil == "Administrador")
                {
                    MessageBox.Show("Login efetuado com sucesso!", "Bem-vindo");
                    this.Close();
                    th = new Thread(openNewForm);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inexistente");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void openNewForm(object obj)
        {
            Application.Run(new mainForm());
        }
    }
}
