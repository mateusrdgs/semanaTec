using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using semanaTec.Metodos;

namespace semanaTec.Forms
{
    public partial class cadInscSemForms : Form
    {
        public cadInscSemForms()
        {
            InitializeComponent();
        }
        private void salvarBtn_Click(object sender, EventArgs e)
        {
            isEmpty validaControles = new isEmpty();
            try
            {
                foreach (Control child in this.Controls)
                {
                    string tag = validaControles.empty(child);
                    if (tag != "") {
                        throw new Exception("O campo '"+ tag + "' está vazio");
                    }
                    else
                    { }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
